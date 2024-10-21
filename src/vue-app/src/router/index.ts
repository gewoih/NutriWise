import {createRouter, createWebHistory} from 'vue-router';
import CallbackGoogle from '../components/Google/CallbackGoogle.vue';
import UserProfile from "../views/UserProfile.vue";
import LoginGoogle from '../components/Google/LoginGoogle.vue';

const routes = [
    { path: '/callback', component: CallbackGoogle },
    { path: '/profile', component: UserProfile },
    { path: '/login', component: LoginGoogle }
];

const router = createRouter({
    history: createWebHistory(),
    routes
});

export default router;
