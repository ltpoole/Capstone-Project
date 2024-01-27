import React from "react";
import { useEffect, useState } from "react";
import axios from "axios";

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
    <div>
      <h1>Latest YouTube Episode</h1>
      {latestVideo && (
        <div>
          <h2>{latestVideo.snippet.title}</h2>
          <p>{latestVideo.snippet.description}</p>
          <iframe
            title="Unique Title"
            width="560"
            height="315"
            src={`https://www.youtube.com/embed/${latestVideo.id.videoId}`}
            frameborder="0"
            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
            allowFullScreen
          ></iframe>
        </div>
      )}
    </div>
  );
};

export default HomePage;
