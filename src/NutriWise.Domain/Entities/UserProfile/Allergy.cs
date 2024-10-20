namespace NutriWise.Domain.Entities.UserProfile;

public sealed class Allergy
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public ICollection<UserProfile> UserProfiles { get; set; }
}