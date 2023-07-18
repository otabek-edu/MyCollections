import CONST from "./CONST.js";
import axios from "axios";

export default class ProfileService {
  static baseUrl = CONST.API_URL;
  static jwt = localStorage.getItem('jwt');

  static async fetchMyProfile() {
    this.jwt = localStorage.getItem('jwt');
    const response = await axios.get( this.baseUrl + "/api/profile", {
      headers: {
        Authorization: "Bearer " + this.jwt
      }
    });
    return response;
  }

  static async fetchRecentlyItems() {
    const response = await axios.get(this.baseUrl + '/api/home/recent');
    return response;
  }
}