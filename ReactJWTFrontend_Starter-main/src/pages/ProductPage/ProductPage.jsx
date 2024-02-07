import React, { useState, useEffect } from "react";
import axios from "axios";
import { Link } from "react-router-dom";

const ProductPage = () => {
  const [products, setProducts] = useState([]);

  const fetchProducts = async () => {
    try {
      let response = await axios.get("https://localhost:5001/api/products");
      setProducts(response.data);
    } catch (error) {
      console.log(error.response.data);
    }
  };

  useEffect(() => {
    fetchProducts();
  }, []);

  return (
    <div>
      <h2 style={{ color: "orangered" }}>Charity's Products</h2>
      <ul>
        {products.map((product) => (
          <Link to={`/productDetails/${product.id}`}>
            <li key={product.id}>{product.name}</li>
            <li>${product.price}</li>
          </Link>
        ))}
      </ul>
    </div>
  );
};

export default ProductPage;
