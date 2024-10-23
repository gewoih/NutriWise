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