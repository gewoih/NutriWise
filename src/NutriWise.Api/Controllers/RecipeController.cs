using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriWise.Application.MealPlan;

namespace NutriWise.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class RecipeController : ControllerBase
	{
		private readonly IMealPlanService _mealPlanService;

		public RecipeController(IMealPlanService mealPlanService)
		{
			_mealPlanService = mealPlanService;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var foodRecipe = await _mealPlanService.GenerateRecipeAsync();
			return Ok(foodRecipe);
		}
	}
}