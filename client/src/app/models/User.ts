import { Cart } from './Cart';

export interface User {
  userName: string;
  password: string;
  email: string;
  token: string;
  cart: Cart;
}
