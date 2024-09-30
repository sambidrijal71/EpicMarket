import { ProductParams } from './../../models/Product';
import {
  createAsyncThunk,
  createEntityAdapter,
  createSlice,
  isAnyOf,
} from '@reduxjs/toolkit';
import { Product } from '../../models/Product';
import { agent } from '../../api/agent';
import { RootState } from '../../store/configureStore';
import { Metadata } from '../../models/Pagination';

interface ProductState {
  productsLoaded: boolean;
  filtersLoaded: boolean;
  status: string;
  brands: string[];
  categories: string[];
  productParams: ProductParams;
  metaData: Metadata | null;
}
const urlSearchParams = (productParams: ProductParams) => {
  let params = new URLSearchParams();
  params.append('pageNumber', productParams.pageNumber.toString());
  params.append('pageSize', productParams.pageSize.toString());
  if (productParams.brands.length > 0)
    params.append('brands', productParams.brands.toString());
  if (productParams.categories.length > 0)
    params.append('categories', productParams.categories.toString());
  if (productParams.searchTerm)
    params.append('searchTerm', productParams.searchTerm);
  if (productParams.orderBy) params.append('orderBy', productParams.orderBy);
  return params;
};
const productsAdapter = createEntityAdapter<Product>();

export const getProductsAsync = createAsyncThunk<
  Product[],
  void,
  { state: RootState }
>('users/getProductsAsync', async (_, thunkAPI) => {
  const params = urlSearchParams(thunkAPI.getState().products.productParams);
  try {
    const response = await agent.Product.getProducts(params);
    thunkAPI.dispatch(setMetaData(response.metaData));
    return response.items;
  } catch (error) {
    console.log(error);
    return thunkAPI.rejectWithValue(error);
  }
});

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

const initParams = (): ProductParams => {
  return {
    orderBy: 'name',
    pageNumber: 1,
    pageSize: 24,
    searchTerm: '',
    brands: [],
    categories: [],
  };
};

export const productSlice = createSlice({
  name: 'products',
  initialState: productsAdapter.getInitialState<ProductState>({
    status: 'idle',
    brands: [],
    categories: [],
    productParams: initParams(),
    productsLoaded: false,
    filtersLoaded: false,
    metaData: null,
  }),
  reducers: {
    setProductParams: (state, action) => {
      state.productsLoaded = false;
      state.productParams = {
        ...state.productParams,
        ...action.payload,
        pageNumber: 1,
      };
    },
    setMetaData: (state, action) => {
      state.metaData = action.payload;
    },
    setPageNumber: (state, action) => {
      state.productsLoaded = false;
      state.productParams = { ...state.productParams, ...action.payload };
    },
    resetProductParams: (state) => {
      state.productsLoaded = false;
      state.productParams = initParams();
    },
  },
  extraReducers: (builder) => {
    builder.addCase(getProductsAsync.fulfilled, (state, action) => {
      productsAdapter.setAll(state, action.payload);
      state.status = 'idle';
      state.productsLoaded = true;
    });
    builder.addCase(getProductAsync.fulfilled, (state, action) => {
      productsAdapter.upsertOne(state, action.payload);
      state.status = 'idle';
      state.productsLoaded = true;
    });
    builder.addCase(getFiltersAsync.fulfilled, (state, action) => {
      state.categories = action.payload.categories;
      state.brands = action.payload.brands;
      state.status = 'idle';
      state.filtersLoaded = true;
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

export const {
  setProductParams,
  setMetaData,
  resetProductParams,
  setPageNumber,
} = productSlice.actions;
export const productsSelector = productsAdapter.getSelectors(
  (state: RootState) => state.products
);
