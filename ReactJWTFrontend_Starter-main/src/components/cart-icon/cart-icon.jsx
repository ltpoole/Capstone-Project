import React from "react";
import shoppingCart from "../../assets/shopping-cart.png";
import "./cart-icon.css";

const CartIcon = () => {
  return (
    <div className="cart-container">
      <img src={shoppingCart} alt="shopping-cart-icon" />
      <span className="cart-count"> 5 </span>
    </div>
  );
};

export default CartIcon;
