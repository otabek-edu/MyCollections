import React from 'react';
import {Link} from "react-router-dom";

const MyLink = ({to, value}) => {
  return (
      <>
        <Link
            to={to}
            children={value}
            className='link-offset-2-hover link-dark link-body-emphasis'
        />
      </>
  );
};

export default MyLink;