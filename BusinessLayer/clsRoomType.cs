using System;
using System.Data;
using StegiHotel_databaseDataAccessLayer;
namespace RoomTypesBusinessLayer
{

public class clsRoomType
{
public enum enMode { AddNew = 0, Update = 1 };
public enMode Mode = enMode.AddNew;
public int RoomTypeID {get; set;}
public string Name {get; set;}
public string Description {get; set;}


public clsRoomType()
{
this.RoomTypeID = default;
this.Name = default;
this.Description = default;


Mode = enMode.AddNew;

}

private clsRoomType( int RoomTypeID,  string Name,  string Description)
{
this.RoomTypeID = RoomTypeID;
this.Name = Name;
this.Description = Description;


Mode = enMode.Update;

}

private bool _AddNewRoomType()
{
//call DataAccess Layer 

this.RoomTypeID = clsRoomTypesDataAccess.AddNewRoomType(this.Name, this.Description);

return (this.RoomTypeID != -1);

}

private bool _UpdateRoomType()
{
//call DataAccess Layer 

return clsRoomTypesDataAccess.UpdateRoomType(this.RoomTypeID, this.Name, this.Description);

}

public static clsRoomType Find(int RoomTypeID)
{
string Name = default;
string Description = default;


if(clsRoomTypesDataAccess.GetRoomTypeInfoByID(RoomTypeID, ref Name, ref Description))
return new clsRoomType( RoomTypeID,  Name,  Description);
else
return null;

}

        public bool Save()
        {
            

            switch  (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRoomType())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateRoomType();

            }




            return false;
        }

public static DataTable GetAllRoomTypes(){return clsRoomTypesDataAccess.GetAllRoomTypes();}

public static bool DeleteRoomType(int RoomTypeID){return  clsRoomTypesDataAccess.DeleteRoomType(RoomTypeID);}

public static bool isRoomTypeExist(int RoomTypeID){return clsRoomTypesDataAccess.IsRoomTypeExist(RoomTypeID);}


}

}