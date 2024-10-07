import * as React from 'react';
import Menu from '@mui/material/Menu';
import MenuItem from '@mui/material/MenuItem';
import { User } from '../models/User';
import { Typography } from '@mui/material';
import { setLogout } from '../features/account/accountSlice';
import { useAppDispatch } from '../store/configureStore';

interface Props {
  user: User;
}
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
const UserLoggedInMenu = ({ user }: Props) => {
  const [anchorEl, setAnchorEl] = React.useState<null | HTMLElement>(null);
  const dispatch = useAppDispatch();
  const open = Boolean(anchorEl);
  const handleClick = (event: React.MouseEvent<HTMLButtonElement>) => {
    setAnchorEl(event.currentTarget);
  };
  const handleClose = () => {
    setAnchorEl(null);
  };

  return (
    <div>
      <Typography
        variant='body1'
        sx={{ cursor: 'pointer', ...navStyle }}
        aria-controls={open ? 'basic-menu' : undefined}
        aria-haspopup='true'
        aria-expanded={open ? 'true' : undefined}
        onClick={handleClick}
      >
        {user.userName.charAt(0).toUpperCase() + user.userName.slice(1)}
      </Typography>
      <Menu
        id='basic-menu'
        anchorEl={anchorEl}
        open={open}
        onClose={handleClose}
        MenuListProps={{
          'aria-labelledby': 'basic-button',
        }}
      >
        <MenuItem onClick={handleClose}>Profile</MenuItem>
        <MenuItem onClick={handleClose}>My Orders</MenuItem>
        <MenuItem
          onClick={() => {
            handleClose();
            dispatch(setLogout());
          }}
        >
          Logout
        </MenuItem>
      </Menu>
    </div>
  );
};

export default UserLoggedInMenu;
