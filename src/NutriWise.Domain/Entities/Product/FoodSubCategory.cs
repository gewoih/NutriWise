using NutriWise.Domain.Entities.Base;

namespace NutriWise.Domain.Entities.Product;

public sealed class FoodSubCategory : Entity
{
	public Guid CategoryId { get; set; }
	public ICollection<Product> Products { get; set; }
}