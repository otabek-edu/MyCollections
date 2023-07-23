import React, {useEffect, useState} from 'react';
import Button from "react-bootstrap/Button";
import Modal from "react-bootstrap/Modal";
import AdminService from "../../API/admin.service.js";
import login from "../Pages/Login.jsx";
import User from "../User.jsx";
import Loader from "../UI/Loader/Loader.jsx";

const AdminViewModalPage = () => {
  const [show, setShow] = useState(false);
  const [isLoading, setIsLoading] = useState(false)
  const [users, setUsers] = useState([{
    id: '',
    email: '',
    firstName: '',
    lastName: '',
    isAdmin: false,
    isBlocked: false
  }])

  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);

  const getUsers = async () => {
    setIsLoading(true)
    const response = await AdminService.getUsers()
    if (response.data !== undefined && response.success !== 'false') {
      setUsers(response.data)
    }

    console.log(users)
    setIsLoading(false)
  };

  useEffect(() => {
    if (show) {
      getUsers().catch((e) => console.log(e))
    }
  }, [show])

  return (
      <>
        <Button variant="dark" onClick={handleShow}>
          Admin
        </Button>

        <Modal show={show} size={"lg"} scrollable={true} onHide={handleClose}>
          <Modal.Header closeButton>
            <Modal.Title>Admin</Modal.Title>
          </Modal.Header>

          <Modal.Body>
            <h4>User list</h4>
            {
              isLoading
                  ? <Loader/>
                  : <div>
                    {
                      users.map((user) =>
                          <User
                              user={user}
                              users={users}
                              setUsers={setUsers}
                              key={user.id}
                          />
                      )
                    }
                  </div>
            }
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

export default AdminViewModalPage;