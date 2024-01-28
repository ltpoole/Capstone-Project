import React from "react";
import InventoryItem from "../InventoryItem/InventoryItem";

const InventoryList = (products) => {
  return (
    <div>
      <h2>Inventory</h2>
      <ul>
        {products.map((product) => (
          <InventoryItem key={product.id} product={product} />
        ))}
      </ul>
    </div>
  );
};

export default InventoryList;
