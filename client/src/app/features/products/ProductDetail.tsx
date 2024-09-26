import Grid from '@mui/material/Grid2';
import { useEffect } from 'react';
import { useParams } from 'react-router';
import {
  ImageList,
  ImageListItem,
  Paper,
  Table,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Typography,
} from '@mui/material';
import LoadingComponent from '../../components/LoadingComponent';
import {
  capitalizeFirstLetter,
  currencyAfterDiscount,
  currencyConverter,
} from '../../utils/Utils';
import { useAppDispatch, useAppSelector } from '../../store/configureStore';
import { getProductAsync } from './productSlice';

const ProductDetail = () => {
  const { id } = useParams<string>();
  const dispatch = useAppDispatch();
  const { product, status } = useAppSelector((state) => state.products);

  useEffect(() => {
    try {
      if (id) dispatch(getProductAsync(parseInt(id)));
    } catch (error) {
      console.log(error);
    }
  }, [dispatch, id]);
  if (status.includes('pendingFetch') || !product)
    return <LoadingComponent message={`Loading product with id ${id}`} />;
  return (
    <Grid
      container
      spacing={2}
      display={'flex'}
      justifyContent={'space-between'}
    >
      <Grid size={{ xs: 5 }}>
        <ImageList sx={{ width: 500, height: 450 }} cols={3} rowHeight={164}>
          {product.images.map((image, index) => (
            <ImageListItem key={index}>
              <img src={image} alt={product.name} />
            </ImageListItem>
          ))}
        </ImageList>
      </Grid>
      <Grid size={{ xs: 7 }}>
        <TableContainer component={Paper}>
          <Table>
            <TableHead>
              <TableRow>
                <TableCell align='left' style={{ width: 200 }}></TableCell>
                <TableCell>
                  <Typography variant='h5' padding={1}>
                    {product?.name}
                  </Typography>
                </TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Description:</TableCell>
                <TableCell>{product?.description}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Category / Brand:</TableCell>
                <TableCell>
                  {product && capitalizeFirstLetter(product.category)} /{' '}
                  {capitalizeFirstLetter(product.brand)}
                </TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Rating:</TableCell>
                <TableCell>{product?.rating}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Warranty:</TableCell>
                <TableCell>{product?.warrantyInformation}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Shipping Information:</TableCell>
                <TableCell>{product?.shippingInformation}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Availability Status:</TableCell>
                <TableCell>{product?.availabilityStatus}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Quantity In Stock:</TableCell>
                <TableCell>{product?.quantityInStock}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Return Policy:</TableCell>
                <TableCell>{product?.returnPolicy}</TableCell>
              </TableRow>

              <TableRow>
                <TableCell>Price:</TableCell>
                <TableCell sx={{ display: 'flex' }}>
                  <Typography paddingRight={4}>
                    {currencyAfterDiscount(
                      product.price,
                      product.discountPercentage
                    )}
                  </Typography>
                  <Typography sx={{ textDecoration: 'line-through' }}>
                    {currencyConverter(product?.price)}
                  </Typography>
                </TableCell>
              </TableRow>
            </TableHead>
          </Table>
        </TableContainer>
      </Grid>
    </Grid>
  );
};

export default ProductDetail;
