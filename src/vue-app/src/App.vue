<template>
  <div id="app">
    <header>
      <nav>
        <RouterLink to="/login">Login</RouterLink> |
        <RouterLink to="/profile">Profile</RouterLink>
      </nav>
    </header>
    <RouterView />
  </div>
</template>

<script setup lang="ts">
import { onMounted } from 'vue';
import 'primeicons/primeicons.css';

onMounted(() => {
  console.log('App mounted');
});
</script>

<style scoped>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  text-align: center;
  color: #2c3e50;
}

header {
  background-color: #42b983;
  padding: 20px;
  color: white;
}

nav a {
  margin: 0 15px;
  text-decoration: none;
  color: white;
}

nav a:hover {
  text-decoration: underline;
}
</style>
