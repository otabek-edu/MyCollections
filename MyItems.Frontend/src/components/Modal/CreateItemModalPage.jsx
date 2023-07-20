import React, { useState } from 'react';
import Modal from "react-bootstrap/Modal";
import Button from "react-bootstrap/Button";
import { Form } from "react-bootstrap";
import {formToJSON} from "axios";
import ItemService from "../../API/item.service.js";

const CreateItemModalPage = ({ collection, refreshmPage}) => {
  const [show, setShow] = useState(false);
  const [itemData, setItemData] = useState({
    name: "",
    collectionId: collection.id,
    customPropertyValues: collection.customProperties.map((property) => ({
      customPropertyId: property.id,
      value: property.typeProperty === "bool" ? "false" : "",
    })),
  });

  const handleShow = () => setShow(true);
  const handleClose = () => {
    setShow(false)
    refreshmPage();
  };

  const handleCreate = async () => {
    const response = await ItemService.createItem(itemData)
    console.log(response)
    console.log(itemData);

    handleClose();
  }

  const handleItemNameChange = (e) => {
    setItemData({ ...itemData, name: e.target.value });
  };

  const handleCustomPropertyValueChange = (customPropertyId, value) => {
    setItemData((prevData) => ({
      ...prevData,
      customPropertyValues: prevData.customPropertyValues.map((item) =>
          item.customPropertyId === customPropertyId ? { ...item, value } : item
      ),
    }));
  };

  return (
      <div>
        <Button variant="dark" onClick={handleShow}>
          Create item
        </Button>

        <Modal size="lg" scrollable show={show} onHide={handleClose}>
          <Modal.Header closeButton>
            <Modal.Title>Create item</Modal.Title>
          </Modal.Header>
          <Modal.Body>
            <Form>
              <Form.Group className="mb-3">
                <Form.Label>Item Name</Form.Label>
                <Form.Control
                    type="text"
                    placeholder="Enter item name"
                    value={itemData.name}
                    onChange={handleItemNameChange}
                />
              </Form.Group>
              <div>
                <strong>Custom Properties:</strong>
                {collection.customProperties.map((property) => (
                    <Form.Group
                        key={property.id}
                        className="mb-3 d-flex align-items-center"
                    >
                      <Form.Label>{property.name}</Form.Label>
                      {property.typeProperty === "string" && (
                          <Form.Control
                              type="text"
                              value={itemData.customPropertyValues.find(
                                  (item) => item.customPropertyId === property.id
                              ).value}
                              onChange={(e) =>
                                  handleCustomPropertyValueChange(property.id, e.target.value)
                              }
                          />
                      )}
                      {property.typeProperty === "number" && (
                          <Form.Control
                              type="number"
                              value={itemData.customPropertyValues.find(
                                  (item) => item.customPropertyId === property.id
                              ).value}
                              onChange={(e) =>
                                  handleCustomPropertyValueChange(property.id, e.target.value)
                              }
                          />
                      )}
                      {property.typeProperty === "bool" && (
                          <Form.Select
                              value={itemData.customPropertyValues.find(
                                  (item) => item.customPropertyId === property.id
                              ).value}
                              onChange={(e) =>
                                  handleCustomPropertyValueChange(property.id, e.target.value)
                              }
                          >
                            <option value="false">false</option>
                            <option value="true">true</option>
                          </Form.Select>
                      )}
                    </Form.Group>
                ))}
              </div>
            </Form>
          </Modal.Body>
          <Modal.Footer>
            <Button variant="dark" onClick={handleClose}>
              Close
            </Button>
            <Button variant="dark" onClick={handleCreate}>
              Create
            </Button>
          </Modal.Footer>
        </Modal>
      </div>
  );
};

export default CreateItemModalPage;
