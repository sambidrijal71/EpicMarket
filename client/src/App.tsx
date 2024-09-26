import {
  Container,
  createTheme,
  CssBaseline,
  ThemeProvider,
} from '@mui/material';
import Header from './app/components/Header';
import Footer from './app/components/Footer';
import { Outlet } from 'react-router';
import { useState } from 'react';

const App = () => {
  const [darkTheme, setDarkTheme] = useState<boolean>(true);

  const paletteType = darkTheme == true ? 'dark' : 'light';
  const theme = createTheme({
    palette: {
      mode: paletteType,
      background: {
        default: paletteType == 'dark' ? '#212121' : '#fafafa',
      },
    },
    typography: {
      fontFamily: 'Raleway, Arial',
    },
  });

  const handleThemeChange = () => {
    setDarkTheme(!darkTheme);
  };

  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <Header checked={darkTheme} onThemeChange={handleThemeChange} />
      <Container
        sx={{ display: 'flex', flexDirection: 'column', minHeight: '71vh' }}
      >
        <Outlet />
      </Container>
      <Footer />
    </ThemeProvider>
  );
};

export default App;
