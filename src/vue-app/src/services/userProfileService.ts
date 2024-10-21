import { apiService } from './api.ts'
import { AxiosResponse } from 'axios';

export interface UserProfileDto {
    gender: string | null;
    birthdayDate: string | null;
    height: number | null;
    weight: number | null;
    activityLevel: string | null;
    dietGoalType: string | null;
    allergies: string[];
    kitchenEquipment: string[];
}

class UserProfileService {
    async getUserProfile(): Promise<UserProfileDto | null> {
        try {
            const response: AxiosResponse<UserProfileDto> = await apiService.axiosInstance.get('/user-profile');
            return response.data;
        } catch (error) {
            console.error('Error fetching user profile', error);
            return null;
        }
    }

    async createUserProfile(userProfile: UserProfileDto): Promise<UserProfileDto | null> {
        try {
            const response: AxiosResponse<UserProfileDto> = await apiService.axiosInstance.post('/user-profile', userProfile);
            return response.data;
        } catch (error) {
            console.error('Error creating user profile', error);
            return null;
        }
    }

    async updateUserProfile(patchDocument: any): Promise<boolean> {
        try {
            await apiService.axiosInstance.patch('/user-profile', patchDocument, {
                headers: {
                    'Content-Type': 'application/json-patch+json'
                }
            });
            return true;
        } catch (error) {
            console.error('Error updating user profile', error);
            return false;
        }
    }
}

export const userProfileService = new UserProfileService();
