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
  <div class="user-profile-container">
    <div class="form-card">
      <h2>Edit Your Profile</h2>
      <form @submit.prevent="updateProfile">
        <!-- Gender -->
        <div class="form-group">
          <label for="gender">Gender</label>
          <Select
              id="gender"
              v-model="userProfile.gender"
              :options="genders"
              optionLabel="label"
              optionValue="value"
              placeholder="Select Gender"
              class="form-input"
          />
        </div>

        <!-- Birthday Date -->
        <div class="form-group">
          <label for="birthday">Birthday Date</label>
          <DatePicker
              id="birthday"
              v-model="userProfile.birthdayDate"
              dateFormat="yy-mm-dd"
              :showTime="false"
              showIcon
              class="form-input"
          />
        </div>

        <!-- Height -->
        <div class="form-group">
          <label for="height">Height (cm)</label>
          <InputNumber
              id="height"
              v-model="userProfile.height"
              :min="50"
              :max="250"
              mode="decimal"
              :step="0.1"
              class="form-input"
          />
        </div>

        <!-- Weight -->
        <div class="form-group">
          <label for="weight">Weight (kg)</label>
          <InputNumber
              id="weight"
              v-model="userProfile.weight"
              :min="30"
              :max="300"
              mode="decimal"
              :step="0.01"
              class="form-input"
          />
        </div>

        <!-- Activity Level -->
        <div class="form-group">
          <label for="activityLevel">Activity Level</label>
          <Select
              id="activityLevel"
              v-model="userProfile.activityLevel"
              :options="activityLevels"
              optionLabel="label"
              optionValue="value"
              placeholder="Select Activity Level"
              class="form-input"
          />
        </div>

        <!-- Diet Goal -->
        <div class="form-group">
          <label for="dietGoalType">Diet Goal</label>
          <Select
              id="dietGoalType"
              v-model="userProfile.dietGoalType"
              :options="dietGoals"
              optionLabel="label"
              optionValue="value"
              placeholder="Select Diet Goal"
              class="form-input"
          />
        </div>

        <!-- Allergies -->
        <div class="form-group">
          <label for="allergies">Allergies</label>
          <MultiSelect
              id="allergies"
              v-model="userProfile.allergies"
              :options="allergiesOptions"
              optionLabel="label"
              optionValue="value"
              placeholder="Select Allergies"
              class="form-input"
          />
        </div>

        <!-- Kitchen Equipment -->
        <div class="form-group">
          <label for="kitchenEquipment">Kitchen Equipment</label>
          <MultiSelect
              id="kitchenEquipment"
              v-model="userProfile.kitchenEquipment"
              :options="kitchenEquipmentsOptions"
              optionLabel="label"
              optionValue="value"
              placeholder="Select Equipment"
              class="form-input"
          />
        </div>

        <!-- Submit Button -->
        <div class="button-container">
          <Button
              label="Update Profile"
              type="submit"
              class="submit-button"
          />
        </div>
      </form>
    </div>
  </div>
</template>

<style scoped>
@import url('https://fonts.googleapis.com/css2?family=Roboto:wght@400;500;700&display=swap');

.user-profile-container {
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 40px 20px;
  background: linear-gradient(135deg, #f5f7fa, #c3cfe2);
  min-height: 100vh;
}

.form-card {
  background-color: #ffffff;
  padding: 30px 40px;
  border-radius: 12px;
  box-shadow: 0 8px 16px rgba(0, 0, 0, 0.1);
  width: 100%;
  max-width: 600px;
}

h2 {
  text-align: center;
  margin-bottom: 30px;
  font-size: 1.8rem;
  color: #333333;
  font-family: 'Roboto', sans-serif;
}

.form-group {
  margin-bottom: 20px;
}

.form-group label {
  display: block;
  margin-bottom: 8px;
  font-weight: 500;
  color: #555555;
  font-family: 'Roboto', sans-serif;
}

.form-input {
  width: 100%;
}

.Button {
  width: 100%;
}

.button-container {
  text-align: center;
  margin-top: 30px;
}

.submit-button {
  background-color: #007bff;
  color: #ffffff;
  border: none;
  padding: 12px 25px;
  border-radius: 6px;
  font-size: 1rem;
  cursor: pointer;
  transition: background-color 0.3s ease, transform 0.2s ease;
}

.submit-button:hover {
  background-color: #0056b3;
  transform: translateY(-2px);
}

.submit-button:disabled {
  background-color: #a0c5f1;
  cursor: not-allowed;
}

@media (max-width: 600px) {
  .form-card {
    padding: 20px;
  }

  h2 {
    font-size: 1.5rem;
  }

  .submit-button {
    padding: 10px 20px;
    font-size: 0.9rem;
  }
}
</style>
