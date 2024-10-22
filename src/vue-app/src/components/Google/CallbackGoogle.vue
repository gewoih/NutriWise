<template>
  <div>
    Redirecting...
  </div>
</template>

<script lang="ts">
import { defineComponent, onMounted } from 'vue';
import { useRouter } from 'vue-router';
import {useAuthStore} from "../../stores/auth.ts";

export default defineComponent({
  name: 'Callback',

  setup() {
    const router = useRouter();
    const authStore = useAuthStore();

    const handleCallback = (): void => {
      const urlParams = new URLSearchParams(window.location.search);
      const token = urlParams.get('token');

      if (token) {
        authStore.setAuthToken(token);
        router.push('/');
      } else {
        console.error('Token not found in URL');
        router.push('/login');
      }
    };

    onMounted(() => {
      handleCallback();
    });

    return {};
  }
});
</script>
