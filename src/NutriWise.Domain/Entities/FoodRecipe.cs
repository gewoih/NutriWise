using NutriWise.Domain.Entities.Base;
using NutriWise.Domain.ValueObjects;

namespace NutriWise.Domain.Entities;

public sealed class FoodRecipe : Entity
{
	public ICollection<RecipeIngredient> Ingredients { get; set; }
	public string CookingInstructions { get; set; }
	public NutrientValue NutrientValue { get; set; }
}