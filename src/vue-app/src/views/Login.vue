<!-- src/views/Login.vue -->
<template>
  <div class="login-page p-d-flex p-jc-center p-ai-center">
    <div class="login-card p-shadow-3 p-p-6 p-mb-4">
<!--      <img src="@/assets/logo.png" alt="Logo" class="login-logo" />-->
      <h2 class="login-title">Welcome Back!</h2>
      <LoginButton />
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import LoginButton from '../components/Google/LoginButton.vue';

export default defineComponent({
  name: 'Login',
  components: {
    LoginButton,
  },
});
</script>

<style scoped>
/* Styles as before */
</style>
