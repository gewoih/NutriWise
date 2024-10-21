﻿using Microsoft.EntityFrameworkCore;
using NutriWise.Domain.Entities.UserProfile;
using NutriWise.Infrastructure.Database;

namespace NutriWise.Application;

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
			.Select(userProfile => new UserProfileDto(userProfile.Gender, userProfile.BirthdayDate, userProfile.Height,
				userProfile.Weight, userProfile.ActivityLevel, userProfile.DietGoalType,
				userProfile.Allergies.Select(allergy => allergy.Id),
				userProfile.KitchenEquipments.Select(kitchenEquipment => kitchenEquipment.Id)))
			.FirstOrDefaultAsync();

		return userProfile;
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
		var userProfile = await _context.UserProfiles.FirstOrDefaultAsync(userProfile => userProfile.UserId == userId);
		if (userProfile is null)
			return null;

		var allergies = await _context.Allergies
			.Where(allergy => userProfileDto.Allergies.Contains(allergy.Id))
			.ToListAsync();

		var kitchenEquipment = await _context.KitchenEquipments
			.Where(equipment => userProfileDto.KitchenEquipment.Contains(equipment.Id))
			.ToListAsync();
		
		userProfile.Gender = userProfileDto.Gender;
		userProfile.BirthdayDate = userProfileDto.BirthdayDate;
		userProfile.ActivityLevel = userProfileDto.ActivityLevel;
		userProfile.DietGoalType = userProfileDto.DietGoalType;
		userProfile.Height = userProfileDto.Height;
		userProfile.Weight = userProfileDto.Weight;
		userProfile.Allergies = allergies;
		userProfile.KitchenEquipments = kitchenEquipment;

		await _context.SaveChangesAsync();
		return userProfile;
	}
}