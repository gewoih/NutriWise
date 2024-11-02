<script setup lang="ts">
import {ref, onMounted} from 'vue';
import {userProfileService} from "../services/userProfileService.ts";
import {UserProfile} from "../models/UserProfile.ts";
import * as jsonpatch from 'fast-json-patch';
import { format } from 'date-fns';

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

const originalProfile = ref<UserProfile>();

const gendersList = ref([]);
const activityLevelsList = ref([]);
const dietGoalsList = ref([]);
const allergiesList = ref([]);
const kitchenEquipmentsList = ref([]);

const loadSelectableFields = async () => {
  try {
    const response = await userProfileService.getSelectableFields();
    console.log(response);
    gendersList.value = response.genders.map((gender: string, index: number) => ({label: gender, value: index}));
    activityLevelsList.value = response.activityLevels.map((level: string, index: number) => ({
      label: level,
      value: index
    }));
    dietGoalsList.value = response.dietGoalTypes.map((goal: string, index: number) => ({label: goal, value: index}));
    allergiesList.value = response.allergies.map((allergy: any) => ({label: allergy.caption, value: allergy.id}));
    kitchenEquipmentsList.value = response.kitchenEquipment.map((equipment: any) => ({
      label: equipment.caption,
      value: equipment.id
    }));
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
    const formattedUserProfile = {
      ...userProfile.value,
      birthdayDate: format(new Date(userProfile.value.birthdayDate), 'yyyy-MM-dd'),
    };
    
    const patchDocument = jsonpatch.compare(originalProfile.value as UserProfile, formattedUserProfile);

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
      <Card class="shadow-3">
        <template #title><h2>Редактирование профиля</h2></template>
        <template #content>
          <div class="flex justify-content-around align-content-start gap-3 mb-3">
            <div class="w-5">
              <!-- Weight -->
              <div class="flex justify-content-between align-items-center mb-4">
                <label class="font-semibold w-3" for="weight">Вес (кг)</label>
                <InputNumber class="w-9" id="weight" v-model="userProfile.weight" :min="30" :max="300" mode="decimal"
                             :step="0.01"/>
              </div>

              <!-- Height -->
              <div class="flex justify-content-between align-items-center mb-4">
                <label class="font-semibold w-3" for="height">Рост (см)</label>
                <InputNumber class="w-9" id="height" v-model="userProfile.height" :min="50" :max="250" mode="decimal"
                             :step="0.1"/>
              </div>

              <!-- Birthday Date -->
              <div class="flex justify-content-between align-items-center">
                <label class="font-semibold w-3" for="birthday">Дата рождения</label>
                <DatePicker class="w-9" id="birthday" v-model="userProfile.birthdayDate" dateFormat="yy-mm-dd"
                            :showTime="false" showIcon/>
              </div>
            </div>
            <div class="w-5">
              <!-- Gender -->
              <div class="flex justify-content-between align-items-center mb-4">
                <label class="font-semibold w-3" for="gender">Пол</label>
                <Select class="w-9" id="gender" v-model="userProfile.gender" :options="gendersList" optionLabel="label"
                        optionValue="value" placeholder="Выберите пол"/>
              </div>

              <!-- Activity Level -->
              <div class="flex justify-content-between align-items-center mb-4">
                <label class="font-semibold w-3" for="activityLevel">Уровень активности</label>
                <Select class="w-9" id="activityLevel" v-model="userProfile.activityLevel" :options="activityLevelsList"
                        optionLabel="label" optionValue="value" placeholder="Выберите уровень активности"/>
              </div>

              <!-- Diet Goal -->
              <div class="flex justify-content-between align-items-center mb-4">
                <label class="font-semibold w-3" for="dietGoalType">Цель диеты</label>
                <Select class="w-9" id="dietGoalType" v-model="userProfile.dietGoalType" :options="dietGoalsList"
                        optionLabel="label" optionValue="value" placeholder="Выберите цель диеты"
                />
              </div>
              <!-- Allergies -->
              <div class="flex justify-content-between align-items-center mb-4">
                <label class="font-semibold w-3" for="allergies">Аллергии</label>
                <MultiSelect class="w-9" id="allergies" :maxSelectedLabels="3" display="chip"
                             v-model="userProfile.allergies"
                             :options="allergiesList"
                             optionLabel="label" optionValue="value" placeholder="Выберите аллергии"
                />
              </div>
              <!-- Kitchen Equipment -->
              <div class="flex justify-content-between align-items-center">
                <label class="font-semibold w-6rem" for="kitchenEquipment">Кухонное оборудование</label>
                <MultiSelect class="w-9" id="kitchenEquipment" :maxSelectedLabels="3" display="chip"
                             v-model="userProfile.kitchenEquipment" :options="kitchenEquipmentsList"
                             optionLabel="label" optionValue="value" placeholder="Выберите кухонное оборудование"
                />
              </div>
              <div class="flex justify-content-end align-items-center pt-5">
                <Button label="Обновить профиль" type="submit" @click="updateProfile"/>
              </div>
            </div>
          </div>
        </template>
      </Card>
    </div>
  </div>
</template>
