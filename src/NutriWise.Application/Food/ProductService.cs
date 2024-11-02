using Microsoft.EntityFrameworkCore;
using NutriWise.Domain.Entities.Product;
using NutriWise.Infrastructure.Database;

namespace NutriWise.Application.Food;

public sealed class ProductService : IProductService
{
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetAllProductsAsync()
    {
        return await _context.Products.ToListAsync();
    }
}