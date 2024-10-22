namespace NutriWise.Application.Extensions;

public static class UserExtensions
{
	public static int CalculateAge(DateOnly birthdayDate)
	{
		var today = DateOnly.FromDateTime(DateTime.Today);
		var age = today.Year - birthdayDate.Year;

		if (birthdayDate > today.AddYears(-age))
			age--;

		return age;
	}
}