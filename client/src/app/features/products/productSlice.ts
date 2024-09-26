import { createAsyncThunk, createSlice, isAnyOf } from '@reduxjs/toolkit';
import { Product } from '../../models/Product';
import { agent } from '../../api/agent';

export interface ProductState {
  products: Product[] | null;
  product: Product | null;
  status: string;
}

export const getProductsAsync = createAsyncThunk<Product[]>(
  'users/getProductsAsync',
  async (_, thunkAPI) => {
    try {
      const products = await agent.Product.getProducts();
      return products;
    } catch (error) {
      console.log(error);
      return thunkAPI.rejectWithValue(error);
    }
  }
);

export const getProductAsync = createAsyncThunk<Product, number>(
  'users/getProductAsync',
  async (id, thunkAPI) => {
    try {
      const product = await agent.Product.getProduct(id);
      return product;
    } catch (error) {
      console.log(error);
      return thunkAPI.rejectWithValue(error);
    }
  }
);

const initialState: ProductState = {
  products: null,
  product: null,
  status: 'idle',
};

export const productSlice = createSlice({
  name: 'counter',
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder.addCase(getProductsAsync.fulfilled, (state, action) => {
      state.products = action.payload;
      state.status = 'idle';
    });
    builder.addCase(getProductAsync.fulfilled, (state, action) => {
      state.product = action.payload;
      state.status = 'idle';
    });
    builder.addMatcher(
      isAnyOf(getProductsAsync.pending, getProductAsync.pending),
      (state) => {
        state.status = 'pendingFetch';
      }
    );

    builder.addMatcher(
      isAnyOf(getProductsAsync.rejected, getProductAsync.rejected),
      (state, action) => {
        state.status = 'idle';
        throw action.payload;
      }
    );
  },
});

export default productSlice.reducer;
