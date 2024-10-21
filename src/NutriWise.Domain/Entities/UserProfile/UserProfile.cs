using NutriWise.Domain.Entities.Base;
using NutriWise.Domain.Entities.Identity;
using NutriWise.Domain.ValueObjects;

namespace NutriWise.Domain.Entities.UserProfile;

public sealed class UserProfile : Entity
{
	public User User { get; set; }
	public Guid UserId { get; set; }
	public Gender Gender { get; set; }
	public DateOnly BirthdayDate { get; set; }
	public double Height { get; set; }
	public double Weight { get; set; }
	public ActivityLevel ActivityLevel { get; set; }
	public DietGoalType DietGoalType { get; set; }
	public ICollection<Allergy> Allergies { get; set; }
	public ICollection<KitchenEquipment> KitchenEquipments { get; set; }
}