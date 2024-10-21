using NutriWise.Domain.ValueObjects;

namespace NutriWise.Application;

public record UserProfileDto(
	Gender Gender, 
	DateOnly BirthdayDate,
	double Height,
	double Weight,
	ActivityLevel ActivityLevel,
	DietGoalType DietGoalType,
	IEnumerable<Guid> Allergies,
	IEnumerable<Guid> KitchenEquipment);