import Grid from '@mui/material/Grid2';
import { Product } from '../../models/Product';
import ProductCard from './ProductCard';
import { useAppSelector } from '../../store/configureStore';

interface Props {
  products: Product[] | null;
}
const ProductList = ({ products }: Props) => {
  const { status } = useAppSelector((state) => state.products);
  return (
    <>
      <Grid container spacing={2}>
        {products?.map((product) => (
          <Grid size={4} key={product.id}>
            {status.includes('pendingFetch') ? <></> : <></>}
            <ProductCard product={product} />
          </Grid>
        ))}
      </Grid>
    </>
  );
};

export default ProductList;
