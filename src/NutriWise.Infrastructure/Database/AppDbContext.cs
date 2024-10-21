using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NutriWise.Domain.Entities.Base;
using NutriWise.Domain.Entities.Identity;
using NutriWise.Domain.Entities.Product;
using NutriWise.Domain.Entities.Recipe;
using NutriWise.Domain.Entities.UserProfile;

namespace NutriWise.Infrastructure.Database;

public sealed class AppDbContext : IdentityDbContext<User, Role, Guid>
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}
	
	public DbSet<UserProfile> UserProfiles { get; set; }
	public DbSet<Allergy> Allergies { get; set; }
	public DbSet<KitchenEquipment> KitchenEquipments { get; set; }
	public DbSet<FoodCategory> FoodCategories { get; set; }
	public DbSet<FoodSubCategory> FoodSubCategories { get; set; }
	public DbSet<Product> Products { get; set; }
	public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
	public DbSet<FoodRecipe> Recipes { get; set; }
    
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
			new FoodCategory { Id = fruitCategoryId, Name = "Fruits" },
			new FoodCategory { Id = vegetableCategoryId, Name = "Vegetables" },
			new FoodCategory { Id = meatCategoryId, Name = "Meats" },
			new FoodCategory { Id = dairyCategoryId, Name = "Dairy" },
			new FoodCategory { Id = grainCategoryId, Name = "Grains and Legumes" },
			new FoodCategory { Id = nutCategoryId, Name = "Nuts and Seeds" },
			new FoodCategory { Id = oilCategoryId, Name = "Oils and Fats" },
			new FoodCategory { Id = herbCategoryId, Name = "Herbs and Spices" },
			new FoodCategory { Id = bakingCategoryId, Name = "Baking Ingredients" }
		);

		modelBuilder.Entity<FoodSubCategory>().HasData(
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Citrus Fruits", CategoryId = fruitCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Berries", CategoryId = fruitCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Stone Fruits", CategoryId = fruitCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Tropical Fruits", CategoryId = fruitCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Pome Fruits", CategoryId = fruitCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Melons", CategoryId = fruitCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Dried Fruits", CategoryId = fruitCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Leafy Greens", CategoryId = vegetableCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Cruciferous Vegetables", CategoryId = vegetableCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Root Vegetables", CategoryId = vegetableCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Allium Vegetables", CategoryId = vegetableCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Squash Vegetables", CategoryId = vegetableCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Nightshades", CategoryId = vegetableCategoryId },

			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Beef", CategoryId = meatCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Pork", CategoryId = meatCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Poultry", CategoryId = meatCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Fish", CategoryId = meatCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Shellfish", CategoryId = meatCategoryId },

			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Cheese", CategoryId = dairyCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Milk", CategoryId = dairyCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Other Dairy", CategoryId = dairyCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Rice", CategoryId = grainCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Other Grains", CategoryId = grainCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Pasta", CategoryId = grainCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Legumes", CategoryId = grainCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Nuts", CategoryId = nutCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Seeds", CategoryId = nutCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Oils", CategoryId = oilCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Herbs", CategoryId = herbCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Spices", CategoryId = herbCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Sugars", CategoryId = bakingCategoryId },
			new FoodSubCategory { Id = Guid.NewGuid(), Name = "Baking Ingredients", CategoryId = bakingCategoryId }
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