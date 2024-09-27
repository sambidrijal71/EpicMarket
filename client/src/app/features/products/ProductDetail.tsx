import Grid from '@mui/material/Grid2';
import { useEffect, useState } from 'react';
import { useParams } from 'react-router';
import {
  Box,
  Button,
  ImageList,
  ImageListItem,
  Modal,
  Paper,
  Table,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  TextField,
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
import { LoadingButton } from '@mui/lab';

const style = {
  position: 'absolute',
  top: '50%',
  left: '50%',
  transform: 'translate(-50%, -50%)',
  width: '80vh',
  height: '80vh',
  bgcolor: 'background.paper',
  border: '2px solid #000',
  boxShadow: 24,
  p: 4,
};

const ProductDetail = () => {
  const { id } = useParams<string>();
  const dispatch = useAppDispatch();
  const { product, status } = useAppSelector((state) => state.products);
  const [open, setOpen] = useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);

  const imageDisplay = () => {
    if (product) {
      return product.images.map((image, index) => (
        <ImageListItem key={index}>
          <img src={image} alt={product.name} />
        </ImageListItem>
      ));
    }
  };
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
        {open ? (
          <Modal
            open={open}
            onClose={handleClose}
            aria-labelledby='modal-modal-title'
            aria-describedby='modal-modal-description'
          >
            <Box sx={style}>
              <ImageList>{imageDisplay()!}</ImageList>
            </Box>
          </Modal>
        ) : (
          <Box
            sx={{
              display: 'flex',
              flexDirection: 'column',
              justifyContent: 'space-between',
              // alignItems: 'center',
              height: '80vh',
            }}
          >
            <Button onClick={handleOpen}>
              <ImageList cols={3} rowHeight={164}>
                {imageDisplay()!}
              </ImageList>
            </Button>
            <Grid
              container
              sx={{
                display: 'flex',
                justifyContent: 'center',
                alignItems: 'center',
              }}
            >
              <Grid size={{ xs: 5 }}>
                <TextField
                  id='outlined-basic'
                  label='Update Cart'
                  variant='outlined'
                  type='number'
                />
              </Grid>
              <Grid size={{ xs: 4 }}>
                <LoadingButton variant='outlined' fullWidth size='large'>
                  Update Cart
                </LoadingButton>
              </Grid>
            </Grid>
          </Box>
        )}
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
