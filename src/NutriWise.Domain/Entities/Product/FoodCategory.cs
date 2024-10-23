using NutriWise.Domain.Entities.Base;

namespace NutriWise.Domain.Entities.Product;

public sealed class FoodCategory : Entity
{
	public ICollection<FoodSubCategory> SubCategories { get; set; }
}