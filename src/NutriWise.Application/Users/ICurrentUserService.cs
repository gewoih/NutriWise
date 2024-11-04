namespace NutriWise.Application.Users;

public interface ICurrentUserService
{
	Task<UserDto?> GetCurrentUserAsync();
	Guid GetCurrentUserId();
}