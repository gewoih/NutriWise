using Newtonsoft.Json;

namespace NutriWise.Application.Recipe;

public class MealPlan
{
	[JsonProperty("meals")]
	public List<Meal> Meals { get; set; }
}