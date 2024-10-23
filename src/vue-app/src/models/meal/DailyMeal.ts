import {Meal} from "./Meal.ts";

export interface DailyMeal {
    id: string,
    meals: Meal[]
}