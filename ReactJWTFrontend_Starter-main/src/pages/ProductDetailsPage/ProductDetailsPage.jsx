import React, { useState, useEffect } from "react";
import axios from "axios";
import { useParams } from "react-router-dom";
import useAuth from "../../hooks/useAuth";
import Product from "./Product";
import ReviewList from "./ReviewList";
import ReviewForm from "./ReviewForm";

const ProductDetailsPage = () => {
  const { productId } = useParams();
  const [user, token] = useAuth();
  const [product, setProduct] = useState(null);
  const [productDetails, setProductDetails] = useState([]);
  console.log(product);

  useEffect(() => {
    const fetchProduct = async () => {
      try {
        let response = await axios.get(
          `https://localhost:5001/api/products/${productId}`
        );
        setProduct(response.data);
      } catch (error) {
        console.log(error.data);
      }
    };
    fetchProduct();
    getProductDetails();
  }, [productId]);

  const getProductDetails = async () => {
    try {
      let response = await axios.get(
        `https://localhost:5001/api/productdetails/${productId}`,
        {
          headers: {
            Authorization: "Bearer " + token,
          },
        }
      );
      setProductDetails(response.data);
    } catch (error) {
      console.log(error);
    }
  };

  return (
    <div>
      {product && (
        <div>
          <Product
            product={
              productDetails.reviews.length !== 0 && (
                <ReviewList reviews={productDetails.reviews} />
              )
            }
          />
          <ReviewForm productId={productId} />
        </div>
      )}
    </div>
  );
};

export default ProductDetailsPage;
