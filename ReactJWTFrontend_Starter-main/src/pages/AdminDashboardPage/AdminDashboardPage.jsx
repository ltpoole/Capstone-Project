import React from "react";
import InventoryList from "../../components/InventoryList/InventoryList";
import AddProductForm from "../../components/AddProductForm/AddProductForm";

const AdminDashboardPage = () => {
  return (
    <div>
      <h1>Admin Dashboard</h1>
      <InventoryList />
      <AddProductForm />
    </div>
  );
};

export default AdminDashboardPage;
