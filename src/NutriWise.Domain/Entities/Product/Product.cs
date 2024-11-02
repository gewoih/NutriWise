using NutriWise.Domain.Entities.Base;

namespace NutriWise.Domain.Entities.Product;

public sealed class Product : Entity
{
	public FoodSubCategory SubCategory { get; set; }
	public Guid SubCategoryId { get; set; }
	public double? Calories { get; set; }
	public double? Proteins { get; set; }
	public double? Fats { get; set; }
	public double? Carbohydrates { get; set; }
	public ICollection<UserProfile.UserProfile> UserProfiles { get; set; }
}