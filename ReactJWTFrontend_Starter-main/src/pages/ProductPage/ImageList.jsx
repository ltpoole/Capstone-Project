import axios from "axios";
import React, { useState, useEffect } from "react";

export default function ImageList() {
  const [images, setImages] = useState([]);

  useEffect(() => {
    const fetchImages = async () => {
      try {
        const response = await axios.get(`https://localhost:5001/api/image/`);
        console.log(response.data);
        setImages();
      } catch (error) {
        console.log(error);
      }
    };

    fetchImages();
  }, []);

  return (
    <div>
      {/* Render each image in the list */}
      {images?.map((image) => (
        <div key={image.id}>
          <img src={image.imageSrc} alt={image.title} width="250" />
        </div>
      ))}
    </div>
  );
}
