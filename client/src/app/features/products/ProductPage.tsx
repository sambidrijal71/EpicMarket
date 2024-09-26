import { useEffect } from 'react';
import LoadingComponent from '../../components/LoadingComponent';
import ProductList from './ProductList';
import { useAppDispatch, useAppSelector } from '../../store/configureStore';
import { getProductsAsync } from './productSlice';

const ProductPage = () => {
  const { products, status } = useAppSelector((state) => state.products);
  const dispatch = useAppDispatch();
  useEffect(() => {
    try {
      dispatch(getProductsAsync());
    } catch (error) {
      console.log(error);
    }
  }, [dispatch]);
  if (status.includes('pendingFetch'))
    return <LoadingComponent message='Loading Products...' />;
  return <ProductList products={products} />;
};

export default ProductPage;
