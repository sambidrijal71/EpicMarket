import { createAsyncThunk, createSlice, isAnyOf } from '@reduxjs/toolkit';
import { agent } from '../../api/agent';
import { Cart } from '../../models/Cart';
import { getCookie } from '../../utils/Utils';

export interface CartState {
  cart: Cart | null;
  status: string;
}

export const getCartItemsAsync = createAsyncThunk<Cart>(
  'cart/getCartItemsAsync',
  async (_, thunkAPI) => {
    try {
      const cartItems = await agent.Cart.getCart();
      return cartItems;
    } catch (error) {
      console.log(error);
      return thunkAPI.rejectWithValue(error);
    }
  },
  {
    condition: () => {
      if (!getCookie('buyerId')) return false;
    },
  }
);

export const addCartItemsAsync = createAsyncThunk<
  Cart,
  { productId: number; quantity: number }
>('cart/addCartItemsAsync', async ({ productId, quantity }, thunkAPI) => {
  try {
    const cartItems = await agent.Cart.addCartItems(productId, quantity);
    return cartItems;
  } catch (error: any) {
    console.log(error);
    return thunkAPI.rejectWithValue({ error: error.data });
  }
});

export const removeCartItemsAsync = createAsyncThunk<
  Cart,
  { productId: number; quantity: number; name: string }
>('cart/removeCartItemsAsync', async ({ productId, quantity }, thunkAPI) => {
  try {
    const cartItems = await agent.Cart.removeCartItems(productId, quantity);
    return cartItems;
  } catch (error: any) {
    console.log(error);
    return thunkAPI.rejectWithValue({ error: error.data });
  }
});

const initialState: CartState = {
  cart: null,
  status: 'idle',
};

export const cartSlice = createSlice({
  name: 'cart',
  initialState,
  reducers: {},

  extraReducers: (builder) => {
    builder.addCase(getCartItemsAsync.pending, (state) => {
      state.status = 'pendingFetchItems';
    });
    builder.addCase(addCartItemsAsync.pending, (state, action) => {
      console.log(action);
      state.status = 'pendingAddBasketItems' + action.meta.arg.productId;
    });
    builder.addCase(removeCartItemsAsync.pending, (state, action) => {
      console.log(action);
      state.status =
        'pendingremoveBasketItems' +
        action.meta.arg.productId +
        action.meta.arg.name;
    });

    builder.addMatcher(
      isAnyOf(
        getCartItemsAsync.fulfilled,
        addCartItemsAsync.fulfilled,
        removeCartItemsAsync.fulfilled
      ),
      (state, action) => {
        state.cart = action.payload;
        state.status = 'idle';
      }
    );

    builder.addMatcher(
      isAnyOf(
        getCartItemsAsync.rejected,
        addCartItemsAsync.rejected,
        removeCartItemsAsync.rejected
      ),
      (state, action) => {
        state.status = 'idle';
        throw action.payload;
      }
    );
  },
});

export default cartSlice.reducer;
