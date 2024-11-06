export interface MealPlan {
    id: string,
    name: string,
    mealNames: string[],
    calories: number,
    proteins: number,
    fats: number,
    carbs: number
}