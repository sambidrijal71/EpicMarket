import { List, ListItem, Paper, Typography } from '@mui/material';

const Footer = () => {
  return (
    <Paper
      sx={{
        marginTop: 4,
        width: '100%',
        position: 'relative',
        left: 0,
        bottom: 0,
        right: 0,
        color: 'inherit',
      }}
      component='footer'
      square
      variant='outlined'
    >
      <List>
        <ListItem
          sx={{
            display: 'flex',
            flexDirection: 'column',
            justifyContent: 'space-around',
            alignItems: 'center',
          }}
        >
          <Typography>StoreCart</Typography>
          <Typography>Copyright &copy; StoreCart, Inc.</Typography>
          <Typography>All rights reserved.</Typography>
        </ListItem>
      </List>
    </Paper>
  );
};

export default Footer;
