import {
  Avatar,
  Box,
  Button,
  Card,
  CardActions,
  CardContent,
  CardHeader,
  CardMedia,
  Rating,
  Typography,
} from '@mui/material';
import { Product } from '../../models/Product';
import { useNavigate } from 'react-router';
import { currencyAfterDiscount, currencyConverter } from '../../utils/Utils';
import { useAppDispatch, useAppSelector } from '../../store/configureStore';
import { addCartItemsAsync } from '../cart/cart.Slice';
import { LoadingButton } from '@mui/lab';

interface Props {
  product: Product;
}
const ProductCard = ({ product }: Props) => {
  const { status } = useAppSelector((state) => state.cart);
  const navigate = useNavigate();
  const dispatch = useAppDispatch();
  const handleAddItem = (productId: number, quantity: number) => {
    dispatch(addCartItemsAsync({ productId, quantity }));
  };
  return (
    <Card sx={{ maxWidth: 345 }}>
      <CardHeader
        avatar={
          <Avatar sx={{ bgcolor: 'secondary.main' }} aria-label='recipe'>
            {product.name[0].toUpperCase()}
          </Avatar>
        }
        title={product.name}
        subheader={
          <Rating
            name='read-only'
            value={product.rating}
            readOnly
            size='small'
          />
        }
      />
      <CardMedia
        sx={{ height: 140, backgroundSize: 'contain' }}
        image={`./images/thumbnails/${product.thumbnail}.png`}
        title={product.name}
      />
      <CardContent>
        <Box display={'flex'} sx={{ color: 'primary.main' }}>
          <Typography gutterBottom variant='h5' marginRight={2}>
            {currencyAfterDiscount(product.price, product.discountPercentage)}
          </Typography>
          <Typography
            gutterBottom
            variant='h5'
            sx={{ textDecoration: 'line-through' }}
          >
            {currencyConverter(product.price)}
          </Typography>
        </Box>
        <Typography variant='body2' sx={{ color: 'text.secondary' }}>
          {product.description}
        </Typography>
      </CardContent>
      <CardActions
        sx={{
          display: 'flex',
          alignItems: 'center',
          justifyContent: 'space-around',
        }}
      >
        <Button
          size='small'
          variant='outlined'
          onClick={() => navigate(`${product.id}`)}
        >
          View
        </Button>
        <LoadingButton
          disabled={product.quantityInStock === 0}
          loading={status === 'pendingAddBasketItems' + product.id}
          size='small'
          variant='outlined'
          onClick={() => handleAddItem(product.id, 1)}
        >
          {product.quantityInStock === 0 ? 'Out of Stock' : 'Add To Cart'}
        </LoadingButton>
      </CardActions>
    </Card>
  );
};

export default ProductCard;
