using System.Text;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using NutriWise.Infrastructure.Extensions;
using NutriWise.Infrastructure.OpenAi.Dto;
using OpenAI.Chat;

namespace NutriWise.Infrastructure.OpenAi;

public class OpenAiService
{
	private readonly IConfiguration _configuration;

	public OpenAiService(IConfiguration configuration)
	{
		_configuration = configuration;
	}

	public async Task<MealPlanDto> GetMealPlanAsync(double calories, double proteinGrams, double fatGrams,
		double carbGrams, IEnumerable<ProductDto> availableProducts)
	{
		var client = new ChatClient(model: "gpt-4o", apiKey: _configuration["OpenAi:ApiKey"]);
		var recipeResponseJsonSchema = await EmbeddedResourcesUtils.GetResourceFileContentAsync("recipeResponse.json");

		var options = new ChatCompletionOptions
		{
			Temperature = 0.1f,
			ResponseFormat = ChatResponseFormat.CreateJsonSchemaFormat(
				jsonSchemaFormatName: "recipes",
				jsonSchema: BinaryData.FromBytes(Encoding.UTF8.GetBytes(recipeResponseJsonSchema)),
				jsonSchemaIsStrict: true)
		};

		var availableProductsList =
			string.Join('\n', availableProducts.Select(product => $"{product.Id} {product.Name}"));
		
		var message =
			$"Generate me daily meals plan with following nutrition value: {calories} calories, " +
			$"{proteinGrams}g. of proteins, {fatGrams}g. of fats, {carbGrams} of carbs" +
			$"\n\n" +
			$"Available products List:\n" +
			$"{availableProductsList}";

		var prompt = await EmbeddedResourcesUtils.GetResourceFileContentAsync("generateRecipe.txt");
		var completion = await client.CompleteChatAsync([$"{prompt} {message}"], options);
		var response = completion.Value.Content[0].Text;
		var mealPlanDto = JsonConvert.DeserializeObject<MealPlanDto>(response);

		if (mealPlanDto?.Meals is null)
			throw new ApplicationException("Произошла ошибка при генерации плана питания.");

		return mealPlanDto;
	}
}