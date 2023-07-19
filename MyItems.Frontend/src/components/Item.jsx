import React from 'react';
import {Link} from "react-router-dom";

const Item = ({name, itemId, collectionName, collectionId, author, authorId}) => {
  return (
      <div className="card mt-2">
        <div className="card-body">
          Item: <Link to={`/item/${itemId}`} className="link-offset-2-hover link-dark link-body-emphasis">{name}</Link>
          <div className="card-link">
            Collection: <Link to={`/collection/${collectionId}`} className="link-offset-2-hover link-dark link-body-emphasis">{collectionName}</Link>
          </div>
          <div className="card-footer">
            Author: <Link to={`profile/${authorId}`} className="link-offset-2-hover link-dark link-body-emphasis">{author}</Link>
          </div>
        </div>
      </div>
  );
};

export default Item;