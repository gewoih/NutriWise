<script setup lang="ts">
import {computed, watch} from 'vue';
import {userProfileService} from "../services/userProfileService.ts";
import {useUserProfile} from "../composables/useUserProfile.ts";
import ProfileInputs from "./ProfileInputs.vue";
import {TreeNode} from "primevue/treenode";
import _ from 'lodash'

const {
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
} = useUserProfile();

const isProductNode = (key: string, nodes: TreeNode[]): boolean => {
  for (const node of nodes) {
    if (node.key === key && node.isProduct) {
      return true;
    }
    if (node.children) {
      const found = isProductNode(key, node.children);
      if (found) return true;
    }
  }
  return false;
};

const selectedProductIds = computed(() => {
  return Object.entries(selectionKeys.value)
      .filter(([key, value]) => value.checked && isProductNode(key, productsNodes.value))
      .map(([key]) => key);
});

watch(selectedProductIds, (newProductIds) => {
  userProfile.value.products = newProductIds;
});

const updateProfile = async () => {
  if (!_.isEqual(originalProfile.value, userProfile.value)) {
    await userProfileService.updateUserProfile(userProfile.value);
  }
};
</script>

<template>
  <div>
    <Card class="shadow-3">
      <template #title><h2>Редактирование профиля</h2></template>
      <template #content>
        <ProfileInputs
            :userProfile="userProfile"
            :gendersList="gendersList"
            :activityLevelsList="activityLevelsList"
            :dietGoalsList="dietGoalsList"
            :allergiesList="allergiesList"
            :kitchenEquipmentsList="kitchenEquipmentsList"
            @updateProfile="updateProfile"
        />
        <Tree :value="productsNodes" v-model:expanded-keys="expandedKeys" v-model:selection-keys="selectionKeys"
              selectionMode="checkbox" class="w-full md:w-[30rem]"/>
      </template>
    </Card>
  </div>
</template>