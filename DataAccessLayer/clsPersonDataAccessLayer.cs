using MyClassLibrary;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StegiHotel_databaseDataAccessLayer
{
    public static class clsPeopleDataAccess
    {
        public static bool GetPersonInfoByID(int PersonID, ref string FirstName, ref string LastName, ref string Email, ref string Phone, ref string IdentificationNum, ref int IdentificationTypeID, ref DateTime DateOfBirth)
        {
            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM People WHERE PersonID = @PersonID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                FirstName = (string)reader["FirstName"];
                                LastName = (string)reader["LastName"];
                                Email = (string)reader["Email"];
                                Phone = reader["Phone"] != DBNull.Value ? (string)reader["Phone"] : Phone = default;
                                IdentificationNum = (string)reader["IdentificationNum"];
                                IdentificationTypeID = (int)reader["IdentificationTypeID"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];

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
        public static int AddNewPerson(string FirstName, string LastName, string Email, string Phone, string IdentificationNum, int IdentificationTypeID, DateTime DateOfBirth)
        {

            int ID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"INSERT INTO People VALUES (@FirstName, @LastName, @Email, @Phone, @IdentificationNum, @IdentificationTypeID, @DateOfBirth)
        SELECT SCOPE_IDENTITY()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@FirstName", FirstName);

                        command.Parameters.AddWithValue("@LastName", LastName);

                        command.Parameters.AddWithValue("@Email", Email);

                        if (Phone == null)
                            command.Parameters.AddWithValue("@Phone", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@IdentificationNum", IdentificationNum);

                        command.Parameters.AddWithValue("@IdentificationTypeID", IdentificationTypeID);

                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);




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


        public static bool UpdatePerson(int PersonID, string FirstName, string LastName, string Email, string Phone, string IdentificationNum, int IdentificationTypeID, DateTime DateOfBirth)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    string query = @"UPDATE People
	SET	FirstName = @FirstName,
	LastName = @LastName,
	Email = @Email,
	Phone = @Phone,
	IdentificationNum = @IdentificationNum,
	IdentificationTypeID = @IdentificationTypeID,
	DateOfBirth = @DateOfBirth	WHERE PersonID = @PersonID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        command.Parameters.AddWithValue("@FirstName", FirstName);

                        command.Parameters.AddWithValue("@LastName", LastName);

                        command.Parameters.AddWithValue("@Email", Email);

                        if (Phone == null)
                            command.Parameters.AddWithValue("@Phone", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@IdentificationNum", IdentificationNum);

                        command.Parameters.AddWithValue("@IdentificationTypeID", IdentificationTypeID);

                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);


                        connection.Open(); rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex) { clsErrorHandling.HandleError(ex); }
            return (rowsAffected > 0);

        }
        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE People WHERE PersonID = @PersonID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { clsErrorHandling.HandleError(ex); }

            return (rowsAffected > 0);

        }

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found=1 FROM People WHERE PersonID= @PersonID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM People";
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