import React from "react";
import { useEffect, useState } from "react";
import axios from "axios";
import "./HomePage.css";

const HomePage = () => {
  const [latestVideo, setLatestVideo] = useState(null);

  useEffect(() => {
    const fetchLatestVideo = async () => {
      try {
        const response = await axios.get(
          `https://www.googleapis.com/youtube/v3/search?key=AIzaSyBkOOjj0B8q0jiM4G7b6zZhZYoxjFPdigg&channelId=UCj3uS1EabcZU7MAWKC3y3Nw&part=snippet,id&order=date&maxResults=1`
        );

        setLatestVideo(response.data.items[0]);
      } catch (error) {
        console.error("Error fetching latest video:", error);
      }
    };

    fetchLatestVideo();
  }, []);

  return (
    <div className="image">
      <img
        src="kgmlogo.jpeg"
        alt="Knit Girl Magic logo"
        width="600"
        height="600"
      />
      {latestVideo && (
        <div className="image">
          <h1>Watch The Latest!</h1>
          <iframe
            title="Unique Title"
            width="560"
            height="315"
            src={`https://www.youtube.com/embed/${latestVideo.id.videoId}`}
            frameBorder="0"
            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
            allowFullScreen
          ></iframe>
        </div>
      )}
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
