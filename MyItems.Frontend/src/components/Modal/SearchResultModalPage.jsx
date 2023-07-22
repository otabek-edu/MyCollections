import React, {useEffect, useState} from 'react';
import Modal from "react-bootstrap/Modal";
import Button from "react-bootstrap/Button";
import Loader from "../UI/Loader/Loader.jsx";
import SearchService from "../../API/search.service.js";
import {getUID} from "bootstrap/js/src/util/index.js";
import Collection from "../Collection.jsx";
import Item from "../Item.jsx";
import SimpleItem from "../SimpleItem.jsx";

const SearchResultModalPage = ({query, show, handleClose }) => {
  const [isLoading,setIsLoading] = useState(false)
  const [collections, setCollections] = useState([{
    id: '',
    name: '',
    description: '',
    itemsCount: ''
  }])
  const [items, setItems] = useState([{
    id: '',
    name: ''
  }])

  const searchQuery = async () => {
    setIsLoading(true)

    const response = await SearchService.fetchSearch(query)
    setCollections(response.data.collections)
    setItems(response.data.items)

    setIsLoading(false)
  };

  useEffect(() => {
    if (query !== '' && query !== undefined) {
      searchQuery()
          .catch((e) => console.log(e))
    }
  }, [show])

  return (
        <Modal
            show={show}
            size="lg"
        >
          <Modal.Header>
            <Modal.Title id="contained-modal-title-vcenter">
              Search result
            </Modal.Title>
          </Modal.Header>
          <Modal.Body>
            {
              isLoading
                  ?
                  <Loader/>
                  :
                  <div>
                    {collections.map((collection) =>
                        <Collection name={collection.name} id={collection.id} count={collection.itemsCount} key={collection.id}/>
                    )}
                    {items.map((item) =>
                        <SimpleItem id={item.id} name={item.name}  key={item.id}/>
                    )}
                  </div>
            }
          </Modal.Body>
          <Modal.Footer>
            <Button variant={"dark"} onClick={handleClose}>Close</Button>
          </Modal.Footer>
        </Modal>
  );
};

export default SearchResultModalPage;