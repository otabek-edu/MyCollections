import React, {useContext, useEffect, useState} from 'react';
import Button from 'react-bootstrap/Button';
import Modal from 'react-bootstrap/Modal';
import ProfileService from "../../API/profile.service.js";
import {AuthContext} from "../../Context/AuthContext.js";


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

  const signOut = () => {
    setIsAuth(false)
    setUser({})
    localStorage.removeItem('auth')
    localStorage.removeItem('jwt')
  }

  useEffect(() => {
    async function fetchProfile() {
      const response = await ProfileService.fetchMyProfile()
      if (response.status === 401) {
        signOut();
        return;
      }
      let userResponse = response.data.data
      setUser({
        id: userResponse.id,
        firstName: userResponse.firstName,
        lastName: userResponse.lastName,
        email: userResponse.email
      })
    }

    if (localStorage.getItem('jwt')) {
      fetchProfile().then()
    }
  }, [])

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
              <hr/>
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