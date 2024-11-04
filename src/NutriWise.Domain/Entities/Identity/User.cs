using Microsoft.AspNetCore.Identity;
using NutriWise.Domain.ValueObjects;

namespace NutriWise.Domain.Entities.Identity;

public sealed class User : IdentityUser<Guid>
{
    public Gender Gender { get; set; }
    public DateOnly BirthDate { get; set; }
    public UserProfile.UserProfile Profile { get; set; }
}