import React from 'react';
import { Link } from 'react-router-dom';
import Home from '../Pages/Home';
import logo from '../utils/image2vector.svg';

const Navbar = () => {
  return (
    <nav className='navbar'>
      <div className='nav-center'>
        <Link to='/'>
          <img src={logo} alt='' className='logo' />
        </Link>
        <ul className='nav-links'>
          <li>
            <Link to='/' className='nav-link'>
              Home
            </Link>
            <Link to='/about' className='nav-link'>
              About
            </Link>
          </li>
        </ul>
      </div>
    </nav>
  );
};

export default Navbar;
