import axios, { AxiosError, AxiosResponse } from 'axios';
import { PaginatedList } from '../models/Pagination';
import { FieldValues } from 'react-hook-form';
import { store } from '../store/configureStore';
import { toast } from 'react-toastify';
import { router } from '../routes/Routes';

axios.defaults.baseURL = 'http://localhost:5000/api/';
axios.defaults.withCredentials = true;

const responseBody = (response: AxiosResponse) => response.data;

axios.interceptors.request.use((config) => {
  const token = store.getState().user.user?.token;
  if (token) config.headers.Authorization = `Bearer ${token}`;
  return config;
});
axios.interceptors.response.use(
  async (response) => {
    const pagination = response.headers['pagination'];
    if (pagination) {
      response.data = new PaginatedList(response.data, JSON.parse(pagination));
      return response;
    }
    return response;
  },
  (error: AxiosError) => {
    const { data, status } = error.response as AxiosResponse;
    switch (status) {
      case 400:
        if (data.errors) {
          const modelStateErrors: string[] = [];
          for (const key in data.errors) {
            if (data.errors[key]) {
              modelStateErrors.push(data.errors[key]);
            }
          }
          throw modelStateErrors.flat();
        }
        toast.error(data.title);
        break;
      case 401:
        toast.error(data.title);
        break;
      case 500:
        router.navigate('/server-error', { state: { error: data } });
        break;
      default:
        break;
    }
    return Promise.reject(error);
  }
);

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

const Account = {
  login: (data: FieldValues) => requests.post('account/loginUser', data),
  register: (data: FieldValues) => requests.post('account/registerUser', data),
  getUser: () => requests.get('account/getUser'),
};

const Orders = {
  getOrders: () => requests.get('order'),
  getOrder: (id: number) => requests.get(`order/${id}`),
};

export const agent = { Product, Cart, Account, Orders };
