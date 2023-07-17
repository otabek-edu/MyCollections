import React, {useContext} from "react";
import "../main.css";
import {AuthContext} from "../Context/AuthContext.js";
import {Link} from "react-router-dom";

export const Box = () => {
  const {isAuth, setIsAuth} = useContext(AuthContext);

  const signOut = () => {
    setIsAuth(false);
    localStorage.removeItem('auth')
  }

  return (
      <div className="box section">
        <h3 className="text-center">My collections</h3>
        {
          isAuth ?
              <button className="btn btn-dark" onClick={signOut}>Logout</button>
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
