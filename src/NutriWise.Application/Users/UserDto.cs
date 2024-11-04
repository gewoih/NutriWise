using NutriWise.Domain.ValueObjects;

namespace NutriWise.Application.Users;

public sealed class UserDto
{
    public Guid Id { get; set; }
    public Gender Gender { get; set; }
    public DateOnly BirthDate { get; set; }
}