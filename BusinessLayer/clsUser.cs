using PeopleBusinessLayer;
using StegiHotel_databaseDataAccessLayer;
using System.Data;
namespace UsersBusinessLayer
{

    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get; set; }

        public clsUser()
        {
            this.UserID = default;
            this.Username = default;
            this.Password = default;
            this.IsActive = default;
            this.PersonID = default;


            Mode = enMode.AddNew;

        }

        private clsUser(int UserID, string Username, string Password, bool IsActive, int PersonID)
        {
            this.UserID = UserID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            this.PersonID = PersonID;
            PersonInfo = clsPerson.Find(PersonID);

            Mode = enMode.Update;

        }

        private bool _AddNewUser()
        {
            //call DataAccess Layer 

            this.UserID = clsUsersDataAccess.AddNewUser(this.Username, this.Password, this.IsActive, this.PersonID);

            return (this.UserID != -1);

        }

        private bool _UpdateUser()
        {
            //call DataAccess Layer 

            return clsUsersDataAccess.UpdateUser(this.UserID, this.Username, this.Password, this.IsActive, this.PersonID);

        }

        public static clsUser Find(int UserID)
        {
            string Username = default;
            string Password = default;
            bool IsActive = default;
            int PersonID = default;


            if (clsUsersDataAccess.GetUserInfoByID(UserID, ref Username, ref Password, ref IsActive, ref PersonID))
                return new clsUser(UserID, Username, Password, IsActive, PersonID);
            else
                return null;

        }

        public static clsUser Find(string Username)
        {
            int UserID = default;
            string Password = default;
            bool IsActive = default;
            int PersonID = default;


            if (clsUsersDataAccess.GetUserInfoByUsername(ref UserID, ref Username, ref Password, ref IsActive, ref PersonID))
                return new clsUser(UserID, Username, Password, IsActive, PersonID);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }




            return false;
        }

        public static DataTable GetAllUsers() { return clsUsersDataAccess.GetAllUsers(); }

        public static bool DeleteUser(int UserID) { return clsUsersDataAccess.DeleteUser(UserID); }

        public static bool isUserExist(int UserID) { return clsUsersDataAccess.IsUserExist(UserID); }

        public static bool IsAbleToLogin(string Username, string Password)
        {
            return clsUsersDataAccess.IsAbleToLogin(Username, Password);
        }
    }

}