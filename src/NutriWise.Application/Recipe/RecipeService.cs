using Newtonsoft.Json;
using NutriWise.Application.Nutrition;
using NutriWise.Application.UserProfiles;
using NutriWise.Application.Users;
using NutriWise.Domain.Entities.Recipe;
using NutriWise.Domain.ValueObjects;
using NutriWise.Infrastructure.Database;
using NutriWise.Infrastructure.OpenAi;

namespace NutriWise.Application.Recipe;

public class RecipeService : IRecipeService
{
	private readonly OpenAiService _openAiService;
	private readonly INutritionService _nutritionService;
	private readonly ICurrentUserService _currentUserService;
	private readonly IUserProfileService _userProfileService;
	private readonly AppDbContext _context;
	
	public RecipeService(OpenAiService openAiService, 
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

	public async Task<Domain.Entities.Recipe.Meal> GenerateRecipeAsync()
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
		var meals = JsonConvert.DeserializeObject<MealPlan>(response);

		foreach (var meal in meals?.Meals)
		{
			var foodRecipe = new Domain.Entities.Recipe.Meal
			{
				Caption = meal.Name,
				CookingInstructions = meal.Recipe.Instructions,
				Ingredients = meal.Recipe.Ingredients.Select(i => new Domain.Entities.Recipe.Ingredient
				{
					Amount = i.Quantity,
					MeasurmentType = MeasurmentType.Grams
				}).ToList()
			};

			await _context.Meals.AddAsync(foodRecipe);
		}

		await _context.SaveChangesAsync();

		return new();
	}
}