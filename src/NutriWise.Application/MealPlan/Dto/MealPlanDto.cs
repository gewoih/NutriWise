using Newtonsoft.Json;

namespace NutriWise.Application.MealPlan.Dto;

public class MealPlanDto
{
	[JsonProperty("meals")]
	public List<MealDto> Meals { get; set; }
}