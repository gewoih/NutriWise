using System.Drawing;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriWise.Application.Extensions;
using NutriWise.Application.Nutrition;
using NutriWise.Application.Users;
using OpenAI.Chat;

namespace NutriWise.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class RecipeController : ControllerBase
	{
		private readonly INutritionService _nutritionService;
		private readonly ICurrentUserService _currentUserService;
		private readonly IConfiguration _configuration;

		public RecipeController(INutritionService nutritionService, ICurrentUserService currentUserService, IConfiguration configuration)
		{
			_nutritionService = nutritionService;
			_currentUserService = currentUserService;
			_configuration = configuration;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var client = new ChatClient(model: "gpt-4o", apiKey: _configuration["OpenAi:ApiKey"]);

			var recipeResponseJsonSchema = await EmbeddedResourcesUtils.GetResourceFileContentAsync("recipeResponse.json");
			
			var options = new ChatCompletionOptions
			{
				ResponseFormat = ChatResponseFormat.CreateJsonSchemaFormat(
					jsonSchemaFormatName: "recipes",
					jsonSchema: BinaryData.FromBytes(Encoding.UTF8.GetBytes(recipeResponseJsonSchema)),
					jsonSchemaIsStrict: true)
			};

			var currentUserId = _currentUserService.GetCurrentUserId();
			var nutrition = await _nutritionService.CalculateNutritionPlan(currentUserId);
			if (nutrition is null)
				return NotFound();

			var prompt = await EmbeddedResourcesUtils.GetResourceFileContentAsync("generateRecipe.txt");
			var message =
				$"Generate me daily meals plan with following nutrition value: " +
				$"calories={nutrition.Calories}, " +
				$"proteins={nutrition.ProteinGrams}, " +
				$"fats={nutrition.FatGrams}, " +
				$"carbs={nutrition.CarbGrams}.";
			
			var completion = await client.CompleteChatAsync([$"{prompt} {message}"], options);

			var response = completion.Value.Content[0].Text;
			return Ok(response);
		}
	}
}