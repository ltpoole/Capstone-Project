import React from "react";
import YoutubeVideos from "../../components/YoutubeVideos/YoutubeVideos";
import "./HomePage.css";

const HomePage = () => {
  // const [videos, setVideos] = useState([]);

  // useEffect(() => {
  //   const fetchVideos = async () => {
  //     try {
  //       const response = await axios.get(
  //         "https://youtube.googleapis.com/youtube/v3/playlistItems?part=snippet&maxResults=15&playlistId=UUj3uS1EabcZU7MAWKC3y3Nw&key=AIzaSyCW9otJvPp_zbiubuRLTCh3hlngqPMu2DI"
  //       );

  //       setVideos(response.data);
  //     } catch (error) {
  //       console.warn("Error fetching videos: ", error);
  //     }
  //   };
  //   fetchVideos();
  // }, []);

  // console.log(videos);

  return (
    <div>
      <div className="img">
        <img src="kgmlogo.png" alt="knit-girl-magic-logo" />
      </div>
      <div>
        <YoutubeVideos />
        {/* {videos
          ? videos.map((video) => (
              <div key={video.id}>
                <h3>{video.title}</h3>
              </div>
            ))
          : null} */}
      </div>
      {/* <FetchVideos /> */}
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
