using NutriWise.Domain.Entities.Base;
using NutriWise.Domain.ValueObjects;

namespace NutriWise.Domain.Entities.Recipe;

public sealed class RecipeIngredient : Entity
{
	public Product.Product Product { get; set; }
	public MeasurmentType MeasurmentType { get; set; }
	public double Amount { get; set; }
}