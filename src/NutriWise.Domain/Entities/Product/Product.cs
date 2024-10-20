using NutriWise.Domain.Entities.Base;
using NutriWise.Domain.ValueObjects;

namespace NutriWise.Domain.Entities.Product;

public sealed class Product : Entity
{
	public SubCategory SubCategory { get; set; }
	public NutrientValue NutrientValue { get; set; }
}