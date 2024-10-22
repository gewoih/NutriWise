using NutriWise.Domain.Entities.Base;
using NutriWise.Domain.ValueObjects;

namespace NutriWise.Domain.Entities.Recipe;

public sealed class Ingredient : Entity
{
	public Guid ProductId { get; set; }
	public MeasurmentType MeasurmentType { get; set; }
	public double Amount { get; set; }
}