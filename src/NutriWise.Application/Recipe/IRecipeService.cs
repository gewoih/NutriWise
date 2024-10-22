using NutriWise.Domain.Entities.Recipe;

namespace NutriWise.Application.Recipe;

public interface IRecipeService
{
	Task<FoodRecipe> GenerateRecipeAsync();
}