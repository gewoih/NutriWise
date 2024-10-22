import {createRouter, createWebHistory} from 'vue-router';
import CallbackGoogle from '../components/Google/CallbackGoogle.vue';
import Profile from '../views/Profile.vue';
import Login from '../views/Login.vue';
import { useAuthStore } from '../stores/auth';

const routes = [
    { path: '/callback', component: CallbackGoogle },
    { path: '/profile', name: 'profile', component: Profile, meta: { requiresAuth: true } },
    { path: '/login', name: 'login', component: Login }
];

const router = createRouter({
    history: createWebHistory(),
    routes
});

router.beforeEach((to, from, next) => {
    const authStore = useAuthStore();
    if (to.meta.requiresAuth && !authStore.isAuthenticated) {
        next('/login');
    } else {
        next();
    }
});

export default router;
