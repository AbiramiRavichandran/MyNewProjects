using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entities;

namespace DataAccessLayer
{
    public class SearchAddressDAL : ISearchAddressDAL
    {
        public List<Location> SearchLocation(string searchString)
        {
            SqlParameter paramSearchString = new SqlParameter("@SearchText", SqlDbType.VarChar);
            paramSearchString.Value = searchString;
            
            List<SqlParameter> sqlParams = new List<SqlParameter> { paramSearchString };
            var result = new DBHelper().GetCollectionFromSP<Location>(Constants.SearchLocationSP, sqlParams, DALMapper.Map);
            return result;
        }
    }
}
