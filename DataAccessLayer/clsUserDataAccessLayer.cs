using MyClassLibrary;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StegiHotel_databaseDataAccessLayer
{

    public static class clsUsersDataAccess
    {
        public static bool GetUserInfoByID(int UserID, ref string Username, ref string Password, ref bool IsActive, ref int PersonID)
        {
            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Users WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                UserID = (int)reader["UserID"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];
                                PersonID = (int)reader["PersonID"];

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


        public static bool GetUserInfoByUsername(ref int UserID, ref string Username, ref string Password, ref bool IsActive, ref int PersonID)
        {
            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Users WHERE Username = @Username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                UserID = (int)reader["UserID"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];
                                PersonID = (int)reader["PersonID"];

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




        public static int AddNewUser(string Username, string Password, bool IsActive, int PersonID)
        {

            int ID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"INSERT INTO Users VALUES (@Username, @Password, @IsActive, @PersonID)
        SELECT SCOPE_IDENTITY()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@Username", Username);

                        command.Parameters.AddWithValue("@Password", Password);

                        command.Parameters.AddWithValue("@IsActive", IsActive);

                        command.Parameters.AddWithValue("@PersonID", PersonID);




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


        public static bool UpdateUser(int UserID, string Username, string Password, bool IsActive, int PersonID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"UPDATE Users
	SET	Username = @Username,
	Password = @Password,
	IsActive = @IsActive,
	PersonID = @PersonID	WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@UserID", UserID);

                        command.Parameters.AddWithValue("@Username", Username);

                        command.Parameters.AddWithValue("@Password", Password);

                        command.Parameters.AddWithValue("@IsActive", IsActive);

                        command.Parameters.AddWithValue("@PersonID", PersonID);


                        connection.Open(); rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            return (rowsAffected > 0);

        }
        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE Users WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@UserID", UserID);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }

            return (rowsAffected > 0);

        }

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found=1 FROM Users WHERE UserID= @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@UserID", UserID);

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

        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Users";
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

        public static bool IsAbleToLogin(string Username, string Password)
        {
            int result = 0;
            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand("sp_Login", connection))
                {
                    connection.Open();

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    command.Parameters.Add(returnParameter);
                    command.ExecuteNonQuery();

                    result = (int)returnParameter.Value;
                }
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }

            return result == 1;
        }
    }

}