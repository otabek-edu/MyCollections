import React from 'react';
import {Form} from "react-bootstrap";
import Button from "react-bootstrap/Button";

const CollectionFormCustomField = ({customFields, handleChangeCustomField, handleAddCustomField}) => {
  return (
      <>
        {customFields.map((field, index) => (
            <div key={index} className='d-flex'>
              <Form.Group className="mb-3">
                <Form.Label>Custom field name</Form.Label>
                <Form.Control
                    type="text"
                    value={field.name}
                    onChange={(e) => handleChangeCustomField(index, "name", e.target.value)}
                />
              </Form.Group>
              <Form.Group className="mb-3 mx-3">
                <Form.Label>Custom field type</Form.Label>
                <Form.Select
                    value={field.typeProperty}
                    onChange={(e) => handleChangeCustomField(index, "typeProperty", e.target.value)}
                >
                  <option value="string">string</option>
                  <option value="number">number</option>
                  <option value="bool">bool</option>
                </Form.Select>
              </Form.Group>
            </div>
        ))}

        <Button variant="outline-dark" onClick={handleAddCustomField}>
          Add Custom Field
        </Button>
      </>
  );
};

export default CollectionFormCustomField;