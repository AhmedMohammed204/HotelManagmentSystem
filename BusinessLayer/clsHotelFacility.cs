using StegiHotel_databaseDataAccessLayer;
using System.Data;
namespace HotelFacilitiesBusinessLayer
{

    public class clsHotelFacility
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int HotelFacilitiesID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HotleID { get; set; }


        public clsHotelFacility()
        {
            this.HotelFacilitiesID = default;
            this.Name = default;
            this.Description = default;
            this.HotleID = default;


            Mode = enMode.AddNew;

        }

        private clsHotelFacility(int HotelFacilitiesID, string Name, string Description, int HotleID)
        {
            this.HotelFacilitiesID = HotelFacilitiesID;
            this.Name = Name;
            this.Description = Description;
            this.HotleID = HotleID;


            Mode = enMode.Update;

        }

        private bool _AddNewHotelFacility()
        {
            //call DataAccess Layer 

            this.HotelFacilitiesID = clsHotelFacilitiesDataAccess.AddNewHotelFacility(this.Name, this.Description, this.HotleID);

            return (this.HotelFacilitiesID != -1);

        }

        private bool _UpdateHotelFacility()
        {
            //call DataAccess Layer 

            return clsHotelFacilitiesDataAccess.UpdateHotelFacility(this.HotelFacilitiesID, this.Name, this.Description, this.HotleID);

        }

        public static clsHotelFacility Find(int HotelFacilitiesID)
        {
            string Name = default;
            string Description = default;
            int HotleID = default;


            if (clsHotelFacilitiesDataAccess.GetHotelFacilityInfoByID(HotelFacilitiesID, ref Name, ref Description, ref HotleID))
                return new clsHotelFacility(HotelFacilitiesID, Name, Description, HotleID);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewHotelFacility())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateHotelFacility();

            }




            return false;
        }

        public static DataTable GetAllHotelFacilities() { return clsHotelFacilitiesDataAccess.GetAllHotelFacilities(); }

        public static bool DeleteHotelFacility(int HotelFacilitiesID) { return clsHotelFacilitiesDataAccess.DeleteHotelFacility(HotelFacilitiesID); }

        public static bool isHotelFacilityExist(int HotelFacilitiesID) { return clsHotelFacilitiesDataAccess.IsHotelFacilityExist(HotelFacilitiesID); }


    }

}