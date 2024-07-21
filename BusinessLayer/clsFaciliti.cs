using StegiHotel_databaseDataAccessLayer;
using System.Data;
namespace FacilitiesBusinessLayer
{

    public class clsFaciliti
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int FacilitiyD { get; set; }
        public string Name { get; set; }


        public clsFaciliti()
        {
            this.FacilitiyD = default;
            this.Name = default;


            Mode = enMode.AddNew;

        }

        private clsFaciliti(int FacilitiyD, string Name)
        {
            this.FacilitiyD = FacilitiyD;
            this.Name = Name;


            Mode = enMode.Update;

        }

        private bool _AddNewFaciliti()
        {
            //call DataAccess Layer 

            this.FacilitiyD = clsFacilitiesDataAccess.AddNewFaciliti(this.Name);

            return (this.FacilitiyD != -1);

        }

        private bool _UpdateFaciliti()
        {
            //call DataAccess Layer 

            return clsFacilitiesDataAccess.UpdateFaciliti(this.FacilitiyD, this.Name);

        }

        public static clsFaciliti Find(int FacilitiyD)
        {
            string Name = default;


            if (clsFacilitiesDataAccess.GetFacilitiInfoByID(FacilitiyD, ref Name))
                return new clsFaciliti(FacilitiyD, Name);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewFaciliti())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateFaciliti();

            }




            return false;
        }

        public static DataTable GetAllFacilities() { return clsFacilitiesDataAccess.GetAllFacilities(); }

        public static bool DeleteFaciliti(int FacilitiyD) { return clsFacilitiesDataAccess.DeleteFaciliti(FacilitiyD); }

        public static bool isFacilitiExist(int FacilitiyD) { return clsFacilitiesDataAccess.IsFacilitiExist(FacilitiyD); }


    }

}