using NutriWise.Domain.ValueObjects;

namespace NutriWise.Application.UserProfiles;

public record UserProfileDto(
	Gender Gender, 
	DateOnly BirthdayDate,
	double Height,
	double Weight,
	ActivityLevel ActivityLevel,
	DietGoalType DietGoalType,
	IEnumerable<Guid> Allergies,
	IEnumerable<Guid> KitchenEquipment);