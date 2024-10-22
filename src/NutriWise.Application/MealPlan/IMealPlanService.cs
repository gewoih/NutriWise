namespace NutriWise.Application.MealPlan;

public interface IMealPlanService
{
	Task<Domain.Entities.Meal.MealPlan> GenerateMealPlanAsync();
}