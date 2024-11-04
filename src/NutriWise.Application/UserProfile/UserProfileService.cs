using Microsoft.EntityFrameworkCore;
using NutriWise.Application.Extensions;
using NutriWise.Domain.Entities.UserProfile;
using NutriWise.Domain.ValueObjects;
using NutriWise.Infrastructure.Database;

namespace NutriWise.Application.UserProfiles;

public sealed class UserProfileService : IUserProfileService
{
    private readonly AppDbContext _context;

    public UserProfileService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<UserProfileDto?> GetAsync(Guid userId)
    {
        var userProfile = await _context.UserProfiles
            .Where(userProfile => userProfile.UserId == userId)
            .Include(userProfile => userProfile.Allergies)
            .Include(userProfile => userProfile.KitchenEquipments)
            .Include(userProfile => userProfile.Products)
            .FirstOrDefaultAsync();

        return userProfile?.ToDto();
    }

    public async Task<UserProfile?> CreateAsync(Guid userId, UserProfileDto userProfileDto)
    {
        var isUserProfileExists = await _context.UserProfiles.AnyAsync(userProfile => userProfile.UserId == userId);
        if (isUserProfileExists)
            return null;

        var allergies = await _context.Allergies
            .Where(allergy => userProfileDto.Allergies.Contains(allergy.Id))
            .ToListAsync();

        var kitchenEquipment = await _context.KitchenEquipments
            .Where(equipment => userProfileDto.KitchenEquipment.Contains(equipment.Id))
            .ToListAsync();

        var userProfile = new UserProfile
        {
            UserId = userId,
            ActivityLevel = userProfileDto.ActivityLevel,
            BirthdayDate = userProfileDto.BirthdayDate,
            Gender = userProfileDto.Gender,
            Height = userProfileDto.Height,
            Weight = userProfileDto.Weight,
            DietGoalType = userProfileDto.DietGoalType,
            Allergies = allergies,
            KitchenEquipments = kitchenEquipment
        };

        await _context.UserProfiles.AddAsync(userProfile);
        await _context.SaveChangesAsync();

        return userProfile;
    }

    public async Task<UserProfile?> UpdateAsync(Guid userId, UserProfileDto userProfileDto)
    {
        var userProfile = await _context.UserProfiles
            .Include(userProfile => userProfile.Allergies)
            .Include(userProfile => userProfile.KitchenEquipments)
            .Include(userProfile => userProfile.Products)
            .FirstOrDefaultAsync(userProfile => userProfile.UserId == userId);

        if (userProfile is null)
            return null;

        var allergies = await _context.Allergies
            .Where(allergy => userProfileDto.Allergies.Contains(allergy.Id))
            .ToListAsync();

        var kitchenEquipment = await _context.KitchenEquipments
            .Where(equipment => userProfileDto.KitchenEquipment.Contains(equipment.Id))
            .ToListAsync();

        var products = await _context.Products
            .Where(product => userProfileDto.Products.Contains(product.Id))
            .ToListAsync();

        userProfile.Gender = userProfileDto.Gender;
        userProfile.BirthdayDate = userProfileDto.BirthdayDate;
        userProfile.ActivityLevel = userProfileDto.ActivityLevel;
        userProfile.DietGoalType = userProfileDto.DietGoalType;
        userProfile.Height = userProfileDto.Height;
        userProfile.Weight = userProfileDto.Weight;
        userProfile.Allergies = allergies;
        userProfile.KitchenEquipments = kitchenEquipment;
        userProfile.Products = products;

        await _context.SaveChangesAsync();
        return userProfile;
    }

    public async Task<SelectableFieldsInfo> GetSelectableFieldsAsync()
    {
        var allergies = await _context.Allergies.ToListAsync();
        var kitchenEquipment = await _context.KitchenEquipments.ToListAsync();
        var productCategories = await _context.FoodCategories
            .Include(foodCategory => foodCategory.SubCategories)
            .ThenInclude(subCategory => subCategory.Products)
            .Select(foodCategory => new ProductCategoryDto
            {
                Id = foodCategory.Id,
                Name = foodCategory.Caption,
                SubCategories = foodCategory.SubCategories.Select(subCategory => new ProductSubCategoryDto
                {
                    Id = subCategory.Id,
                    Name = subCategory.Caption,
                    Products = subCategory.Products.Select(product => new ProductDto
                    {
                        Id = product.Id,
                        Name = product.Caption,
                    })
                })
            }).ToListAsync();

        var genders = Enum.GetValues<Gender>()
            .Select(g => g.ToString())
            .ToList();

        var activityLevels = Enum.GetValues<ActivityLevel>()
            .Select(al => al.ToString())
            .ToList();

        var dietGoalTypes = Enum.GetValues<DietGoalType>()
            .Select(dg => dg.ToString())
            .ToList();

        return new SelectableFieldsInfo
        {
            Allergies = allergies,
            KitchenEquipment = kitchenEquipment,
            Genders = genders,
            ActivityLevels = activityLevels,
            DietGoalTypes = dietGoalTypes,
            ProductCategories = productCategories
        };
    }
}