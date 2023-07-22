import React, {useState} from 'react';
import Button from "react-bootstrap/Button";
import Modal from "react-bootstrap/Modal";
import {Form} from "react-bootstrap";
import CollectionFormBasic from "../CollectionFormBasic.jsx";
import CollectionFormCustomField from "../CollectionFormCustomField.jsx";
import collection from "../Collection.jsx";
import CollectionService from "../../API/collection.service.js";
import ResultModalPage from "./ResultModalPage.jsx";
import Loader from "../UI/Loader/Loader.jsx";

const CreateCollectionModalPage = () => {
  const [show, setShow] = useState(false);
  const [customFields, setCustomFields] = useState([]);
  const [isLoading, setIsLoading] = useState(false)
  const [collectionData, setCollectionData] = useState({
    name: "",
    description: "",
    theme: "",
    imageUrl: "",
    customProperties: [{}]
  });

  const handleCreate = async () => {
    setIsLoading(true)
    collectionData.customProperties = customFields;
    const response = await CollectionService.createCollection(collectionData)
    if (response.success === true) {
      handleClose();
    }

    setIsLoading(false)
  };

  const handleAddCustomField = () => {
    setCustomFields((prevFields) => [
      ...prevFields,
      { name: "", typeProperty: "string" },
    ]);
  };

  const handleChangeCustomField = (index, field, value) => {
    setCustomFields((prevFields) =>
        prevFields.map((item, i) => (i === index ? { ...item, [field]: value } : item))
    );
  };

  const handleChange = (e) => {
    const { name, value } = e.target;
    setCollectionData((prevData) => ({
      ...prevData,
      [name]: value,
    }));
  };

  const handleShow = () => setShow(true);

  const handleClose = () => {
    setCustomFields([])
    setCollectionData({name: "", theme: "", description: "", imageUrl: "", customProperties: []})
    setShow(false)
    return (
        <ResultModalPage setView={true}/>
    )
  };

  return (
      <>
        <Button variant="dark" onClick={handleShow}>
          Create
        </Button>

        <Modal show={show} size={"lg"} scrollable={true} onHide={handleClose}>
          <Modal.Header closeButton>
            <Modal.Title>Create collection</Modal.Title>
          </Modal.Header>
          {
            isLoading
              ? <Loader/>
                :
                <>
                  <Modal.Body>
                    <Form>
                      <CollectionFormBasic
                          collectionData={collectionData}
                          handleChange={handleChange}
                      />
                      <CollectionFormCustomField
                          customFields={customFields}
                          handleAddCustomField={handleAddCustomField}
                          handleChangeCustomField={handleChangeCustomField}
                      />
                    </Form>
                  </Modal.Body>
                  <Modal.Footer>
                    <Button variant="outline-dark" onClick={handleClose}>
                      Close
                    </Button>
                    <Button variant="outline-dark" onClick={handleCreate}>
                      Create
                    </Button>
                  </Modal.Footer>
                </>
          }
        </Modal>
      </>
  );
};

export default CreateCollectionModalPage;