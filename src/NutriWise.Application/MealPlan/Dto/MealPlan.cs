using Newtonsoft.Json;

namespace NutriWise.Application.MealPlan.Dto;

public class MealPlan
{
	[JsonProperty("meals")]
	public List<Meal> Meals { get; set; }
}