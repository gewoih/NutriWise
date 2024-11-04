using NutriWise.Application.UserProfiles;

namespace NutriWise.Application.Nutrition;

public interface INutritionService
{
	NutritionPlan CalculateNutritionPlan(UserProfileDto userProfile);
}