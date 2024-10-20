using NutriWise.Domain.Entities.Base;

namespace NutriWise.Domain.Entities;

public sealed class Category : Entity
{
	public ICollection<SubCategory> SubCategories { get; set; }
}