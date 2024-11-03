export interface UserProfile {
    gender: number | null;
    birthdayDate: Date | null;
    height: number | null;
    weight: number | null;
    activityLevel: number | null;
    dietGoalType: number | null;
    allergies: string[];
    kitchenEquipment: string[];
    products: string[];
}