export interface Product {
  id: number;
  name: string;
  description: string;
  category: string;
  brand: string;
  tags: string[];
  price: number;
  discountPercentage: number;
  rating: number;
  warrantyInformation: string;
  shippingInformation: string;
  availabilityStatus: string;
  quantityInStock: number;
  returnPolicy: string;
  images: string[];
  thumbnail: string;
}
