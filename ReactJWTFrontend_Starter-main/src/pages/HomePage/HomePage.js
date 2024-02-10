import React from "react";
import { useEffect, useState } from "react";
import axios from "axios";
import "./HomePage.css";

const HomePage = () => {
  return (
    <div>
      <div className="img">
        <img src="kgmlogo.png" alt="knit-girl-magic-logo" />
      </div>
      <div className="info">
        <h2>Reach Out!</h2>
        <h3>PO Box:</h3>
        <p>PO Box 12345 Graham, NC 27253</p>
        <h3>Email:</h3>
        <p>knitgirlmagic@gmail.com</p>
        <h3>Social:</h3>
        <div className="social-icons">
          <a href="https://www.instagram.com/knitgirlmagic?utm_source=ig_web_button_share_sheet&igsh=ZDNlZDc0MzIxNw==">
            <img src="Instagram.png" alt="Instagram icon" />
          </a>
          <a href="https://www.youtube.com/@Knitgirlmagic">
            <img src="Youtube-Icon.png" alt="Youtube icon" />
          </a>
        </div>
      </div>
    </div>
  );
};

export default HomePage;
