import {
  Button,
  Paper,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Typography,
} from '@mui/material';
import Grid from '@mui/material/Grid2';
import { useAppDispatch, useAppSelector } from '../../store/configureStore';
import { addCartItemsAsync, removeCartItemsAsync } from './cart.Slice';
import LoadingComponent from '../../components/LoadingComponent';
import { LoadingButton } from '@mui/lab';
import {
  AddCircleOutlineSharp,
  DeleteOutline,
  RemoveCircleOutlineSharp,
} from '@mui/icons-material';
import { NavLink } from 'react-router-dom';
import { currencyConverter } from '../../utils/Utils';
import CartSummaryPage from './CartSummaryPage';
import NotFound from '../../components/NotFound';

const CartPage = () => {
  const handleAddItem = (productId: number, quantity: number) => {
    dispatch(addCartItemsAsync({ productId, quantity }));
  };
  const handleRemoveItem = (
    productId: number,
    quantity: number,
    name: string
  ) => {
    dispatch(removeCartItemsAsync({ productId, quantity, name }));
  };
  const { cart, status } = useAppSelector((state) => state.cart);
  const dispatch = useAppDispatch();
  if (status.includes('pendingFetchCart'))
    return <LoadingComponent message='Loading Cart...' />;
  if (!cart?.items)
    return <NotFound message='Please add items to cart first...' />;
  return (
    <>
      <TableContainer component={Paper}>
        <Table aria-label='products table'>
          <TableHead>
            <TableRow>
              <TableCell align='center'>Product</TableCell>
              <TableCell>Price</TableCell>
              <TableCell>Quantity</TableCell>
              <TableCell>SubTotal</TableCell>
              <TableCell>Action</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {cart?.items.map((item) => (
              <TableRow
                key={item.name}
                sx={{ '&:last-child td, &:last-child th': { border: 0 } }}
              >
                <TableCell
                  component='th'
                  scope='row'
                  sx={{ display: 'flex', alignItems: 'center' }}
                >
                  <img
                    src={`./images/thumbnails/${item.thumbnail}.png`}
                    alt={item.name}
                    style={{ backgroundSize: 'contain', height: '50px' }}
                  />
                  <Typography
                    paddingLeft={2}
                    variant='body2'
                    component={NavLink}
                    to={`/products/${item.id}`}
                    sx={{ textDecoration: 'none', color: 'inherit' }}
                  >
                    {item.name}
                  </Typography>
                </TableCell>
                <TableCell>{currencyConverter(item.price)}</TableCell>
                <TableCell>
                  <LoadingButton
                    size='small'
                    color='success'
                    loading={status === 'pendingAddBasketItems' + item.id}
                    onClick={() => handleAddItem(item.id, 1)}
                  >
                    <AddCircleOutlineSharp />
                  </LoadingButton>
                  {item.quantity}
                  <LoadingButton
                    size='small'
                    color='secondary'
                    loading={status.includes(
                      'pendingremoveBasketItems' + item.id + 'rem'
                    )}
                    onClick={() => handleRemoveItem(item.id, 1, 'rem')}
                  >
                    <RemoveCircleOutlineSharp />
                  </LoadingButton>
                </TableCell>
                <TableCell>
                  {currencyConverter(item.price * item.quantity)}
                </TableCell>
                <TableCell>
                  <LoadingButton
                    color='error'
                    loading={status.includes(
                      'pendingremoveBasketItems' + item.id + 'del'
                    )}
                    onClick={() =>
                      handleRemoveItem(item.id, item.quantity, 'del')
                    }
                  >
                    <DeleteOutline />
                  </LoadingButton>
                </TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
      <Grid container spacing={2} mt={1}>
        <Grid size={{ xs: 7 }}></Grid>
        <Grid size={{ xs: 5 }}>
          <CartSummaryPage />
          <Button
            variant='outlined'
            sx={{ mt: 1 }}
            component={NavLink}
            to='/checkout'
          >
            Checkout
          </Button>
        </Grid>
      </Grid>
    </>
  );
};

export default CartPage;
