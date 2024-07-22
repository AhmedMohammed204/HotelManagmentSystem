using IdentificationTypesBusinessLayer;
using StegiHotel_databaseDataAccessLayer;
using System;
using System.Data;
namespace PeopleBusinessLayer
{

    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string IdentificationNum { get; set; }
        public int IdentificationTypeID { get; set; }
        public DateTime DateOfBirth { get; set; }

        public clsIdentificationType IdInfo { get; set; }
        public clsPerson()
        {
            this.PersonID = default;
            this.FirstName = default;
            this.LastName = default;
            this.Email = default;
            this.Phone = default;
            this.IdentificationNum = default;
            this.IdentificationTypeID = default;
            this.DateOfBirth = default;


            Mode = enMode.AddNew;

        }

        private clsPerson(int PersonID, string FirstName, string LastName, string Email, string Phone, string IdentificationNum, int IdentificationTypeID, DateTime DateOfBirth)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.IdentificationNum = IdentificationNum;
            this.IdentificationTypeID = IdentificationTypeID;
            this.DateOfBirth = DateOfBirth;
            IdInfo = clsIdentificationType.Find(IdentificationTypeID);

            Mode = enMode.Update;

        }

        private bool _AddNewPerson()
        {
            //call DataAccess Layer 

            this.PersonID = clsPeopleDataAccess.AddNewPerson(this.FirstName, this.LastName, this.Email, this.Phone, this.IdentificationNum, this.IdentificationTypeID, this.DateOfBirth);

            return (this.PersonID != -1);

        }

        private bool _UpdatePerson()
        {
            //call DataAccess Layer 

            return clsPeopleDataAccess.UpdatePerson(this.PersonID, this.FirstName, this.LastName, this.Email, this.Phone, this.IdentificationNum, this.IdentificationTypeID, this.DateOfBirth);

        }

        public static clsPerson Find(int PersonID)
        {
            string FirstName = default;
            string LastName = default;
            string Email = default;
            string Phone = default;
            string IdentificationNum = default;
            int IdentificationTypeID = default;
            DateTime DateOfBirth = default;


            if (clsPeopleDataAccess.GetPersonInfoByID(PersonID, ref FirstName, ref LastName, ref Email, ref Phone, ref IdentificationNum, ref IdentificationTypeID, ref DateOfBirth))
                return new clsPerson(PersonID, FirstName, LastName, Email, Phone, IdentificationNum, IdentificationTypeID, DateOfBirth);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }




            return false;
        }

        public static DataTable GetAllPeople() { return clsPeopleDataAccess.GetAllPeople(); }

        public static bool DeletePerson(int PersonID) { return clsPeopleDataAccess.DeletePerson(PersonID); }

        public static bool isPersonExist(int PersonID) { return clsPeopleDataAccess.IsPersonExist(PersonID); }

        
    }

}