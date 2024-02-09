import React from "react";

const InventoryItem = ({ product }) => {
  return (
    <li>
      <div>Product Name: {product.name}</div>
      <div>Price: ${product.price}</div>
      <div>Quantity: {product.stockQuantity}</div>
      <div>Image: {product.imageFile}</div>
    </li>
  );
};

export default InventoryItem;
