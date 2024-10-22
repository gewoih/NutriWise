using NutriWise.Domain.Entities.Base;

namespace NutriWise.Domain.Entities.Recipe;

public sealed class DailyMeals : Entity
{
	public ICollection<Meal> FoodRecipes { get; set; }
}