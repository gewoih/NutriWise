using NutriWise.Domain.Entities.Base;

namespace NutriWise.Domain.Entities.Product;

public sealed class Product : Entity
{
	public FoodSubCategory FoodSubCategory { get; set; }
	public double Calories { get; set; }
	public double Proteins { get; set; }
	public double Fats { get; set; }
	public double Carbohydrates { get; set; }
}