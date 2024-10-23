using Newtonsoft.Json;

namespace NutriWise.Infrastructure.OpenAi.Dto;

public class IngredientDto
{
	[JsonProperty("id")]
	public Guid Id { get; set; }

	[JsonProperty("quantity")]
	public double Quantity { get; set; }
}