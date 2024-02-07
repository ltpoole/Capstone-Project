import React, { useState, useEffect } from "react";
import axios from "axios";
import { useParams } from "react-router-dom";
import ReviewList from "./ReviewList";
import ReviewForm from "./ReviewForm";
import Product from "./Product";

const ProductDetailsPage = () => {
  const { id } = useParams();
  const [product, setProduct] = useState(null);
  const [productDetails, setProductDetails] = useState([]);

  useEffect(() => {
    const fetchProduct = async () => {
      try {
        let response = await axios.get(
          `https://localhost:5001/api/products/${id}`
        );
        setProduct(response.data);
      } catch (error) {
        console.log(error);
      }
    };

    const getProductDetails = async () => {
      try {
        let response = await axios.get(
          `https://localhost:5001/api/productDetails/${id}`
        );
        setProductDetails(response.data);
      } catch (error) {
        console.log(error);
      }
    };

    fetchProduct();
    getProductDetails();
  }, [id]);

  return (
    <div>
      {product && (
        <div>
          <Product product={product} />
          {productDetails.reviews.length !== 0 && (
            <ReviewList reviews={productDetails.reviews} />
          )}
          <ReviewForm id={id} />
        </div>
      )}
    </div>
  );
};

export default ProductDetailsPage;
