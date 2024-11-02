using Microsoft.AspNetCore.Identity;

namespace NutriWise.Domain.Entities.Identity;

public sealed class User : IdentityUser<Guid>
{
    public UserProfile.UserProfile Profile { get; set; }
}