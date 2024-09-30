import axios, { AxiosResponse } from 'axios';
import { PaginatedList } from '../models/Pagination';

axios.defaults.baseURL = 'http://localhost:5000/api/';
axios.defaults.withCredentials = true;

const responseBody = (response: AxiosResponse) => response.data;
axios.interceptors.response.use(async (response) => {
  const pagination = response.headers['pagination'];
  if (pagination) {
    response.data = new PaginatedList(response.data, JSON.parse(pagination));
    return response;
  }
  return response;
});
const requests = {
  get: (url: string, params?: URLSearchParams) =>
    axios.get(url, { params }).then(responseBody),

  post: (url: string, body: object) => axios.post(url, body).then(responseBody),

  delete: (url: string) => axios.delete(url).then(responseBody),
};

const Product = {
  getProducts: (params: URLSearchParams) => requests.get('products', params),
  getProduct: (id: number) => requests.get(`products/${id}`),
  getProductFilters: () => requests.get('products/filter'),
};

const Cart = {
  getCart: () => requests.get('cart'),
  addCartItems: (productId: number, quantity: number) =>
    requests.post(
      `cart/addCartItems?productId=${productId}&quantity=${quantity}`,
      {}
    ),
  removeCartItems: (productId: number, quantity: number) =>
    requests.delete(
      `cart/removeCartItems?productId=${productId}&quantity=${quantity}`
    ),
};

export const agent = { Product, Cart };
