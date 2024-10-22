import { createApp } from 'vue';
import PrimeVue from 'primevue/config';
import App from './App.vue';

import Material from '@primevue/themes/material';
import 'primeicons/primeicons.css'
import 'primeflex/primeflex.css';

import { createPinia } from 'pinia';

import router from "./router";

const app = createApp(App);
const pinia = createPinia();

app.use(pinia);
app.use(router);
app.use(PrimeVue, {
    theme: {
        preset: Material,
        options: {
            prefix: 'p',
            darkModeSelector: 'system',
            cssLayer: false
        }
    }
});
    
app.mount('#app');
