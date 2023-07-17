import React, {useContext, useEffect, useState} from 'react';
import {BrowserRouter, Navigate, Route, Routes} from "react-router-dom";
import Home from "./components/Home/Home.jsx";
import Login from "./components/Auth/Login.jsx";
import Register from "./components/Auth/Register.jsx";
import {AuthContext} from "./Context/AuthContext.js";

const App = () => {
  const [isAuth, setIsAuth] = useState(false);

  useEffect(() => {
    if (localStorage.getItem('auth')) {
      setIsAuth(true)
    }
  }, [])

  return (
      <AuthContext.Provider value={
        {isAuth, setIsAuth}
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
          </Routes> }
        </BrowserRouter>
      </AuthContext.Provider>
  );
};

export default App;