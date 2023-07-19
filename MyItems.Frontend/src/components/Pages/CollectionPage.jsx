import React, {useEffect, useState} from 'react';
import {Link, useParams} from "react-router-dom";
import CollectionService from "../../API/collection.service.js";

const CollectionPage = () => {
  const {id } = useParams()
  const [collection, setCollection] = useState({})
  const [items, setItems] = useState([])
  const [customProperty, setCustomProperty] = useState([])

  useEffect( () => {
    async function getCollectionById(id){
      const collection = await CollectionService.getById(id)
      setCollection(collection)
      setItems(collection.items)
      setCustomProperty(collection.customProperties)
      console.log(collection)
    }

    getCollectionById(id).catch(console.error)

  }, [])

  return (
      <div className="container mt-5 collectionBox section p-3">
        <Link to='/' className="btn btn-dark">Back</Link>
        <hr/>
          <h3>Collection</h3>
        <div className="d-flex">
          <div>
            <table className="table section">
              <tbody>
              <tr>
                <th scope="row">Name</th>
                <td>{collection.name}</td>
              </tr>
              <tr>
                <th scope="row">Description:</th>
                <td>{collection.description}</td>
              </tr>
              <tr>
                <th scope="row">Theme:</th>
                <td>{collection.theme}</td>
              </tr>
              <tr>
                <th scope="row">Author:</th>
                <td>
                  <Link to={`/profile/${collection.userId}`} className='link-dark link-offset-2-hover'>{collection.author}</Link>
                </td>
              </tr>
              </tbody>
            </table>
          </div>
          <div>
            <img src={collection.imageUrl} className='rounded float-end section w-75 h-75' alt=""/>
          </div>
        </div>

        <hr/>

        <table className="table section">
          <thead>
          <tr>
            <th>#</th>
            <th>Name</th>
            <th>CreatedAt</th>
            {customProperty.map((property) => (
                <th key={property.id}>{property.name}</th>
            ))}
          </tr>
          </thead>
          <tbody>
          {items.map((item, index) => (
              <tr key={item.id}>
                <th scope="row">{index + 1}</th>
                <td>
                  <Link to={`/item/${item.id}`} className="link-dark">{item.name}</Link>
                </td>
                <td>{item.createdAt.slice(0,10)}</td>
                {item.customPropertyValues.map((value) => (
                    <td key={value.id}>
                      {value.value}
                    </td>
                ))}
              </tr>
          ))}
          </tbody>
        </table>
      </div>
  );
};

export default CollectionPage;