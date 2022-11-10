import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import IconButton from '@mui/material/IconButton';
import Typography from '@mui/material/Typography';
import Menu from '@mui/material/Menu';
import Avatar from '@mui/material/Avatar';
import Button from '@mui/material/Button';
import Tooltip from '@mui/material/Tooltip';
import MenuItem from '@mui/material/MenuItem';

import { useAuth0 } from "@auth0/auth0-react";

const NavBar = () => {

  let navigate = useNavigate();
  const [anchorElUser, setAnchorElUser] = useState(null);

  const {
    user,
    isAuthenticated,
    loginWithRedirect,
    logout,
  } = useAuth0();

  const logoutWithRedirect = () =>
    logout({
      returnTo: window.location.origin,
    });

  const handleOpenUserMenu = (event) => {
    setAnchorElUser(event.currentTarget);
  };

  const handleCloseUserMenu = () => {
    setAnchorElUser(null);
  };

  const routeChange = (path) => {
    navigate(path);
  }

  return (
    <Box sx={{ flexGrow: 1 }}>
      <AppBar position="static">
        <Toolbar>
          <Box sx={{ display: { xs: 'none', sm: 'block' } }}>
            <Button key="Home" sx={{ color: '#fff' }} onClick={() => routeChange('')}>
              Home
            </Button>
            {isAuthenticated && (
              <Button key="Functionality" sx={{ color: '#fff' }} onClick={() => routeChange('functionality')}>
                Functionality
              </Button>
            )}
          </Box>
          <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
            Secure Application Example
          </Typography>
          {!isAuthenticated && (
            <Button color="inherit" onClick={() => loginWithRedirect()}>Login</Button>
          )}
          {isAuthenticated && (
            <Box sx={{ flexGrow: 0 }}>
              <Tooltip title="Open settings">
                <IconButton onClick={handleOpenUserMenu} sx={{ p: 0 }}>
                  <Avatar src={user.picture} />
                </IconButton>
              </Tooltip>
              <Menu
                sx={{ mt: '45px' }}
                id="menu-appbar"
                anchorEl={anchorElUser}
                anchorOrigin={{
                  vertical: 'top',
                  horizontal: 'right',
                }}
                keepMounted
                transformOrigin={{
                  vertical: 'top',
                  horizontal: 'right',
                }}
                open={Boolean(anchorElUser)}
                onClose={handleCloseUserMenu}
              >
                <MenuItem key="profile" onClick={handleCloseUserMenu}>
                  <Typography textAlign="center" onClick={() => routeChange('profile')}>
                    Profile
                  </Typography>
                </MenuItem>
              </Menu>
              <Button color="inherit" onClick={() => logoutWithRedirect()}>Logout</Button>
            </Box>
          )}
        </Toolbar>
      </AppBar>
    </Box>
  );
};

export default NavBar;
