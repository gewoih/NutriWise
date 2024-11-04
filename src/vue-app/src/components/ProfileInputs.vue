<script setup lang="ts">
import { UserProfile } from '../models/UserProfile';

const props = defineProps<{
  userProfile: UserProfile;
  activityLevelsList: Array<{ label: string; value: number }>;
  dietGoalsList: Array<{ label: string; value: number }>;
  allergiesList: Array<{ label: string; value: string }>;
  kitchenEquipmentsList: Array<{ label: string; value: string }>;
}>();

const emits = defineEmits(['updateProfile']);
</script>

<template>
  <div class="flex justify-content-around align-content-start gap-3 mb-3">
    <div class="w-5">
      <!-- Weight -->
      <div class="flex justify-content-between align-items-center mb-4">
        <label class="font-semibold w-3" for="weight">Вес (кг)</label>
        <InputNumber class="w-9" id="weight" v-model="props.userProfile.weight" :min="30" :max="300" mode="decimal"
                     :step="0.01"/>
      </div>

      <!-- Height -->
      <div class="flex justify-content-between align-items-center mb-4">
        <label class="font-semibold w-3" for="height">Рост (см)</label>
        <InputNumber class="w-9" id="height" v-model="props.userProfile.height" :min="50" :max="250" mode="decimal"
                     :step="0.1"/>
      </div>
    </div>

    <div class="w-5">
      <!-- Activity Level -->
      <div class="flex justify-content-between align-items-center mb-4">
        <label class="font-semibold w-3" for="activityLevel">Уровень активности</label>
        <Select class="w-9" id="activityLevel" v-model="props.userProfile.activityLevel" :options="props.activityLevelsList"
                optionLabel="label" optionValue="value" placeholder="Выберите уровень активности"/>
      </div>

      <!-- Diet Goal -->
      <div class="flex justify-content-between align-items-center mb-4">
        <label class="font-semibold w-3" for="dietGoalType">Цель диеты</label>
        <Select class="w-9" id="dietGoalType" v-model="props.userProfile.dietGoalType" :options="props.dietGoalsList"
                optionLabel="label" optionValue="value" placeholder="Выберите цель диеты"/>
      </div>

      <!-- Allergies -->
      <div class="flex justify-content-between align-items-center mb-4">
        <label class="font-semibold w-3" for="allergies">Аллергии</label>
        <MultiSelect class="w-9" id="allergies" :maxSelectedLabels="3" display="chip"
                     v-model="props.userProfile.allergies" :options="props.allergiesList"
                     optionLabel="label" optionValue="value" placeholder="Выберите аллергии"/>
      </div>

      <!-- Kitchen Equipment -->
      <div class="flex justify-content-between align-items-center">
        <label class="font-semibold w-6rem" for="kitchenEquipment">Кухонное оборудование</label>
        <MultiSelect class="w-9" id="kitchenEquipment" :maxSelectedLabels="3" display="chip"
                     v-model="props.userProfile.kitchenEquipment" :options="props.kitchenEquipmentsList"
                     optionLabel="label" optionValue="value" placeholder="Выберите кухонное оборудование"/>
      </div>

      <!-- Update Button -->
      <div class="flex justify-content-end align-items-center pt-5">
        <Button label="Обновить профиль" type="submit" @click="$emit('updateProfile')"/>
      </div>
    </div>
  </div>
</template>
