<template>
  <div class="meal-plan-page">
    <!-- Форма для генерации -->
    <Panel header="Generate Meal Plan">
      <div class="p-grid p-justify-center">
        <div class="p-col-12 p-md-4">
          <InputNumber v-model="daysCount" :min="1" :max="30" placeholder="Days count" />
        </div>
        <div class="p-col-12 p-md-4">
          <Button label="Generate" icon="pi pi-refresh" class="p-button-success" @click="generateMealPlan" />
        </div>
      </div>
    </Panel>

    <!-- Отображение сгенерированного плана -->
    <Panel header="Generated Meal Plan" v-if="mealPlan">
      <Accordion v-for="(dailyMeal, index) in mealPlan.dailyMeals" :key="index">
        <AccordionTab :header="'Day ' + (index + 1)">
          <div v-for="meal in dailyMeal.meals" :key="meal.id" class="meal-details">
            <h4>Meal</h4>
            <p><b>Instructions:</b> {{ meal.cookingInstructions }}</p>
            <h5>Ingredients:</h5>
            <ul>
              <li v-for="ingredient in meal.ingredients" :key="ingredient.id">
                {{ ingredient.amount }} {{ ingredient.measurmentType }} of Product ID: {{ ingredient.productId }}
              </li>
            </ul>
          </div>
        </AccordionTab>
      </Accordion>
    </Panel>

    <!-- История предыдущих Meal Plans -->
    <Panel header="Meal Plan History" v-if="mealPlanHistory.length">
      <DataTable :value="mealPlanHistory">
        <Column field="date" header="Generated Date" />
        <Column header="Details">
          <template #body="slotProps">
            <Button label="View Plan" @click="viewPlan(slotProps.rowData)" />
          </template>
        </Column>
      </DataTable>
    </Panel>
  </div>
</template>

<script setup>
import { ref, onMounted } from 'vue';
import { InputNumber } from 'primevue/inputnumber';
import { Button } from 'primevue/button';
import { Panel } from 'primevue/panel';
import { Accordion, AccordionTab } from 'primevue/accordion';
import { DataTable, Column } from 'primevue/datatable';
import { useMealPlanStore } from '@/stores/mealPlanStore';

const mealPlanStore = useMealPlanStore();
const daysCount = ref(1);
const mealPlan = ref(null);
const mealPlanHistory = ref([]);

const generateMealPlan = async () => {
  mealPlan.value = await mealPlanStore.generatePlan({ daysCount: daysCount.value });
};

const loadMealPlanHistory = async () => {
  mealPlanHistory.value = await mealPlanStore.getMealPlanHistory();
};

onMounted(() => {
  loadMealPlanHistory();
});

const viewPlan = (plan) => {
  mealPlan.value = plan;
};
</script>

<style scoped>
.meal-details {
  margin-top: 1rem;
}
</style>
