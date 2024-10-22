using Newtonsoft.Json;

namespace NutriWise.Application.Recipe
{
	public class DailyMeals
	{
		[JsonProperty("meals")]
		public List<Meal> Meals { get; set; }
	}

	public class Meal
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("recipe")]
		public Recipe Recipe { get; set; }
	}

	public class Recipe
	{
		[JsonProperty("ingredients")]
		public List<Ingredient> Ingredients { get; set; }

		[JsonProperty("instructions")]
		public string Instructions { get; set; }
	}

	public class Ingredient
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("quantity")]
		public double Quantity { get; set; }
	}
}