using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace DataAccessLayer
{
    public interface IAddLocationDAL
    {
        void AddLocation(Location location);
    }
}
