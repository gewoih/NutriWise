using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using NutriWise.Application;

namespace NutriWise.Controllers;

[Authorize]
[ApiController]
[Route("api/user-profile")]
public class UserProfileController : ControllerBase
{
	private readonly IUserProfileService _userProfileService;

	public UserProfileController(IUserProfileService userProfileService)
	{
		_userProfileService = userProfileService;
	}

	[HttpGet]
	public async Task<IActionResult> Get()
	{
		var currentUserId = GetCurrentUserId();
		var userProfileDto = await _userProfileService.GetAsync(currentUserId);
		return userProfileDto is null ? NotFound() : Ok(userProfileDto);
	}

	[HttpPost]
	public async Task<IActionResult> Post([FromBody] UserProfileDto userProfileDto)
	{
		var currentUserId = GetCurrentUserId();
		var createdUserProfile = await _userProfileService.CreateAsync(currentUserId, userProfileDto);
		return createdUserProfile is null 
			? Conflict() 
			: CreatedAtAction(nameof(Get), new { userId = createdUserProfile.UserId }, createdUserProfile);
	}
	
	[HttpPatch]
	public async Task<IActionResult> Patch([FromBody] JsonPatchDocument<UserProfileDto> patchDocument)
	{
		var currentUserId = GetCurrentUserId();
		var userProfileDto = await _userProfileService.GetAsync(currentUserId);
		if (userProfileDto is null)
			return NotFound();

		patchDocument.ApplyTo(userProfileDto);
		
		await _userProfileService.UpdateAsync(currentUserId, userProfileDto);
		return NoContent();
	}
	
	private Guid GetCurrentUserId()
	{
		var nameIdentifierClaims = User?.Claims
			.Where(c => c.Type == ClaimTypes.NameIdentifier)
			.Select(c => c.Value)
			.ToList();

		if (nameIdentifierClaims == null || nameIdentifierClaims.Count == 0)
			return Guid.Empty;

		foreach (var claim in nameIdentifierClaims)
		{
			if (Guid.TryParse(claim, out var userId))
				return userId;
		}

		return Guid.Empty;
	}
}