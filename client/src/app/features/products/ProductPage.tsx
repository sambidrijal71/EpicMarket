import { useEffect, useState } from 'react';
import LoadingComponent from '../../components/LoadingComponent';
import ProductList from './ProductList';
import { useAppDispatch, useAppSelector } from '../../store/configureStore';
import {
  getProductsAsync,
  productsSelector,
  resetProductParams,
  setPageNumber,
  setProductParams,
} from './productSlice';
import NotFound from '../../components/NotFound';
import Grid from '@mui/material/Grid2';
import ProductSearch from './productComponents/ProductSearch';
import SortProducts from './productComponents/SortProducts';
import FilterProducts from './productComponents/FilterProducts';
import ProductPagination from './productComponents/ProductPagination';
import { Button } from '@mui/material';

const sortProducts = [
  { label: 'Name', value: 'name' },
  { label: 'Price - High to Low', value: 'priceDesc' },
  { label: 'Price - Low to High', value: 'price' },
];
const ProductPage = () => {
  const {
    status,
    categories,
    brands,
    productsLoaded,
    productParams,
    metaData,
  } = useAppSelector((state) => state.products);
  const products = useAppSelector(productsSelector.selectAll);
  const dispatch = useAppDispatch();
  const [filtersCheck, setFiltersCheck] = useState(true);

  const handleFiltersReset = () => {
    {
      setFiltersCheck(true);
      dispatch(resetProductParams());
    }
  };
  useEffect(() => {
    if (
      productParams.categories.length > 0 ||
      productParams.brands.length > 0
    ) {
      setFiltersCheck(false);
    }
    if (!productsLoaded)
      try {
        dispatch(getProductsAsync());
      } catch (error) {
        console.log(error);
      }
  }, [dispatch, productsLoaded, setFiltersCheck]);
  if (status.includes('pendingFetch'))
    return <LoadingComponent message='Loading Products...' />;
  if (!products) return <NotFound message={'No products in the database.'} />;
  return (
    <Grid container spacing={4}>
      <Grid size={{ xs: 3 }}>
        <ProductSearch />
        <SortProducts
          sortProducts={sortProducts}
          handleSortOption={(e: any) =>
            dispatch(setProductParams({ orderBy: e.target.value }))
          }
          selectedValue={productParams.orderBy}
        />
        <FilterProducts
          filters={categories}
          filterName='Categories'
          checkedValue={productParams.categories}
          onChange={(items: string[]) =>
            dispatch(setProductParams({ categories: items }))
          }
        />
        <FilterProducts
          filters={brands}
          filterName='Brands'
          checkedValue={productParams.brands}
          onChange={(items: string[]) =>
            dispatch(setProductParams({ brands: items }))
          }
        />
        <Button
          fullWidth
          variant='outlined'
          onClick={() => handleFiltersReset()}
          disabled={filtersCheck}
        >
          Reset Filters
        </Button>
      </Grid>
      <Grid size={{ xs: 9 }}>
        <ProductList products={products} />
        {metaData && (
          <ProductPagination
            metaData={metaData}
            handlePageChange={(pageNumber: number) =>
              dispatch(setPageNumber({ pageNumber: pageNumber }))
            }
            handleFiltersReset={() => dispatch(resetProductParams())}
          />
        )}
      </Grid>
    </Grid>
  );
};

export default ProductPage;
