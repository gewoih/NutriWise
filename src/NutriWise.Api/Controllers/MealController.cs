using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriWise.Application.MealPlan;

namespace NutriWise.Controllers
{
	[Authorize]
	[Route("api/meal")]
	[ApiController]
	public class MealController : ControllerBase
	{
		private readonly IMealService _mealService;

		public MealController(IMealService mealService)
		{
			_mealService = mealService;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var mealPlans = await _mealService.GetUserPlansAsync();
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