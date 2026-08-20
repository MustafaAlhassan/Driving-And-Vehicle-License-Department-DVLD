using System;
using System.Collections.Generic;
using System.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DVLDDataAccessLayer
{
    public class clsCountriesData
    {
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * from Countries";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
    }
}
