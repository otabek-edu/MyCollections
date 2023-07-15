import React from 'react';
import {Box} from "../Box.jsx";
import Search from "../Search.jsx";
import TopCollections from "../TopCollections.jsx";
import RecentlyItems from "../RecentlyItems.jsx";

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
                <Search/>
              </div>
              <div className="col-12">
                <TopCollections/>
              </div>
              <div className="col-12">
                <RecentlyItems/>
              </div>
            </div>
          </div>
        </div>
      </div>
  );
};

export default Home;