"use client";
import React, { useState, useEffect } from "react";
import axios from "@/utils/axios";

const CategoryTable = () => {
  const [categories, setCategories] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get("/categories"); // Replace with your actual API endpoint
        setCategories(response.data.categories);
      } catch (error) {
        console.error("Error fetching category data:", error);
      }
    };

    fetchData();
  }, []);

  return (
    <div className="container mx-auto mt-8">
      <h1 className="text-2xl font-bold mb-4">Category List</h1>
      <table className="min-w-full table-auto">
        <thead>
          <tr>
            <th className="border border-gray-300 px-4 py-2">ID</th>
            <th className="border border-gray-300 px-4 py-2">Name</th>
            <th className="border border-gray-300 px-4 py-2">Created At</th>
            <th className="border border-gray-300 px-4 py-2">Updated At</th>
          </tr>
        </thead>
        <tbody>
          {categories.map((category) => (
            <tr key={category.id}>
              <td className="border border-gray-300 px-4 py-2">{category.id}</td>
              <td className="border border-gray-300 px-4 py-2">{category.name}</td>
              <td className="border border-gray-300 px-4 py-2">{category.created_at}</td>
              <td className="border border-gray-300 px-4 py-2">{category.updated_at}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default CategoryTable;
