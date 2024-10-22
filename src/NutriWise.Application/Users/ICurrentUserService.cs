namespace NutriWise.Application.Users;

public interface ICurrentUserService
{
	Guid GetCurrentUserId();
}