import React from 'react';

const Item = ({name, collection, author}) => {
  return (
      <div className="card mt-2">
        <div className="card-body">
          <a href="#" className="link-offset-2-hover link-dark link-body-emphasis">{name}</a>
          <div className="card-link">
            {collection}
          </div>
          <div className="card-footer">
            <a href="/" className="link-offset-2-hover link-dark link-body-emphasis">{author}</a>
          </div>
        </div>
      </div>
  );
};

export default Item;