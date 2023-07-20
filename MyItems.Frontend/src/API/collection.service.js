import axios from "axios";
import CONST from "./CONST.js";

export default class CollectionService {
  static url = CONST.API_URL;

  static async getById(id) {
    const response = await axios.get(this.url + `/api/collections/${id}`)
    return response.data.data;
  }

  static async getMyCollections(id) {
    const response = await axios.get(this.url + `/api/collections/${id}`)
    return response.data.data;
  }

  static async createCollection(collection) {
    const response = await axios.post(this.url + `/api/collections`, collection, {
      headers: {
        Authorization: "Bearer " + localStorage.getItem('jwt')
      }
    })
    return response.data;
  }

  static async deleteMyCollectionById(id) {
    const response = await axios.delete(this.url + `/api/collections/${id}`, {
      headers: {
        Authorization: "Bearer " + localStorage.getItem('jwt')
      }
    })
    return response.data;
  }
}