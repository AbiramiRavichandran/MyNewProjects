using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace DataAccessLayer
{
    public interface ISearchAddressDAL
    {
        List<Location> SearchLocation(string searchString);
    }
}
