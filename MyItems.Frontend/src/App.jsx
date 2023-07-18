import React, {useContext, useEffect, useState} from 'react';
import {BrowserRouter, Navigate, Route, Routes} from "react-router-dom";
import Home from "./components/Pages/Home.jsx";
import Login from "./components/Pages/Login.jsx";
import Register from "./components/Pages/Register.jsx";
import {AuthContext} from "./Context/AuthContext.js";

const App = () => {
  const [isAuth, setIsAuth] = useState(false);
  const [isAdmin, setIsAdmin] = useState(false);

  useEffect(() => {
    if (localStorage.getItem('auth')) {
      setIsAuth(true)
    }
  }, [])

  return (
      <AuthContext.Provider value={
        {isAuth, setIsAuth, isAdmin, setIsAdmin}
      }>
        <BrowserRouter>
          {isAuth ?
          <Routes>
            <Route path="/" element={<Home/>}  />
            <Route
                path="*"
                element={<Navigate to="/" replace />}
            />
          </Routes>
          :
          <Routes>
            <Route path="/" element={<Home/>}  />
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