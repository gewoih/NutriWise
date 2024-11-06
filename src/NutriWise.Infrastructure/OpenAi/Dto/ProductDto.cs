namespace NutriWise.Infrastructure.OpenAi.Dto;

public class ProductDto
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public double Calories { get; set; }
	public double Proteins { get; set; }
	public double Fats { get; set; }
	public double Carbs { get; set; }
}