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
import { NavLink } from 'react-router-dom';

const Login = () => {
  const handleSubmit = (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();
    const data = new FormData(event.currentTarget);
    console.log({
      email: data.get('email'),
      password: data.get('password'),
    });
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
            onSubmit={handleSubmit}
            noValidate
            sx={{
              display: 'flex',
              flexDirection: 'column',
              width: '100%',
              gap: 2,
            }}
          >
            <FormControl>
              <FormLabel htmlFor='email'>Email</FormLabel>
              <TextField
                slotProps={{
                  htmlInput: {
                    autoComplete: 'new-email',
                  },
                }}
                // error={emailError}
                // helperText={emailErrorMessage}
                id='email'
                type='email'
                name='email'
                placeholder='your@email.com'
                required
                fullWidth
                variant='outlined'
                // color={emailError ? 'error' : 'primary'}
                sx={{ ariaLabel: 'email' }}
              />
            </FormControl>
            <FormControl>
              <Box sx={{ display: 'flex', justifyContent: 'space-between' }}>
                <FormLabel htmlFor='password'>Password</FormLabel>
              </Box>
              <TextField
                slotProps={{
                  htmlInput: {
                    autoComplete: 'new-password',
                  },
                }}
                // error={passwordError}
                // helperText={passwordErrorMessage}
                name='password'
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
