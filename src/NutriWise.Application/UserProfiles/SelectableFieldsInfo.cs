using NutriWise.Domain.Entities.UserProfile;

namespace NutriWise.Application.UserProfiles;

public sealed class SelectableFieldsInfo
{
	public IEnumerable<string> Genders { get; set; }
	public IEnumerable<string> ActivityLevels { get; set; }
	public IEnumerable<string> DietGoalTypes { get; set; }
	public IEnumerable<Allergy> Allergies { get; set; }
	public IEnumerable<KitchenEquipment> KitchenEquipment { get; set; }
}