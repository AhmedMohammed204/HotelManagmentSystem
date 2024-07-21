using MyClassLibrary;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StegiHotel_databaseDataAccessLayer
{
    public static class clsHotlesDataAccess
    {
        public static bool GetHotleInfoByID(int HotleID, ref string Address, ref int CountryID, ref string Description)
        {
            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Hotles WHERE HotleID = @HotleID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HotleID", HotleID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                HotleID = (int)reader["HotleID"];
                                Address = (string)reader["Address"];
                                CountryID = (int)reader["CountryID"];
                                Description = (string)reader["Description"];

                            }
                            else
                            {
                                isFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            return isFound;

        }
        public static int AddNewHotle(string Address, int CountryID, string Description)
        {

            int ID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"INSERT INTO Hotles VALUES (@Address, @CountryID, @Description)
        SELECT SCOPE_IDENTITY()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@Address", Address);

                        command.Parameters.AddWithValue("@CountryID", CountryID);

                        command.Parameters.AddWithValue("@Description", Description);




                        connection.Open();

                        object result = command.ExecuteScalar();


                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ID = insertedID;
                        }
                    }
                }
            }

            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            return ID;

        }


        public static bool UpdateHotle(int HotleID, string Address, int CountryID, string Description)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"UPDATE Hotles
	SET	Address = @Address,
	CountryID = @CountryID,
	Description = @Description	WHERE HotleID = @HotleID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@HotleID", HotleID);

                        command.Parameters.AddWithValue("@Address", Address);

                        command.Parameters.AddWithValue("@CountryID", CountryID);

                        command.Parameters.AddWithValue("@Description", Description);


                        connection.Open(); rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            return (rowsAffected > 0);

        }
        public static bool DeleteHotle(int HotleID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE Hotles WHERE HotleID = @HotleID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@HotleID", HotleID);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }

            return (rowsAffected > 0);

        }

        public static bool IsHotleExist(int HotleID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found=1 FROM Hotles WHERE HotleID= @HotleID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@HotleID", HotleID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }

            return isFound;

        }

        public static DataTable GetAllHotles()
        {

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Hotles";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) dt.Load(reader);
                            reader.Close();
                        }
                    }
                }
            }

            catch (Exception ex) { clsErrorHandling.HandleError(ex); }

            return dt;
        }


    }

}