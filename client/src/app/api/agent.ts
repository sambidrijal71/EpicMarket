import axios, { AxiosResponse } from 'axios';

axios.defaults.baseURL = 'http://localhost:5000/api/';
axios.defaults.withCredentials = true;

const responseBody = (response: AxiosResponse) => response.data;

const requests = {
  get: (url: string) => axios.get(url).then(responseBody),

  post: (url: string, body: object) => axios.post(url, body).then(responseBody),

  delete: (url: string) => axios.delete(url).then(responseBody),
};

const Product = {
  getProducts: () => requests.get('products'),
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
