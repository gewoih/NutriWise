namespace NutriWise.Application.MealPlan;

public sealed class MealPlanDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<string> MealNames { get; set; }
    public int Calories { get; set; }
    public int Proteins { get; set; }
    public int Fats { get; set; }
    public int Carbs { get; set; }
}