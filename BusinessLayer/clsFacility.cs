using System;
using System.Data;
using StegiHotel_databaseDataAccessLayer;
namespace AllHotelFacilitiesBusinessLayer
{

public class clsFacility
{
public enum enMode { AddNew = 0, Update = 1 };
public enMode Mode = enMode.AddNew;
public int FacilityID {get; set;}
public int HotelID {get; set;}
public int HotelFacilityID {get; set;}


public clsFacility()
{
this.FacilityID = default;
this.HotelID = default;
this.HotelFacilityID = default;


Mode = enMode.AddNew;

}

private clsFacility( int FacilityID,  int HotelID,  int HotelFacilityID)
{
this.FacilityID = FacilityID;
this.HotelID = HotelID;
this.HotelFacilityID = HotelFacilityID;


Mode = enMode.Update;

}

private bool _AddNewFacility()
{
//call DataAccess Layer 

this.FacilityID = clsAllHotelFacilitiesDataAccess.AddNewFacility(this.HotelID, this.HotelFacilityID);

return (this.FacilityID != -1);

}

private bool _UpdateFacility()
{
//call DataAccess Layer 

return clsAllHotelFacilitiesDataAccess.UpdateFacility(this.FacilityID, this.HotelID, this.HotelFacilityID);

}

public static clsFacility Find(int FacilityID)
{
int HotelID = default;
int HotelFacilityID = default;


if(clsAllHotelFacilitiesDataAccess.GetFacilityInfoByID(FacilityID, ref HotelID, ref HotelFacilityID))
return new clsFacility( FacilityID,  HotelID,  HotelFacilityID);
else
return null;

}

        public bool Save()
        {
            

            switch  (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewFacility())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateFacility();

            }




            return false;
        }

public static DataTable GetAllAllHotelFacilities(){return clsAllHotelFacilitiesDataAccess.GetAllAllHotelFacilities();}

public static bool DeleteFacility(int FacilityID){return  clsAllHotelFacilitiesDataAccess.DeleteFacility(FacilityID);}

public static bool isFacilityExist(int FacilityID){return clsAllHotelFacilitiesDataAccess.IsFacilityExist(FacilityID);}


}

}