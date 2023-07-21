import React, {useContext, useEffect, useState} from 'react';
import Button from 'react-bootstrap/Button';
import Modal from 'react-bootstrap/Modal';
import ProfileService from "../../API/profile.service.js";
import {AuthContext} from "../../Context/AuthContext.js";
import Collection from "../Collection.jsx";


const MyProfileModalPage = () => {
  const [show, setShow] = useState(false);
  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);
  const {setIsAuth} = useContext(AuthContext);
  const [user, setUser] = useState({
    "id": "",
    "email": "",
    "firstName": "",
    "lastName": ""
  })
  const [userCollections, setUserCollections] = useState([])

  const signOut = () => {
    setIsAuth(false)
    setUser({id: '', email: '', firstName: '', lastName: ''})
    localStorage.removeItem('auth')
    localStorage.removeItem('jwt')
    localStorage.removeItem('id')
  }

  async function fetchProfile() {
    const response = await ProfileService.fetchMyProfile()
    if (response.status === 401 || response.success === false) {
      signOut();
      return;
    }

    setUser({
      id: response.data.id,
      firstName: response.data.firstName,
      lastName: response.data.lastName,
      email: response.data.email
    })

    setUserCollections(response.data.collections)
  }

  useEffect(() => {
    if (localStorage.getItem('jwt') && show === true) {
      fetchProfile().then()
    }
  }, [show])

  return (
      <>
        <Button variant="dark" onClick={handleShow}>
          Profile
        </Button>

        <Modal show={show} size={"lg"} scrollable={true} onHide={handleClose}>
          <Modal.Header closeButton>
            <Modal.Title>Profile</Modal.Title>
          </Modal.Header>

          <Modal.Body>
            <div className='row'>
              <h6>Name: {user.firstName}</h6>
              <h6>Last name: {user.lastName}</h6>
              <h6>Email: {user.email}</h6>
            </div>
            <hr/>
            <div>
              {
                userCollections.map((collection) =>
                    <Collection
                        name={collection.name}
                        isMyProfile={true}
                        refreshModalPage={fetchProfile}
                        count={collection.itemsCount}
                        id={collection.id}
                        key={collection.id}/>
                )
              }
            </div>
          </Modal.Body>

          <Modal.Footer>
            <Button variant="outline-dark" onClick={handleClose}>
              Close
            </Button>
            <Button variant="outline-dark" onClick={handleClose}>
              Save Changes
            </Button>
          </Modal.Footer>
        </Modal>
      </>
  );
};

export default MyProfileModalPage;