using NutriWise.Domain.ValueObjects;

namespace NutriWise.Application.UserProfile;

public record UserProfileDto(
	double Height,
	double Weight,
	ActivityLevel ActivityLevel,
	DietGoalType DietGoalType,
	IEnumerable<Guid> Allergies,
	IEnumerable<Guid> KitchenEquipment,
	IEnumerable<Guid> Products);