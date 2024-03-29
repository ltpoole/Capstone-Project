import React from "react";

const ReviewList = ({ reviews }) => {
  return (
    <div>
      <h3>Product Reviews</h3>
      <ul>
        {reviews?.map((review) => (
          <li key={review.id}>
            {review.text} - {review.user.firstName}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default ReviewList;
