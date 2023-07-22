import CONST from "./CONST.js";
import axios from "axios";

export default class ProfileService {
  static baseUrl = CONST.API_URL;

  static async fetchMyProfile() {
    try {
      const response = await axios.get( this.baseUrl + "/api/profile", {
        headers: {
          Authorization: "Bearer " + localStorage.getItem('jwt')
        }
      })
      return response.data;
    } catch (error) {
       if (error.request.status === 0) {
         return {'status': 401}
       }
    }
  }

  static async fetchProfileByUserId(id) {
    try {
      const response = await axios.get( this.baseUrl + `/api/profile/${id}`);
      console.log('test fetch')
      return response.data.data;
    } catch (error) {
      if (error.request.status === 0) {
        return {'status': 401}
      }
    }
  }
}