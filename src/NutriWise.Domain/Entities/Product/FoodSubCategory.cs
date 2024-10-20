namespace NutriWise.Domain.Entities.Product;

public sealed class FoodSubCategory
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public FoodCategory Category { get; set; }
	public Guid CategoryId { get; set; }
}