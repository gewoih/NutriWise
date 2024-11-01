using NutriWise.Domain.Entities.Base;
using NutriWise.Domain.ValueObjects;

namespace NutriWise.Domain.Entities.Meal;

public sealed class Ingredient : Entity
{
	public Product.Product? Product { get; set; }
	public Guid ProductId { get; set; }
	public MeasurmentType MeasurmentType { get; set; }
	public double Amount { get; set; }
}