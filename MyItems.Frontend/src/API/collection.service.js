import axios from "axios";

export default class CollectionService {
  static url = CONST.API_URL;

  static async getTop(limit = 10, page = 1) {
    const response = await axios.get(this.url + '/api/home/top')
    return response.data.data;
  }

  static async getById(id) {
    const response = await axios.get(this.url + `/api/collection/${id}`)
    return response.data.data;
  }

  static async getCommentsByPostId(id) {
    const response = await axios.get(``)
    return response;
  }
}