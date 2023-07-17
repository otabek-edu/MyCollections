import React, {useEffect, useState} from 'react';
import Collection from "./Collection.jsx";
import axios from "axios";
import collection from "./Collection.jsx";

const TopCollections = () => {

  const [collections, setCollections] = useState([]);
  const baseUrl = import.meta.env.VITE_KEY;

  async function fetchCollections() {
    const response = await axios.get( baseUrl + "/api/home/top");
    setCollections(response.data.data)
  }

  useEffect(() =>{
    fetchCollections().then(r => console.log("success"))
  }, [])

  return (
      <div className="topCollections section ps-3 pt-2 pe-3 pb-3">
        <h4>Top 5 collections</h4>
        {collections.map((post) =>
            <Collection name={post.name} count={post.items.length} key={post.id}/>
        )}
      </div>
  );
};

export default TopCollections;