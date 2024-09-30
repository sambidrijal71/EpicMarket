import { Paper, TextField } from '@mui/material';
import { useState } from 'react';

const ProductSearch = () => {
  const [searchTerm, setSearchTerm] = useState('');

  const handleSearchTerm = (e: any) => {
    setSearchTerm(e.target.value);
    console.log(searchTerm);
  };

  return (
    <Paper sx={{ marginBottom: 2 }}>
      <TextField
        variant='outlined'
        fullWidth
        label='Search Products'
        id='product_search'
        value={searchTerm}
        onChange={handleSearchTerm}
      />
    </Paper>
  );
};

export default ProductSearch;
