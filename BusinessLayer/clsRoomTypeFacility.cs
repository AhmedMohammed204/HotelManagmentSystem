using System;
using System.Data;
using StegiHotel_databaseDataAccessLayer;
namespace RoomTypesFacilitiesBusinessLayer
{

public class clsRoomTypeFacility
{
public enum enMode { AddNew = 0, Update = 1 };
public enMode Mode = enMode.AddNew;
public int RoomTypeFacilityID {get; set;}
public int FacilityID {get; set;}
public int RoomTypeID {get; set;}


public clsRoomTypeFacility()
{
this.RoomTypeFacilityID = default;
this.FacilityID = default;
this.RoomTypeID = default;


Mode = enMode.AddNew;

}

private clsRoomTypeFacility( int RoomTypeFacilityID,  int FacilityID,  int RoomTypeID)
{
this.RoomTypeFacilityID = RoomTypeFacilityID;
this.FacilityID = FacilityID;
this.RoomTypeID = RoomTypeID;


Mode = enMode.Update;

}

private bool _AddNewRoomTypeFacility()
{
//call DataAccess Layer 

this.RoomTypeFacilityID = clsRoomTypesFacilitiesDataAccess.AddNewRoomTypeFacility(this.FacilityID, this.RoomTypeID);

return (this.RoomTypeFacilityID != -1);

}

private bool _UpdateRoomTypeFacility()
{
//call DataAccess Layer 

return clsRoomTypesFacilitiesDataAccess.UpdateRoomTypeFacility(this.RoomTypeFacilityID, this.FacilityID, this.RoomTypeID);

}

public static clsRoomTypeFacility Find(int RoomTypeFacilityID)
{
int FacilityID = default;
int RoomTypeID = default;


if(clsRoomTypesFacilitiesDataAccess.GetRoomTypeFacilityInfoByID(RoomTypeFacilityID, ref FacilityID, ref RoomTypeID))
return new clsRoomTypeFacility( RoomTypeFacilityID,  FacilityID,  RoomTypeID);
else
return null;

}

        public bool Save()
        {
            

            switch  (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRoomTypeFacility())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateRoomTypeFacility();

            }




            return false;
        }

public static DataTable GetAllRoomTypesFacilities(){return clsRoomTypesFacilitiesDataAccess.GetAllRoomTypesFacilities();}

public static bool DeleteRoomTypeFacility(int RoomTypeFacilityID){return  clsRoomTypesFacilitiesDataAccess.DeleteRoomTypeFacility(RoomTypeFacilityID);}

public static bool isRoomTypeFacilityExist(int RoomTypeFacilityID){return clsRoomTypesFacilitiesDataAccess.IsRoomTypeFacilityExist(RoomTypeFacilityID);}


}

}