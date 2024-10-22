using NutriWise.Domain.Entities.UserProfile;

namespace NutriWise.Application.Nutrition;

public interface INutritionService
{
	NutritionPlan CalculateNutritionPlan(UserProfile userProfile);
}