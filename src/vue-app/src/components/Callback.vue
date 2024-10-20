<template>
  <div>
    Redirecting...
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import { useRouter } from 'vue-router';

export default defineComponent({
  name: 'Callback',

  setup() {
    const router = useRouter();

    const handleCallback = (): void => {
      const urlParams = new URLSearchParams(window.location.search);
      const token = urlParams.get('token');

      if (token) {
        localStorage.setItem('jwt', token);
        router.push('/');
      } else {
        console.error('Token not found in URL');
      }
    };

    handleCallback();

    return {};
  }
});
</script>