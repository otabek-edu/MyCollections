import React, {useState} from 'react';
import Toast from 'react-bootstrap/Toast';
import Container from 'react-bootstrap/Container';
import Button from 'react-bootstrap/Button';
import FormCheckInput from "react-bootstrap/FormCheckInput";
import button from "bootstrap/js/src/button.js";

const Counter = () => {
  const [likes, setLikes] = useState(0);

  return (
      <div>
        <h2>{likes}</h2>
        <h4>{import.meta.env.VITE_KEY}</h4>
        <h4>{import.meta.env.MODE}</h4>
        <hr style={{maxWidth: "400px"}}/>
        <input className="input-group-text"
            type="number"
            value={likes}
            onChange={event => setLikes(event.target.value * 1)}/>
        <Button onClick={() => setLikes(likes + 1)}>Like</Button>
        <button className="button" onClick={() => setLikes(likes - 1)}>Dislike</button>
      </div>
  );
};

export default Counter;