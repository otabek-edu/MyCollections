import React, {useEffect, useState} from 'react';
import Collection from "./Collection.jsx";
import axios from "axios";
import HomeService from "../API/home.service.js";

const BoxTopCollections = () => {
  const [collections, setCollections] = useState([]);

  async function fetchCollections() {
    const response = await HomeService.fetchTopCollections();
    setCollections(response.data.data)
  }

  useEffect(() =>{
    fetchCollections().then()
  }, [])

  return (
    <div className="topCollections section ps-3 pt-2 pe-3 pb-3">
      <h4>Top 5 collections</h4>
      {collections.map((post) =>
          <Collection name={post.name} count={post.itemsCount} id={post.id} key={post.id}/>
      )}
    </div>
  );
};

export default BoxTopCollections;