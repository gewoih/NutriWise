using NutriWise.Domain.Entities.Base;

namespace NutriWise.Domain.Entities.Meal;

public sealed class DailyMeals : Entity
{
	public ICollection<Meal> FoodRecipes { get; set; }
}