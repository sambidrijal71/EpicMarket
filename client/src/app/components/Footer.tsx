import { AppBar, Box, Toolbar, Typography } from '@mui/material';

const Footer = () => {
  return (
    <Box sx={{ flexGrow: 1 }}>
      <AppBar position='static'>
        <Toolbar>
          <Typography
            variant='h6'
            component='div'
            sx={{ flexGrow: 1, textAlign: 'center' }}
          >
            EpicMarket &copy;
          </Typography>
        </Toolbar>
      </AppBar>
    </Box>
  );
};

export default Footer;
