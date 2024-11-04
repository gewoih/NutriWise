using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using NutriWise.Domain.Entities.Identity;

namespace NutriWise.Application.Users;

public sealed class CurrentUserService : ICurrentUserService
{
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly UserManager<User> _userManager;

	public CurrentUserService(IHttpContextAccessor httpContextAccessor, UserManager<User> userManager)
	{
		_httpContextAccessor = httpContextAccessor;
		_userManager = userManager;
	}

	public async Task<UserDto?> GetCurrentUserAsync()
	{
		var currentUserId = GetCurrentUserId();
		var currentUser = await _userManager.FindByIdAsync(currentUserId.ToString());
		if (currentUser is null) 
			return null;
		
		return new UserDto
		{
			Id = currentUserId,
			Gender = currentUser.Gender,
			BirthDate = currentUser.BirthDate
		};
	}

	public Guid GetCurrentUserId()
	{
		var nameIdentifierClaims = _httpContextAccessor.HttpContext?.User.Claims
			.Where(c => c.Type == ClaimTypes.NameIdentifier)
			.Select(c => c.Value)
			.ToList();

		if (nameIdentifierClaims is null || nameIdentifierClaims.Count == 0)
			return Guid.Empty;

		foreach (var claim in nameIdentifierClaims)
		{
			if (Guid.TryParse(claim, out var userId))
				return userId;
		}

		return Guid.Empty;
	}
}