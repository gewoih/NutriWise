<script setup lang="ts">
import {computed, watch} from 'vue';
import {userProfileService} from "../services/userProfileService.ts";
import {UserProfile} from "../models/UserProfile.ts";
import * as jsonpatch from 'fast-json-patch';
import {format} from 'date-fns';
import {useUserProfile} from "../composables/useUserProfile.ts";
import ProfileInputs from "./ProfileInputs.vue";

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

const selectedProductIds = computed(() => {
  return Object.entries(selectionKeys.value)
      .filter(([_, value]) => value.checked)
      .map(([key]) => key);
});

watch(selectedProductIds, (newProductIds) => {
  userProfile.value.products = newProductIds;
});

const updateProfile = async () => {
  try {
    const formattedUserProfile = {
      ...userProfile.value,
      birthdayDate: format(new Date(userProfile.value.birthdayDate), 'yyyy-MM-dd'),
    };

    const patchDocument = jsonpatch.compare(originalProfile.value as UserProfile, formattedUserProfile);

    if (patchDocument.length > 0) {
      await userProfileService.updateUserProfile(patchDocument);
      alert('Profile updated successfully!');
    } else {
      alert('No changes to update');
    }
  } catch (error) {
    console.error('Failed to update profile', error);
    alert('Failed to update profile');
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