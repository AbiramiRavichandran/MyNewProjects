using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Entities;

namespace DataAccessLayer
{
    public static class DALMapper
    {
        public static void Map(SqlDataReader reader,Location data)
        {
            data.Address = reader["Address"].ToString();
            data.City = reader["City"].ToString();
            data.State = reader["State"].ToString();
            data.ZipCode = reader["ZipCode"].ToString();
        }
    }
}
