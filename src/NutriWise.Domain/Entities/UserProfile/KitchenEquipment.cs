using NutriWise.Domain.Entities.Base;

namespace NutriWise.Domain.Entities.UserProfile;

public sealed class KitchenEquipment : Entity
{
	public ICollection<UserProfile> UserProfiles { get; set; }
}