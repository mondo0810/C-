"use client";
import React, { useState, useEffect } from "react";
import axios from "@/utils/axios";
import { toast, ToastContainer } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";

const AddArticleForm = () => {
  const [formData, setFormData] = useState({
    title: "",
    author: "",
    detail: "",
    category_id: "1",
  });

  const handleChange = (e) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value,
    });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    try {
      const response = await axios.post("/articles", formData, {
        headers: {
          "Content-Type": "application/json",
        },
      });

      toast.success(response.data.message);
    } catch (error) {
      toast.error("Error adding article. Please try again.");
    }
  };

  return (
    <div>
      <h2>Add Article</h2>
      <form onSubmit={handleSubmit}>
        <label>
          Title:
          <input type="text" name="title" value={formData.title} onChange={handleChange} required />
        </label>
        <br />
        <label>
          Author:
          <input type="text" name="author" value={formData.author} onChange={handleChange} required />
        </label>
        <br />
        <label>
          Detail:
          <textarea name="detail" value={formData.detail} onChange={handleChange} required></textarea>
        </label>
        <br />
        <label>
          Category ID:
          <input type="text" name="category_id" value={formData.category_id} onChange={handleChange} required />
        </label>
        <br />
        <button type="submit">Submit</button>
      </form>
      <ToastContainer />
    </div>
  );
};

export default AddArticleForm;
