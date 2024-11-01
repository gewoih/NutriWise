using NutriWise.Domain.Entities.Meal;

namespace NutriWise.Application.MealPlan;

public interface IMealService
{
	Task<List<MealPlanDto>> GetAsync();
	Task<List<DailyMeals>> GenerateDailyMealsAsync();
}