import {
  Avatar,
  Box,
  Button,
  Card,
  CardActions,
  CardContent,
  CardHeader,
  CardMedia,
  Typography,
} from '@mui/material';
import { Product } from '../../models/Product';
import { useNavigate } from 'react-router';
import { currencyAfterDiscount, currencyConverter } from '../../utils/Utils';

interface Props {
  product: Product;
}
const ProductCard = ({ product }: Props) => {
  const navigate = useNavigate();
  return (
    <Card sx={{ maxWidth: 345 }}>
      <CardHeader
        avatar={
          <Avatar sx={{ bgcolor: 'secondary.main' }} aria-label='recipe'>
            {product.name[0].toUpperCase()}
          </Avatar>
        }
        title={product.name}
        subheader={product.rating}
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
        <Button size='small' variant='outlined'>
          Add To Cart
        </Button>
      </CardActions>
    </Card>
  );
};

export default ProductCard;
