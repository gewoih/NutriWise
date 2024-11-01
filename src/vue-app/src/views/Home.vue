<script setup lang="ts">
import {DailyMeal} from "../models/meal/DailyMeal.ts";
import {onMounted, ref} from "vue";
import {mealPlanService} from "../services/mealService.ts";

const userDailyMeals = ref<DailyMeal[]>([]);

onMounted(async () => {
  await loadDailyMeals();
});

const loadDailyMeals = async () => {
  userDailyMeals.value = await mealPlanService.getDailyMeals();
};

</script>

<template>
  <div class="card">
    <DataView :value="userDailyMeals" data-key="id">
      <template #list="slotProps">
        <div v-for="(item, index) in slotProps.items" :key="index">
          <div>{{ item.id }}</div>
          <Button icon="pi pi-shopping-cart">Открыть</Button>
        </div>
      </template>
    </DataView>
  </div>
</template>