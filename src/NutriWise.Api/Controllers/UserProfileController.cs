using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriWise.Application.UserProfiles;
using NutriWise.Application.Users;

namespace NutriWise.Controllers;

[Authorize]
[Route("api/user-profile")]
[ApiController]
public class UserProfileController : ControllerBase
{
	private readonly IUserProfileService _userProfileService;
	private readonly ICurrentUserService _currentUserService;

	public UserProfileController(IUserProfileService userProfileService, ICurrentUserService currentUserService)
	{
		_userProfileService = userProfileService;
		_currentUserService = currentUserService;
	}

	[HttpGet]
	public async Task<IActionResult> Get()
	{
		var currentUserId = _currentUserService.GetCurrentUserId();
		var userProfileDto = await _userProfileService.GetAsync(currentUserId);
		return userProfileDto is null ? NotFound() : Ok(userProfileDto);
	}

	[HttpPost]
	public async Task<IActionResult> Post([FromBody] UserProfileDto userProfileDto)
	{
		var currentUserId = _currentUserService.GetCurrentUserId();
		var createdUserProfile = await _userProfileService.CreateAsync(currentUserId, userProfileDto);
		return createdUserProfile is null 
			? Conflict() 
			: CreatedAtAction(nameof(Get), new { userId = createdUserProfile.UserId }, createdUserProfile);
	}
	
	[HttpPatch]
	public async Task<IActionResult> Patch([FromBody] UserProfileDto userProfileDto)
	{
		var currentUserId = _currentUserService.GetCurrentUserId();
		await _userProfileService.UpdateAsync(currentUserId, userProfileDto);
		
		return NoContent();
	}

	[HttpGet("selectable-fields")]
	public async Task<IActionResult> GetSelectableFields()
	{
		var selectableFieldsInfo = await _userProfileService.GetSelectableFieldsAsync();
		return Ok(selectableFieldsInfo);
	}
}