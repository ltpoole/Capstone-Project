import React from "react";

const ProductItem = ({ product }) => {
  return (
    <li>
      <div>Product Name: {product.name}</div>
      <div>Price: ${product.price}</div>
      <div>Quantity: {product.quantity}</div>
    </li>
  );
};

export default ProductItem;
