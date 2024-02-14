import React, { useState, useEffect } from "react";
import axios from "axios";
import { Link } from "react-router-dom";
import ImageList from "./ImageList";

const ProductPage = () => {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    const fetchProducts = async () => {
      try {
        let response = await axios.get("https://localhost:5001/api/products");
        console.log(response.data);
        setProducts(response.data);
      } catch (error) {
        console.log(error.response.data);
      }
    };

    fetchProducts();
  }, []);

  return (
    <div>
      <h2 style={{ color: "orangered" }}>Charity's Products</h2>
      <ImageList />
      <ul>
        {products?.map((product) => (
          <Link to={`/productDetails/${product.id}`}>
            <li key={product.id}>{product.imageSrc}</li>
            <li>{product.name}</li>
            <li>${product.price}</li>
          </Link>
        ))}
      </ul>
    </div>
  );
};

export default ProductPage;
