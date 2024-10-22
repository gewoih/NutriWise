using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriWise.Application.Nutrition;
using NutriWise.Application.UserProfiles;
using NutriWise.Application.Users;

namespace NutriWise.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionController : ControllerBase
    {
        private readonly IUserProfileService _userProfileService;
        private readonly INutritionService _nutritionService;
        private readonly ICurrentUserService _currentUserService;

        public NutritionController(INutritionService nutritionService, ICurrentUserService currentUserService, IUserProfileService userProfileService)
        {
            _nutritionService = nutritionService;
            _currentUserService = currentUserService;
            _userProfileService = userProfileService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var currentUserId = _currentUserService.GetCurrentUserId();
            var currentUserProfile = await _userProfileService.GetAsync(currentUserId);
            if (currentUserProfile is null)
                return NotFound();
            
            var nutritionPlan = _nutritionService.CalculateNutritionPlan(currentUserProfile);
            return Ok(nutritionPlan);
        }
    }
}
