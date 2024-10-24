﻿using Microsoft.EntityFrameworkCore;
using NutriWise.Application.Nutrition;
using NutriWise.Application.UserProfiles;
using NutriWise.Application.Users;
using NutriWise.Domain.Entities.Meal;
using NutriWise.Domain.ValueObjects;
using NutriWise.Infrastructure.Database;
using NutriWise.Infrastructure.OpenAi;
using NutriWise.Infrastructure.OpenAi.Dto;

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

	public async Task<List<DailyMeals>> GetAsync()
	{
		var currentUserId = _currentUserService.GetCurrentUserId();
		var mealPlans = await _context.DailyMeals
			.AsNoTracking()
			.Where(dailyMeal => dailyMeal.UserId == currentUserId)
			.ToListAsync();

		return mealPlans;
	}

	public async Task<List<DailyMeals>> GenerateDailyMealsAsync()
	{
		var currentUserId = _currentUserService.GetCurrentUserId();
		var userProfile = await _userProfileService.GetAsync(currentUserId);
		var nutrition = _nutritionService.CalculateNutritionPlan(userProfile);

		var availableProductsDto = await _context.Products
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

	private async Task ValidateUsedProductsAsync(MealPlanDto mealPlanDto)
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