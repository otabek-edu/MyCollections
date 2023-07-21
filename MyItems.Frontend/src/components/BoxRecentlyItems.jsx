import React, {useEffect, useState} from 'react';
import Item from "./Item.jsx";
import HomeService from "../API/home.service.js";
import Loader from "./UI/Loader/Loader.jsx";
import {map} from "react-bootstrap/ElementChildren";

const BoxRecentlyItems = () => {
  const [items, setItem] = useState([]);
  const [isLoading,setIsLoading] = useState(false)

  async function fetchItems() {
    setIsLoading(true)
    const response = await HomeService.fetchRecentlyItems()
    setItem(response.data.data);
    setIsLoading(false)
  }

  useEffect(() => {
    fetchItems().then()

  }, [])
  
  return (
      <div className="recentlyItems section ps-3 pt-2 pe-3 pb-3">
        <h4>Recently items</h4>
        {
          isLoading
              ? <Loader/>
              :
              <>
                {items.map((item) =>
                    <Item
                        name={item.name}
                        itemId={item.id}
                        collectionName={item.collectionName}
                        collectionId={item.collectionId}
                        author={item.author}
                        authorId={item.authorId}
                        key={item.id}/>
                )}
              </>
        }

      </div>
  );
};

export default BoxRecentlyItems;