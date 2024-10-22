import { defineStore } from 'pinia';

export const useAuthStore = defineStore('auth', {
    state: () => ({
        authToken: localStorage.getItem('authToken') || '',
    }),
    actions: {
        setAuthToken(token: string) {
            this.authToken = token;
            localStorage.setItem('authToken', token);
        },
        clearAuthToken() {
            this.authToken = '';
            localStorage.removeItem('authToken');
        },
    },
    getters: {
        isAuthenticated: (state) => !!state.authToken,
    },
});
