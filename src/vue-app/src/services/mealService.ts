import {apiService} from './api.ts'
import {AxiosResponse} from "axios";
import {DailyMeal} from "../models/meal/DailyMeal.ts";

class MealPlanService {
    async getDailyMeals(): Promise<DailyMeal[] | null> {
        try {
            const response: AxiosResponse<DailyMeal[]> = await apiService.axiosInstance.get('/meal');
            return response.data;
        } catch (error) {
            console.error('Error fetching meals plan', error);
            return null;
        }
    }

    async createDailyMeals(): Promise<DailyMeal | null> {
        try {
            const response: AxiosResponse<DailyMeal> = await apiService.axiosInstance.post('/meal');
            return response.data;
        } catch (error) {
            console.error('Error creating meals plan', error);
            return null;
        }
    }
}

export const mealPlanService = new MealPlanService();