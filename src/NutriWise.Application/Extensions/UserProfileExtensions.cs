using NutriWise.Application.UserProfile;

namespace NutriWise.Application.Extensions;

public static class UserProfileExtensions
{
	public static UserProfileDto ToDto(this Domain.Entities.UserProfile.UserProfile userProfile)
	{
		var allergies = userProfile.Allergies.Select(allergy => allergy.Id);
		var kitchenEquipment = userProfile.KitchenEquipments.Select(equipment => equipment.Id);
		var products = userProfile.Products.Select(product => product.Id);
		
		return new UserProfileDto(userProfile.Height, userProfile.Weight, userProfile.ActivityLevel, 
			userProfile.DietGoalType, allergies, kitchenEquipment, products);
	}
}