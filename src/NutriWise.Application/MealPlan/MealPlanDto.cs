namespace NutriWise.Application.MealPlan;

public sealed class MealPlanDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<string> MealNames { get; set; }
}