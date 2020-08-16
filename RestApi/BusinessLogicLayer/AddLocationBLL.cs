using System;
using DataAccessLayer;
using Entities;

namespace BusinessLogicLayer
{
    public class AddLocationBLL : IAddLocationBLL
    {
        IAddLocationDAL addLocationDAL;
        public AddLocationBLL()
        {
            addLocationDAL = new AddLocationDAL();
        }
        public void AddLocation(Location location)
        {
            
            addLocationDAL.AddLocation(location);
        }
    }
}
