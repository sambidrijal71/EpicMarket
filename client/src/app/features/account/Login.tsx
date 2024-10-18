import {
  Box,
  Button,
  Container,
  FormControl,
  FormLabel,
  Paper,
  TextField,
  Typography,
} from '@mui/material';
import { SubmitHandler, useForm } from 'react-hook-form';
import { NavLink, useLocation, useNavigate } from 'react-router-dom';
import { useAppDispatch } from '../../store/configureStore';
import { postUserLoginAsync } from './accountSlice';
import { toast } from 'react-toastify';

type Input = {
  userName: string;
  password: string;
};
const Login = () => {
  const {
    register,
    handleSubmit,
    setError,
    formState: { errors },
  } = useForm<Input>({
    defaultValues: {
      userName: 'member',
      password: 'Pa$$w0rd',
    },
    mode: 'onChange',
  });
  const dispatch = useAppDispatch();
  const navigate = useNavigate();
  const location = useLocation();
  const handleUserSubmit: SubmitHandler<Input> = async (data) => {
    try {
      await dispatch(postUserLoginAsync(data)).then(() =>
        navigate(location.state?.from || '/products')
      );
      toast.success('Login successful.');
    } catch (error: any) {
      console.log(error.response.data.title);
      const { title } = error.response.data;
      if (title.includes('email')) setError('userName', { message: '' });
      if (title.includes('password'))
        setError('password', { message: error.response.data.title });
      toast.error(error);
    }
  };

  return (
    <Container
      sx={{
        height: '60vh',
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
      }}
    >
      <Paper>
        <Box sx={{ padding: 4, width: 450 }}>
          <Typography
            component='h1'
            variant='h4'
            textAlign={'center'}
            paddingBottom={4}
          >
            Login
          </Typography>
          <Box
            component='form'
            onSubmit={handleSubmit(handleUserSubmit)}
            noValidate
            sx={{
              display: 'flex',
              flexDirection: 'column',
              width: '100%',
              gap: 2,
            }}
          >
            <FormControl>
              <FormLabel>Email</FormLabel>
              <TextField
                {...register('userName', {
                  required: 'Username field cannot be empty.',
                })}
                slotProps={{
                  htmlInput: {
                    autoComplete: 'new-email',
                  },
                }}
                error={!!errors.userName}
                helperText={errors.userName?.message}
                id='userName'
                type='text'
                placeholder='username71'
                required
                fullWidth
                variant='outlined'
                sx={{ ariaLabel: 'email' }}
              />
            </FormControl>
            <FormControl>
              <Box sx={{ display: 'flex', justifyContent: 'space-between' }}>
                <FormLabel>Password</FormLabel>
              </Box>
              <TextField
                {...register('password', {
                  required: 'Password field cannot be empty.',
                })}
                slotProps={{
                  htmlInput: {
                    autoComplete: 'new-password',
                  },
                }}
                error={!!errors.password}
                helperText={errors.password?.message}
                placeholder='••••••'
                type='password'
                id='password'
                required
                fullWidth
                variant='outlined'
                // color={passwordError ? 'error' : 'primary'}
              />
            </FormControl>
            <Button type='submit' fullWidth variant='contained'>
              Login
            </Button>
            <Typography sx={{ textAlign: 'center' }}>
              Don&apos;t have an account?{' '}
              <span>
                <Button
                  variant='outlined'
                  component={NavLink}
                  to='/register'
                  sx={{
                    alignSelf: 'center',
                    textDecoration: 'none',
                    color: 'inherit',
                    marginLeft: '10px',
                  }}
                >
                  Register
                </Button>
              </span>
            </Typography>
          </Box>
        </Box>
      </Paper>
    </Container>
  );
};
export default Login;
