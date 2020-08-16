using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public interface ISearchAddressBLL
    {
        List<Location> SearchLocation(string searchString);
    }
}
