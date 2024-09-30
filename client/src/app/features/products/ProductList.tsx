import Grid from '@mui/material/Grid2';
import { Product } from '../../models/Product';
import ProductCard from './ProductCard';

interface Props {
  products: Product[] | null;
}
const ProductList = ({ products }: Props) => {
  return (
    <Grid container spacing={2}>
      {products?.map((product) => (
        <Grid size={4} key={product.id}>
          <ProductCard product={product} />
        </Grid>
      ))}
    </Grid>
  );
};

export default ProductList;
