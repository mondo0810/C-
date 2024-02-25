import axios from "../../utils/axios";

async function getCsrfToken() {
    const response = await axios.get('/api/csrf-token');
    return response.data.csrf_token;
}
