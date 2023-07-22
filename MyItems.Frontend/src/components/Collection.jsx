import React from 'react';
import {Link} from "react-router-dom";
import CollectionService from "../API/collection.service.js";

const Collection = ({name, count, id, refreshModalPage, isMyProfile}) => {

  const deleteCollection = async () => {
    const response = await CollectionService.deleteMyCollectionById(id)
    if (response.success === true) {
      console.log('success')
      refreshModalPage()
    }
  };

  return (
      <div className="card mt-2">
        <div className="card-body d-flex justify-content-between">
          <div>
            <Link to={`/collection/${id}`} className="link-offset-2-hover link-dark link-body-emphasis">{name}</Link>
            <div>
              <span className="card-subtitle">Item count: {count}</span>
            </div>
          </div>
          {
            isMyProfile ?
                <button className='btn btn-danger' onClick={deleteCollection}>Delete</button>
                : false
          }

        </div>
      </div>
  );
};

export default Collection;