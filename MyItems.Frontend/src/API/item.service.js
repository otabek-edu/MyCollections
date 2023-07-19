import CONST from "./CONST.js";
import axios from "axios";

export default class ItemService {
  static url = CONST.API_URL;

  static async getById(id) {
    const response = await axios.get(this.url + `/api/item/${id}`)
    return response.data;
  }

}