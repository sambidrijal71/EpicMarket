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
import { NavLink } from 'react-router-dom';
import { useAppDispatch } from '../../store/configureStore';
import { postUserRegisterAsync } from './accountSlice';

type Input = {
  userName: string;
  email: string;
  password: string;
};
const Register = () => {
  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm<Input>({
    defaultValues: {
      userName: 'member',
      email: 'member@test.com',
      password: 'Pa$$w0rd',
    },
    mode: 'onChange',
  });
  const dispatch = useAppDispatch();
  const handleUserSubmit: SubmitHandler<Input> = (data) => {
    dispatch(postUserRegisterAsync(data));
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
            Register
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
              <FormLabel>Username</FormLabel>
              <TextField
                {...register('userName', {
                  required: 'Username field cannot be empty.',
                  pattern: {
                    value: /^(?!.*\.\.)(?!.*\.$)[^\W][\w.]{4,10}$/gim,
                    message: 'Username should be between 5-10 char long.',
                  },
                })}
                slotProps={{
                  htmlInput: {
                    autoComplete: 'new-userName',
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
              />
            </FormControl>
            <FormControl>
              <FormLabel>Email</FormLabel>
              <TextField
                {...register('email', {
                  required: 'Email field cannot be empty.',
                  pattern: {
                    value: /\b[\w.-]+@[\w.-]+\.\w{2,4}\b/gi,
                    message: 'Invalid email format. Please try again.',
                  },
                })}
                slotProps={{
                  htmlInput: {
                    autoComplete: 'new-email',
                  },
                }}
                error={!!errors.email}
                helperText={errors.email?.message}
                id='email'
                type='text'
                placeholder='youremail@test.com'
                required
                fullWidth
                variant='outlined'
              />
            </FormControl>
            <FormControl>
              <Box sx={{ display: 'flex', justifyContent: 'space-between' }}>
                <FormLabel>Password</FormLabel>
              </Box>
              <TextField
                {...register('password', {
                  required: 'Password field cannot be empty.',
                  pattern: {
                    value:
                      /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$/gm,
                    message:
                      'Password must contain atleast 8 characters including each of upper, lower case, number and special character.',
                  },
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
              Register
            </Button>
            <Typography sx={{ textAlign: 'center' }}>
              Already have an account?{' '}
              <span>
                <Button
                  variant='outlined'
                  component={NavLink}
                  to='/login'
                  sx={{
                    alignSelf: 'center',
                    textDecoration: 'none',
                    color: 'inherit',
                    marginLeft: '10px',
                  }}
                >
                  Login
                </Button>
              </span>
            </Typography>
          </Box>
        </Box>
      </Paper>
    </Container>
  );
};
export default Register;
