using Microsoft.EntityFrameworkCore;
using NutriWise.Domain.Entities.Product;
using NutriWise.Domain.Entities.UserProfile;

namespace NutriWise.Infrastructure.Database;

public sealed class DatabaseInitializer
{
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
        var foodCategories = new List<FoodCategory>
        {
            new()
            {
                Caption = "Fruits",
                SubCategories = new List<FoodSubCategory>
                {
                    new()
                    {
                        Caption = "Citrus Fruits",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Oranges", Calories = 47, Proteins = 0.9, Fats = 0.1, Carbohydrates = 12
                            },
                            new() { Caption = "Lemons", Calories = 29, Proteins = 1.1, Fats = 0.3, Carbohydrates = 9 },
                            new() { Caption = "Limes", Calories = 30, Proteins = 0.7, Fats = 0.2, Carbohydrates = 11 },
                            new()
                            {
                                Caption = "Grapefruits", Calories = 42, Proteins = 0.8, Fats = 0.1, Carbohydrates = 11
                            },
                            new()
                            {
                                Caption = "Tangerines", Calories = 53, Proteins = 0.8, Fats = 0.3, Carbohydrates = 13
                            },
                            new()
                            {
                                Caption = "Clementines", Calories = 47, Proteins = 0.9, Fats = 0.2, Carbohydrates = 12
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Berries",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Strawberries", Calories = 32, Proteins = 0.7, Fats = 0.3, Carbohydrates = 8
                            },
                            new()
                            {
                                Caption = "Blueberries", Calories = 57, Proteins = 0.7, Fats = 0.3, Carbohydrates = 14
                            },
                            new()
                            {
                                Caption = "Raspberries", Calories = 52, Proteins = 1.2, Fats = 0.7, Carbohydrates = 12
                            },
                            new()
                            {
                                Caption = "Blackberries", Calories = 43, Proteins = 1.4, Fats = 0.5, Carbohydrates = 10
                            },
                            new()
                            {
                                Caption = "Cranberries", Calories = 46, Proteins = 0.4, Fats = 0.1, Carbohydrates = 12
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Stone Fruits",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Peaches", Calories = 39, Proteins = 0.9, Fats = 0.3, Carbohydrates = 10
                            },
                            new() { Caption = "Plums", Calories = 46, Proteins = 0.7, Fats = 0.3, Carbohydrates = 11 },
                            new()
                            {
                                Caption = "Cherries", Calories = 50, Proteins = 1.0, Fats = 0.3, Carbohydrates = 12
                            },
                            new()
                            {
                                Caption = "Apricots", Calories = 48, Proteins = 1.4, Fats = 0.4, Carbohydrates = 11
                            },
                            new()
                            {
                                Caption = "Nectarines", Calories = 44, Proteins = 1.1, Fats = 0.3, Carbohydrates = 10
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Tropical Fruits",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Bananas", Calories = 89, Proteins = 1.1, Fats = 0.3, Carbohydrates = 23
                            },
                            new()
                            {
                                Caption = "Pineapples", Calories = 50, Proteins = 0.5, Fats = 0.1, Carbohydrates = 13
                            },
                            new()
                            {
                                Caption = "Mangoes", Calories = 60, Proteins = 0.8, Fats = 0.4, Carbohydrates = 15
                            },
                            new()
                            {
                                Caption = "Papayas", Calories = 43, Proteins = 0.5, Fats = 0.3, Carbohydrates = 11
                            },
                            new()
                            {
                                Caption = "Passion Fruit", Calories = 97, Proteins = 2.2, Fats = 0.4, Carbohydrates = 23
                            },
                            new() { Caption = "Guavas", Calories = 68, Proteins = 2.6, Fats = 1.0, Carbohydrates = 14 }
                        }
                    },
                    new()
                    {
                        Caption = "Pome Fruits",
                        Products = new List<Product>
                        {
                            new() { Caption = "Apples", Calories = 52, Proteins = 0.3, Fats = 0.2, Carbohydrates = 14 },
                            new() { Caption = "Pears", Calories = 57, Proteins = 0.4, Fats = 0.1, Carbohydrates = 15 },
                            new() { Caption = "Quinces", Calories = 57, Proteins = 0.4, Fats = 0.1, Carbohydrates = 15 }
                        }
                    },
                    new()
                    {
                        Caption = "Melons",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Watermelons", Calories = 30, Proteins = 0.6, Fats = 0.2, Carbohydrates = 8
                            },
                            new()
                            {
                                Caption = "Cantaloupes", Calories = 34, Proteins = 0.8, Fats = 0.2, Carbohydrates = 8
                            },
                            new()
                            {
                                Caption = "Honeydews", Calories = 36, Proteins = 0.5, Fats = 0.1, Carbohydrates = 9
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Dried Fruits",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Raisins", Calories = 299, Proteins = 3.1, Fats = 0.5, Carbohydrates = 79
                            },
                            new() { Caption = "Dates", Calories = 282, Proteins = 2.5, Fats = 0.4, Carbohydrates = 75 },
                            new()
                            {
                                Caption = "Dried Apricots", Calories = 241, Proteins = 3.4, Fats = 0.5,
                                Carbohydrates = 63
                            }
                        }
                    }
                }
            },
            new()
            {
                Caption = "Vegetables",
                SubCategories = new List<FoodSubCategory>
                {
                    new()
                    {
                        Caption = "Leafy Greens",
                        Products = new List<Product>
                        {
                            new() { Caption = "Lettuce", Calories = 15, Proteins = 1.4, Fats = 0.2, Carbohydrates = 3 },
                            new()
                            {
                                Caption = "Spinach", Calories = 23, Proteins = 2.9, Fats = 0.4, Carbohydrates = 3.6
                            },
                            new() { Caption = "Kale", Calories = 35, Proteins = 2.9, Fats = 1.5, Carbohydrates = 4.4 },
                            new()
                            {
                                Caption = "Swiss Chard", Calories = 19, Proteins = 1.8, Fats = 0.2, Carbohydrates = 3.7
                            },
                            new()
                            {
                                Caption = "Arugula", Calories = 25, Proteins = 2.6, Fats = 0.7, Carbohydrates = 3.7
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Cruciferous Vegetables",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Broccoli", Calories = 55, Proteins = 3.7, Fats = 0.6, Carbohydrates = 11
                            },
                            new()
                            {
                                Caption = "Cauliflower", Calories = 25, Proteins = 1.9, Fats = 0.3, Carbohydrates = 5
                            },
                            new() { Caption = "Cabbage", Calories = 25, Proteins = 1.3, Fats = 0.1, Carbohydrates = 6 },
                            new()
                            {
                                Caption = "Brussels Sprouts", Calories = 43, Proteins = 3.4, Fats = 0.3,
                                Carbohydrates = 9
                            },
                            new()
                            {
                                Caption = "Bok Choy", Calories = 13, Proteins = 1.5, Fats = 0.2, Carbohydrates = 2.2
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Root Vegetables",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Carrots", Calories = 41, Proteins = 0.9, Fats = 0.2, Carbohydrates = 10
                            },
                            new() { Caption = "Beets", Calories = 43, Proteins = 1.6, Fats = 0.2, Carbohydrates = 10 },
                            new() { Caption = "Turnips", Calories = 28, Proteins = 0.9, Fats = 0.1, Carbohydrates = 6 },
                            new()
                            {
                                Caption = "Radishes", Calories = 16, Proteins = 0.7, Fats = 0.1, Carbohydrates = 3.4
                            },
                            new()
                            {
                                Caption = "Parsnips", Calories = 75, Proteins = 1.2, Fats = 0.3, Carbohydrates = 18
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Allium Vegetables",
                        Products = new List<Product>
                        {
                            new() { Caption = "Onions", Calories = 40, Proteins = 1.1, Fats = 0.1, Carbohydrates = 9 },
                            new()
                            {
                                Caption = "Garlic", Calories = 149, Proteins = 6.4, Fats = 0.5, Carbohydrates = 33
                            },
                            new() { Caption = "Leeks", Calories = 61, Proteins = 1.5, Fats = 0.3, Carbohydrates = 14 },
                            new()
                            {
                                Caption = "Shallots", Calories = 72, Proteins = 2.5, Fats = 0.1, Carbohydrates = 17
                            },
                            new()
                            {
                                Caption = "Green Onions", Calories = 32, Proteins = 1.8, Fats = 0.2, Carbohydrates = 7
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Squash Vegetables",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Zucchini", Calories = 17, Proteins = 1.2, Fats = 0.3, Carbohydrates = 3.1
                            },
                            new()
                            {
                                Caption = "Yellow Squash", Calories = 16, Proteins = 1.0, Fats = 0.2,
                                Carbohydrates = 3.4
                            },
                            new() { Caption = "Pumpkin", Calories = 26, Proteins = 1.0, Fats = 0.1, Carbohydrates = 7 },
                            new()
                            {
                                Caption = "Butternut Squash", Calories = 45, Proteins = 1.0, Fats = 0.1,
                                Carbohydrates = 12
                            },
                            new()
                            {
                                Caption = "Acorn Squash", Calories = 40, Proteins = 1.5, Fats = 0.1, Carbohydrates = 10
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Nightshades",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Tomatoes", Calories = 18, Proteins = 0.9, Fats = 0.2, Carbohydrates = 3.9
                            },
                            new()
                            {
                                Caption = "Cherry Tomatoes", Calories = 18, Proteins = 0.9, Fats = 0.2,
                                Carbohydrates = 3.9
                            },
                            new()
                            {
                                Caption = "Grape Tomatoes", Calories = 18, Proteins = 0.9, Fats = 0.2,
                                Carbohydrates = 3.9
                            },
                            new()
                            {
                                Caption = "Eggplants", Calories = 25, Proteins = 1.0, Fats = 0.2, Carbohydrates = 6
                            },
                            new()
                            {
                                Caption = "Bell Peppers", Calories = 31, Proteins = 1.0, Fats = 0.3, Carbohydrates = 6
                            },
                            new()
                            {
                                Caption = "Chili Peppers", Calories = 40, Proteins = 2.0, Fats = 0.4, Carbohydrates = 9
                            },
                            new()
                            {
                                Caption = "Jalapenos", Calories = 29, Proteins = 1.0, Fats = 0.4, Carbohydrates = 6
                            },
                            new()
                            {
                                Caption = "Habaneros", Calories = 40, Proteins = 1.8, Fats = 0.4, Carbohydrates = 8
                            },
                            new()
                            {
                                Caption = "Serrano Peppers", Calories = 32, Proteins = 1.7, Fats = 0.4,
                                Carbohydrates = 7
                            }
                        }
                    }
                }
            },
            new()
            {
                Caption = "Meats",
                SubCategories = new List<FoodSubCategory>
                {
                    new()
                    {
                        Caption = "Beef",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Ground Beef", Calories = 250, Proteins = 26, Fats = 17, Carbohydrates = 0
                            },
                            new() { Caption = "Steaks", Calories = 271, Proteins = 25, Fats = 19, Carbohydrates = 0 },
                            new() { Caption = "Roasts", Calories = 286, Proteins = 28, Fats = 19, Carbohydrates = 0 }
                        }
                    },
                    new()
                    {
                        Caption = "Pork",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Pork Chops", Calories = 231, Proteins = 25, Fats = 14, Carbohydrates = 0
                            },
                            new()
                            {
                                Caption = "Pork Loins", Calories = 206, Proteins = 23, Fats = 12, Carbohydrates = 0
                            },
                            new()
                            {
                                Caption = "Ground Pork", Calories = 263, Proteins = 18, Fats = 21, Carbohydrates = 0
                            },
                            new() { Caption = "Bacon", Calories = 541, Proteins = 37, Fats = 42, Carbohydrates = 1 },
                            new() { Caption = "Ham", Calories = 145, Proteins = 20, Fats = 5, Carbohydrates = 1.5 }
                        }
                    },
                    new()
                    {
                        Caption = "Poultry",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Chicken Breasts", Calories = 165, Proteins = 31, Fats = 3.6,
                                Carbohydrates = 0
                            },
                            new()
                            {
                                Caption = "Chicken Thighs", Calories = 209, Proteins = 26, Fats = 10.9,
                                Carbohydrates = 0
                            },
                            new()
                            {
                                Caption = "Chicken Wings", Calories = 203, Proteins = 30, Fats = 8, Carbohydrates = 0
                            },
                            new()
                            {
                                Caption = "Ground Chicken", Calories = 143, Proteins = 17, Fats = 8, Carbohydrates = 0
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Fish",
                        Products = new List<Product>
                        {
                            new() { Caption = "Salmon", Calories = 208, Proteins = 20, Fats = 13, Carbohydrates = 0 },
                            new() { Caption = "Tuna", Calories = 132, Proteins = 28, Fats = 1, Carbohydrates = 0 },
                            new() { Caption = "Cod", Calories = 82, Proteins = 18, Fats = 0.7, Carbohydrates = 0 },
                            new() { Caption = "Haddock", Calories = 90, Proteins = 20, Fats = 0.6, Carbohydrates = 0 }
                        }
                    },
                    new()
                    {
                        Caption = "Shellfish",
                        Products = new List<Product>
                        {
                            new() { Caption = "Shrimp", Calories = 99, Proteins = 24, Fats = 0.3, Carbohydrates = 0.2 },
                            new() { Caption = "Crab", Calories = 87, Proteins = 18, Fats = 1.5, Carbohydrates = 0 },
                            new() { Caption = "Lobster", Calories = 89, Proteins = 19, Fats = 0.9, Carbohydrates = 0 },
                            new() { Caption = "Scallops", Calories = 111, Proteins = 23, Fats = 0.8, Carbohydrates = 5 }
                        }
                    }
                }
            },
            new()
            {
                Caption = "Dairy",
                SubCategories = new List<FoodSubCategory>
                {
                    new()
                    {
                        Caption = "Cheese",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Cheddar", Calories = 402, Proteins = 25, Fats = 33, Carbohydrates = 1.3
                            },
                            new()
                            {
                                Caption = "Mozzarella", Calories = 280, Proteins = 28, Fats = 17, Carbohydrates = 3.1
                            },
                            new() { Caption = "Swiss", Calories = 380, Proteins = 27, Fats = 28, Carbohydrates = 5 },
                            new()
                            {
                                Caption = "Parmesan", Calories = 431, Proteins = 38, Fats = 29, Carbohydrates = 4.1
                            },
                            new() { Caption = "Feta", Calories = 264, Proteins = 14, Fats = 21, Carbohydrates = 4 },
                            new()
                            {
                                Caption = "Goat Cheese", Calories = 364, Proteins = 22, Fats = 30, Carbohydrates = 0
                            },
                            new()
                            {
                                Caption = "Cottage Cheese", Calories = 98, Proteins = 11, Fats = 4.3,
                                Carbohydrates = 3.4
                            },
                            new() { Caption = "Ricotta", Calories = 174, Proteins = 11, Fats = 13, Carbohydrates = 3 },
                            new()
                            {
                                Caption = "Cream Cheese", Calories = 342, Proteins = 6, Fats = 34, Carbohydrates = 4.1
                            },
                            new() { Caption = "Brie", Calories = 334, Proteins = 20, Fats = 28, Carbohydrates = 0.5 }
                        }
                    },
                    new()
                    {
                        Caption = "Milk",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Whole Milk", Calories = 61, Proteins = 3.2, Fats = 3.3, Carbohydrates = 4.8
                            },
                            new()
                            {
                                Caption = "Low-Fat Milk", Calories = 50, Proteins = 3.5, Fats = 1.2, Carbohydrates = 5
                            },
                            new()
                            {
                                Caption = "Skim Milk", Calories = 34, Proteins = 3.4, Fats = 0.1, Carbohydrates = 5
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Other Dairy",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Greek Yogurt", Calories = 59, Proteins = 10, Fats = 0.4, Carbohydrates = 3.6
                            },
                            new()
                            {
                                Caption = "Salted Butter", Calories = 717, Proteins = 0.9, Fats = 81, Carbohydrates = 0
                            },
                            new()
                            {
                                Caption = "Unsalted Butter", Calories = 717, Proteins = 0.9, Fats = 81,
                                Carbohydrates = 0
                            },
                            new()
                            {
                                Caption = "Heavy Cream", Calories = 340, Proteins = 2.8, Fats = 36, Carbohydrates = 2.8
                            },
                            new()
                            {
                                Caption = "Sour Cream", Calories = 214, Proteins = 2.4, Fats = 20, Carbohydrates = 4.6
                            }
                        }
                    }
                }
            },
            new()
            {
                Caption = "Grains and Legumes",
                SubCategories = new List<FoodSubCategory>
                {
                    new()
                    {
                        Caption = "Rice",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "White Rice", Calories = 130, Proteins = 2.4, Fats = 0.2, Carbohydrates = 28
                            },
                            new()
                            {
                                Caption = "Brown Rice", Calories = 123, Proteins = 2.7, Fats = 1, Carbohydrates = 26
                            },
                            new()
                            {
                                Caption = "Basmati Rice", Calories = 121, Proteins = 3.5, Fats = 0.3, Carbohydrates = 25
                            },
                            new()
                            {
                                Caption = "Jasmine Rice", Calories = 130, Proteins = 2.4, Fats = 0.2, Carbohydrates = 28
                            },
                            new()
                            {
                                Caption = "Arborio Rice", Calories = 130, Proteins = 2.4, Fats = 0.2, Carbohydrates = 28
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Other Grains",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Quinoa", Calories = 120, Proteins = 4.4, Fats = 1.9, Carbohydrates = 21
                            },
                            new() { Caption = "Barley", Calories = 354, Proteins = 12, Fats = 2.3, Carbohydrates = 73 },
                            new() { Caption = "Millet", Calories = 378, Proteins = 11, Fats = 4.2, Carbohydrates = 73 },
                            new()
                            {
                                Caption = "Buckwheat", Calories = 343, Proteins = 13, Fats = 3.4, Carbohydrates = 71
                            },
                            new() { Caption = "Rye", Calories = 335, Proteins = 10, Fats = 2.5, Carbohydrates = 73 },
                            new()
                            {
                                Caption = "Cornmeal", Calories = 370, Proteins = 9, Fats = 4.7, Carbohydrates = 79
                            },
                            new()
                            {
                                Caption = "Polenta", Calories = 373, Proteins = 8.9, Fats = 1.9, Carbohydrates = 79
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Pasta",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Spaghetti", Calories = 158, Proteins = 5.8, Fats = 0.9, Carbohydrates = 30.9
                            },
                            new()
                            {
                                Caption = "Penne", Calories = 157, Proteins = 5.9, Fats = 0.8, Carbohydrates = 30.6
                            },
                            new()
                            {
                                Caption = "Fusilli", Calories = 150, Proteins = 5.7, Fats = 0.9, Carbohydrates = 30
                            },
                            new()
                            {
                                Caption = "Macaroni", Calories = 158, Proteins = 5.8, Fats = 0.9, Carbohydrates = 30.9
                            },
                            new()
                            {
                                Caption = "Lasagna Sheets", Calories = 165, Proteins = 5.9, Fats = 1,
                                Carbohydrates = 31.4
                            },
                            new()
                            {
                                Caption = "Rice Noodles", Calories = 109, Proteins = 2, Fats = 0.2, Carbohydrates = 24.9
                            },
                            new()
                            {
                                Caption = "Soba Noodles", Calories = 99, Proteins = 5, Fats = 0.1, Carbohydrates = 21.4
                            },
                            new()
                            {
                                Caption = "Egg Noodles", Calories = 138, Proteins = 4.5, Fats = 1.7,
                                Carbohydrates = 25.2
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Legumes",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Black Beans", Calories = 132, Proteins = 8.9, Fats = 0.5, Carbohydrates = 24
                            },
                            new()
                            {
                                Caption = "Kidney Beans", Calories = 127, Proteins = 8.7, Fats = 0.5, Carbohydrates = 23
                            },
                            new()
                            {
                                Caption = "Pinto Beans", Calories = 143, Proteins = 9, Fats = 0.7, Carbohydrates = 27
                            },
                            new()
                            {
                                Caption = "Chickpeas", Calories = 164, Proteins = 8.9, Fats = 2.6, Carbohydrates = 27
                            },
                            new() { Caption = "Lentils", Calories = 116, Proteins = 9, Fats = 0.4, Carbohydrates = 20 }
                        }
                    }
                }
            },
            new()
            {
                Caption = "Nuts and Seeds",
                SubCategories = new List<FoodSubCategory>
                {
                    new()
                    {
                        Caption = "Nuts",
                        Products = new List<Product>
                        {
                            new() { Caption = "Almonds", Calories = 579, Proteins = 21, Fats = 50, Carbohydrates = 22 },
                            new() { Caption = "Walnuts", Calories = 654, Proteins = 15, Fats = 65, Carbohydrates = 14 },
                            new() { Caption = "Pecans", Calories = 691, Proteins = 9, Fats = 72, Carbohydrates = 14 },
                            new() { Caption = "Cashews", Calories = 553, Proteins = 18, Fats = 44, Carbohydrates = 30 },
                            new()
                            {
                                Caption = "Pistachios", Calories = 562, Proteins = 20, Fats = 45, Carbohydrates = 28
                            },
                            new()
                            {
                                Caption = "Macadamia Nuts", Calories = 718, Proteins = 8, Fats = 76, Carbohydrates = 14
                            },
                            new() { Caption = "Peanuts", Calories = 567, Proteins = 25, Fats = 49, Carbohydrates = 16 }
                        }
                    },
                    new()
                    {
                        Caption = "Seeds",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Sunflower Seeds", Calories = 584, Proteins = 20, Fats = 51,
                                Carbohydrates = 20
                            },
                            new()
                            {
                                Caption = "Pumpkin Seeds", Calories = 446, Proteins = 19, Fats = 19, Carbohydrates = 54
                            },
                            new()
                            {
                                Caption = "Chia Seeds", Calories = 486, Proteins = 17, Fats = 31, Carbohydrates = 42
                            },
                            new()
                            {
                                Caption = "Flaxseeds", Calories = 534, Proteins = 18, Fats = 42, Carbohydrates = 29
                            }
                        }
                    }
                }
            },
            new()
            {
                Caption = "Oils and Fats",
                SubCategories = new List<FoodSubCategory>
                {
                    new()
                    {
                        Caption = "Oils",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Olive Oil", Calories = 884, Proteins = 0, Fats = 100, Carbohydrates = 0
                            },
                            new()
                            {
                                Caption = "Vegetable Oil", Calories = 884, Proteins = 0, Fats = 100, Carbohydrates = 0
                            },
                            new()
                            {
                                Caption = "Canola Oil", Calories = 884, Proteins = 0, Fats = 100, Carbohydrates = 0
                            },
                            new()
                            {
                                Caption = "Sunflower Oil", Calories = 884, Proteins = 0, Fats = 100, Carbohydrates = 0
                            },
                            new()
                            {
                                Caption = "Coconut Oil", Calories = 862, Proteins = 0, Fats = 100, Carbohydrates = 0
                            },
                            new()
                            {
                                Caption = "Avocado Oil", Calories = 884, Proteins = 0, Fats = 100, Carbohydrates = 0
                            },
                            new()
                            {
                                Caption = "Sesame Oil", Calories = 884, Proteins = 0, Fats = 100, Carbohydrates = 0
                            }
                        }
                    }
                }
            },
            new()
            {
                Caption = "Herbs and Spices",
                SubCategories = new List<FoodSubCategory>
                {
                    new()
                    {
                        Caption = "Herbs",
                        Products = new List<Product>
                        {
                            new() { Caption = "Basil", Calories = 22, Proteins = 3.2, Fats = 0.6, Carbohydrates = 1.6 },
                            new() { Caption = "Oregano", Calories = 265, Proteins = 9, Fats = 4.3, Carbohydrates = 69 },
                            new() { Caption = "Thyme", Calories = 276, Proteins = 9, Fats = 7.4, Carbohydrates = 63 },
                            new()
                            {
                                Caption = "Rosemary", Calories = 131, Proteins = 3.3, Fats = 5.9, Carbohydrates = 21
                            },
                            new() { Caption = "Parsley", Calories = 36, Proteins = 3, Fats = 0.8, Carbohydrates = 6.3 },
                            new()
                            {
                                Caption = "Cilantro", Calories = 23, Proteins = 2.1, Fats = 0.5, Carbohydrates = 3.7
                            },
                            new() { Caption = "Dill", Calories = 43, Proteins = 3.5, Fats = 1.1, Carbohydrates = 7 },
                            new() { Caption = "Mint", Calories = 70, Proteins = 4.8, Fats = 0.9, Carbohydrates = 15 }
                        }
                    },
                    new()
                    {
                        Caption = "Spices",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Black Pepper", Calories = 251, Proteins = 10, Fats = 3.3, Carbohydrates = 64
                            },
                            new() { Caption = "Paprika", Calories = 282, Proteins = 14, Fats = 13, Carbohydrates = 54 },
                            new()
                            {
                                Caption = "Chili Powder", Calories = 282, Proteins = 12, Fats = 13, Carbohydrates = 50
                            },
                            new() { Caption = "Cumin", Calories = 375, Proteins = 18, Fats = 22, Carbohydrates = 44 },
                            new()
                            {
                                Caption = "Coriander", Calories = 298, Proteins = 12, Fats = 17, Carbohydrates = 55
                            },
                            new()
                            {
                                Caption = "Turmeric", Calories = 312, Proteins = 9.7, Fats = 3.3, Carbohydrates = 67
                            },
                            new()
                            {
                                Caption = "Cinnamon", Calories = 247, Proteins = 4, Fats = 1.2, Carbohydrates = 81
                            },
                            new() { Caption = "Ginger", Calories = 335, Proteins = 9, Fats = 4.2, Carbohydrates = 71 }
                        }
                    }
                }
            },
            new()
            {
                Caption = "Baking Ingredients",
                SubCategories = new List<FoodSubCategory>
                {
                    new()
                    {
                        Caption = "Sugars",
                        Products = new List<Product>
                        {
                            new()
                            {
                                Caption = "Granulated Sugar", Calories = 387, Proteins = 0, Fats = 0,
                                Carbohydrates = 100
                            },
                            new()
                            {
                                Caption = "Brown Sugar", Calories = 380, Proteins = 0, Fats = 0, Carbohydrates = 98
                            },
                            new() { Caption = "Honey", Calories = 304, Proteins = 0.3, Fats = 0, Carbohydrates = 82 },
                            new()
                            {
                                Caption = "Maple Syrup", Calories = 260, Proteins = 0, Fats = 0, Carbohydrates = 67
                            }
                        }
                    },
                    new()
                    {
                        Caption = "Baking Ingredients",
                        Products = new List<Product>
                        {
                            new() { Caption = "Salt", Calories = 0, Proteins = 0, Fats = 0, Carbohydrates = 0 },
                            new()
                            {
                                Caption = "Baking Powder", Calories = 53, Proteins = 0, Fats = 0, Carbohydrates = 28
                            },
                            new() { Caption = "Baking Soda", Calories = 0, Proteins = 0, Fats = 0, Carbohydrates = 0 }
                        }
                    }
                }
            }
        };

        await _context.FoodCategories.AddRangeAsync(foodCategories);
        await _context.SaveChangesAsync();
    }

    private async Task SeedAllergiesAsync()
    {
        var allergies = new List<Allergy>
        {
            new() { Caption = "Gluten" },
            new() { Caption = "Dairy" },
            new() { Caption = "Peanuts" },
            new() { Caption = "Tree Nuts" },
            new() { Caption = "Eggs" },
            new() { Caption = "Shellfish" },
            new() { Caption = "Fish" },
            new() { Caption = "Soy" },
            new() { Caption = "Wheat" },
            new() { Caption = "Sesame" }
        };

        await _context.Allergies.AddRangeAsync(allergies);
        await _context.SaveChangesAsync();
    }

    private async Task SeedKitchenEquipmentAsync()
    {
        var kitchenEquipment = new List<KitchenEquipment>
        {
            new() { Caption = "Blender" },
            new() { Caption = "Oven" },
            new() { Caption = "Microwave" },
            new() { Caption = "Air Fryer" },
            new() { Caption = "Food Processor" },
            new() { Caption = "Grill" },
            new() { Caption = "Stove" },
            new() { Caption = "Slow Cooker" },
            new() { Caption = "Pressure Cooker" },
            new() { Caption = "Toaster" },
            new() { Caption = "Rice Cooker" },
            new() { Caption = "Mixer" }
        };

        await _context.KitchenEquipments.AddRangeAsync(kitchenEquipment);
        await _context.SaveChangesAsync();
    }
}