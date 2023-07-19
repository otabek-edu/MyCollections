import React from "react";
import { Form } from "react-bootstrap";

const CollectionFormBasic = ({ collectionData, handleChange }) => {
  return (
      <>
        <Form.Group className="mb-3">
          <Form.Label>Collection name</Form.Label>
          <Form.Control
              type="textarea"
              name="name"
              placeholder="Collection name"
              autoFocus
              value={collectionData.name}
              onChange={handleChange}
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label>Description</Form.Label>
          <Form.Control
              as="textarea"
              rows={1}
              name="description"
              value={collectionData.description}
              onChange={handleChange}
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label>Theme</Form.Label>
          <Form.Control
              type="textarea"
              name="theme"
              placeholder="Collection theme"
              value={collectionData.theme}
              onChange={handleChange}
          />
        </Form.Group>

        <Form.Group className="mb-3">
          <Form.Label>Image url</Form.Label>
          <Form.Control
              type="textarea"
              name="imageUrl"
              placeholder="Image url"
              value={collectionData.imageUrl}
              onChange={handleChange}
          />
        </Form.Group>
      </>
  );
};

export default CollectionFormBasic;
