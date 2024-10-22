using Newtonsoft.Json;

namespace NutriWise.Application.Recipe;

public class Ingredient
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("quantity")]
	public double Quantity { get; set; }
}