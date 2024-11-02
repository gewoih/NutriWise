using NutriWise.Application.UserProfiles;
using NutriWise.Domain.Entities.UserProfile;

namespace NutriWise.Application.Extensions;

public static class UserProfileExtensions
{
	public static UserProfileDto ToDto(this UserProfile userProfile)
	{
		var allergies = userProfile.Allergies?.Select(allergy => allergy.Id);
		var kitchenEquipment = userProfile.KitchenEquipments?.Select(equipment => equipment.Id);
		var products = userProfile.Products?.Select(product => product.Id);
		
		return new UserProfileDto(userProfile.Gender, userProfile.BirthdayDate, userProfile.Height, userProfile.Weight,
			userProfile.ActivityLevel, userProfile.DietGoalType, allergies, kitchenEquipment, products);
	}
}