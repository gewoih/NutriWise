import router from "../router";

class AuthService {
    async login() {
        await router.push("https://localhost:5001/api/auth/google?returnUrl=http://localhost:8080/callback");
    }
}

export const authService = new AuthService();