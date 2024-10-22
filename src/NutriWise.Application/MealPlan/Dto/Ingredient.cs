using Newtonsoft.Json;

namespace NutriWise.Application.MealPlan.Dto;

public class Ingredient
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("quantity")]
	public double Quantity { get; set; }
}