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
							new() { Caption = "Oranges" },
							new() { Caption = "Lemons" },
							new() { Caption = "Limes" },
							new() { Caption = "Grapefruits" },
							new() { Caption = "Tangerines" },
							new() { Caption = "Clementines" }
						}
					},
					new()
					{
						Caption = "Berries",
						Products = new List<Product>
						{
							new() { Caption = "Strawberries" },
							new() { Caption = "Blueberries" },
							new() { Caption = "Raspberries" },
							new() { Caption = "Blackberries" },
							new() { Caption = "Cranberries" }
						}
					},
					new()
					{
						Caption = "Stone Fruits",
						Products = new List<Product>
						{
							new() { Caption = "Peaches" },
							new() { Caption = "Plums" },
							new() { Caption = "Cherries" },
							new() { Caption = "Apricots" },
							new() { Caption = "Nectarines" }
						}
					},
					new()
					{
						Caption = "Tropical Fruits",
						Products = new List<Product>
						{
							new() { Caption = "Bananas" },
							new() { Caption = "Pineapples" },
							new() { Caption = "Mangoes" },
							new() { Caption = "Papayas" },
							new() { Caption = "Passion Fruit" },
							new() { Caption = "Guavas" }
						}
					},
					new()
					{
						Caption = "Pome Fruits",
						Products = new List<Product>
						{
							new() { Caption = "Apples" },
							new() { Caption = "Pears" },
							new() { Caption = "Quinces" }
						}
					},
					new()
					{
						Caption = "Melons",
						Products = new List<Product>
						{
							new() { Caption = "Watermelons" },
							new() { Caption = "Cantaloupes" },
							new() { Caption = "Honeydews" }
						}
					},
					new()
					{
						Caption = "Dried Fruits",
						Products = new List<Product>
						{
							new() { Caption = "Raisins" },
							new() { Caption = "Dates" },
							new() { Caption = "Dried Apricots" }
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
							new() { Caption = "Lettuce" },
							new() { Caption = "Spinach" },
							new() { Caption = "Kale" },
							new() { Caption = "Swiss Chard" },
							new() { Caption = "Arugula" }
						}
					},
					new()
					{
						Caption = "Cruciferous Vegetables",
						Products = new List<Product>
						{
							new() { Caption = "Broccoli" },
							new() { Caption = "Cauliflower" },
							new() { Caption = "Cabbage" },
							new() { Caption = "Brussels Sprouts" },
							new() { Caption = "Bok Choy" }
						}
					},
					new()
					{
						Caption = "Root Vegetables",
						Products = new List<Product>
						{
							new() { Caption = "Carrots" },
							new() { Caption = "Beets" },
							new() { Caption = "Turnips" },
							new() { Caption = "Radishes" },
							new() { Caption = "Parsnips" }
						}
					},
					new()
					{
						Caption = "Allium Vegetables",
						Products = new List<Product>
						{
							new() { Caption = "Onions" },
							new() { Caption = "Garlic" },
							new() { Caption = "Leeks" },
							new() { Caption = "Shallots" },
							new() { Caption = "Green Onions" }
						}
					},
					new()
					{
						Caption = "Squash Vegetables",
						Products = new List<Product>
						{
							new() { Caption = "Zucchini" },
							new() { Caption = "Yellow Squash" },
							new() { Caption = "Pumpkin" },
							new() { Caption = "Butternut Squash" },
							new() { Caption = "Acorn Squash" }
						}
					},
					new()
					{
						Caption = "Nightshades",
						Products = new List<Product>
						{
							new() { Caption = "Tomatoes" },
							new() { Caption = "Cherry Tomatoes" },
							new() { Caption = "Grape Tomatoes" },
							new() { Caption = "Eggplants" },
							new() { Caption = "Bell Peppers" },
							new() { Caption = "Chili Peppers" },
							new() { Caption = "Jalapenos" },
							new() { Caption = "Habaneros" },
							new() { Caption = "Serrano Peppers" }
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
							new() { Caption = "Ground Beef" },
							new() { Caption = "Steaks" },
							new() { Caption = "Roasts" }
						}
					},
					new()
					{
						Caption = "Pork",
						Products = new List<Product>
						{
							new() { Caption = "Pork Chops" },
							new() { Caption = "Pork Loins" },
							new() { Caption = "Ground Pork" },
							new() { Caption = "Bacon" },
							new() { Caption = "Ham" }
						}
					},
					new()
					{
						Caption = "Poultry",
						Products = new List<Product>
						{
							new() { Caption = "Chicken Breasts" },
							new() { Caption = "Chicken Thighs" },
							new() { Caption = "Chicken Wings" },
							new() { Caption = "Ground Chicken" }
						}
					},
					new()
					{
						Caption = "Fish",
						Products = new List<Product>
						{
							new() { Caption = "Salmon" },
							new() { Caption = "Tuna" },
							new() { Caption = "Cod" },
							new() { Caption = "Haddock" }
						}
					},
					new()
					{
						Caption = "Shellfish",
						Products = new List<Product>
						{
							new() { Caption = "Shrimp" },
							new() { Caption = "Crab" },
							new() { Caption = "Lobster" },
							new() { Caption = "Scallops" }
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
							new() { Caption = "Cheddar" },
							new() { Caption = "Mozzarella" },
							new() { Caption = "Swiss" },
							new() { Caption = "Parmesan" },
							new() { Caption = "Feta" },
							new() { Caption = "Goat Cheese" },
							new() { Caption = "Cottage Cheese" },
							new() { Caption = "Ricotta" },
							new() { Caption = "Cream Cheese" },
							new() { Caption = "Brie" }
						}
					},
					new()
					{
						Caption = "Milk",
						Products = new List<Product>
						{
							new() { Caption = "Whole Milk" },
							new() { Caption = "Low-Fat Milk" },
							new() { Caption = "Skim Milk" }
						}
					},
					new()
					{
						Caption = "Other Dairy",
						Products = new List<Product>
						{
							new() { Caption = "Greek Yogurt" },
							new() { Caption = "Salted Butter" },
							new() { Caption = "Unsalted Butter" },
							new() { Caption = "Heavy Cream" },
							new() { Caption = "Sour Cream" }
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
							new() { Caption = "White Rice" },
							new() { Caption = "Brown Rice" },
							new() { Caption = "Basmati Rice" },
							new() { Caption = "Jasmine Rice" },
							new() { Caption = "Arborio Rice" }
						}
					},
					new()
					{
						Caption = "Other Grains",
						Products = new List<Product>
						{
							new() { Caption = "Quinoa" },
							new() { Caption = "Barley" },
							new() { Caption = "Millet" },
							new() { Caption = "Buckwheat" },
							new() { Caption = "Rye" },
							new() { Caption = "Cornmeal" },
							new() { Caption = "Polenta" }
						}
					},
					new()
					{
						Caption = "Pasta",
						Products = new List<Product>
						{
							new() { Caption = "Spaghetti" },
							new() { Caption = "Penne" },
							new() { Caption = "Fusilli" },
							new() { Caption = "Macaroni" },
							new() { Caption = "Lasagna Sheets" },
							new() { Caption = "Rice Noodles" },
							new() { Caption = "Soba Noodles" },
							new() { Caption = "Egg Noodles" }
						}
					},
					new()
					{
						Caption = "Legumes",
						Products = new List<Product>
						{
							new() { Caption = "Black Beans" },
							new() { Caption = "Kidney Beans" },
							new() { Caption = "Pinto Beans" },
							new() { Caption = "Chickpeas" },
							new() { Caption = "Lentils" }
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
							new() { Caption = "Almonds" },
							new() { Caption = "Walnuts" },
							new() { Caption = "Pecans" },
							new() { Caption = "Cashews" },
							new() { Caption = "Pistachios" },
							new() { Caption = "Macadamia Nuts" },
							new() { Caption = "Peanuts" }
						}
					},
					new()
					{
						Caption = "Seeds",
						Products = new List<Product>
						{
							new() { Caption = "Sunflower Seeds" },
							new() { Caption = "Pumpkin Seeds" },
							new() { Caption = "Chia Seeds" },
							new() { Caption = "Flaxseeds" }
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
							new() { Caption = "Olive Oil" },
							new() { Caption = "Vegetable Oil" },
							new() { Caption = "Canola Oil" },
							new() { Caption = "Sunflower Oil" },
							new() { Caption = "Coconut Oil" },
							new() { Caption = "Avocado Oil" },
							new() { Caption = "Sesame Oil" }
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
							new() { Caption = "Basil" },
							new() { Caption = "Oregano" },
							new() { Caption = "Thyme" },
							new() { Caption = "Rosemary" },
							new() { Caption = "Parsley" },
							new() { Caption = "Cilantro" },
							new() { Caption = "Dill" },
							new() { Caption = "Mint" }
						}
					},
					new()
					{
						Caption = "Spices",
						Products = new List<Product>
						{
							new() { Caption = "Black Pepper" },
							new() { Caption = "Paprika" },
							new() { Caption = "Chili Powder" },
							new() { Caption = "Cumin" },
							new() { Caption = "Coriander" },
							new() { Caption = "Turmeric" },
							new() { Caption = "Cinnamon" },
							new() { Caption = "Ginger" }
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
							new() { Caption = "Granulated Sugar" },
							new() { Caption = "Brown Sugar" },
							new() { Caption = "Honey" },
							new() { Caption = "Maple Syrup" }
						}
					},
					new()
					{
						Caption = "Baking Ingredients",
						Products = new List<Product>
						{
							new() { Caption = "Salt" },
							new() { Caption = "Baking Powder" },
							new() { Caption = "Baking Soda" }
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