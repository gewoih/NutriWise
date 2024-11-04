import {ref, onMounted} from 'vue';
import { userProfileService } from '../services/userProfileService';
import { UserProfile } from '../models/UserProfile';
import { Category } from '../models/product/Category';
import { TreeNode } from 'primevue/treenode';

export function useUserProfile() {
    const userProfile = ref<UserProfile>({
        gender: null,
        birthdayDate: null,
        height: null,
        weight: null,
        activityLevel: null,
        dietGoalType: null,
        allergies: [],
        kitchenEquipment: [],
        products: [],
    });

    const originalProfile = ref<UserProfile>();
    const gendersList = ref([]);
    const activityLevelsList = ref([]);
    const dietGoalsList = ref([]);
    const allergiesList = ref([]);
    const kitchenEquipmentsList = ref([]);
    const productCategories = ref<Category[]>([]);
    const productsNodes = ref<TreeNode[]>([]);
    const expandedKeys = ref<{ [key: string]: boolean }>({});
    const selectionKeys = ref<{ [key: string]: { checked?: boolean; partialChecked?: boolean } }>({});

    const loadSelectableFields = async () => {
        try {
            const response = await userProfileService.getSelectableFields();
            gendersList.value = response.genders.map((gender: string, index: number) => ({ label: gender, value: index }));
            activityLevelsList.value = response.activityLevels.map((level: string, index: number) => ({
                label: level,
                value: index,
            }));
            dietGoalsList.value = response.dietGoalTypes.map((goal: string, index: number) => ({ label: goal, value: index }));
            allergiesList.value = response.allergies.map((allergy: any) => ({ label: allergy.caption, value: allergy.id }));
            kitchenEquipmentsList.value = response.kitchenEquipment.map((equipment: any) => ({
                label: equipment.caption,
                value: equipment.id,
            }));
            productCategories.value = response.productCategories;
        } catch (error) {
            console.error('Failed to load selectable fields', error);
        }
    };

    const loadUserProfile = async () => {
        try {
            const profile = await userProfileService.getUserProfile();
            if (profile) {
                userProfile.value = { ...profile };
                originalProfile.value = JSON.parse(JSON.stringify(profile));
            }
        } catch (error) {
            console.error('Failed to load user profile', error);
        }
    };

    const transformToTreeNodes = (data: Category[]): TreeNode[] => {
        return data.map(category => ({
            key: category.id,
            label: category.name,
            children: category.subCategories.map(subCategory => ({
                key: subCategory.id,
                label: subCategory.name,
                children: subCategory.products.map(product => ({
                    key: product.id,
                    label: product.name,
                    isProduct: true,
                })),
            })),
        }));
    };

    const propagateSelectionUp = (nodes: TreeNode[], selectionKeys: { [key: string]: { checked: boolean; partialChecked?: boolean } }) => {
        nodes.forEach(node => {
            if (node.children && node.children.length > 0) {
                propagateSelectionUp(node.children, selectionKeys);

                const allChildrenSelected = node.children.every(child => selectionKeys[child.key]?.checked);
                const anyChildSelected = node.children.some(child => selectionKeys[child.key]?.checked || selectionKeys[child.key]?.partialChecked);

                if (allChildrenSelected) {
                    selectionKeys[node.key] = { checked: true, partialChecked: false };
                } else if (anyChildSelected) {
                    selectionKeys[node.key] = { checked: false, partialChecked: true };
                } else {
                    selectionKeys[node.key] = { checked: false, partialChecked: false };
                }
            }
        });
    };

    onMounted(async () => {
        await loadSelectableFields();
        await loadUserProfile();

        productsNodes.value = transformToTreeNodes(productCategories.value);

        if (userProfile.value.products.length > 0) {
            selectionKeys.value = userProfile.value.products.reduce((keys, productId) => {
                keys[productId.toString()] = { checked: true };
                return keys;
            }, {} as { [key: string]: { checked: boolean } });

            propagateSelectionUp(productsNodes.value, selectionKeys.value);
        }
    });

    return {
        userProfile,
        originalProfile,
        gendersList,
        activityLevelsList,
        dietGoalsList,
        allergiesList,
        kitchenEquipmentsList,
        productsNodes,
        expandedKeys,
        selectionKeys,
    };
}