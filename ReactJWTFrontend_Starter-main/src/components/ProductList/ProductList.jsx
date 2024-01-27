import React from "react";
import ProductItem from "../ProductItem/ProductItem";

const ProductList = (products) => {
  return (
    <div>
      <h2>Inventory</h2>
      <ul>
        {products.map((product) => (
          <ProductItem key={product.id} product={product} />
        ))}
      </ul>
    </div>
  );
};

export default ProductList;
