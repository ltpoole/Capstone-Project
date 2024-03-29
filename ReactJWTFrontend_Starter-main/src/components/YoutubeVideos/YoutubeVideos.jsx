import React, { useState, useEffect } from "react";
import axios from "axios";
import "./YoutubeVideos.css";

const YoutubeVideos = () => {
  const [videos, setVideos] = useState([]);

  useEffect(() => {
    const fetchYoutubeVideos = async () => {
      try {
        const response = await axios.get(
          "https://youtube.googleapis.com/youtube/v3/playlistItems?part=snippet&maxResults=15&playlistId=UUj3uS1EabcZU7MAWKC3y3Nw&key=AIzaSyCW9otJvPp_zbiubuRLTCh3hlngqPMu2DI"
        );
        setVideos(response.data.items);
        console.log(response.data.items);
      } catch (error) {
        console.warn("Error fetching YouTube videos: ", error);
      }
    };
    fetchYoutubeVideos();
  }, []);

  return (
    <div>
      <h1>Checkout My Videos!</h1>
      <div className="flex-container">
        {videos.map((video) => (
          <div className="yt-videos" key={video.id}>
            <a
              href={`https://www.youtube.com/watch?v=${video.snippet.resourceId.videoId}`}
              target="_blank"
              rel="noopener noreferrer"
            >
              <img
                src={video.snippet.thumbnails.medium.url}
                alt={video.snippet.title}
              />
              <p>{video.snippet.title}</p>
            </a>
          </div>
        ))}
      </div>
    </div>
  );
};

export default YoutubeVideos;
