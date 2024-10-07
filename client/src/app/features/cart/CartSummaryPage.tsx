import {
  TableContainer,
  Paper,
  Table,
  TableBody,
  TableRow,
  TableCell,
  Typography,
} from '@mui/material';
import { useAppSelector } from '../../store/configureStore';
import { currencyConverter } from '../../utils/Utils';

const CartSummaryPage = () => {
  const { cart } = useAppSelector((state) => state.cart);
  const quantity = cart?.items.reduce(
    (value, item) => value + item.quantity,
    0
  );
  const totalPrice = cart?.items.reduce(
    (value, item) => value + item.price * item.quantity,
    0
  );

  const deliveryFee = totalPrice && totalPrice > 10000 ? 0 : 1000;
  return (
    <TableContainer component={Paper} variant='outlined'>
      <Table aria-label='products description'>
        <TableBody>
          <TableRow>
            <TableCell colSpan={2}>Total Items :</TableCell>
            <TableCell align='right'>{quantity}</TableCell>
          </TableRow>

          <TableRow>
            <TableCell colSpan={2}>Total Price :</TableCell>
            <TableCell align='right'>
              {totalPrice && currencyConverter(totalPrice)}
            </TableCell>
          </TableRow>

          <TableRow>
            <TableCell colSpan={2}>Delivery Fee :</TableCell>
            <TableCell align='right'>
              {currencyConverter(deliveryFee)}
            </TableCell>
          </TableRow>
        </TableBody>
      </Table>
      <Typography variant='body1' padding={2}>
        *Orders above $100 qualify for free delivery.
      </Typography>
    </TableContainer>
  );
};

export default CartSummaryPage;
