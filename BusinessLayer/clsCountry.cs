using StegiHotel_databaseDataAccessLayer;
using System.Data;
namespace CountriesBusinessLayer
{

    public class clsCountry
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int CountryID { get; set; }
        public string Name { get; set; }


        public clsCountry()
        {
            this.CountryID = default;
            this.Name = default;


            Mode = enMode.AddNew;

        }

        private clsCountry(int CountryID, string Name)
        {
            this.CountryID = CountryID;
            this.Name = Name;


            Mode = enMode.Update;

        }

        private bool _AddNewCountry()
        {
            //call DataAccess Layer 

            this.CountryID = clsCountriesDataAccess.AddNewCountry(this.Name);

            return (this.CountryID != -1);

        }

        private bool _UpdateCountry()
        {
            //call DataAccess Layer 

            return clsCountriesDataAccess.UpdateCountry(this.CountryID, this.Name);

        }

        public static clsCountry Find(int CountryID)
        {
            string Name = default;


            if (clsCountriesDataAccess.GetCountryInfoByID(CountryID, ref Name))
                return new clsCountry(CountryID, Name);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateCountry();

            }




            return false;
        }

        public static DataTable GetAllCountries() { return clsCountriesDataAccess.GetAllCountries(); }

        public static bool DeleteCountry(int CountryID) { return clsCountriesDataAccess.DeleteCountry(CountryID); }

        public static bool isCountryExist(int CountryID) { return clsCountriesDataAccess.IsCountryExist(CountryID); }


    }

}