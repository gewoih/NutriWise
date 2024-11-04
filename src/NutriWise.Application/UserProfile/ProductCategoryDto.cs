namespace NutriWise.Application.UserProfile;

public sealed class ProductCategoryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<ProductSubCategoryDto> SubCategories { get; set; }
}