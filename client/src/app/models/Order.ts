export interface Order {
  id: number;
  buyerId: string;
  shippingAddress: ShippingAddress;
  orderDate: string;
  orderItems: OrderItem[];
  subTotal: number;
  deliveryFee: number;
  total: number;
  orderStatus: string;
}

export interface ShippingAddress {
  fullName: string;
  address1: string;
  address2: string;
  city: string;
  state: string;
  postCode: string;
  country: string;
}

export interface OrderItem {
  productId: number;
  name: string;
  thumbnail: string;
  price: number;
  quantity: number;
}
