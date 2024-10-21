import { createApp } from 'vue';
import PrimeVue from 'primevue/config';
import App from './App.vue';

import Material from '@primevue/themes/material';
import './style.css'
import 'primeicons/primeicons.css'
import 'primeflex/primeflex.css';

import router from "./router";

const app = createApp(App);
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
