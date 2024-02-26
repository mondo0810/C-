"use client";
import React, { useState, useEffect } from "react";
import axios from "@/utils/axios";

const RoleTable = () => {
  const [roles, setRoles] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get("/roles"); // Replace with your actual API endpoint
        setRoles(response.data.data);
      } catch (error) {
        console.error("Error fetching role data:", error);
      }
    };

    fetchData();
  }, []);

  return (
    <div className="container mx-auto mt-8">
      <h1 className="text-2xl font-bold mb-4">Role List</h1>
      <table className="min-w-full table-auto">
        <thead>
          <tr>
            <th className="border border-gray-300 px-4 py-2">ID</th>
            <th className="border border-gray-300 px-4 py-2">Name</th>
            <th className="border border-gray-300 px-4 py-2">Created At</th>
            <th className="border border-gray-300 px-4 py-2">Updated At</th>
            <th className="border border-gray-300 px-4 py-2">Permissions</th>
          </tr>
        </thead>
        <tbody>
          {roles.map((role) => (
            <tr key={role.id}>
              <td className="border border-gray-300 px-4 py-2">{role.id}</td>
              <td className="border border-gray-300 px-4 py-2">{role.name}</td>
              <td className="border border-gray-300 px-4 py-2">{role.created_at}</td>
              <td className="border border-gray-300 px-4 py-2">{role.updated_at}</td>
              <td className="border border-gray-300 px-4 py-2 ">
                <div className="flex flex-wrap w-4/5">
                  {role.permission.map((permission) => (
                    <span
                      key={permission.id}
                      className="text-white text-xs bg-blue-500 rounded-md px-1  py-1 inline-block m-1"
                    >
                      {permission.name}
                    </span>
                  ))}
                </div>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default RoleTable;
