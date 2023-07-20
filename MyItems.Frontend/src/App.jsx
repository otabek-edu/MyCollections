import React, {useContext, useEffect, useState} from 'react';
import {BrowserRouter, Navigate, Route, Routes} from "react-router-dom";
import Home from "./components/Pages/Home.jsx";
import Login from "./components/Pages/Login.jsx";
import Register from "./components/Pages/Register.jsx";
import {AuthContext} from "./Context/AuthContext.js";
import CollectionPage from "./components/Pages/CollectionPage.jsx";
import ItemPage from "./components/Pages/ItemPage.jsx";
import ProfilePage from "./components/Pages/ProfilePage.jsx";
import jwtDecode from "jwt-decode";
import Loader from "./components/UI/Loader/Loader.jsx";

const App = () => {
  const [isAuth, setIsAuth] = useState(false);
  const [isAdmin, setIsAdmin] = useState(false);
  const [isLoading, setIsLoading] = useState(true)

  useEffect(() => {
    if (localStorage.getItem('auth')) {
      setIsAuth(true)
      let decodeToken = jwtDecode(localStorage.getItem('jwt'))
      if (decodeToken["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"] === 'Admin') {
        setIsAdmin(true)
      }
    }

    setIsLoading(false)
  }, [])

  if(isLoading) {
    return <Loader/>
  }

  return (
      <AuthContext.Provider value={
        {isAuth, setIsAuth, isAdmin, setIsAdmin, isLoading, setIsLoading}
      }>
        <BrowserRouter>
          {isAuth ?
          <Routes>
            <Route path="/" element={<Home/>}  />
            <Route path="/collection/:id" element={<CollectionPage/>}/>
            <Route path="/item/:id" element={<ItemPage/>}/>
            <Route path="/profile/:id" element={<ProfilePage/>}/>
            <Route
                path="*"
                element={<Navigate to="/" replace />}
            />
          </Routes>
          :
          <Routes>
            <Route path="/" element={<Home/>}  />
            <Route path="/collection/:id" element={<CollectionPage/>}/>
            <Route path="/item/:id" element={<ItemPage/>}/>
            <Route path="/profile/:id" element={<ProfilePage/>}/>
            <Route path="/login" element={<Login/>} />
            <Route path="/register" element={<Register/>} />
            <Route
                path="*"
                element={<Navigate to="/" replace />}
            />
          </Routes> }
        </BrowserRouter>
      </AuthContext.Provider>
  );
};

export default App;