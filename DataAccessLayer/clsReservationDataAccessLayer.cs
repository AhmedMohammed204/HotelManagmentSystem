using MyClassLibrary;
using System;
using System.Data;
using System.Data.SqlClient;
namespace StegiHotel_databaseDataAccessLayer
{
    public static class clsReservationsDataAccess
    {
        public static bool GetReservationInfoByID(int ReservationID, ref int RoomID, ref int PersonID, ref int CreatedByUserID, ref decimal PaidFees, ref DateTime StartDay, ref DateTime EndDay)
        {
            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Reservations WHERE ReservationID = @ReservationID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", ReservationID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ReservationID = (int)reader["ReservationID"];
                                RoomID = (int)reader["RoomID"];
                                PersonID = (int)reader["PersonID"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                PaidFees = (decimal)reader["PaidFees"];
                                StartDay = (DateTime)reader["StartDay"];
                                EndDay = (DateTime)reader["EndDay"];

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
        public static int AddNewReservation(int RoomID, int PersonID, int CreatedByUserID, decimal PaidFees, DateTime StartDay, DateTime EndDay)
        {

            int ID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"INSERT INTO Reservations VALUES (@RoomID, @PersonID, @CreatedByUserID, @PaidFees, @StartDay, @EndDay)
        SELECT SCOPE_IDENTITY()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@RoomID", RoomID);

                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        command.Parameters.AddWithValue("@PaidFees", PaidFees);

                        command.Parameters.AddWithValue("@StartDay", StartDay);

                        command.Parameters.AddWithValue("@EndDay", EndDay);




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


        public static bool UpdateReservation(int ReservationID, int RoomID, int PersonID, int CreatedByUserID, decimal PaidFees, DateTime StartDay, DateTime EndDay)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"UPDATE Reservations
	SET	RoomID = @RoomID,
	PersonID = @PersonID,
	CreatedByUserID = @CreatedByUserID,
	PaidFees = @PaidFees,
	StartDay = @StartDay,
	EndDay = @EndDay	WHERE ReservationID = @ReservationID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@ReservationID", ReservationID);

                        command.Parameters.AddWithValue("@RoomID", RoomID);

                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        command.Parameters.AddWithValue("@PaidFees", PaidFees);

                        command.Parameters.AddWithValue("@StartDay", StartDay);

                        command.Parameters.AddWithValue("@EndDay", EndDay);


                        connection.Open(); rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            return (rowsAffected > 0);

        }
        public static bool DeleteReservation(int ReservationID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE Reservations WHERE ReservationID = @ReservationID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ReservationID", ReservationID);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }

            return (rowsAffected > 0);

        }

        public static bool IsReservationExist(int ReservationID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found=1 FROM Reservations WHERE ReservationID= @ReservationID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ReservationID", ReservationID);

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

        public static DataTable GetAllReservations()
        {

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Reservations";
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

        public static int Book(int RoomID, int PersonID, int CreatedByUserID, double PaidFees, DateTime StartDate, DateTime EndDate)
        {
            int ReservationID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_BookRoom", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@RoomID", RoomID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@StartDay", StartDate);
                        command.Parameters.AddWithValue("@EndDay", EndDate);

                        SqlParameter outputIdParam = new SqlParameter("@ReservationID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        SqlParameter returnValue = new SqlParameter()
                            {Direction = ParameterDirection.ReturnValue};
                        command.Parameters.Add(returnValue);

                        connection.Open();

                        command.ExecuteNonQuery();

                        int result = (int)returnValue.Value;

                        if (result == 1)
                        {
                            ReservationID = (int)outputIdParam.Value;
                        }
                        else
                        {
                            throw new Exception("There was an error with adding new Reservation");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorHandling.HandleError(ex);
            }

            return ReservationID;
        }

    }

}