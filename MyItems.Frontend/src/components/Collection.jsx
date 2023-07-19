import React from 'react';
import {Link} from "react-router-dom";

const Collection = ({name, count, id}) => {

  return (
      <div className="card mt-2">
        <div className="card-body">
          <Link to={`/collection/${id}`} className="link-offset-2-hover link-dark link-body-emphasis">{name}</Link>
          <div>
            <span className="card-subtitle">Item count: {count}</span>
          </div>
        </div>
      </div>
  );
};

export default Collection;