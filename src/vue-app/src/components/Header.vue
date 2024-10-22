<!-- src/components/Header.vue -->
<template>
  <header class="header">
    <div class="container">
      <div class="logo-section">
<!--        <img src="@/assets/logo.png" alt="NutriWise Logo" class="logo-image" />-->
        <router-link to="/" class="app-title">NutriWise</router-link>
      </div>
      <nav :class="['nav-links', { open: isMenuOpen }]">
        <RouterLink to="/login" class="menu-button">
          <i class="pi pi-sign-in"></i>
          <span>Login</span>
        </RouterLink>
        <RouterLink to="/profile" class="menu-button">
          <i class="pi pi-user"></i>
          <span>Profile</span>
        </RouterLink>
      </nav>
      <button class="menu-toggle" @click="toggleMenu" aria-label="Toggle navigation">
        <i :class="['pi', isMenuOpen ? 'pi-times' : 'pi-bars']"></i>
      </button>
    </div>
  </header>
</template>

<script lang="ts">
import { defineComponent, ref } from 'vue';
import { RouterLink } from 'vue-router';

export default defineComponent({
  name: 'Header',
  components: {
    RouterLink,
  },
  setup() {
    const isMenuOpen = ref(false);

    const toggleMenu = () => {
      isMenuOpen.value = !isMenuOpen.value;
    };

    return {
      isMenuOpen,
      toggleMenu,
    };
  },
});
</script>

<style scoped>
@import url('https://fonts.googleapis.com/css2?family=Roboto:wght@400;500;700&display=swap');

.header {
  background: linear-gradient(90deg, #4CAF50, #81C784);
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.1);
  position: sticky;
  top: 0;
  z-index: 1000;
}

.container {
  max-width: 1200px;
  margin: 0 auto;
  padding: 0.75rem 1.5rem;
  display: flex;
  align-items: center;
  justify-content: space-between;
}

.logo-section {
  display: flex;
  align-items: center;
}

.logo-image {
  height: 50px;
  margin-right: 0.75rem;
  transition: transform 0.3s ease;
}

.logo-image:hover {
  transform: scale(1.05);
}

.app-title {
  font-family: 'Roboto', sans-serif;
  font-size: 1.75rem;
  font-weight: 700;
  color: #ffffff;
  text-decoration: none;
  transition: color 0.3s ease;
}

.app-title:hover {
  color: #e0f2f1;
}

.nav-links {
  display: flex;
  align-items: center;
  gap: 1.5rem;
}

.menu-button {
  display: flex;
  align-items: center;
  font-family: 'Roboto', sans-serif;
  font-size: 1rem;
  color: #ffffff;
  text-decoration: none;
  transition: color 0.3s ease, transform 0.3s ease;
}

.menu-button i {
  margin-right: 0.5rem;
  font-size: 1.25rem;
}

.menu-button:hover {
  color: #c8e6c9;
  transform: translateY(-2px);
}

.menu-toggle {
  display: none;
  background: none;
  border: none;
  color: #ffffff;
  font-size: 1.5rem;
  cursor: pointer;
}

.menu-toggle:focus {
  outline: none;
}

/* Responsive Styles */
@media (max-width: 768px) {
  .nav-links {
    position: absolute;
    top: 100%;
    right: 0;
    background: #4CAF50;
    flex-direction: column;
    width: 200px;
    padding: 1rem;
    border-bottom-left-radius: 8px;
    border-bottom-right-radius: 8px;
    transform: translateY(-10px);
    opacity: 0;
    visibility: hidden;
    transition: all 0.3s ease;
  }

  .nav-links.open {
    transform: translateY(0);
    opacity: 1;
    visibility: visible;
  }

  .menu-toggle {
    display: block;
  }
}
</style>
