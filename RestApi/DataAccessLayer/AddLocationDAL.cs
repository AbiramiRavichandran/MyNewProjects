using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Entities;
using System.Data;

namespace DataAccessLayer
{
    public class AddLocationDAL : IAddLocationDAL
    {

        public void AddLocation(Location location) 
        {
            SqlParameter paramAddress = new SqlParameter("@Address", SqlDbType.VarChar);
            paramAddress.Value = location.Address;
            SqlParameter paramCity = new SqlParameter("@City", SqlDbType.VarChar);
            paramCity.Value = location.City;
            SqlParameter paramState = new SqlParameter("@State", SqlDbType.VarChar);
            paramState.Value = location.State;
            SqlParameter paramZip = new SqlParameter("@ZipCpde", SqlDbType.VarChar);
            paramZip.Value = location.ZipCode;
            List<SqlParameter> sqlParams = new List<SqlParameter> { paramAddress, paramCity, paramState, paramZip };
            new DBHelper().GetCollectionFromSP<Location>(Constants.AddLocationSP, sqlParams, DALMapper.Map);
        }
    }
}
