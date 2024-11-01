namespace NutriWise.Application.MealPlan;

public sealed class MealDto
{
    public string Name { get; set; }
    public List<IngredientDto> Ingredients { get; set; }
    public string CookingInstructions { get; set; }
}