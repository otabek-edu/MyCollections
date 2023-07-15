import React from 'react';

const Collection = ({name, count}) => {

  return (
      <div className="card mt-2">
        <div className="card-body">
          <a href='' className="link-offset-2-hover link-dark link-body-emphasis">{name}</a>
          <div>
            <span className="card-subtitle">Item count: {count}</span>
          </div>
        </div>
      </div>
  );
};

export default Collection;