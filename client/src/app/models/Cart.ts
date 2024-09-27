export interface Cart {
  id: number;
  buyerId: string;
  items: CartItem[];
}

export interface CartItem {
  id: number;
  name: string;
  description: string;
  category: string;
  price: number;
  discountPercentage: number;
  rating: number;
  quantityInStock: number;
  tags: string[];
  brand: string;
  warrantyInformation: string;
  shippingInformation: string;
  availabilityStatus: string;
  returnPolicy: string;
  images: string[];
  thumbnail: string;
  quantity: number;
}
