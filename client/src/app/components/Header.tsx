import {
  AppBar,
  Badge,
  Box,
  List,
  ListItem,
  Switch,
  Toolbar,
  Typography,
} from '@mui/material';
import { Link, NavLink } from 'react-router-dom';
import ShoppingCartIcon from '@mui/icons-material/ShoppingCart';
import { useAppSelector } from '../store/configureStore';

interface Props {
  checked: boolean;
  onThemeChange: () => void;
}
const midLinks = [
  { name: 'Products', path: 'products' },
  { name: 'Contact', path: 'contact-us' },
  { name: 'About', path: 'about-us' },
];

const rightLinks = [
  { name: 'Login', path: 'login' },
  { name: 'Register', path: 'register' },
];
const flexProperties = {
  display: 'flex',
  justifyContent: 'space-between',
  alignItems: 'center',
};

const navStyle = {
  typography: 'h6',
  textDecoration: 'none',
  color: 'white',
  '&:hover': {
    color: 'secondary.main',
  },
  '&.active': {
    color: 'text.primary',
  },
};

const Header = ({ checked, onThemeChange }: Props) => {
  const { cart } = useAppSelector((state) => state.cart);
  const totalItem =
    cart && cart.items.reduce((value, item) => value + item.quantity, 0);
  return (
    <Box sx={{ mb: 4 }}>
      <AppBar position='static'>
        <Toolbar sx={flexProperties}>
          <Box
            sx={{
              display: 'flex',
              justifyContent: 'space-between',
              alignItems: 'center',
            }}
          >
            <Typography variant='h6' component={Link} to='/' sx={navStyle}>
              EpicMarket
            </Typography>
            <Switch id='setMode' checked={checked} onChange={onThemeChange} />
          </Box>
          <Box>
            <List sx={flexProperties}>
              {midLinks.map(({ name, path }) => (
                <ListItem key={name}>
                  <Typography
                    variant='h6'
                    component={Link}
                    to={`${path}`}
                    sx={navStyle}
                  >
                    {name}
                  </Typography>
                </ListItem>
              ))}
            </List>
          </Box>
          <Box>
            <List sx={flexProperties}>
              <Badge
                badgeContent={totalItem}
                color='secondary'
                sx={{ mr: 2, ...navStyle }}
                component={NavLink}
                to='/cart'
              >
                <ShoppingCartIcon sx={{ color: 'secondary.dark' }} />
              </Badge>
              {rightLinks.map(({ name, path }) => (
                <ListItem key={name}>
                  <Typography
                    variant='h6'
                    component={Link}
                    to={`${path}`}
                    sx={navStyle}
                  >
                    {name}
                  </Typography>
                </ListItem>
              ))}
            </List>
          </Box>
        </Toolbar>
      </AppBar>
    </Box>
  );
};

export default Header;
