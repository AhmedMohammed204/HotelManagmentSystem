using System;
using System.Data;
using StegiHotel_databaseDataAccessLayer;
namespace HotelFacilitiesBusinessLayer
{

public class clsHotelFacilities
{
public enum enMode { AddNew = 0, Update = 1 };
public enMode Mode = enMode.AddNew;
public int HotelFacilitiesID {get; set;}
public string Name {get; set;}
public string Description {get; set;}


public clsHotelFacilities()
{
this.HotelFacilitiesID = default;
this.Name = default;
this.Description = default;


Mode = enMode.AddNew;

}

private clsHotelFacilities( int HotelFacilitiesID,  string Name,  string Description)
{
this.HotelFacilitiesID = HotelFacilitiesID;
this.Name = Name;
this.Description = Description;


Mode = enMode.Update;

}

private bool _AddNewHotelFacilities()
{
//call DataAccess Layer 

this.HotelFacilitiesID = clsHotelFacilitiesDataAccess.AddNewHotelFacilities(this.Name, this.Description);

return (this.HotelFacilitiesID != -1);

}

private bool _UpdateHotelFacilities()
{
//call DataAccess Layer 

return clsHotelFacilitiesDataAccess.UpdateHotelFacilities(this.HotelFacilitiesID, this.Name, this.Description);

}

public static clsHotelFacilities Find(int HotelFacilitiesID)
{
string Name = default;
string Description = default;


if(clsHotelFacilitiesDataAccess.GetHotelFacilitiesInfoByID(HotelFacilitiesID, ref Name, ref Description))
return new clsHotelFacilities( HotelFacilitiesID,  Name,  Description);
else
return null;

}

        public bool Save()
        {
            

            switch  (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewHotelFacilities())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateHotelFacilities();

            }




            return false;
        }

public static DataTable GetAllHotelFacilities(){return clsHotelFacilitiesDataAccess.GetAllHotelFacilities();}

public static bool DeleteHotelFacilities(int HotelFacilitiesID){return  clsHotelFacilitiesDataAccess.DeleteHotelFacilities(HotelFacilitiesID);}

public static bool isHotelFacilitiesExist(int HotelFacilitiesID){return clsHotelFacilitiesDataAccess.IsHotelFacilitiesExist(HotelFacilitiesID);}


}

}