import axios from "axios";
import CONST from "./CONST.js";

export default class {
  static baseUrl = CONST.API_URL;

  static async fetchSearch(query) {
    try {
      const response = await axios.get( this.baseUrl + `/api/search/${query}`)
      return response;
    } catch (error) {
      if (error.request.status === 0) {
        return {'status': 401}
      }
    }
  }
}