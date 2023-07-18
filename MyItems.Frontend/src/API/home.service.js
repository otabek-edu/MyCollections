import axios from "axios";
import CONST from "./CONST.js";

export default class HomeService {
  static baseUrl = CONST.API_URL;

  static async fetchTopCollections() {
    const response = await axios.get( this.baseUrl + "/api/home/top");
    return response;
  }

  static async fetchRecentlyItems() {
    const response = await axios.get(this.baseUrl + '/api/home/recent');
    return response;
  }
}