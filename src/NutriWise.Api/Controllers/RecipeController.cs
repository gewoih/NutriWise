using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriWise.Application.Recipe;

namespace NutriWise.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class RecipeController : ControllerBase
	{
		private readonly IRecipeService _recipeService;

		public RecipeController(IRecipeService recipeService)
		{
			_recipeService = recipeService;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var foodRecipe = await _recipeService.GenerateRecipeAsync();
			return Ok(foodRecipe);
		}
	}
}