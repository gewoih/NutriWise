using Newtonsoft.Json;

namespace NutriWise.Infrastructure.OpenAi.Dto;

public class MealPlanDto
{
	[JsonProperty("name")]
	public string Name { get; set; }
	
	[JsonProperty("meals")]
	public List<MealDto> Meals { get; set; }
}