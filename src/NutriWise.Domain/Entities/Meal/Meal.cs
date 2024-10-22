using NutriWise.Domain.Entities.Base;

namespace NutriWise.Domain.Entities.Meal;

public sealed class Meal : Entity
{
	public ICollection<Ingredient> Ingredients { get; set; }
	public string CookingInstructions { get; set; }
}