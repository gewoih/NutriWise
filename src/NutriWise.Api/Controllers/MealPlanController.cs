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
		private readonly IMealService _mealService;

		public MealPlanController(IMealService mealService)
		{
			_mealService = mealService;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var mealPlans = await _mealService.GetAsync();
			return Ok(mealPlans);
		}
		
		[HttpPost]
		public async Task<IActionResult> Post()
		{
			var mealPlan = await _mealService.GenerateDailyMealsAsync();
			return Ok(mealPlan);
		}
	}
}