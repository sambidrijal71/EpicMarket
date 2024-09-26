import { createBrowserRouter } from 'react-router-dom';
import App from '../../App';
import HomePage from '../features/home/HomePage';
import AboutUs from '../features/about/AboutUs';
import ContactUs from '../features/contact/ContactUs';
import Login from '../features/account/Login';
import Register from '../features/account/Register';
import ProductPage from '../features/products/ProductPage';
import ProductDetail from '../features/products/ProductDetail';
import CartPage from '../features/cart/CartPage';

export const router = createBrowserRouter([
  {
    path: '/',
    element: <App />,
    children: [
      { path: '/', element: <HomePage /> },
      { path: '/about-us', element: <AboutUs /> },
      { path: '/contact-us', element: <ContactUs /> },
      { path: '/login', element: <Login /> },
      { path: '/register', element: <Register /> },
      { path: '/products', element: <ProductPage /> },
      { path: 'products/:id', element: <ProductDetail /> },
      { path: '/cart', element: <CartPage /> },
    ],
  },
]);
