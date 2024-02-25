"use client";
import { useState } from "react";
import axios from "@/utils/axios";
import Cookies from "js-cookie";

export default function LoginPage() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [errorMessage, setErrorMessage] = useState("");

  const handleLogin = async () => {
    try {
      const response = await axios.post("/auth/login", {
        email: email,
        password: password,
      });

      // Lưu access_token vào cookie
      const { access_token } = response.data;
      Cookies.set("access_token", access_token);

      console.log(response.data);
      // Xử lý kết quả đăng nhập ở đây, ví dụ: chuyển hướng đến trang chính sau khi đăng nhập thành công
    } catch (error) {
      console.error(error);
      setErrorMessage("Đăng nhập thất bại. Vui lòng thử lại sau.");
    }
  };

  return (
    <div>
      <h2>Đăng nhập</h2>
      {errorMessage && <p style={{ color: "red" }}>{errorMessage}</p>}
      <form
        onSubmit={(e) => {
          e.preventDefault();
          handleLogin();
        }}
      >
        <div>
          <label>Email:</label>
          <input
            type="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
          />
        </div>
        <div>
          <label>Password:</label>
          <input
            type="password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
          />
        </div>
        <button type="submit">Đăng nhập</button>
      </form>
    </div>
  );
}
