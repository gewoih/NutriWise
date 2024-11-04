export interface UserProfile {
    height: number | null;
    weight: number | null;
    activityLevel: number | null;
    dietGoalType: number | null;
    allergies: string[];
    kitchenEquipment: string[];
    products: string[];
}