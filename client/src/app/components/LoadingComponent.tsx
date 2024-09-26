import { Box, CircularProgress, Typography } from '@mui/material';

interface Props {
  message: string;
}
const LoadingComponent = ({ message }: Props) => {
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
      <CircularProgress size={60} />
      <Typography variant='h4' mt={4}>
        {message || 'Loading, please wait...'}
      </Typography>
    </Box>
  );
};

export default LoadingComponent;
