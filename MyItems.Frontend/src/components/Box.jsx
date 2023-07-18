import React, {useContext, useEffect, useState} from "react";
import "../main.css";
import {AuthContext} from "../Context/AuthContext.js";
import {Link} from "react-router-dom";
import ProfileService from "../API/profile.service.js";
import MyProfileModalPage from "./Modal/MyProfileModalPage.jsx";
import CreateCollectionModalPage from "./Modal/CreateCollectionModalPage.jsx";

export const Box = () => {
  const {isAuth, setIsAuth, isAdmin} = useContext(AuthContext);
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

  async function fetchProfile() {
    const response = await ProfileService.fetchMyProfile()
    let userResponse = response.data.data
    setUser({
      id: userResponse.id,
      firstName: userResponse.firstName,
      lastName: userResponse.lastName,
      email: userResponse.email
    })
  }

  useEffect(() => {
    if (localStorage.getItem('jwt')) {
      fetchProfile().then()
    }
  }, [])

  return (
      <div className="box section">
        <h3 className="text-center">My collections</h3>
        {
          isAuth ?
              <div className="d-flex justify-content-between">
                <button className="btn btn-dark w-10" onClick={signOut}>Logout</button>
                <MyProfileModalPage/>
                <CreateCollectionModalPage/>
                {
                  isAdmin ? <button className="btn btn-dark w-10" onClick={signOut}>Admin</button> : false
                }
              </div>
              :
              <div className="d-flex justify-content-evenly">
                <Link className="btn btn-dark" to={'/login'}>Login</Link>
                <Link className="btn btn-dark" to={'/register'}>Register</Link>
              </div>
        }
        <hr />
        {
          isAuth ?
              <div className='row'>
                <h6>Name: {user.firstName}</h6>
                <h6>Last name: {user.lastName}</h6>
                <h6>Email: {user.email}</h6>
                <hr/>
              </div>
              :
              <div>
              </div>
        }
      </div>
  );
};
