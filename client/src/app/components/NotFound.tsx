import { Box, Button, Typography } from '@mui/material';
import { useNavigate } from 'react-router';

interface Props {
  message: string;
}
const NotFound = ({ message }: Props) => {
  const navigate = useNavigate();
  return (
    <Box
      sx={{
        display: 'flex',
        flexDirection: 'column',
        height: '80vh',
        alignItems: 'center',
        justifyContent: 'center',
      }}
    >
      <Typography variant='h4' mb={4}>
        {message || 'Not Found what you are looking for...'}
      </Typography>
      <Button onClick={() => navigate('/')} variant='outlined'>
        Back to Home
      </Button>
    </Box>
  );
};

export default NotFound;
