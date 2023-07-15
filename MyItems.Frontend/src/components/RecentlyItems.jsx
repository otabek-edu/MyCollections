import React, {useEffect, useState} from 'react';
import Item from "./Item.jsx";
import axios from "axios";
import collection from "./Collection.jsx";

const RecentlyItems = () => {
  const [items, setItem] = useState([]);
  const baseUrl = import.meta.env.VITE_KEY;

  useEffect(() => {
    fetchItems().then(() => console.log("success"))

  }, [])

  async function fetchItems() {
    const response = await axios.get(baseUrl + '/api/home/recent');
    setItem(response.data.data);
    console.log(response.data.data);

  }
  
  return (
      <div className="recentlyItems ps-3 pt-2 pe-3 pb-3">
        <h4>Recently items</h4>
        {items.map((item) =>
          <Item name={item.name} collection={item.collectionId} author={item.id}/>
        )}
      </div>
  );
};

export default RecentlyItems;