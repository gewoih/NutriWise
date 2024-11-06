<script setup lang="ts">
import {onMounted, ref} from "vue";
import {mealPlanService} from "../services/mealService.ts";
import {MealPlan} from "../models/meal/MealPlan.ts";

const userDailyMeals = ref<MealPlan[]>([]);

onMounted(async () => {
  await loadDailyMeals();
});

const loadDailyMeals = async () => {
  userDailyMeals.value = await mealPlanService.getMealPlans();
};

const createMealPlan = async () => {
  await mealPlanService.createMealPlan();
}

</script>

<template>
  <div class="p-4">
    <div class="flex justify-start mb-4">
      <Button @click="createMealPlan">Создать новый план питания</Button>
    </div>
    <DataView :value="userDailyMeals" data-key="id" layout="grid">
      <template #grid="slotProps">
        <div class="grid grid-cols-12 gap-4 p-4">
          <div v-for="(item, index) in slotProps.items" :key="index"
               class="col-span-12 p-2"
          >
            <div class="flex justify-center rounded p-2">
              <div class="relative mx-auto">
                <img
                    :src="`https://images.immediate.co.uk/production/volatile/sites/30/2020/08/chorizo-mozarella-gnocchi-bake-cropped-9ab73a3.jpg?quality=90&resize=556,505`"
                    :alt="item.name"
                    style="max-width: 200px"
                />
              </div>
            </div>
            <div class="pt-2">
              <div class="flex flex-row gap-2">
                <div>
                  <div class="text-lg mt-1">{{ item.name }} (КБЖУ: {{ item.calories }}/{{item.proteins}}/{{item.fats}}/{{item.carbs}})</div>
                </div>
              </div>
              <div>
                <ul>
                  <li v-for="(meal, mealIndex) in item.mealNames" :key="mealIndex">
                    {{ meal }}
                  </li>
                </ul>
              </div>
              <div>
                <Button label="Открыть"></Button>
              </div>
            </div>
          </div>
        </div>
      </template>
    </DataView>
  </div>
</template>