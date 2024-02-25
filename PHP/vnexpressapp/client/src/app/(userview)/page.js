"use client"
import { useEffect } from 'react';
import axios from '@/utils/axios';


export default function MyPage({ data }) {
  useEffect(() => {
    // Sử dụng Axios để gọi API trong useEffect
    axios.get('/articles')
      .then(response => {
      })
      .catch(error => {
        console.error(error);
      });
  }, []);

  return (
    <>

    </>
  );
}
