"use client";
import React, { useState, useEffect } from "react";
import axios from "@/utils/axios";
import Link from "next/link";

const ArticleTable = () => {
  const [articles, setArticles] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get("/articles"); // Replace with your actual API endpoint
        setArticles(response.data.data);
      } catch (error) {
        console.error("Error fetching article data:", error);
      }
    };

    fetchData();
  }, []);

  return (
    <div className="container mx-auto mt-8">
      <h1 className="text-2xl font-bold mb-4">Article List</h1>
      <Link
        href="/dashboard/article/add-article"
        className="bg-green-500 text-white px-4 py-2 rounded-md font-bold transition duration-300 hover:bg-green-600"
      >
        Add Article
      </Link>
      <table className="min-w-full table-auto">
        <thead>
          <tr>
            <th className="border border-gray-300 px-4 py-2">ID</th>
            <th className="border border-gray-300 px-4 py-2">Title</th>
            <th className="border border-gray-300 px-4 py-2">Author</th>
            <th className="border border-gray-300 px-4 py-2">Detail</th>
            <th className="border border-gray-300 px-4 py-2">User ID</th>
            <th className="border border-gray-300 px-4 py-2">Category ID</th>
            <th className="border border-gray-300 px-4 py-2">Created At</th>
            <th className="border border-gray-300 px-4 py-2">Updated At</th>
          </tr>
        </thead>
        <tbody>
          {articles.map((article) => (
            <tr key={article.id}>
              <td className="border border-gray-300 px-4 py-2">{article.id}</td>
              <td className="border border-gray-300 px-4 py-2">{article.title}</td>
              <td className="border border-gray-300 px-4 py-2">{article.author}</td>
              <td className="border border-gray-300 px-4 py-2">{article.detail}</td>
              <td className="border border-gray-300 px-4 py-2">{article.user_id}</td>
              <td className="border border-gray-300 px-4 py-2">{article.category_id}</td>
              <td className="border border-gray-300 px-4 py-2">{article.created_at}</td>
              <td className="border border-gray-300 px-4 py-2">{article.updated_at}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default ArticleTable;
