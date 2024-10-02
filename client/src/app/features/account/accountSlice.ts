import { createAsyncThunk, createSlice, isAnyOf } from '@reduxjs/toolkit';
import { agent } from '../../api/agent';
import { User } from '../../models/User';
import { FieldValues } from 'react-hook-form';
import { router } from '../../routes/Routes';

export interface UserState {
  user: User | null;
  status: string;
}

export const postUserLoginAsync = createAsyncThunk<User, FieldValues>(
  'account/postUserLoginAsync',
  async (data, thunkAPI) => {
    try {
      const user = await agent.Account.login(data);
      if (user) router.navigate('/');
      return user;
    } catch (error: any) {
      return thunkAPI.rejectWithValue(error.response.data.title);
    }
  }
);

export const postUserRegisterAsync = createAsyncThunk<User, FieldValues>(
  'account/postUserRegisterAsync',
  async (data, thunkAPI) => {
    try {
      const user = await agent.Account.register(data);
      if (user) router.navigate('/login');
      return user;
    } catch (error: any) {
      console.log(error);
      return thunkAPI.rejectWithValue({ error: error.data });
    }
  }
);

// export const getUserAsync = createAsyncThunk<
//   User,
//   { productId: number; quantity: number; name: string }
// >('cart/removeCartItemsAsync', async ({ productId, quantity }, thunkAPI) => {
//   try {
//     const cartItems = await agent.Cart.removeCartItems(productId, quantity);
//     return cartItems;
//   } catch (error: any) {
//     console.log(error);
//     return thunkAPI.rejectWithValue({ error: error.data });
//   }
// });

const initialState: UserState = {
  user: null,
  status: 'idle',
};

export const userSlice = createSlice({
  name: 'user',
  initialState,
  reducers: {},

  extraReducers: (builder) => {
    builder.addMatcher(
      isAnyOf(postUserLoginAsync.pending, postUserRegisterAsync.pending),
      (state) => {
        state.status = 'pendingUserAction';
      }
    );

    builder.addMatcher(
      isAnyOf(postUserLoginAsync.fulfilled, postUserRegisterAsync.fulfilled),
      (state, action) => {
        state.user = action.payload;
        state.status = 'idle';
      }
    );

    builder.addMatcher(
      isAnyOf(postUserLoginAsync.rejected, postUserRegisterAsync.rejected),
      (state, action) => {
        state.status = 'idle';
        throw action.payload;
      }
    );
  },
});

export default userSlice.reducer;
