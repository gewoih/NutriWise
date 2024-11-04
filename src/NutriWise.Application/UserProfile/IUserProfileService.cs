using NutriWise.Domain.Entities.UserProfile;

namespace NutriWise.Application.UserProfiles;

public interface IUserProfileService
{
	Task<UserProfileDto?> GetAsync(Guid userId);
	Task<UserProfile?> CreateAsync(Guid userId, UserProfileDto userProfileDto);
	Task<UserProfile?> UpdateAsync(Guid userId, UserProfileDto userProfileDto);
	Task<SelectableFieldsInfo> GetSelectableFieldsAsync();
}