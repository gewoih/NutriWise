using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriWise.Application.Nutrition;
using NutriWise.Application.UserProfile;
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

        public NutritionController(INutritionService nutritionService, ICurrentUserService currentUserService,
            IUserProfileService userProfileService)
        {
            _nutritionService = nutritionService;
            _currentUserService = currentUserService;
            _userProfileService = userProfileService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var currentUserDto = await _currentUserService.GetCurrentUserAsync();
            if (currentUserDto is null)
                return Unauthorized();
            
            var currentUserProfile = await _userProfileService.GetAsync(currentUserDto.Id);
            if (currentUserProfile is null)
                return NotFound();
            
            var nutritionPlan = _nutritionService.CalculateNutritionPlan(currentUserDto.Gender,
                currentUserDto.BirthDate, currentUserProfile);
            
            return Ok(nutritionPlan);
        }
    }
}