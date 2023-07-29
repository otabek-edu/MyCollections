import CONST from "./CONST.js";
import axios from "axios";

export default class AdminService {
  static url = CONST.API_URL;

  static async getUsers() {
    const response = await axios.get(this.url + '/api/admin/users', {
      headers: {
        Authorization: "Bearer " + localStorage.getItem('jwt')
      }
    })
    return response.data;
  }

  static async getUserById(id) {
    const response = await axios.get(this.url + `/api/admin/users/${id}`, {
      headers: {
        Authorization: "Bearer " + localStorage.getItem('jwt')
      }
    })
    return response.data;
  }

  static async deleteUser(id) {
    const response = await axios.delete(this.url + `/api/admin/users/${id}`, {
      headers: {
        Authorization: "Bearer " + localStorage.getItem('jwt')
      }
    })
    return response.data;
  }

  static async blockUser(id) {
    const response = await axios.post(this.url + `/api/admin/users/block/${id}`, {}, {
      headers: {
        Authorization: "Bearer " + localStorage.getItem('jwt')
      }
    })
    return response.data;
  }

  static async unBlockUser(id) {
    const response = await axios.post(this.url + `/api/Admin/users/unBlock/${id}`,{}, {
      headers: {
        Authorization: "Bearer " + localStorage.getItem('jwt')
      }
    })
    return response.data;
  }

  static async setAdmin(id) {
    const response = await axios.post(this.url + `/api/admin/users/setAdmin/${id}`,{}, {
      headers: {
        Authorization: "Bearer " + localStorage.getItem('jwt')
      }
    })
    return response.data;
  }

  static async unSetAdmin(id) {
    const response = await axios.post(this.url + `/api/admin/users/unSetAdmin/${id}`, {},{
      headers: {
        Authorization: "Bearer " + localStorage.getItem('jwt')
      }
    })
    return response.data;
  }
}