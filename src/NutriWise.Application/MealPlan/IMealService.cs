using NutriWise.Domain.Entities.Meal;

namespace NutriWise.Application.MealPlan;

public interface IMealService
{
	Task<List<MealPlanDto>> GetUserPlansAsync();
	Task<List<DailyMeals>> GenerateDailyMealsAsync();
}