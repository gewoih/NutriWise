import {createRouter, createWebHistory} from 'vue-router';
import Profile from '../views/Profile.vue';
import Login from '../views/Login.vue';
import {useUserStore} from "../stores/user.ts";
import CallbackGoogle from "../components/Google/CallbackGoogle.vue";
import Home from "../views/Home.vue";

const routes = [
    { path: '/', component: Home },
    { path: '/callback', component: CallbackGoogle },
    { path: '/profile', name: 'profile', component: Profile },
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
