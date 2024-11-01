<script setup lang="ts">
import { ref, onMounted } from 'vue';
import { userProfileService } from "../services/userProfileService.ts";
import { UserProfile } from "../models/UserProfile.ts";
import * as jsonpatch from 'fast-json-patch';

const userProfile = ref<UserProfile>({
  gender: null,
  birthdayDate: null,
  height: null,
  weight: null,
  activityLevel: null,
  dietGoalType: null,
  allergies: [],
  kitchenEquipment: []
});

const originalProfile = ref({ ...userProfile.value });

const genders = ref([]);
const activityLevels = ref([]);
const dietGoals = ref([]);
const allergiesOptions = ref([]);
const kitchenEquipmentsOptions = ref([]);

const loadSelectableFields = async () => {
  try {
    const response = await userProfileService.getSelectableFields();
    genders.value = response.genders.map((gender: string, index: number) => ({ label: gender, value: index }));
    activityLevels.value = response.activityLevels.map((level: string, index: number) => ({ label: level, value: index }));
    dietGoals.value = response.dietGoalTypes.map((goal: string, index: number) => ({ label: goal, value: index }));
    allergiesOptions.value = response.allergies.map((allergy: any) => ({ label: allergy.name, value: allergy.id }));
    kitchenEquipmentsOptions.value = response.kitchenEquipment.map((equipment: any) => ({ label: equipment.name, value: equipment.id }));
  } catch (error) {
    console.error('Failed to load selectable fields', error);
  }
};

const loadUserProfile = async () => {
  try {
    const profile = await userProfileService.getUserProfile();
    if (profile) {
      userProfile.value = {
        gender: profile.gender,
        birthdayDate: profile.birthdayDate,
        height: profile.height,
        weight: profile.weight,
        activityLevel: profile.activityLevel,
        dietGoalType: profile.dietGoalType,
        allergies: profile.allergies,
        kitchenEquipment: profile.kitchenEquipment
      };

      originalProfile.value = JSON.parse(JSON.stringify(userProfile.value));
    }
  } catch (error) {
    console.error('Failed to load user profile', error);
  }
};

onMounted(async () => {
  await loadSelectableFields();
  await loadUserProfile();
});

const updateProfile = async () => {
  try {
    const patchDocument = jsonpatch.compare(originalProfile.value, userProfile.value);

    if (patchDocument.length > 0) {
      await userProfileService.updateUserProfile(patchDocument);
      alert('Profile updated successfully!');
    } else {
      alert('No changes to update');
    }
  } catch (error) {
    console.error('Failed to update profile', error);
    alert('Failed to update profile');
  }
};
</script>

<template>
  <div>
    <div>
      <h2>Edit Your Profile</h2>
      <form @submit.prevent="updateProfile">
        <!-- Gender -->
        <div>
          <label for="gender">Gender</label>
          <Select
              id="gender"
              v-model="userProfile.gender"
              :options="genders"
              optionLabel="label"
              optionValue="value"
              placeholder="Select Gender"
          />
        </div>

        <!-- Birthday Date -->
        <div>
          <label for="birthday">Birthday Date</label>
          <DatePicker
              id="birthday"
              v-model="userProfile.birthdayDate"
              dateFormat="yy-mm-dd"
              :showTime="false"
              showIcon
          />
        </div>

        <!-- Height -->
        <div>
          <label for="height">Height (cm)</label>
          <InputNumber
              id="height"
              v-model="userProfile.height"
              :min="50"
              :max="250"
              mode="decimal"
              :step="0.1"
          />
        </div>

        <!-- Weight -->
        <div>
          <label for="weight">Weight (kg)</label>
          <InputNumber
              id="weight"
              v-model="userProfile.weight"
              :min="30"
              :max="300"
              mode="decimal"
              :step="0.01"
          />
        </div>

        <!-- Activity Level -->
        <div>
          <label for="activityLevel">Activity Level</label>
          <Select
              id="activityLevel"
              v-model="userProfile.activityLevel"
              :options="activityLevels"
              optionLabel="label"
              optionValue="value"
              placeholder="Select Activity Level"
          />
        </div>

        <!-- Diet Goal -->
        <div>
          <label for="dietGoalType">Diet Goal</label>
          <Select
              id="dietGoalType"
              v-model="userProfile.dietGoalType"
              :options="dietGoals"
              optionLabel="label"
              optionValue="value"
              placeholder="Select Diet Goal"
          />
        </div>

        <!-- Allergies -->
        <div>
          <label for="allergies">Allergies</label>
          <MultiSelect
              id="allergies"
              v-model="userProfile.allergies"
              :options="allergiesOptions"
              optionLabel="label"
              optionValue="value"
              placeholder="Select Allergies"
          />
        </div>

        <!-- Kitchen Equipment -->
        <div>
          <label for="kitchenEquipment">Kitchen Equipment</label>
          <MultiSelect
              id="kitchenEquipment"
              v-model="userProfile.kitchenEquipment"
              :options="kitchenEquipmentsOptions"
              optionLabel="label"
              optionValue="value"
              placeholder="Select Equipment"
          />
        </div>

        <!-- Submit Button -->
        <div class="button-container">
          <Button
              label="Update Profile"
              type="submit"
          />
        </div>
      </form>
    </div>
  </div>
</template>
