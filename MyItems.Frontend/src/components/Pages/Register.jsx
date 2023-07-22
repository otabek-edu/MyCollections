import React, {useState} from 'react';
import axios from "axios";
import CONST from "../../API/CONST.js";
import MyLink from "../UI/Link/MyLink.jsx";
import Loader from "../UI/Loader/Loader.jsx";

function Register() {
  const [success, setSuccess] = useState('');
  const [error, setError] = useState('');
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [firstName, setFirstName] = useState('');
  const [lastName, setLastName] = useState('');
  const [isLoading, setIsLoading] = useState(false)


  let baseUrl = CONST.API_URL;

  const handleRegister = async (e) => {
    e.preventDefault();

    try {
      setIsLoading(true)
      const response = await axios.post( baseUrl + "/api/account/register",{
        "email": `${email}`,
        "password": `${password}`,
        "firstName": `${firstName}`,
        "lastName": `${lastName}`
      });

      if(response.data.success === false) {
        console.log(response.data.message)
        setError(response.data.message)
      }
      else {
        console.log(response.data)
        setSuccess(response.data.message)
        setError('')
        setPassword('')
        setLastName('')
        setFirstName('')
      }
    } catch (error) {
      console.error('Error registering:', error);
    } finally {
      setIsLoading(false)
    }
  };

  return (
      <div className="auth section container mt-5 p-5 justify-content-center d-flex col-6">
        {
          isLoading
            ? <Loader/>
            : <div className="row">
                <h1>Register</h1>
                <p style={{color: "red", fontSize: 16, marginBottom: -8, marginTop: 15}}>{error}</p>
                <p style={{color: "green", fontSize: 16, marginBottom: -8, marginTop: 15}}>{success}</p>
                <form onSubmit={handleRegister}>
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
                  <input
                      type="text"
                      placeholder="First name"
                      className="form-control mt-2"
                      value={firstName}
                      onChange={(e) => setFirstName(e.target.value)}
                  />
                  <input
                      type="text"
                      placeholder="Last name"
                      className="form-control mt-2"
                      value={lastName}
                      onChange={(e) => setLastName(e.target.value)}
                  />
                  <button type="submit" className="btn btn-dark w-25 mt-2">Register</button>
                </form>
                <p>
                  Already have an account? <MyLink to="/login" value={'Login'} /><br/>
                  Go to home page <MyLink to="/" value={'Home'} />
                </p>
              </div>
        }
      </div>
  );
}

export default Register;
