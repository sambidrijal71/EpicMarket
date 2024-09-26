import { useEffect, useState } from 'react';
import { Product } from '../../models/Product';
import LoadingComponent from '../../components/LoadingComponent';
import ProductList from './ProductList';
import { agent } from '../../api/agent';

const ProductPage = () => {
  const [products, setProducts] = useState<Product[] | null>(null);
  const [loading, setLoading] = useState<boolean>(true);
  useEffect(() => {
    try {
      agent.Product.getProducts()
        .then((products) => setProducts(products))
        .catch((err) => console.log(err))
        .finally(() => setLoading(false));
    } catch (error) {
      setLoading(false);
      console.log(error);
    }
  }, [setProducts]);
  if (loading) return <LoadingComponent message='Loading Products...' />;
  return <ProductList products={products} />;
};

export default ProductPage;
