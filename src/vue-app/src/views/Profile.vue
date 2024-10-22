<!-- src/views/Profile.vue -->
<template>
  <div class="profile-page p-px-4 p-py-6">
    <UserProfile />
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import UserProfile from '../components/UserProfile.vue';
import Button from 'primevue/button';
import { useRouter } from 'vue-router';
import {useAuthStore} from "../stores/auth.ts";

export default defineComponent({
  name: 'Profile',
  components: {
    UserProfile,
    Button,
  },
  setup() {
    const router = useRouter();
    const authStore = useAuthStore();

    const logout = () => {
      authStore.clearAuthToken();
      router.push('/');
    };

    return {
      logout,
    };
  },
});
</script>
