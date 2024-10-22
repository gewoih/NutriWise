using Newtonsoft.Json;

namespace NutriWise.Application.MealPlan.Dto;

public class Meal
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("recipe")]
	public Recipe Recipe { get; set; }
}