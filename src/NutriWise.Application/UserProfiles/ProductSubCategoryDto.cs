namespace NutriWise.Application.UserProfiles;

public sealed class ProductSubCategoryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<ProductDto> Products { get; set; }
}