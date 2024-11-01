import {createRouter, createWebHistory} from 'vue-router';
import Profile from '../views/Profile.vue';
import Login from '../views/Login.vue';
import {useUserStore} from "../stores/user.ts";
import CallbackGoogle from "../components/Google/CallbackGoogle.vue";

const routes = [
    { path: '/callback', component: CallbackGoogle },
    { path: '/profile', name: 'profile', component: Profile, meta: { requiresAuth: true } },
    { path: '/login', name: 'login', component: Login }
];

const router = createRouter({
    history: createWebHistory(),
    routes
});

router.beforeEach(to => {
    const authStore = useUserStore();
    if (!authStore.isAuthenticated) {
        to.name = '/login';
    }
});

export default router;
