import React, {useEffect, useState} from 'react';
import Modal from "react-bootstrap/Modal";
import Button from "react-bootstrap/Button";
import Loader from "../UI/Loader/Loader.jsx";
import SearchService from "../../API/search.service.js";

const SearchResultModalPage = ({query, show, handleClose }) => {
  const [isLoading,setIsLoading] = useState(false)

  const searchQuery = async () => {
    setIsLoading(true)

    const collections = await SearchService.fetchSearch(query)
    console.log(collections.data)

    setTimeout(() => {
      setIsLoading(false)
    }, 1000)

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
        <Modal.Header closeButton>
          <Modal.Title id="contained-modal-title-vcenter">
            Search result
          </Modal.Title>
        </Modal.Header>
        <Modal.Body>
          {
            isLoading ? <Loader/> : <p>
              {query}
            </p>
          }
        </Modal.Body>
        <Modal.Footer>
          <Button onClick={handleClose}>Close</Button>
        </Modal.Footer>
      </Modal>
  );
};

export default SearchResultModalPage;