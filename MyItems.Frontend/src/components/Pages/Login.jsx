// src/components/Login.js
import React, {useContext, useState} from 'react';
import { Link } from 'react-router-dom';
import axios from "axios";
import CONST from "../../API/CONST.js";
import {AuthContext} from "../../Context/AuthContext.js";
import jwtDecode from "jwt-decode";
import MyLink from "../UI/Link/MyLink.jsx";
import Loader from "../UI/Loader/Loader.jsx";

function Login() {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [error, setError] = useState('');
  const [isLoading, setIsLoading] = useState(false)
  const {setIsAuth, setIsAdmin} = useContext(AuthContext)
  const baseUrl = CONST.API_URL;

  const handleLogin = async (e) => {
    e.preventDefault();

    try {
      setIsLoading(true)
      const response = await axios.post( baseUrl + "/api/account/login",{
        "email": `${email}`,
        "password": `${password}`
      });

      if(response.data.success === false) {
        setError(response.data.message)
      }
      else {

        const decodeToken = jwtDecode(response.data.message)
        const role = decodeToken['http://schemas.microsoft.com/ws/2008/06/identity/claims/role']
        const userId = decodeToken['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier']

        localStorage.setItem("auth", "true")
        localStorage.setItem("jwt", response.data.message)
        localStorage.setItem('id', userId)
        role === 'Admin'
            ? setIsAdmin(true)
            : setIsAdmin(false)

        setIsAuth(true)
      }
    } catch (error) {
      console.error('Error logging in:', error);
    } finally {
      setIsLoading(false)
    }
  };

  return (
      <div className="auth section container mt-5 p-5 justify-content-center d-flex col-6">
        {
          isLoading
            ?  <Loader/>
            :  <div className="row-cols-auto w-75">
                <h1>Login</h1>
                <p style={{color: "red", fontSize: 16, marginBottom: -8, marginTop: 15}}>{error}</p>
                <form onSubmit={handleLogin}>
                  <input
                      type="email"
                      placeholder="Email"
                      className="form-control mt-2"
                      value={email}
                      onChange={(e) => setEmail(e.target.value)}
                  />
                  <input
                      type="password"
                      placeholder="Password"
                      className="form-control mt-2"
                      value={password}
                      onChange={(e) => setPassword(e.target.value)}
                  />
                  <button type="submit" className="btn btn-dark w-25 mt-2">Login</button>
                </form>
                <p>
                  Don't have an account? <MyLink to="/register" value={'Register'}/> <br/>
                  Go to home page <MyLink to="/" value={'Home'} />
                </p>
              </div>
        }
      </div>
  );
}

export default Login;