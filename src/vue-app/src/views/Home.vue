<script setup lang="ts">
import {DailyMeal} from "../models/meal/DailyMeal.ts";
import {onMounted, ref} from "vue";
import {mealPlanService} from "../services/mealService.ts";

const userDailyMeals = ref<DailyMeal[]>([]);

onMounted(async () => {
  await loadDailyMeals();
});

const loadDailyMeals = async () => {
  const dailyMeals = await mealPlanService.getDailyMeals();
  if (dailyMeals) {
    userDailyMeals.value = dailyMeals;
  } else {
    alert('Error loading user daily meals');
  }
};

</script>

<template>
  <div class="card">
    <DataView :value="userDailyMeals" data-key="id">
      <template #list="slotProps">
        <div class="flex flex-col">
          <div v-for="(item, index) in slotProps.items" :key="index">
            <div class="flex flex-col sm:flex-row sm:items-center p-6 gap-4">
              <div class="flex flex-col md:flex-row justify-between md:items-center flex-1 gap-6">
                <div class="flex flex-row md:flex-col justify-between items-start gap-2">
                  <div class="text-lg font-medium mt-2">{{ item.id }}</div>
                </div>
                <div class="flex flex-col md:items-end gap-8">
                  <div class="flex flex-row-reverse md:flex-row gap-2">
                    <Button icon="pi pi-shopping-cart" label="Open daily plan"
                            class="flex-auto md:flex-initial whitespace-nowrap"></Button>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </template>
    </DataView>
  </div>
</template>

<style scoped>

</style>