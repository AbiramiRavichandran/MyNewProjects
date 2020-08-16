using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System;

namespace DataAccessLayer
{
    public class DBHelper
    {
        private readonly string connectionString;
        public DBHelper()
        {
            connectionString = @"Data Source=DESKTOP-CLUDTIB\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        }
        public DBHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<T> GetCollectionFromSP<T>(string storedProcName, List<SqlParameter> sqlParams, Action<SqlDataReader, T> action) where T : class, new()
        {
            List<T> collection = new List<T>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(storedProcName, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var param in sqlParams)
                    {
                        cmd.Parameters.Add(param);
                    }
                    SqlDataReader reader = cmd.ExecuteReader();

                    try
                    {
                        var item = default(T);
                        while (reader.Read())
                        {
                            item = new T();
                            action(reader, item);
                            collection.Add(item);

                        }
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        reader.Close();
                        reader.Dispose();
                    }
                    connection.Close();
                }
            }
            return collection;
        }

        public void ExecuteSP(string storedProcName, List<SqlParameter> sqlParams) 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(storedProcName, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var param in sqlParams)
                    {
                        cmd.Parameters.Add(param);
                    }
                    try
                    {
                        var result = cmd.ExecuteScalar();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    
                    }
                    connection.Close();
                }
           
        }
    }
}
