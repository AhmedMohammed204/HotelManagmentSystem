using System;
using System.Data;
using System.Data.SqlClient;
using MyClassLibrary;
namespace StegiHotel_databaseDataAccessLayer
{
    public static class clsRoomsDataAccess
    {
        public static bool GetRoomInfoByID(int RoomID, ref byte Capacity, ref bool AllowChildern, ref int fees, ref int HotleID, ref int RoomTypeID, ref int TotalSingleBeds, ref int TotalDoubleBeds)
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
                                HotleID = (int)reader["HotleID"];
                                RoomTypeID = (int)reader["RoomTypeID"];
                                TotalSingleBeds = reader["TotalSingleBeds"] != DBNull.Value ? (int)reader["TotalSingleBeds"] : TotalSingleBeds = default;
                                TotalDoubleBeds = reader["TotalDoubleBeds"] != DBNull.Value ? (int)reader["TotalDoubleBeds"] : TotalDoubleBeds = default;

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
        public static int AddNewRoom(byte Capacity, bool AllowChildern, int fees, int HotleID, int RoomTypeID, int TotalSingleBeds, int TotalDoubleBeds)
        {

            int ID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"INSERT INTO Rooms VALUES (@Capacity, @AllowChildern, @fees, @HotleID, @RoomTypeID, @TotalSingleBeds?, @TotalDoubleBeds?)
        SELECT SCOPE_IDENTITY()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@Capacity", Capacity);

                        command.Parameters.AddWithValue("@AllowChildern", AllowChildern);

                        command.Parameters.AddWithValue("@fees", fees);

                        command.Parameters.AddWithValue("@HotleID", HotleID);

                        command.Parameters.AddWithValue("@RoomTypeID", RoomTypeID);

                        if (TotalSingleBeds == null)
                            command.Parameters.AddWithValue("@TotalSingleBeds", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@TotalSingleBeds", TotalSingleBeds);
                        if (TotalDoubleBeds == null)
                            command.Parameters.AddWithValue("@TotalDoubleBeds", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@TotalDoubleBeds", TotalDoubleBeds);



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


        public static bool UpdateRoom(int RoomID, byte Capacity, bool AllowChildern, int fees, int HotleID, int RoomTypeID, int TotalSingleBeds, int TotalDoubleBeds)
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
	HotleID = @HotleID,
	RoomTypeID = @RoomTypeID,
	TotalSingleBeds = @TotalSingleBeds,
	TotalDoubleBeds = @TotalDoubleBeds	WHERE RoomID = @RoomID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@RoomID", RoomID);

                        command.Parameters.AddWithValue("@Capacity", Capacity);

                        command.Parameters.AddWithValue("@AllowChildern", AllowChildern);

                        command.Parameters.AddWithValue("@fees", fees);

                        command.Parameters.AddWithValue("@HotleID", HotleID);

                        command.Parameters.AddWithValue("@RoomTypeID", RoomTypeID);

                        if (TotalSingleBeds == null)
                            command.Parameters.AddWithValue("@TotalSingleBeds", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@TotalSingleBeds", TotalSingleBeds);
                        if (TotalDoubleBeds == null)
                            command.Parameters.AddWithValue("@TotalDoubleBeds", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@TotalDoubleBeds", TotalDoubleBeds);

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