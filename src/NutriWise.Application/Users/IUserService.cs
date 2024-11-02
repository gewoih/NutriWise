using Microsoft.AspNetCore.Authentication;

namespace NutriWise.Application.Users;

public interface IUserService
{
    Task<string> LoginGoogleAsync();
    AuthenticationProperties GetGoogleAuthenticationProperties(string returnUrl);
}