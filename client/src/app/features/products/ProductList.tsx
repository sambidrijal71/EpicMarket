import { Grid2 } from '@mui/material';
import { Product } from '../../models/Product';
import ProductCard from './ProductCard';

interface Props {
  products: Product[] | null;
}
const ProductList = ({ products }: Props) => {
  return (
    <>
      <Grid2 container spacing={2}>
        {products?.map((product) => (
          <Grid2 size={4} key={product.id}>
            <ProductCard product={product} />
          </Grid2>
        ))}
      </Grid2>
    </>
  );
};

export default ProductList;
