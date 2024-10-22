<template>
  <Button
      label="Login with Google"
      icon="pi pi-google"
      class="login-btn p-button-outlined p-button-lg"
      @click="loginWithGoogle"
  />
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import Button from 'primevue/button';

export default defineComponent({
  name: 'LoginButton',
  components: {
    Button,
  },
  methods: {
    loginWithGoogle() {
      window.location.href =
          'https://localhost:5001/api/auth/google?returnUrl=http://localhost:8080/callback';
    },
  },
});
</script>