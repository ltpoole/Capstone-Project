import React, { useState, useEffect } from "react";
import ProductList from "../../components/ProductList/ProductList";
import axios from "axios";

const AdminDashboardPage = () => {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    const fetchProducts = async () => {
      try {
        const response = await axios.get("https://localhost:5001/api/products");
        setProducts(response.data);
      } catch (error) {
        console.error("Error fetching products:", error);
      }
    };

    fetchProducts();
  }, []);
  return (
    <div>
      <h1>Admin Dashboard</h1>
      <ProductList products={products} />
    </div>
  );
};

export default AdminDashboardPage;
