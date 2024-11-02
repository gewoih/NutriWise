import {Ingredient} from "./Ingredient.ts";

export interface Meal {
    id: string,
    name: string,
    ingredients: Ingredient[]
}