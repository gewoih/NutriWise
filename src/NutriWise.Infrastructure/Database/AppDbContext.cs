using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NutriWise.Domain.Entities.Base;
using NutriWise.Domain.Entities.Identity;
using NutriWise.Domain.Entities.Meal;
using NutriWise.Domain.Entities.Product;
using NutriWise.Domain.Entities.UserProfile;

namespace NutriWise.Infrastructure.Database;

public sealed class AppDbContext : IdentityDbContext<User, Role, Guid>
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	public DbSet<UserProfile> UserProfiles { get; set; }
	public DbSet<Allergy> Allergies { get; set; }
	public DbSet<KitchenEquipment> KitchenEquipments { get; set; }
	public DbSet<FoodCategory> FoodCategories { get; set; }
	public DbSet<FoodSubCategory> FoodSubCategories { get; set; }
	public DbSet<Product> Products { get; set; }
	public DbSet<Ingredient> Ingredients { get; set; }
	public DbSet<Meal> Meals { get; set; }
	public DbSet<DailyMeals> DailyMeals { get; set; }
	public DbSet<MealPlan> MealPlans { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		SeedAllergies(modelBuilder);
		SeedKitchenEquipment(modelBuilder);
		SeedCategories(modelBuilder);
	}

	private static void SeedCategories(ModelBuilder modelBuilder)
	{
		var fruitCategoryId = Guid.NewGuid();
		var vegetableCategoryId = Guid.NewGuid();
		var meatCategoryId = Guid.NewGuid();
		var dairyCategoryId = Guid.NewGuid();
		var grainCategoryId = Guid.NewGuid();
		var nutCategoryId = Guid.NewGuid();
		var oilCategoryId = Guid.NewGuid();
		var herbCategoryId = Guid.NewGuid();
		var bakingCategoryId = Guid.NewGuid();

		modelBuilder.Entity<FoodCategory>().HasData(
			new { Id = fruitCategoryId, Name = "Fruits" },
			new { Id = vegetableCategoryId, Name = "Vegetables" },
			new { Id = meatCategoryId, Name = "Meats" },
			new { Id = dairyCategoryId, Name = "Dairy" },
			new { Id = grainCategoryId, Name = "Grains and Legumes" },
			new { Id = nutCategoryId, Name = "Nuts and Seeds" },
			new { Id = oilCategoryId, Name = "Oils and Fats" },
			new { Id = herbCategoryId, Name = "Herbs and Spices" },
			new { Id = bakingCategoryId, Name = "Baking Ingredients" }
		);

		var citrusFruitsSubCategoryId = Guid.NewGuid();
		var berriesSubCategoryId = Guid.NewGuid();
		var stoneFruitsSubCategoryId = Guid.NewGuid();
		var tropicalFruitsSubCategoryId = Guid.NewGuid();
		var pomeFruitsSubCategoryId = Guid.NewGuid();
		var melonsSubCategoryId = Guid.NewGuid();
		var driedFruitsSubCategoryId = Guid.NewGuid();

		var leafyGreensSubCategoryId = Guid.NewGuid();
		var cruciferousVegetablesSubCategoryId = Guid.NewGuid();
		var rootVegetablesSubCategoryId = Guid.NewGuid();
		var alliumVegetablesSubCategoryId = Guid.NewGuid();
		var squashVegetablesSubCategoryId = Guid.NewGuid();
		var nightshadesSubCategoryId = Guid.NewGuid();

		var beefSubCategoryId = Guid.NewGuid();
		var porkSubCategoryId = Guid.NewGuid();
		var poultrySubCategoryId = Guid.NewGuid();
		var fishSubCategoryId = Guid.NewGuid();
		var shellfishSubCategoryId = Guid.NewGuid();

		var cheeseSubCategoryId = Guid.NewGuid();
		var milkSubCategoryId = Guid.NewGuid();
		var otherDairySubCategoryId = Guid.NewGuid();

		var riceSubCategoryId = Guid.NewGuid();
		var otherGrainsSubCategoryId = Guid.NewGuid();
		var pastaSubCategoryId = Guid.NewGuid();
		var legumesSubCategoryId = Guid.NewGuid();

		var nutsSubCategoryId = Guid.NewGuid();
		var seedsSubCategoryId = Guid.NewGuid();

		var oilsSubCategoryId = Guid.NewGuid();

		var herbsSubCategoryId = Guid.NewGuid();
		var spicesSubCategoryId = Guid.NewGuid();

		var sugarsSubCategoryId = Guid.NewGuid();
		var bakingIngredientsSubCategoryId = Guid.NewGuid();

		modelBuilder.Entity<FoodSubCategory>().HasData(
			new { Id = citrusFruitsSubCategoryId, Name = "Citrus Fruits", CategoryId = fruitCategoryId },
			new { Id = berriesSubCategoryId, Name = "Berries", CategoryId = fruitCategoryId },
			new { Id = stoneFruitsSubCategoryId, Name = "Stone Fruits", CategoryId = fruitCategoryId },
			new { Id = tropicalFruitsSubCategoryId, Name = "Tropical Fruits", CategoryId = fruitCategoryId },
			new { Id = pomeFruitsSubCategoryId, Name = "Pome Fruits", CategoryId = fruitCategoryId },
			new { Id = melonsSubCategoryId, Name = "Melons", CategoryId = fruitCategoryId },
			new { Id = driedFruitsSubCategoryId, Name = "Dried Fruits", CategoryId = fruitCategoryId },
			new { Id = leafyGreensSubCategoryId, Name = "Leafy Greens", CategoryId = vegetableCategoryId },
			new { Id = cruciferousVegetablesSubCategoryId, Name = "Cruciferous Vegetables", CategoryId = vegetableCategoryId },
			new { Id = rootVegetablesSubCategoryId, Name = "Root Vegetables", CategoryId = vegetableCategoryId },
			new { Id = alliumVegetablesSubCategoryId, Name = "Allium Vegetables", CategoryId = vegetableCategoryId },
			new { Id = squashVegetablesSubCategoryId, Name = "Squash Vegetables", CategoryId = vegetableCategoryId },
			new { Id = nightshadesSubCategoryId, Name = "Nightshades", CategoryId = vegetableCategoryId },
			new { Id = beefSubCategoryId, Name = "Beef", CategoryId = meatCategoryId },
			new { Id = porkSubCategoryId, Name = "Pork", CategoryId = meatCategoryId },
			new { Id = poultrySubCategoryId, Name = "Poultry", CategoryId = meatCategoryId },
			new { Id = fishSubCategoryId, Name = "Fish", CategoryId = meatCategoryId },
			new { Id = shellfishSubCategoryId, Name = "Shellfish", CategoryId = meatCategoryId },
			new { Id = cheeseSubCategoryId, Name = "Cheese", CategoryId = dairyCategoryId },
			new { Id = milkSubCategoryId, Name = "Milk", CategoryId = dairyCategoryId },
			new { Id = otherDairySubCategoryId, Name = "Other Dairy", CategoryId = dairyCategoryId },
			new { Id = riceSubCategoryId, Name = "Rice", CategoryId = grainCategoryId },
			new { Id = otherGrainsSubCategoryId, Name = "Other Grains", CategoryId = grainCategoryId },
			new { Id = pastaSubCategoryId, Name = "Pasta", CategoryId = grainCategoryId },
			new { Id = legumesSubCategoryId, Name = "Legumes", CategoryId = grainCategoryId },
			new { Id = nutsSubCategoryId, Name = "Nuts", CategoryId = nutCategoryId },
			new { Id = seedsSubCategoryId, Name = "Seeds", CategoryId = nutCategoryId },
			new { Id = oilsSubCategoryId, Name = "Oils", CategoryId = oilCategoryId },
			new { Id = herbsSubCategoryId, Name = "Herbs", CategoryId = herbCategoryId },
			new { Id = spicesSubCategoryId, Name = "Spices", CategoryId = herbCategoryId },
			new { Id = sugarsSubCategoryId, Name = "Sugars", CategoryId = bakingCategoryId },
			new { Id = bakingIngredientsSubCategoryId, Name = "Baking Ingredients", CategoryId = bakingCategoryId }
		);
		
		modelBuilder.Entity<Product>().HasData(
		    new { Id = Guid.NewGuid(), Caption = "Oranges", SubCategoryId = citrusFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Lemons", SubCategoryId = citrusFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Limes", SubCategoryId = citrusFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Grapefruits", SubCategoryId = citrusFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Tangerines", SubCategoryId = citrusFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Clementines", SubCategoryId = citrusFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Strawberries", SubCategoryId = berriesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Blueberries", SubCategoryId = berriesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Raspberries", SubCategoryId = berriesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Blackberries", SubCategoryId = berriesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cranberries", SubCategoryId = berriesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Peaches", SubCategoryId = stoneFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Plums", SubCategoryId = stoneFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cherries", SubCategoryId = stoneFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Apricots", SubCategoryId = stoneFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Nectarines", SubCategoryId = stoneFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Bananas", SubCategoryId = tropicalFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Pineapples", SubCategoryId = tropicalFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Mangoes", SubCategoryId = tropicalFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Papayas", SubCategoryId = tropicalFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Passion Fruit", SubCategoryId = tropicalFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Guavas", SubCategoryId = tropicalFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Apples", SubCategoryId = pomeFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Pears", SubCategoryId = pomeFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Quinces", SubCategoryId = pomeFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Watermelons", SubCategoryId = melonsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cantaloupes", SubCategoryId = melonsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Honeydews", SubCategoryId = melonsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Raisins", SubCategoryId = driedFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Dates", SubCategoryId = driedFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Dried Apricots", SubCategoryId = driedFruitsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Lettuce", SubCategoryId = leafyGreensSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Spinach", SubCategoryId = leafyGreensSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Kale", SubCategoryId = leafyGreensSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Swiss Chard", SubCategoryId = leafyGreensSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Arugula", SubCategoryId = leafyGreensSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Broccoli", SubCategoryId = cruciferousVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cauliflower", SubCategoryId = cruciferousVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cabbage", SubCategoryId = cruciferousVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Brussels Sprouts", SubCategoryId = cruciferousVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Bok Choy", SubCategoryId = cruciferousVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Carrots", SubCategoryId = rootVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Beets", SubCategoryId = rootVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Turnips", SubCategoryId = rootVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Radishes", SubCategoryId = rootVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Parsnips", SubCategoryId = rootVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Onions", SubCategoryId = alliumVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Garlic", SubCategoryId = alliumVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Leeks", SubCategoryId = alliumVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Shallots", SubCategoryId = alliumVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Green Onions", SubCategoryId = alliumVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Zucchini", SubCategoryId = squashVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Yellow Squash", SubCategoryId = squashVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Pumpkin", SubCategoryId = squashVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Butternut Squash", SubCategoryId = squashVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Acorn Squash", SubCategoryId = squashVegetablesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Tomatoes", SubCategoryId = nightshadesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cherry Tomatoes", SubCategoryId = nightshadesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Grape Tomatoes", SubCategoryId = nightshadesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Eggplants", SubCategoryId = nightshadesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Bell Peppers", SubCategoryId = nightshadesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Chili Peppers", SubCategoryId = nightshadesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Jalapenos", SubCategoryId = nightshadesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Habaneros", SubCategoryId = nightshadesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Serrano Peppers", SubCategoryId = nightshadesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Ground Beef", SubCategoryId = beefSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Steaks", SubCategoryId = beefSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Roasts", SubCategoryId = beefSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Pork Chops", SubCategoryId = porkSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Pork Loins", SubCategoryId = porkSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Ground Pork", SubCategoryId = porkSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Bacon", SubCategoryId = porkSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Ham", SubCategoryId = porkSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Chicken Breasts", SubCategoryId = poultrySubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Chicken Thighs", SubCategoryId = poultrySubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Chicken Wings", SubCategoryId = poultrySubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Ground Chicken", SubCategoryId = poultrySubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Salmon", SubCategoryId = fishSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Tuna", SubCategoryId = fishSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cod", SubCategoryId = fishSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Haddock", SubCategoryId = fishSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Shrimp", SubCategoryId = shellfishSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Crab", SubCategoryId = shellfishSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Lobster", SubCategoryId = shellfishSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Scallops", SubCategoryId = shellfishSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cheddar", SubCategoryId = cheeseSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Mozzarella", SubCategoryId = cheeseSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Swiss", SubCategoryId = cheeseSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Parmesan", SubCategoryId = cheeseSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Feta", SubCategoryId = cheeseSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Goat Cheese", SubCategoryId = cheeseSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cottage Cheese", SubCategoryId = cheeseSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Ricotta", SubCategoryId = cheeseSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cream Cheese", SubCategoryId = cheeseSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Brie", SubCategoryId = cheeseSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Whole Milk", SubCategoryId = milkSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Low-Fat Milk", SubCategoryId = milkSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Skim Milk", SubCategoryId = milkSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Greek Yogurt", SubCategoryId = otherDairySubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Salted Butter", SubCategoryId = otherDairySubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Unsalted Butter", SubCategoryId = otherDairySubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Heavy Cream", SubCategoryId = otherDairySubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Sour Cream", SubCategoryId = otherDairySubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "White Rice", SubCategoryId = riceSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Brown Rice", SubCategoryId = riceSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Basmati Rice", SubCategoryId = riceSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Jasmine Rice", SubCategoryId = riceSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Arborio Rice", SubCategoryId = riceSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Quinoa", SubCategoryId = otherGrainsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Barley", SubCategoryId = otherGrainsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Millet", SubCategoryId = otherGrainsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Buckwheat", SubCategoryId = otherGrainsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Rye", SubCategoryId = otherGrainsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cornmeal", SubCategoryId = otherGrainsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Polenta", SubCategoryId = otherGrainsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Spaghetti", SubCategoryId = pastaSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Penne", SubCategoryId = pastaSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Fusilli", SubCategoryId = pastaSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Macaroni", SubCategoryId = pastaSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Lasagna Sheets", SubCategoryId = pastaSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Rice Noodles", SubCategoryId = pastaSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Soba Noodles", SubCategoryId = pastaSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Egg Noodles", SubCategoryId = pastaSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Black Beans", SubCategoryId = legumesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Kidney Beans", SubCategoryId = legumesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Pinto Beans", SubCategoryId = legumesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Chickpeas", SubCategoryId = legumesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Lentils", SubCategoryId = legumesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Almonds", SubCategoryId = nutsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Walnuts", SubCategoryId = nutsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Pecans", SubCategoryId = nutsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cashews", SubCategoryId = nutsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Pistachios", SubCategoryId = nutsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Macadamia Nuts", SubCategoryId = nutsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Peanuts", SubCategoryId = nutsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Sunflower Seeds", SubCategoryId = seedsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Pumpkin Seeds", SubCategoryId = seedsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Chia Seeds", SubCategoryId = seedsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Flaxseeds", SubCategoryId = seedsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Olive Oil", SubCategoryId = oilsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Vegetable Oil", SubCategoryId = oilsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Canola Oil", SubCategoryId = oilsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Sunflower Oil", SubCategoryId = oilsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Coconut Oil", SubCategoryId = oilsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Avocado Oil", SubCategoryId = oilsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Sesame Oil", SubCategoryId = oilsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Basil", SubCategoryId = herbsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Oregano", SubCategoryId = herbsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Thyme", SubCategoryId = herbsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Rosemary", SubCategoryId = herbsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Parsley", SubCategoryId = herbsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cilantro", SubCategoryId = herbsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Dill", SubCategoryId = herbsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Mint", SubCategoryId = herbsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Black Pepper", SubCategoryId = spicesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Paprika", SubCategoryId = spicesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Chili Powder", SubCategoryId = spicesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cumin", SubCategoryId = spicesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Coriander", SubCategoryId = spicesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Turmeric", SubCategoryId = spicesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Cinnamon", SubCategoryId = spicesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Ginger", SubCategoryId = spicesSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Granulated Sugar", SubCategoryId = sugarsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Brown Sugar", SubCategoryId = sugarsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Honey", SubCategoryId = sugarsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Maple Syrup", SubCategoryId = sugarsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Salt", SubCategoryId = bakingIngredientsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Baking Powder", SubCategoryId = bakingIngredientsSubCategoryId, IsDeleted = false },
		    new { Id = Guid.NewGuid(), Caption = "Baking Soda", SubCategoryId = bakingIngredientsSubCategoryId, IsDeleted = false }
		);
	}

	private static void SeedKitchenEquipment(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<KitchenEquipment>().HasData(
			new { Id = Guid.NewGuid(), Name = "Blender" },
			new { Id = Guid.NewGuid(), Name = "Oven" },
			new { Id = Guid.NewGuid(), Name = "Microwave" },
			new { Id = Guid.NewGuid(), Name = "Air Fryer" },
			new { Id = Guid.NewGuid(), Name = "Food Processor" },
			new { Id = Guid.NewGuid(), Name = "Grill" },
			new { Id = Guid.NewGuid(), Name = "Stove" },
			new { Id = Guid.NewGuid(), Name = "Slow Cooker" },
			new { Id = Guid.NewGuid(), Name = "Pressure Cooker" },
			new { Id = Guid.NewGuid(), Name = "Toaster" },
			new { Id = Guid.NewGuid(), Name = "Rice Cooker" },
			new { Id = Guid.NewGuid(), Name = "Mixer" }
		);
	}

	private static void SeedAllergies(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Allergy>().HasData(
			new { Id = Guid.NewGuid(), Name = "Gluten" },
			new { Id = Guid.NewGuid(), Name = "Dairy" },
			new { Id = Guid.NewGuid(), Name = "Peanuts" },
			new { Id = Guid.NewGuid(), Name = "Tree Nuts" },
			new { Id = Guid.NewGuid(), Name = "Eggs" },
			new { Id = Guid.NewGuid(), Name = "Shellfish" },
			new { Id = Guid.NewGuid(), Name = "Fish" },
			new { Id = Guid.NewGuid(), Name = "Soy" },
			new { Id = Guid.NewGuid(), Name = "Wheat" },
			new { Id = Guid.NewGuid(), Name = "Sesame" }
		);
	}

	public override int SaveChanges()
	{
		OnBeforeSaving();
		return base.SaveChanges();
	}

	public override int SaveChanges(bool acceptAllChangesOnSuccess)
	{
		OnBeforeSaving();
		return base.SaveChanges(acceptAllChangesOnSuccess);
	}

	public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
	{
		OnBeforeSaving();
		return base.SaveChangesAsync(cancellationToken);
	}

	public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
		CancellationToken cancellationToken = new())
	{
		OnBeforeSaving();
		return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
	}

	private void OnBeforeSaving()
	{
		var entries = ChangeTracker.Entries();
		foreach (var entry in entries)
		{
			var utcNow = DateTime.UtcNow;
			if (entry.Entity is Entity trackable)
				switch (entry.State)
				{
					case EntityState.Modified:
						trackable.ModifiedDate = utcNow;
						break;
					case EntityState.Added:
						trackable.CreatedDate = utcNow;
						break;
					case EntityState.Deleted:
						entry.State = EntityState.Modified;
						trackable.IsDeleted = true;
						trackable.DeletedDate = utcNow;
						break;
				}
		}
	}
}