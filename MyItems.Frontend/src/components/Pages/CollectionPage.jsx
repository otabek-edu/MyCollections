import React, {useContext, useEffect, useState} from 'react';
import {Link, useNavigate, useParams} from "react-router-dom";
import CollectionService from "../../API/collection.service.js";
import CreateItemModalPage from "../Modal/CreateItemModalPage.jsx";
import Loader from "../UI/Loader/Loader.jsx";

const CollectionPage = () => {
  const {id } = useParams()
  const [collection, setCollection] = useState({
    name: '',
    description: '',
    theme: '',
    author: '',
    imageUrl: '',
    customProperties: [{}]
  })
  const navigate = useNavigate();
  const [items, setItems] = useState([])
  const [customProperty, setCustomProperty] = useState([])
  const [isLoadingCollection,setIsLoadingCollection] = useState(false)

  async function getCollectionById(){
    setIsLoadingCollection(true)

    const collection = await CollectionService.getById(id)
    if (collection === undefined) {
      return navigate('/');
    }
    setCollection(collection)
    setItems(collection.items)
    setCustomProperty(collection.customProperties)
    setIsLoadingCollection(false)

  }

  useEffect( () => {
    getCollectionById().then()
  }, [])

  async function deleteItem(itemId) {
    setIsLoadingCollection(true)

    console.log(itemId)

    setIsLoadingCollection(false)
  }

  return (
      <div className="container mt-5 collectionBox section p-3">
        {
          isLoadingCollection
              ? <Loader/>
              :
              <div className='d-flex'>
                <Link to='/' className="btn btn-dark mx-2">Back</Link>
                {
                  collection.userId === localStorage.getItem('id')
                      ? <CreateItemModalPage
                          collection={collection}
                          refreshmPage={getCollectionById}
                      /> : false
                }
              </div>
        }

        <hr/>
        <h3>Collection</h3>

        <div className="d-flex w-auto h-auto">
          <div>
            <table className="table section" style={{width: 600}}>
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
                  <Link to={`/profile/${collection.userId}`}
                        className='link-dark link-offset-2-hover'>{collection.author}</Link>
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
            {customProperty
                .sort((a, b) => a.id.localeCompare(b.id))
                .map((property) => (
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
                <td>{item.createdAt.slice(0, 10)}</td>
                {item.customPropertyValues
                    .sort((a, b) => a.customPropertyId.localeCompare(b.customPropertyId))
                    .map((value) => (
                    <td key={value.id}>
                      {value ? value.value : ""}
                    </td>
                ))}

                {
                  collection.userId === localStorage.getItem('id')
                      ?
                      <td>
                        <button onClick={() => deleteItem(item.id)} className='btn btn-danger'>Delete</button>
                      </td> : false
                }
              </tr>
          ))}
          </tbody>
        </table>
      </div>
  );


};

export default CollectionPage;