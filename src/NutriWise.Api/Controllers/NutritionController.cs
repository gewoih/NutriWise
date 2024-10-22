using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriWise.Application.Nutrition;
using NutriWise.Application.Users;

namespace NutriWise.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionController : ControllerBase
    {
        private readonly INutritionService _nutritionService;
        private readonly ICurrentUserService _currentUserService;

        public NutritionController(INutritionService nutritionService, ICurrentUserService currentUserService)
        {
            _nutritionService = nutritionService;
            _currentUserService = currentUserService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var currentUserId = _currentUserService.GetCurrentUserId();
            var nutritionPlan = await _nutritionService.CalculateNutritionPlan(currentUserId);
            return nutritionPlan is null ? NotFound() : Ok(nutritionPlan);
        }
    }
}
