using System.Globalization;
using Microsoft.EntityFrameworkCore;
using NutriWise.Domain.Entities.Product;
using NutriWise.Domain.Entities.UserProfile;
using NutriWise.Infrastructure.Extensions;
using CsvHelper;
using CsvHelper.Configuration;

namespace NutriWise.Infrastructure.Database;

public sealed class DatabaseInitializer
{
    private sealed class CsvProduct
    {
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Product { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
        public double Carbohydrates { get; set; }
    }

    private class CsvProductMap : ClassMap<CsvProduct>
    {
        public CsvProductMap()
        {
            Map(m => m.Category).Name("Category");
            Map(m => m.SubCategory).Name("SubCategory");
            Map(m => m.Product).Name("Product");
            Map(m => m.Calories).Name("Calories");
            Map(m => m.Proteins).Name("Proteins");
            Map(m => m.Fats).Name("Fats");
            Map(m => m.Carbohydrates).Name("Carbohydrates");
        }
    }

    private readonly AppDbContext _context;

    public DatabaseInitializer(AppDbContext context)
    {
        _context = context;
    }

    public async Task InitializeAsync()
    {
        if (!await _context.Allergies.AnyAsync())
            await SeedAllergiesAsync();

        if (!await _context.KitchenEquipments.AnyAsync())
            await SeedKitchenEquipmentAsync();

        if (!await _context.FoodCategories.AnyAsync())
            await SeedProductsAndCategories();
    }

    private async Task SeedProductsAndCategories()
    {
        var productsContent = await EmbeddedResourcesUtils.GetResourceFileContentAsync("products.csv");

        using var reader = new StringReader(productsContent);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        csv.Context.RegisterClassMap<CsvProductMap>();
        await csv.ReadAsync();
        csv.ReadHeader();

        var records = csv.GetRecords<CsvProduct>().ToList();

        var foodCategories = records
            .GroupBy(r => r.Category)
            .Select(g => new FoodCategory
            {
                Caption = g.Key,
                SubCategories = g.GroupBy(r => r.SubCategory)
                    .Select(sg => new FoodSubCategory
                    {
                        Caption = sg.Key,
                        Products = sg.Select(p => new Product
                        {
                            Caption = p.Product,
                            Calories = p.Calories,
                            Proteins = p.Proteins,
                            Fats = p.Fats,
                            Carbohydrates = p.Carbohydrates
                        }).ToList()
                    }).ToList()
            }).ToList();

        await _context.FoodCategories.AddRangeAsync(foodCategories);
        await _context.SaveChangesAsync();
    }

    private async Task SeedAllergiesAsync()
    {
        var allergies = new List<Allergy>
        {
            new() { Caption = "Глютен" },
            new() { Caption = "Молочные продукты" },
            new() { Caption = "Арахис" },
            new() { Caption = "Древесные орехи" },
            new() { Caption = "Яйца" },
            new() { Caption = "Моллюски" },
            new() { Caption = "Рыба" },
            new() { Caption = "Соя" },
            new() { Caption = "Пшеница" },
            new() { Caption = "Кунжут" }
        };

        await _context.Allergies.AddRangeAsync(allergies);
        await _context.SaveChangesAsync();
    }

    private async Task SeedKitchenEquipmentAsync()
    {
        var kitchenEquipment = new List<KitchenEquipment>
        {
            new() { Caption = "Плита" },
            new() { Caption = "Духовка" },
            new() { Caption = "Микроволновка" },
            new() { Caption = "Аэрогриль" },
            new() { Caption = "Гриль" },
            new() { Caption = "Мультиварка" },
            new() { Caption = "Блендер" },
            new() { Caption = "Тостер" },
        };

        await _context.KitchenEquipments.AddRangeAsync(kitchenEquipment);
        await _context.SaveChangesAsync();
    }
}