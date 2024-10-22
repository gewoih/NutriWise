using NutriWise.Domain.ValueObjects;

namespace NutriWise.Application.Nutrition;

public interface INutritionService
{
	Task<NutritionPlan?> CalculateNutritionPlan(Guid userId);
}