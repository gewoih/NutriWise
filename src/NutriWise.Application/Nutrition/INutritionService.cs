using NutriWise.Application.UserProfile;

namespace NutriWise.Application.Nutrition;

public interface INutritionService
{
	NutritionPlan CalculateNutritionPlan(UserProfileDto userProfile);
}