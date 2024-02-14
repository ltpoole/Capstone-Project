import React, { useState, useEffect } from "react";
import axios from "axios";
import "../../components/InventoryList/InventoryList.css";

const InventoryList = () => {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    const fetchProducts = async () => {
      try {
        const response = await axios.get("https://localhost:5001/api/products");
        setProducts(response.data);
        console.log(response.data);
      } catch (error) {
        console.error("Error fetching products:", error);
      }
    };

    fetchProducts();
  }, []);

  const handleEdit = async (id) => {
    try {
      await axios.put(`https://localhost:5001/api/products/${id}`);
    } catch (error) {
      console.warn("Error editing product: ", error);
    }
  };

  const handleDelete = async (id) => {
    try {
      await axios.delete(`https://localhost:5001/api/products/${id}`);
    } catch (error) {
      console.warn("Error deleting product: ", error);
    }
  };

  return (
    <div className="inventory-container">
      <h2 className="title">Inventory</h2>
      <table className="table-container">
        <thead>
          <tr>
            <th>Name</th>
            <th>Description</th>
            <th>Price</th>
            <th>Stock Quantity</th>
            <th>Product Image</th>
            <th>Edit Product</th>
            <th>Delete Product</th>
          </tr>
        </thead>
        <tbody>
          {products.map((product) => (
            <tr key={product.id}>
              <td>{product.name}</td>
              <td>{product.description}</td>
              <td>${product.price}</td>
              <td>{product.stockQuantity}</td>
              <td>
                <img src={product.imageUrl} alt={product.name} />
              </td>
              <td>
                <button onClick={handleEdit}>Edit</button>
              </td>
              <td>
                <button onClick={handleDelete}>Delete</button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default InventoryList;
