import { Box, Pagination, Typography } from '@mui/material';
import Grid from '@mui/material/Grid2';
import { Metadata } from '../../../models/Pagination';

interface Props {
  metaData: Metadata;
  handlePageChange: (e: number) => void;
  handleFiltersReset: () => void;
}
const ProductPagination = ({ metaData, handlePageChange }: Props) => {
  const { totalCount, totalPages, pageSize, currentPage } = metaData;
  return (
    <Box>
      {totalCount === 0 ? (
        <Box
          sx={{
            display: 'flex',
            flexDirection: 'column',
            justifyContent: 'center',
            alignItems: 'center',
            height: '60vh',
          }}
        >
          <Typography variant='h4'>No Products Found</Typography>
        </Box>
      ) : (
        <Grid
          container
          spacing={2}
          marginTop={4}
          display={'flex'}
          alignItems={'center'}
          justifyContent={'space-between'}
          paddingX={3}
        >
          <Typography variant='body1'>
            Showing {totalCount === 0 ? 0 : (currentPage - 1) * pageSize + 1} -{' '}
            {currentPage * pageSize > totalCount
              ? totalCount
              : currentPage * pageSize}{' '}
            of {totalCount} products
          </Typography>
          <Pagination
            disabled={totalCount < 24 ? true : false}
            page={currentPage}
            variant='outlined'
            count={totalPages}
            onChange={(_e, page) => handlePageChange(page)}
          />
        </Grid>
      )}
    </Box>
  );
};

export default ProductPagination;
