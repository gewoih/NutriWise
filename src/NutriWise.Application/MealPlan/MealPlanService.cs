using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NutriWise.Application.Nutrition;
using NutriWise.Application.UserProfiles;
using NutriWise.Application.Users;
using NutriWise.Domain.Entities.Meal;
using NutriWise.Domain.ValueObjects;
using NutriWise.Infrastructure.Database;
using NutriWise.Infrastructure.OpenAi;

namespace NutriWise.Application.MealPlan;

public class MealPlanService : IMealPlanService
{
	private readonly OpenAiService _openAiService;
	private readonly INutritionService _nutritionService;
	private readonly ICurrentUserService _currentUserService;
	private readonly IUserProfileService _userProfileService;
	private readonly AppDbContext _context;

	public MealPlanService(OpenAiService openAiService,
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

	public async Task<Domain.Entities.Meal.MealPlan> GenerateMealPlanAsync()
	{
		var currentUserId = _currentUserService.GetCurrentUserId();
		var userProfile = await _userProfileService.GetAsync(currentUserId);
		var nutrition = _nutritionService.CalculateNutritionPlan(userProfile);

		var message =
			$"Generate me daily meals plan with following nutrition value: " +
			$"calories={nutrition.Calories}, " +
			$"proteins={nutrition.ProteinGrams}, " +
			$"fats={nutrition.FatGrams}, " +
			$"carbs={nutrition.CarbGrams}.";

		var response = await _openAiService.GetJsonResponse("recipeResponse.json", "generateRecipe.txt", message);
		var mealsDto = JsonConvert.DeserializeObject<Dto.MealPlanDto>(response);
		if (mealsDto?.Meals is null)
			throw new ApplicationException("Произошла ошибка при генерации плана питания.");

		var usedProductsIds =
			mealsDto.Meals.SelectMany(meal => meal.RecipeDto.Ingredients.Select(i => i.Id))
				.Distinct()
				.ToList();
		
		var usedProducts = await _context.Products
			.Where(product => usedProductsIds.Contains(product.Id))
			.ToListAsync();

		if (usedProducts.Count != usedProductsIds.Count)
		{
			var foundProducts = usedProducts.Select(product => product.Id).ToList();
			var notFoundProducts = usedProductsIds.Except(foundProducts).ToList();
			throw new ApplicationException("В рецептах использовались несуществующие продукты");
		}

		var meals = new List<Meal>();
		foreach (var mealDto in mealsDto.Meals)
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

		var mealPlan = new Domain.Entities.Meal.MealPlan
		{
			Caption = "Meal plan for 1 day",
			DaysCount = 1,
			DailyMeals =
			[
				new DailyMeals
				{
					Meals = meals
				}
			]
		};

		await _context.MealPlans.AddAsync(mealPlan);
		await _context.SaveChangesAsync();

		return mealPlan;
	}
}