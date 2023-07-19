import axios from "axios";
import CONST from "./CONST.js";

export default class CollectionService {
  static url = CONST.API_URL;

  static async getById(id) {
    const response = await axios.get(this.url + `/api/collections/${id}`)
    return response.data.data;
  }

  static async getCollectionsByUserId(id) {
    const response = await axios.get(this.url + `/api/collections/user/${id}`)
    return response.data.data;
  }
}