import { apiService } from './api.ts'
import { AxiosResponse } from 'axios';
import { UserProfile } from "../models/UserProfile.ts";

class UserProfileService {
    async getUserProfile(): Promise<UserProfile | null> {
        try {
            const response: AxiosResponse<UserProfile> = await apiService.axiosInstance.get('/user-profile');
            return response.data;
        } catch (error) {
            console.error('Error fetching user profile', error);
            return null;
        }
    }

    async createUserProfile(userProfile: UserProfile): Promise<UserProfile | null> {
        try {
            const response: AxiosResponse<UserProfile> = await apiService.axiosInstance.post('/user-profile', userProfile);
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

    async getSelectableFields() {
        const response = await apiService.axiosInstance.get('/user-profile/selectable-fields');
        return response.data;
    }
}

export const userProfileService = new UserProfileService();
