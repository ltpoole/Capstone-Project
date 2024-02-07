import axios from "axios";
import React, { useState, useEffect } from "react";

export default function ImageList() {
  const [images, setImages] = useState([]);

  useEffect(() => {
    fetchImages();
  }, []);

  const fetchImages = async () => {
    try {
      const response = await axios.get(`https://localhost:5001/api/image/`);
      console.log(response.data);
      setImages();
    } catch (error) {
      console.log(error);
    }
  };

  return (
    <div>
      {/* Render each image in the list */}
      {images.map((image) => (
        <div>
          <img src={image.imageSrc} alt={image.title} width="250" />
          <div>
            <h2>{image.title}</h2>
            <p>{image.description}</p>
          </div>
        </div>
      ))}
    </div>
  );
}
