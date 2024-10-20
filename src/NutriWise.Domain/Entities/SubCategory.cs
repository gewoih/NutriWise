using NutriWise.Domain.Entities.Base;

namespace NutriWise.Domain.Entities;

public sealed class SubCategory : Entity
{
	public Category Category { get; set; }
}