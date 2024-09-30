import { Pagination, Typography } from '@mui/material';
import Grid from '@mui/material/Grid2';

const ProductPagination = () => {
  return (
    <Grid
      container
      spacing={2}
      marginTop={4}
      display={'flex'}
      alignItems={'center'}
      justifyContent={'space-between'}
      paddingX={3}
    >
      <Typography variant='body1'>Showing 1 - 9 of 100 products</Typography>
      <Pagination count={10} />
    </Grid>
  );
};

export default ProductPagination;
