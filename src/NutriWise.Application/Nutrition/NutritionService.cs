using NutriWise.Application.Extensions;
using NutriWise.Application.UserProfile;
using NutriWise.Domain.ValueObjects;

namespace NutriWise.Application.Nutrition;

public sealed class NutritionService : INutritionService
{
	public NutritionPlan CalculateNutritionPlan(Gender gender, DateOnly birthDate, UserProfileDto userProfile)
	{
		var age = UserExtensions.CalculateAge(birthDate);
		var heightCm = userProfile.Height;
		var weightKg = userProfile.Weight;
		var activityLevel = userProfile.ActivityLevel;
		var dietGoalType = userProfile.DietGoalType;
		
		var basalMetabolicRate = CalculateBasalMetabolicRate(gender, age, heightCm, weightKg);
		var totalDailyEnergyExpenditure = AdjustCaloriesForActivityLevel(activityLevel, basalMetabolicRate);
		var totalGoalCalories = AdjustCaloriesForGoal(dietGoalType, totalDailyEnergyExpenditure);
		
		var proteinGrams = CalculateProteinGrams(activityLevel, dietGoalType, weightKg);
		var fatGrams = CalculateFatGrams(totalGoalCalories, dietGoalType);
		var carbGrams = CalculateCarbGrams(totalGoalCalories, proteinGrams, fatGrams);

		return new NutritionPlan
		{
			Calories = (int)totalGoalCalories,
			ProteinGrams = (int)proteinGrams,
			FatGrams = (int)fatGrams,
			CarbGrams = (int)carbGrams
		};
	}
	
	private static double CalculateProteinGrams(ActivityLevel activityLevel, DietGoalType dietGoalType, double weightKg)
	{
		var proteinPerKg = activityLevel switch
		{
			ActivityLevel.None => 1.6,
			ActivityLevel.Light => 1.8,
			ActivityLevel.Moderate => 2,
			ActivityLevel.Active => 2.2,
			ActivityLevel.Extreme => 2.4,
			_ => throw new ArgumentOutOfRangeException(nameof(activityLevel), activityLevel, null)
		};
		
		var proteinMultiplier = dietGoalType switch
		{
			DietGoalType.Maintenance or DietGoalType.WeightGain => 1.0,
			DietGoalType.WeightLoss => 1.1,
			DietGoalType.Recomposition => 1.2,
			_ => throw new ArgumentOutOfRangeException(nameof(dietGoalType), dietGoalType, null)
		};
		
		return proteinPerKg * proteinMultiplier * weightKg;
	}

	private static double CalculateFatGrams(double totalCalories, DietGoalType dietGoalType)
	{
		var fatPercentage = dietGoalType switch
		{
			DietGoalType.WeightLoss => 0.25,
			DietGoalType.Maintenance => 0.3,
			DietGoalType.Recomposition => 0.25,
			DietGoalType.WeightGain => 0.35,
			_ => throw new ArgumentOutOfRangeException(nameof(dietGoalType), dietGoalType, null)
		};
		
		var fatCalories = totalCalories * fatPercentage;
		return fatCalories / 9;
	}

	private static double CalculateCarbGrams(double totalCalories, double proteinGrams, double fatGrams)
	{
		var proteinCalories = proteinGrams * 4;
		var fatCalories = fatGrams * 9;
		var remainingCalories = totalCalories - (proteinCalories + fatCalories);
		return remainingCalories / 4;
	}
	
	private static double CalculateBasalMetabolicRate(Gender gender, int age, double heightCm, double weightKg)
	{
		return gender switch
		{
			Gender.Male => 10 * weightKg + 6.25 * heightCm - 5 * age + 5,
			Gender.Female => 10 * weightKg + 6.25 * heightCm - 5 * age - 161,
			_ => throw new ArgumentOutOfRangeException(nameof(gender), gender, null)
		};
	}
	
	private static double AdjustCaloriesForGoal(DietGoalType goalType, double calories)
	{
		return goalType switch
		{
			DietGoalType.WeightLoss => calories * 0.8,
			DietGoalType.Maintenance => calories,
			DietGoalType.Recomposition => calories * 0.9,
			DietGoalType.WeightGain => calories * 1.2,
			_ => throw new ArgumentOutOfRangeException(nameof(goalType), goalType, null)
		};
	}

	private static double AdjustCaloriesForActivityLevel(ActivityLevel activityLevel, double calories)
	{
		return activityLevel switch
		{
			ActivityLevel.None => calories * 1.2,
			ActivityLevel.Light => calories * 1.375,
			ActivityLevel.Moderate => calories * 1.55,
			ActivityLevel.Active => calories * 1.725,
			ActivityLevel.Extreme => calories * 1.9,
			_ => throw new ArgumentOutOfRangeException(nameof(activityLevel), activityLevel, null)
		};
	}
}