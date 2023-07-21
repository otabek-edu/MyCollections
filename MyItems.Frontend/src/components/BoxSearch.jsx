import React, {useState} from 'react';
import SearchResultModalPage from "./Modal/SearchResultModalPage.jsx";
import {useAccordionButton} from "react-bootstrap";

const BoxSearch = () => {
  const [modalShow, setModalShow] = React.useState(false);
  const [query,setQuery] = useState('')

  const searchFunc = async (e) => {
    e.preventDefault()

  };

  const handleClose = () => {
    setQuery('')
    setModalShow(false)
  }

  return (
      <div>
        <form action="" onSubmit={searchFunc} className='d-flex align-items-baseline'>
          <input
              type="search"
              className="form-control searchBox section"
              id="datatable-search-input"
              value={query}
              onChange={(e) => setQuery(e.target.value)}
              placeholder="Search"
          />
          <button
              onClick={() => query === '' ? false : setModalShow(true)}
              className='btn btn-dark ms-2'
          >
            Search
          </button>
        </form>

        <SearchResultModalPage
            show={modalShow}
            setModalShow={setModalShow}
            query={query}
            handleClose={handleClose}
        />
      </div>
  );
};

export default BoxSearch;