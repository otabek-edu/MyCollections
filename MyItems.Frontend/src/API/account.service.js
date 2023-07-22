import CONST from "./CONST.js";
import axios from "axios";

export default class CollectionService {
  static url = CONST.API_URL;

  static async login(loginModel) {
    const response = await axios.post(this.url + '/api/account/login', loginModel)
    return response;
  }
}