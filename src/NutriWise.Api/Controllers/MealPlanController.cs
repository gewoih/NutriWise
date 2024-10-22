using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriWise.Application.MealPlan;

namespace NutriWise.Controllers
{
	[Authorize]
	[Route("api/meal-plan")]
	[ApiController]
	public class MealPlanController : ControllerBase
	{
		private readonly IMealPlanService _mealPlanService;

		public MealPlanController(IMealPlanService mealPlanService)
		{
			_mealPlanService = mealPlanService;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var foodRecipe = await _mealPlanService.GenerateMealPlanAsync();
			return Ok(foodRecipe);
		}
	}
}