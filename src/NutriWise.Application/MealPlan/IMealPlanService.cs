namespace NutriWise.Application.MealPlan;

public interface IMealPlanService
{
	Task<List<Domain.Entities.Meal.MealPlan>> GetAsync();
	Task<Domain.Entities.Meal.MealPlan> GenerateMealPlanAsync();
}