using Microsoft.EntityFrameworkCore;
using NutriWise.Application.Nutrition;
using NutriWise.Application.UserProfile;
using NutriWise.Application.Users;
using NutriWise.Domain.Entities.Meal;
using NutriWise.Domain.ValueObjects;
using NutriWise.Infrastructure.Database;
using NutriWise.Infrastructure.OpenAi;
using ProductDto = NutriWise.Infrastructure.OpenAi.Dto.ProductDto;

namespace NutriWise.Application.MealPlan;

public class MealService : IMealService
{
	private readonly OpenAiService _openAiService;
	private readonly INutritionService _nutritionService;
	private readonly ICurrentUserService _currentUserService;
	private readonly IUserProfileService _userProfileService;
	private readonly AppDbContext _context;

	public MealService(OpenAiService openAiService,
		INutritionService nutritionService,
		IUserProfileService userProfileService,
		ICurrentUserService currentUserService,
		AppDbContext context)
	{
		_openAiService = openAiService;
		_nutritionService = nutritionService;
		_userProfileService = userProfileService;
		_currentUserService = currentUserService;
		_context = context;
	}

	public async Task<List<MealPlanDto>> GetUserPlansAsync()
	{
		var currentUserId = _currentUserService.GetCurrentUserId();
		var mealPlans = await _context.DailyMeals
			.AsNoTracking()
			.Include(dailyMeal => dailyMeal.Meals)
			.Where(dailyMeal => dailyMeal.UserId == currentUserId)
			.Select(dailyMeal => new MealPlanDto
			{
				Id = dailyMeal.Id,
				Name = "План питания #",
				MealNames = dailyMeal.Meals.Select(meal => meal.Caption).ToList()
			})
			.ToListAsync();

		return mealPlans;
	}

	public async Task<List<DailyMeals>> GenerateDailyMealsAsync()
	{
		var currentUserId = _currentUserService.GetCurrentUserId();
		var userProfile = await _userProfileService.GetAsync(currentUserId);
		if (userProfile is null)
			return [];
		
		var nutrition = _nutritionService.CalculateNutritionPlan(userProfile);

		var availableProductsDto = await _context.Products
			.Where(product => userProfile.Products.Contains(product.Id))
			.Select(product => new ProductDto { Id = product.Id, Name = product.Caption })
			.ToListAsync();

		var mealPlanDto = await _openAiService.GetMealPlanAsync(nutrition.Calories, nutrition.ProteinGrams,
			nutrition.FatGrams, nutrition.CarbGrams, availableProductsDto);

		await ValidateUsedProductsAsync(mealPlanDto);

		var meals = new List<Meal>();
		foreach (var mealDto in mealPlanDto.Meals)
		{
			var meal = new Meal
			{
				Caption = mealDto.Name,
				CookingInstructions = mealDto.RecipeDto.Instructions,
				Ingredients = mealDto.RecipeDto.Ingredients.Select(i => new Ingredient
				{
					ProductId = i.Id,
					Amount = i.Quantity,
					MeasurmentType = MeasurmentType.Grams
				}).ToList()
			};

			meals.Add(meal);
		}

		var dailyMeals = new DailyMeals
		{
			UserId = currentUserId,
			Meals = meals
		};

		await _context.DailyMeals.AddAsync(dailyMeals);
		await _context.SaveChangesAsync();

		return [dailyMeals];
	}

	private async Task ValidateUsedProductsAsync(Infrastructure.OpenAi.Dto.MealPlanDto mealPlanDto)
	{
		var usedProductsIds = mealPlanDto.Meals
			.SelectMany(meal => meal.RecipeDto.Ingredients.Select(i => i.Id))
			.Distinct()
			.ToList();

		var usedProductsFromDb = await _context.Products
			.Where(product => usedProductsIds.Contains(product.Id))
			.ToListAsync();

		if (usedProductsFromDb.Count != usedProductsIds.Count)
			throw new ApplicationException("В рецептах использовались несуществующие продукты");
	}
}