using NutriWise.Domain.Entities.Product;

namespace NutriWise.Application.Food;

public interface IProductService
{
    Task<List<Product>> GetAllProductsAsync();
}