"use client";
import axios from "@/utils/axios";
import { useRouter } from 'next/navigation';
import React, { createContext, useContext, useEffect, useState } from 'react';

const AuthContext = createContext({
    login: () => void 0,
    loginPassword: () => void 0,
    logout: () => void 0,
    status: 0,
    setDetail: () => void 0
});

export function useAuth() {
    return useContext(AuthContext);
}

function setLocalUser(user) {
    localStorage.setItem("user", JSON.stringify(user));
}



export function AuthProvider({ children }) {
    const [user, setUser] = useState();
    const [status, setStatus] = useState(0);
    const { push } = useRouter();

    useEffect(() => {
        setUser(getLocalUser());
    }, []);

    const setDetail = (user) => {
        if (user) {
            setUser(user);
            setLocalUser(user);
            setStatus(1);
        } else {
            setUser(undefined);
            clearLocalUser();
            setStatus(0);
        }
    }

    const login = async () => {
        const res = await axios.get("/profile/user");

        if (res.status === 200) {
            const data = res.data.data;
            const user = {
                uid: data.uid,
                username: data.username,
                balance: data.balance,
                coin: data.coin,
                phone: data.phone,
                avatar: data.avatar,
                email: data.email,
                createdAt: new Date(data.created_at)
            }
            setDetail(user);
        } else {
            setDetail();
        }
    };


    const loginPassword = async (formData) => {
        try {
            const res = await axios.post("/auth/public", formData);

            if (res.status === 200) {
                const data = res.data;
                // Assume that the response contains the necessary user information
                const user = {
                    uid: data.uid,
                    username: data.username,
                    balance: data.balance,
                    coin: data.coin,
                    phone: data.phone,
                    avatar: data.avatar,
                    email: data.email,
                    createdAt: new Date(data.created_at)
                }
                setDetail(user);
            } else {
                console.error(res.data?.message || "Đăng nhập không thành công");
            }
        } catch (error) {
            console.error((error).response?.data?.message || (error).message || "Lỗi không xác định");
        }
    };

    const logout = async () => {
        const res = await axios.post("/auth/user/logout", null);

        if (res.status === 200) {
            setDetail();
            push('/');
        } else {
            console.error(res.data?.message || res.statusText);
        };
    };

    return (
        <AuthContext.Provider value={{ user, login, logout, setDetail, status, loginPassword }}>
            {children}
        </AuthContext.Provider>
    )
}