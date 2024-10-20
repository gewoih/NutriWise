namespace NutriWise.Domain.Entities.Product;

public sealed class FoodCategory
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public ICollection<FoodSubCategory> SubCategories { get; set; }
}