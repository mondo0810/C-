import React from "react";
import Link from "next/link";
import { useAuth } from "@/contexts/AuthContext";

const Navbar = () => {
  const { user } = useAuth();
  return (
    <nav>
      <ul>
        <li>
          <Link href="/">Trang chủ</Link>
        </li>
        {isLoggedIn ? (
          <>
            <li>
              <Link href="/profile">Hồ sơ: {user.name}</Link>
            </li>
            <li>
              <button onClick={logout}>Đăng xuất</button>
            </li>
          </>
        ) : (
          <>
            <li>
              <Link href="/login">Đăng nhập</Link>
            </li>
            <li>
              <Link href="/register">Đăng ký</Link>
            </li>
          </>
        )}
      </ul>
    </nav>
  );
};

export default Navbar;
