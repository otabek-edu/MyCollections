import React, {useContext} from "react";
import "../main.css";
import {AuthContext} from "../Context/AuthContext.js";
import {Link} from "react-router-dom";
import MyProfileModalPage from "./Modal/MyProfileModalPage.jsx";
import CreateCollectionModalPage from "./Modal/CreateCollectionModalPage.jsx";
import AdminViewModalPage from "./Modal/AdminViewModalPage.jsx";
import ReactSwitch from "react-switch";
import {ThemeContext} from "../Context/ThemeContext.js";

export const Box = () => {
  const {isAuth, setIsAuth, isAdmin} = useContext(AuthContext);
  const {theme, setTheme, body} = useContext(ThemeContext)

  const signOut = () => {
    setIsAuth(false)
    localStorage.removeItem('auth')
    localStorage.removeItem('jwt')
    localStorage.removeItem('id')
    localStorage.removeItem('isAdmin')
  }

  function toggleTheme() {
    if (theme === "light") {
      setTheme('dark')
      body.setAttribute('class', 'bg-dark')
      localStorage.setItem('theme', 'dark')
    }
    else {
      setTheme('light')
      body.setAttribute('class', '')
      localStorage.setItem('theme', 'light')
    }
  }

  return (
      <div className="box section">
        <h3 className="text-center">My collections</h3>
        {
          isAuth ?
              <div className="d-flex flex-sm-wrap justify-content-between">
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
        <div className='d-flex justify-content-evenly'>
          <label> {theme === "light" ? "Light Mode" : "Dark Mode"}</label>
          <ReactSwitch
              checkedIcon={false}
              uncheckedIcon={false}
              onChange={toggleTheme}
              checked={theme === "dark"}/>
        </div>
        <hr/>
      </div>
  );
};
