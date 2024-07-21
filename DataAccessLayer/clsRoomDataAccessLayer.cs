using MyClassLibrary;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StegiHotel_databaseDataAccessLayer
{
    public static class clsRoomsDataAccess
    {
        public static bool GetRoomInfoByID(int RoomID, ref byte Capacity, ref bool AllowChildern, ref int fees, ref bool IsVacant, ref int HotleID)
        {
            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Rooms WHERE RoomID = @RoomID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomID", RoomID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                RoomID = (int)reader["RoomID"];
                                Capacity = (byte)reader["Capacity"];
                                AllowChildern = (bool)reader["AllowChildern"];
                                fees = (int)reader["fees"];
                                IsVacant = (bool)reader["IsVacant"];
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
        public static int AddNewRoom(byte Capacity, bool AllowChildern, int fees, bool IsVacant, int HotleID)
        {

            int ID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"INSERT INTO Rooms VALUES (@Capacity, @AllowChildern, @fees, @IsVacant, @HotleID)
        SELECT SCOPE_IDENTITY()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@Capacity", Capacity);

                        command.Parameters.AddWithValue("@AllowChildern", AllowChildern);

                        command.Parameters.AddWithValue("@fees", fees);

                        command.Parameters.AddWithValue("@IsVacant", IsVacant);

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


        public static bool UpdateRoom(int RoomID, byte Capacity, bool AllowChildern, int fees, bool IsVacant, int HotleID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"UPDATE Rooms
	SET	Capacity = @Capacity,
	AllowChildern = @AllowChildern,
	fees = @fees,
	IsVacant = @IsVacant,
	HotleID = @HotleID	WHERE RoomID = @RoomID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@RoomID", RoomID);

                        command.Parameters.AddWithValue("@Capacity", Capacity);

                        command.Parameters.AddWithValue("@AllowChildern", AllowChildern);

                        command.Parameters.AddWithValue("@fees", fees);

                        command.Parameters.AddWithValue("@IsVacant", IsVacant);

                        command.Parameters.AddWithValue("@HotleID", HotleID);


                        connection.Open(); rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            return (rowsAffected > 0);

        }
        public static bool DeleteRoom(int RoomID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE Rooms WHERE RoomID = @RoomID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@RoomID", RoomID);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }

            return (rowsAffected > 0);

        }

        public static bool IsRoomExist(int RoomID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found=1 FROM Rooms WHERE RoomID= @RoomID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@RoomID", RoomID);

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

        public static DataTable GetAllRooms()
        {

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Rooms";
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