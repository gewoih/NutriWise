namespace NutriWise.Application.MealPlan;

public sealed class MealPlanDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<MealDto> Meals { get; set; }
}