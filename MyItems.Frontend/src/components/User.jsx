import React, {useState} from 'react';
import MyLink from "./UI/Link/MyLink.jsx";
import Button from "react-bootstrap/Button";
import Loader from "./UI/Loader/Loader.jsx";
import AdminService from "../API/admin.service.js";

const User = ({user, users, setUsers}) => {
  const [isLoading, setIsLoading] = useState(false)

  const deleteUser = async (user) => {
    setIsLoading(true)

    const response = await AdminService.deleteUser(user.id)
    if (response.success === true) {
      await setUsers(users.filter(p => p.id !== user.id))
    }

    setIsLoading(false)
  }

  const setAdmin = async (user) => {
    setIsLoading(true)

    const response = await AdminService.setAdmin(user.id)
    if (response.success === true) {
      await setUsers((prevUsers) =>
          prevUsers.map((currUser) => {
            if (currUser === user) return {...currUser, isAdmin: true}
            return currUser;
          })
      );
    }

    setIsLoading(false)
  };

  const unSetAdmin = async (user) => {
    setIsLoading(true)

    const response = await AdminService.unSetAdmin(user.id)
    if (response.success === true) {
      await setUsers((prevUsers) =>
          prevUsers.map((currUser) => {
            if (currUser === user) return {...currUser, isAdmin: false}
            return currUser;
          })
      );
    }

    setIsLoading(false)
  };

  const blockUser = async (user) => {
    setIsLoading(true)

    const response = await AdminService.blockUser(user.id)
    if (response.success === true) {
      await setUsers((prevUsers) =>
          prevUsers.map((currUser) => {
            if (currUser === user) return {...currUser, isBlocked: true}
            return currUser;
          })
      );
    }

    setIsLoading(false)
  };

  const unBlockUser = async (user) => {
    setIsLoading(true)

    const response = await AdminService.unBlockUser(user.id)
    if (response.success === true) {
      await setUsers((prevUsers) =>
          prevUsers.map((currUser) => {
            if (currUser === user) return {...currUser, isBlocked: false}
            return currUser;
          })
      );
    }

    setIsLoading(false)
  };

  const handleChangeFieldUser = async (user, field, value) => {
    await setUsers((prevUsers) =>
        prevUsers.map((currUser) => {
          if (currUser === user) return {...currUser, [field]: value}
          return currUser;
        })
    );
  };

  return (
      <div className="card mt-2">
        {
          isLoading
              ? <Loader/>
              : <div className="card-body d-flex justify-content-between align-items-center">
                <div>
                  <MyLink to={`/profile/${user.id}`} value={`${user.lastName} ${user.firstName}`} />
                  <div>
                    <span className="card-subtitle">Email: {user.email}</span> <br/>
                    <span className="card-subtitle">ID: {user.id}</span>
                  </div>
                </div>
                <div className='d-flex gap-2'>
                  <Button onClick={() => deleteUser(user)} variant={"danger"}>Delete</Button>
                  {
                    user.isAdmin
                        ? <Button onClick={() => unSetAdmin(user)} variant={"warning"}>Unset admin</Button>
                        : <Button onClick={() => setAdmin(user)} variant={"info"}>Set admin</Button>
                  }
                  {
                    user.isBlocked
                        ? <Button onClick={() => unBlockUser(user)} variant={"warning"}>Unblock</Button>
                        : <Button onClick={() => blockUser(user)} variant={"secondary"}>Block</Button>
                  }
                </div>
              </div>
        }
      </div>
  );
};

export default User;