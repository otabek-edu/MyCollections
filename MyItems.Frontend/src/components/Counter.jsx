import React, {useState} from 'react';

const Counter = () => {
  const [likes, setLikes] = useState(0);

  return (
      <div>
        <h2>{likes}</h2>
        <hr style={{maxWidth: "400px"}}/>
        <input
            type="number"
            value={likes}
            onChange={event => setLikes(event.target.value * 1)}/>
        <button onClick={() => setLikes(likes + 1)}>Like</button>
        <button onClick={() => setLikes(likes - 1)}>Dislike</button>
      </div>
  );
};

export default Counter;