using NutriWise.Domain.Entities.Meal;

namespace NutriWise.Application.MealPlan;

public interface IMealPlanService
{
	Task<Meal> GenerateRecipeAsync();
}