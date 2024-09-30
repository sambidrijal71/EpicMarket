import { debounce, Paper, TextField } from '@mui/material';
import { useEffect, useState } from 'react';
import { useAppDispatch, useAppSelector } from '../../../store/configureStore';
import { setProductParams } from '../productSlice';

const ProductSearch = () => {
  const [searchTerm, setSearchTerm] = useState('');
  const dispatch = useAppDispatch();
  const { productParams } = useAppSelector((state) => state.products);

  useEffect(() => {
    setSearchTerm(productParams.searchTerm);
  }, [productParams.searchTerm]);
  const debouncedSearch = debounce((e: any) => {
    dispatch(setProductParams({ searchTerm: e.target.value }));
  }, 1000);
  return (
    <Paper sx={{ marginBottom: 2 }}>
      <TextField
        inputProps={{
          autoComplete: 'off',
        }}
        autoFocus
        variant='outlined'
        fullWidth
        label='Search Products'
        id='product_search'
        value={searchTerm}
        onChange={(e: any) => {
          setSearchTerm(e.target.value);
          debouncedSearch(e);
        }}
      />
    </Paper>
  );
};

export default ProductSearch;
