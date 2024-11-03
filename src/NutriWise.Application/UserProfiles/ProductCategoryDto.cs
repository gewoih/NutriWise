using System.Collections;

namespace NutriWise.Application.UserProfiles;

public sealed class ProductCategoryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<ProductSubCategoryDto> SubCategories { get; set; }
}