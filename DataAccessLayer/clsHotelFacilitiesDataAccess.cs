using MyClassLibrary;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StegiHotel_databaseDataAccessLayer
{
    public static class clsHotelFacilitiesDataAccess
    {
        public static bool GetHotelFacilityInfoByID(int HotelFacilitiesID, ref string Name, ref string Description, ref int HotleID)
        {
            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM HotelFacilities WHERE HotelFacilitiesID = @HotelFacilitiesID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HotelFacilitiesID", HotelFacilitiesID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                HotelFacilitiesID = (int)reader["HotelFacilitiesID"];
                                Name = (string)reader["Name"];
                                Description = (string)reader["Description"];
                                HotleID = (int)reader["HotleID"];

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
        public static int AddNewHotelFacility(string Name, string Description, int HotleID)
        {

            int ID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"INSERT INTO HotelFacilities VALUES (@Name, @Description, @HotleID)
        SELECT SCOPE_IDENTITY()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@Name", Name);

                        command.Parameters.AddWithValue("@Description", Description);

                        command.Parameters.AddWithValue("@HotleID", HotleID);




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


        public static bool UpdateHotelFacility(int HotelFacilitiesID, string Name, string Description, int HotleID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"UPDATE HotelFacilities
	SET	Name = @Name,
	Description = @Description,
	HotleID = @HotleID	WHERE HotelFacilitiesID = @HotelFacilitiesID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@HotelFacilitiesID", HotelFacilitiesID);

                        command.Parameters.AddWithValue("@Name", Name);

                        command.Parameters.AddWithValue("@Description", Description);

                        command.Parameters.AddWithValue("@HotleID", HotleID);


                        connection.Open(); rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            return (rowsAffected > 0);

        }
        public static bool DeleteHotelFacility(int HotelFacilitiesID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE HotelFacilities WHERE HotelFacilitiesID = @HotelFacilitiesID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@HotelFacilitiesID", HotelFacilitiesID);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }

            return (rowsAffected > 0);

        }

        public static bool IsHotelFacilityExist(int HotelFacilitiesID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found=1 FROM HotelFacilities WHERE HotelFacilitiesID= @HotelFacilitiesID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@HotelFacilitiesID", HotelFacilitiesID);

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

        public static DataTable GetAllHotelFacilities()
        {

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM HotelFacilities";
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