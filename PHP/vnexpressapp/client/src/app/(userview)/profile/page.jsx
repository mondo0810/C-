"use client";
import React, { useContext } from "react";
import { AuthContext } from "@/contexts/AuthContext";

function ProfilePage() {
  const { user, loading, logout } = useContext(AuthContext);

  if (loading) {
    return <div>Loading...</div>;
  }

  return (
    <div>
      {user ? (
        <div>
          <h2>Welcome, {user.name}!</h2>
          <button onClick={logout}>Logout</button>
        </div>
      ) : (
        <div>
          <h2>Please log in to view your profile</h2>
          {/* Render form login */}
        </div>
      )}
    </div>
  );
}

export default ProfilePage;
