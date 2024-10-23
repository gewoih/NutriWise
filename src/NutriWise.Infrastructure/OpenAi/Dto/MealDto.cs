using Newtonsoft.Json;

namespace NutriWise.Infrastructure.OpenAi.Dto;

public class MealDto
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("recipe")]
	public RecipeDto RecipeDto { get; set; }
}