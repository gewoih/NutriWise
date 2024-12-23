﻿using Newtonsoft.Json;

namespace NutriWise.Infrastructure.OpenAi.Dto
{
	public class RecipeDto
	{
		[JsonProperty("ingredients")]
		public List<IngredientDto> Ingredients { get; set; }

		[JsonProperty("instructions")]
		public string Instructions { get; set; }
	}
}