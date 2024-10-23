using NutriWise.Domain.Entities.Base;

namespace NutriWise.Domain.Entities.Meal;

public sealed class DailyMeals : Entity
{
	public Guid UserId { get; set; }
	public ICollection<Meal> Meals { get; set; }
}