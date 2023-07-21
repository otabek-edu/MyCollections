import React from 'react';
import {Link} from "react-router-dom";

const SimpleItem = ({name, id}) => {
  return (
      <div className="card mt-2">
        <div className="card-body">
          Item: <Link to={`/item/${id}`} className="link-offset-2-hover link-dark link-body-emphasis">{name}</Link>
        </div>
      </div>
  );
};

export default SimpleItem;