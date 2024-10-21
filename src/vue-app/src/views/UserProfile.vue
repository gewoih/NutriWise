<script setup lang="ts">
import { ref } from 'vue';
import { userProfileService } from "../services/userProfileService.ts";
import * as jsonpatch from 'fast-json-patch';
//import { Dropdown, InputNumber, Calendar, MultiSelect, Button } from 'primevue';

// Поля профиля
const userProfile = ref({
  gender: null,
  birthdayDate: null,
  height: null,
  weight: null,
  activityLevel: null,
  dietGoalType: null,
  allergies: [],
  kitchenEquipment: []
});

const originalProfile = JSON.parse(JSON.stringify(userProfile.value));

// Опции для выбора
const genders = [
  { label: 'Male', value: 'Male' },
  { label: 'Female', value: 'Female' }
];

const activityLevels = [
  { label: 'Sedentary', value: 'Sedentary' },
  { label: 'Active', value: 'Active' },
  { label: 'Very Active', value: 'VeryActive' }
];

const dietGoals = [
  { label: 'Weight Loss', value: 'WeightLoss' },
  { label: 'Muscle Gain', value: 'MuscleGain' },
  { label: 'Maintain', value: 'Maintain' }
];

const allergies = ref([
  { name: 'Peanuts', id: '1' },
  { name: 'Gluten', id: '2' },
  { name: 'Lactose', id: '3' }
]);

const kitchenEquipments = ref([
  { name: 'Oven', id: '1' },
  { name: 'Blender', id: '2' },
  { name: 'Microwave', id: '3' }
]);

// Функция для отправки профиля
const submitProfile = async () => {
  try {
    const patchDocument = jsonpatch.compare(originalProfile, userProfile.value);
    if (patchDocument.length > 0) {
      await userProfileService.updateUserProfile(patchDocument);
    }
    alert('Profile created successfully!');
  } catch (error) {
    console.error(error);
    alert('Failed to create profile');
  }
};
</script>

<template>
  <div class="user-profile-form">
    <h2>Fill in your profile</h2>
    <form @submit.prevent="submitProfile">
      <!-- Пол -->
      <div class="p-field">
        <label for="gender">Gender</label>
        <Dropdown id="gender" v-model="userProfile.gender" :options="genders" optionLabel="label" optionValue="value" placeholder="Select Gender" />
      </div>

      <!-- Дата рождения -->
      <div class="p-field">
        <label for="birthday">Birthday Date</label>
        <Calendar id="birthday" v-model="userProfile.birthdayDate" dateFormat="yy-mm-dd" showIcon />
      </div>

      <!-- Рост -->
      <div class="p-field">
        <label for="height">Height (cm)</label>
        <InputNumber id="height" v-model="userProfile.height" min="0" max="300" />
      </div>

      <!-- Вес -->
      <div class="p-field">
        <label for="weight">Weight (kg)</label>
        <InputNumber id="weight" v-model="userProfile.weight" min="0" max="300" />
      </div>

      <!-- Уровень активности -->
      <div class="p-field">
        <label for="activityLevel">Activity Level</label>
        <Dropdown id="activityLevel" v-model="userProfile.activityLevel" :options="activityLevels" optionLabel="label" optionValue="value" placeholder="Select Activity Level" />
      </div>

      <!-- Цель по питанию -->
      <div class="p-field">
        <label for="dietGoalType">Diet Goal</label>
        <Dropdown id="dietGoalType" v-model="userProfile.dietGoalType" :options="dietGoals" optionLabel="label" optionValue="value" placeholder="Select Diet Goal" />
      </div>

      <!-- Аллергии -->
      <div class="p-field">
        <label for="allergies">Allergies</label>
        <MultiSelect id="allergies" v-model="userProfile.allergies" :options="allergies" optionLabel="name" optionValue="id" placeholder="Select Allergies" />
      </div>

      <!-- Кухонное оборудование -->
      <div class="p-field">
        <label for="kitchenEquipment">Kitchen Equipment</label>
        <MultiSelect id="kitchenEquipment" v-model="userProfile.kitchenEquipment" :options="kitchenEquipments" optionLabel="name" optionValue="id" placeholder="Select Equipment" />
      </div>

      <!-- Кнопка для отправки -->
      <Button label="Submit Profile" type="submit" class="p-mt-2" />
    </form>
  </div>
</template>

<style scoped>
.user-profile-form {
  max-width: 600px;
  margin: 50px auto;
}

h2 {
  margin-bottom: 20px;
}

.p-field {
  margin-bottom: 20px;
}
</style>
