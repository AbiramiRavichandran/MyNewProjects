using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Entities;

namespace BusinessLogicLayer
{
    public class SearchAddressBLL : ISearchAddressBLL
    {
        ISearchAddressDAL SearchAddressDAL;
        public SearchAddressBLL()
        {
            SearchAddressDAL = new SearchAddressDAL();
        }
       
        public List<Location> SearchLocation(string searchString)
        {
            if (Validate(searchString))
            {
                return SearchAddressDAL.SearchLocation(searchString);

            }
            else
            {
                throw new Exception("The search text should have minimum 3 characters ");
            }

        }
        private bool Validate(string searchString)
        {
            if (searchString.Length >= 3)
                return true;
            else
                return false;
        }
    }
}
