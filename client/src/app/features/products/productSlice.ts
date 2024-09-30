import { createAsyncThunk, createSlice, isAnyOf } from '@reduxjs/toolkit';
import { Product } from '../../models/Product';
import { agent } from '../../api/agent';
import { ProductParams } from '../../models/Product';

export interface ProductState {
  products: Product[] | null;
  product: Product | null;
  status: string;
  brands: string[] | null;
  categories: string[] | null;
  productParams: ProductParams | null;
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

export const getFiltersAsync = createAsyncThunk(
  'users/getFiltersAsync',
  async (_, thunkAPI) => {
    try {
      const filters = await agent.Product.getProductFilters();
      return filters;
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

const initParams = () => {
  return {
    orderBy: 'name',
    pageNumber: 1,
    pageSize: 24,
  };
};
const initialState: ProductState = {
  products: null,
  product: null,
  status: 'idle',
  brands: null,
  categories: null,
  productParams: initParams(),
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
    builder.addCase(getFiltersAsync.fulfilled, (state, action) => {
      state.categories = action.payload.categories;
      state.brands = action.payload.brands;
      state.status = 'idle';
    });
    builder.addMatcher(
      isAnyOf(
        getProductsAsync.pending,
        getProductAsync.pending,
        getFiltersAsync.pending
      ),
      (state) => {
        state.status = 'pendingFetch';
      }
    );

    builder.addMatcher(
      isAnyOf(
        getProductsAsync.rejected,
        getProductAsync.rejected,
        getFiltersAsync.rejected
      ),
      (state, action) => {
        state.status = 'idle';
        throw action.payload;
      }
    );
  },
});

export default productSlice.reducer;
