import { createAsyncThunk, createSlice, isAnyOf } from '@reduxjs/toolkit';
import { agent } from '../../api/agent';
import { User } from '../../models/User';
import { FieldValues } from 'react-hook-form';
import { router } from '../../routes/Routes';
import { toast } from 'react-toastify';
import { setCart } from '../cart/cart.Slice';

export interface UserState {
  user: User | null;
  status: string;
}

export const postUserLoginAsync = createAsyncThunk<User, FieldValues>(
  'account/postUserLoginAsync',
  async (data, thunkAPI) => {
    try {
      const userDto = await agent.Account.login(data);
      const { cart, ...user } = userDto;
      if (cart) thunkAPI.dispatch(setCart(cart));
      localStorage.setItem('user', JSON.stringify(user));
      return user;
    } catch (error: any) {
      return thunkAPI.rejectWithValue(error);
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
      return thunkAPI.rejectWithValue(error);
    }
  }
);

export const getUserAsync = createAsyncThunk<User>(
  'account/getUserAsync',
  async (_, thunkAPI) => {
    thunkAPI.dispatch(setUser(JSON.parse(localStorage.getItem('user')!)));
    try {
      const userDto = await agent.Account.getUser();
      const { cart, ...user } = userDto;
      localStorage.setItem('user', JSON.stringify(user));
      if (cart) thunkAPI.dispatch(setCart(cart));
      return user;
    } catch (error: any) {
      console.log(error);
      return thunkAPI.rejectWithValue({ error: error.data });
    }
  },
  {
    condition: () => {
      if (!localStorage.getItem('user')) return false;
    },
  }
);

const initialState: UserState = {
  user: null,
  status: 'idle',
};

export const userSlice = createSlice({
  name: 'user',
  initialState,
  reducers: {
    setUser: (state, action) => {
      state.user = action.payload;
    },
    setLogout: (state) => {
      state.user = null;
      localStorage.removeItem('user');
      router.navigate('/');
      toast.success('Logged out successfully.');
    },
  },

  extraReducers: (builder) => {
    builder.addCase(getUserAsync.rejected, (state) => {
      state.user = null;
      localStorage.removeItem('user');
      router.navigate('/login');
      toast.error('Token expired, please login again.');
    });
    builder.addMatcher(
      isAnyOf(
        postUserLoginAsync.pending,
        postUserRegisterAsync.pending,
        getUserAsync.pending
      ),
      (state) => {
        state.status = 'pendingUserAction';
      }
    );

    builder.addMatcher(
      isAnyOf(
        postUserLoginAsync.fulfilled,
        postUserRegisterAsync.fulfilled,
        getUserAsync.fulfilled
      ),
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
export const { setUser, setLogout } = userSlice.actions;

export default userSlice.reducer;
