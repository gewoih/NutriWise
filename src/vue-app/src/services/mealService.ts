import {apiService} from './api.ts'
import {AxiosResponse} from "axios";
import {MealPlan} from "../models/meal/MealPlan.ts";

class MealPlanService {
    async getDailyMeals(): Promise<MealPlan[]> {
        try {
            const response: AxiosResponse<MealPlan[]> = await apiService.axiosInstance.get('/meal');
            return response.data;
        } catch (error) {
            console.error('Error fetching meals plan', error);
            return [];
        }
    }

    async createDailyMeals(): Promise<MealPlan | null> {
        try {
            const response: AxiosResponse<MealPlan> = await apiService.axiosInstance.post('/meal');
            return response.data;
        } catch (error) {
            console.error('Error creating meals plan', error);
            return null;
        }
    }
}

export const mealPlanService = new MealPlanService();