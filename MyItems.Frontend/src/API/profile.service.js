import CONST from "./CONST.js";
import axios from "axios";

export default class ProfileService {
  static baseUrl = CONST.API_URL;
  static jwt = localStorage.getItem('jwt');

  static async fetchMyProfile() {
    this.jwt = localStorage.getItem('jwt');
    try {
      const response = await axios.get( this.baseUrl + "/api/profile", {
        headers: {
          Authorization: "Bearer " + this.jwt
        }
      })
      return response;
    } catch (error) {
       if (error.request.status === 0) {
         return {'status': 401}
       }
    }
  }

  static async fetchProfileByUserId(id) {
    try {
      const response = await axios.get( this.baseUrl + `/api/profile/${id}`);
      return response.data.data;
    } catch (error) {
      if (error.request.status === 0) {
        return {'status': 401}
      }
    }
  }
}