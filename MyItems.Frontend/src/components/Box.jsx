import React, {useContext} from "react";
import "../main.css";
import {AuthContext} from "../Context/AuthContext.js";
import {Link} from "react-router-dom";
import MyProfileModalPage from "./Modal/MyProfileModalPage.jsx";
import CreateCollectionModalPage from "./Modal/CreateCollectionModalPage.jsx";
import AdminViewModalPage from "./Modal/AdminViewModalPage.jsx";

export const Box = () => {
  const {isAuth, setIsAuth, isAdmin} = useContext(AuthContext);

  const signOut = () => {
    setIsAuth(false)
    localStorage.removeItem('auth')
    localStorage.removeItem('jwt')
  }

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
                  isAdmin ? <AdminViewModalPage/> : false
                }
              </div>
              :
              <div className="d-flex justify-content-evenly">
                <Link className="btn btn-dark" to={'/login'}>Login</Link>
                <Link className="btn btn-dark" to={'/register'}>Register</Link>
              </div>
        }
        <hr />
      </div>
  );
};
