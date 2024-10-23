using Newtonsoft.Json;

namespace NutriWise.Infrastructure.OpenAi.Dto;

public class MealPlanDto
{
	[JsonProperty("meals")]
	public List<MealDto> Meals { get; set; }
}