import React, {useEffect, useState} from 'react';
import Modal from "react-bootstrap/Modal";
import {Form} from "react-bootstrap";
import CollectionFormBasic from "../CollectionFormBasic.jsx";
import CollectionFormCustomField from "../CollectionFormCustomField.jsx";
import Button from "react-bootstrap/Button";

const ResultModalPage = ({setView}) => {
  const [show, setShow] = useState(false)
  const handleClose = () => {
    setShow(false)
  };

  useEffect(() => {
    setShow(setView)
  }, [])

  return (
      <>
        <Modal show={show} size={"lg"} scrollable={true} onHide={handleClose}>
          <Modal.Header closeButton>
            <Modal.Title>Result</Modal.Title>
          </Modal.Header>

          <Modal.Body>

          </Modal.Body>

          <Modal.Footer>
            <Button variant="outline-dark" onClick={handleClose}>
              Close
            </Button>
          </Modal.Footer>
        </Modal>
      </>
  );
};

export default ResultModalPage;