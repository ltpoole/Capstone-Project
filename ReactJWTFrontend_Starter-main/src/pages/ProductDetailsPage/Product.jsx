import React from "react";

const Product = ({ product }) => {
  return (
    <div>
      <h3>{product.name}</h3>
      <p>${product.price}</p>
      <p>{product.description}</p>
    </div>
  );
};

export default Product;
