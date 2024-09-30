import { useEffect } from 'react';
import LoadingComponent from '../../components/LoadingComponent';
import ProductList from './ProductList';
import { useAppDispatch, useAppSelector } from '../../store/configureStore';
import { getProductsAsync } from './productSlice';
import NotFound from '../../components/NotFound';
import Grid from '@mui/material/Grid2';
import ProductSearch from './productComponents/ProductSearch';
import SortProducts from './productComponents/SortProducts';
import FilterProducts from './productComponents/FilterProducts';
import ProductPagination from './productComponents/ProductPagination';

const sortProducts = [
  { label: 'Name', value: 'name' },
  { label: 'Price - High to Low', value: 'price' },
  { label: 'Price - Low to High', value: 'priceDesc' },
];
const ProductPage = () => {
  const { products, status, categories, brands } = useAppSelector(
    (state) => state.products
  );
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
  if (!products) return <NotFound message={'No products in the database.'} />;
  return (
    <Grid container spacing={4}>
      <Grid size={{ xs: 3 }}>
        <ProductSearch />
        <SortProducts sortProducts={sortProducts} />
        <FilterProducts filters={categories} filterName='Categories' />
        <FilterProducts filters={brands} filterName='Brands' />
      </Grid>
      <Grid size={{ xs: 9 }}>
        <ProductList products={products} />
        <ProductPagination />
      </Grid>
    </Grid>
  );
};

export default ProductPage;
