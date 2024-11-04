namespace NutriWise.Application.UserProfile;

public interface IUserProfileService
{
	Task<UserProfileDto?> GetAsync(Guid userId);
	Task<Domain.Entities.UserProfile.UserProfile?> CreateAsync(Guid userId, UserProfileDto userProfileDto);
	Task<Domain.Entities.UserProfile.UserProfile?> UpdateAsync(Guid userId, UserProfileDto userProfileDto);
	Task<SelectableFieldsInfo> GetSelectableFieldsAsync();
}