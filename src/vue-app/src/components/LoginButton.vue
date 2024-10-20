<template>
  <div>
    <button @click="loginWithGoogle" class="login-btn">
      Login with Google
    </button>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';

export default defineComponent({
  name: 'LoginButton',

  methods: {
    loginWithGoogle() {
      window.location.href = 'https://localhost:5001/api/auth/google';
    }
  }
});
</script>

<style scoped>
.login-btn {
  background-color: #4285f4;
  color: white;
  padding: 10px 20px;
  border: none;
  border-radius: 5px;
  cursor: pointer;
  font-size: 16px;
}

.login-btn:hover {
  background-color: #357ae8;
}
</style>
