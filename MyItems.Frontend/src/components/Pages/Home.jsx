import React from 'react';
import {Box} from "../Box.jsx";
import BoxSearch from "../BoxSearch.jsx";
import BoxTopCollections from "../BoxTopCollections.jsx";
import BoxRecentlyItems from "../BoxRecentlyItems.jsx";

const Home = () => {
  return (
      <div className="container mt-5">
        <div className="row">
          <div className="col-sm-4">
            <Box/>
          </div>
          <div className="col-sm-8">
            <div className="row">
              <div className="col-12">
                <BoxSearch/>
              </div>
              <div className="col-12">
                <BoxTopCollections/>
              </div>
              <div className="col-12">
                <BoxRecentlyItems/>
              </div>
            </div>
          </div>
        </div>
      </div>
  );
};

export default Home;