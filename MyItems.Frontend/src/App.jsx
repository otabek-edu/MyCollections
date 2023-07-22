import React, {useEffect, useState} from 'react';
import {BrowserRouter, Navigate, Route, Routes} from "react-router-dom";
import {AuthContext} from "./Context/AuthContext.js";
import {ThemeContext} from "./Context/ThemeContext.js";
import Home from "./components/Pages/Home.jsx";
import Login from "./components/Pages/Login.jsx";
import Register from "./components/Pages/Register.jsx";
import CollectionPage from "./components/Pages/CollectionPage.jsx";
import ItemPage from "./components/Pages/ItemPage.jsx";
import ProfilePage from "./components/Pages/ProfilePage.jsx";

const App = () => {
  const [isAuth, setIsAuth] = useState(false);
  const [isAdmin, setIsAdmin] = useState(false);
  const [theme, setTheme] = useState('light')

  useEffect(() => {
    const localTheme = localStorage.getItem('theme')
    if (localTheme === 'dark') {
      body.setAttribute('class', 'bg-dark')
      setTheme('dark')
    } else {
      body.setAttribute('class', '')
      setTheme('light')
    }

    if (localStorage.getItem('auth')) {
      setIsAuth(true)
      localStorage.getItem('isAdmin') === 'true' ? setIsAdmin(true) : setIsAdmin(false)
    }
  }, [])

  return (
    <ThemeContext.Provider value={
      {theme, setTheme, body: body}
    }>
      <AuthContext.Provider value={
        {isAuth, setIsAuth, isAdmin, setIsAdmin}
      }>
        <div id={theme} data-bs-theme={theme} >
          <BrowserRouter id={theme}>
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
        </div>
      </AuthContext.Provider>
  </ThemeContext.Provider>
  );
};

export default App;