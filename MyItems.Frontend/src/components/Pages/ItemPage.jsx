import React, {useEffect, useState} from 'react';
import {Link, useParams} from "react-router-dom";
import CollectionService from "../../API/collection.service.js";
import ItemService from "../../API/item.service.js";

const ItemPage = () => {
  const {id } = useParams()
  const [item, setItem] = useState({})
  const [customPropertyValues, setCustomPropertyValues] = useState([])

  async function getItemById(id){
    const item = await ItemService.getById(id)
    setItem(item)
    setCustomPropertyValues(item.customPropertyValues)
  }

  const handleComment = (e) => {
    e.preventDefault()
  }

  useEffect( () => {
    getItemById(id)
        .catch(console.error)

  }, [])

  return (
      <div className="container mt-5 box section p-3">
        <Link to='/' className="btn btn-dark">Back</Link>
        <hr/>
        <h3>Item</h3>
        <table className="table section">
          <tbody>
          <tr>
            <th scope="row">Name</th>
            <td>{item.name}</td>
          </tr>
          <tr>
            <th scope="row">Collection:</th>
            <td><Link to={`/collection/${item.collectionId}`} className='link-dark link-offset-2-hover'>{item.collectionName}</Link></td>
          </tr>
          <tr>
            <th scope="row">Author:</th>
            <td>
              <Link to={`/profile/${item.authorId}`} className='link-dark link-offset-2-hover'>{item.author}</Link>
            </td>
          </tr>
          <tr>
            <th scope="row">CreatedAt:</th>
            <td>
              {item.createdAt}
            </td>
          </tr>
          {
            customPropertyValues.map((property) => (
                <tr key={property.id}>
                  <th scope="row">
                    {property.customPropertyName}
                    <i style={{fontSize: 13, color: "yellowgreen"}}> {property.customPropertyType}</i>
                  </th>
                  <td>
                    {property.value}
                  </td>
                </tr>
            ))
          }
          </tbody>
        </table>
        <hr/>
        <form onSubmit={handleComment}>
          <div className='d-flex align-items-baseline'>
            <input
                type="text"
                className="form-control searchBox section"
                id="datatable-search-input"
                placeholder="Comment"
            />
            <button type="submit" className="btn btn-dark form-control mx-2 section w-auto">Send</button>
          </div>
        </form>
      </div>
  );
};
export default ItemPage;