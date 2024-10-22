using NutriWise.Domain.Entities.Base;

namespace NutriWise.Domain.Entities.Recipe;

public sealed class MealPlan : Entity
{
	public int DaysCount { get; set; }
	public ICollection<DailyMeals> DailyMeals { get; set; }
}