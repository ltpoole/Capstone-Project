import React from "react";

const InventoryItem = ({ product }) => {
  return (
    <li>
      <div>Product Name: {product.name}</div>
      <div>Price: ${product.price}</div>
      <div>Quantity: {product.quantity}</div>
    </li>
  );
};

export default InventoryItem;
