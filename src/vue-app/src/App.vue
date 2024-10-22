<template>
  <div id="app" class="app-container">
    <Header />

    <main class="app-main">
      <router-view />
    </main>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import Header from './components/Header.vue';

export default defineComponent({
  name: 'App',
  components: {
    Header,
  },
});
</script>

<style>
#app {
  font-family: 'Roboto', sans-serif;
  background-color: #f5f7fa;
  color: #333;
  min-height: 100vh;
  display: flex;
  flex-direction: column;
}

.app-main {
  flex-grow: 1;
  margin: 0;
  width: 100%;
  display: flex;
  flex-direction: column;
}

main {
  flex-grow: 1;
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100%;
}

@media (max-width: 768px) {
  .app-main {
    padding: 10px;
  }
}

body {
  margin: 0;
  padding: 0;
}
</style>
