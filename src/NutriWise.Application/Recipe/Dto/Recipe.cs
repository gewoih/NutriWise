using Newtonsoft.Json;

namespace NutriWise.Application.Recipe
{
	public class Recipe
	{
		[JsonProperty("ingredients")]
		public List<Ingredient> Ingredients { get; set; }

		[JsonProperty("instructions")]
		public string Instructions { get; set; }
	}
}