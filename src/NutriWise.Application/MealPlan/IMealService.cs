using NutriWise.Domain.Entities.Meal;

namespace NutriWise.Application.MealPlan;

public interface IMealService
{
	Task<List<DailyMeals>> GetAsync();
	Task<List<DailyMeals>> GenerateDailyMealsAsync();
}