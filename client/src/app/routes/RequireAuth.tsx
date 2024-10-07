import { Navigate, Outlet, useLocation } from 'react-router';
import { useAppSelector } from '../store/configureStore';

const RequireAuth = () => {
  const { user } = useAppSelector((state) => state.user);
  const location = useLocation();
  if (user) {
    return <Outlet />;
  } else {
    return <Navigate to='/login' state={{ from: location }} />;
  }
};

export default RequireAuth;
