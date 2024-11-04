using NutriWise.Application.UserProfile;
using NutriWise.Domain.ValueObjects;

namespace NutriWise.Application.Nutrition;

public interface INutritionService
{
	NutritionPlan CalculateNutritionPlan(Gender gender, DateOnly birthDate, UserProfileDto userProfile);
}