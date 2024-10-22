using Newtonsoft.Json;

namespace NutriWise.Application.MealPlan.Dto
{
	public class Recipe
	{
		[JsonProperty("ingredients")]
		public List<Ingredient> Ingredients { get; set; }

		[JsonProperty("instructions")]
		public string Instructions { get; set; }
	}
}