using NutriWise.Domain.Entities.Base;

namespace NutriWise.Domain.Entities.Recipe;

public sealed class FoodRecipe : Entity
{
	public ICollection<RecipeIngredient> Ingredients { get; set; }
	public string CookingInstructions { get; set; }
}