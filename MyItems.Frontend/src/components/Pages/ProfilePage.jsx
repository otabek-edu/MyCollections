import React, {useEffect, useState} from 'react';
import {Link, useParams} from "react-router-dom";
import ItemService from "../../API/item.service.js";
import CollectionService from "../../API/collection.service.js";
import ProfileService from "../../API/profile.service.js";
import Collection from "../Collection.jsx";

const ProfilePage = () => {
  const {id } = useParams()
  const [user, setUser] = useState({})
  const [collections, setCollections] = useState([])

  async function getCollectionsByUserId(id){
    const user = await ProfileService.fetchProfileByUserId(id)
    console.log(user)
    setUser(user)
    setCollections(user.collections)
  }

  useEffect( () => {
    getCollectionsByUserId(id)
        .catch(console.error)
  }, [])

  return (
      <div className="container mt-5 collectionBox section p-3">
        <Link to='/' className="btn btn-dark">Back</Link>
        <hr/>
        <h4>User</h4>
        <table className="table section">
          <tbody>
          <tr>
            <th scope="row">First name</th>
            <td>{user.firstName}</td>
          </tr>
          <tr>
            <th scope="row">Last name:</th>
            <td>{user.lastName}</td>
          </tr>
          <tr>
            <th scope="row">Email:</th>
            <td>
              {user.email}
            </td>
          </tr>
          </tbody>
        </table>
        <hr/>

        <h4>User collections</h4>
          {
            collections.map((post) =>
                <Collection name={post.name} count={post.itemsCount} id={post.id} key={post.id}/>
            )
          }
      </div>
  );
};
export default ProfilePage;