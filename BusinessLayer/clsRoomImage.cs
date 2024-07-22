using System;
using System.Data;
using StegiHotel_databaseDataAccessLayer;
namespace RoomsImagesBusinessLayer
{

public class clsRoomImage
{
public enum enMode { AddNew = 0, Update = 1 };
public enMode Mode = enMode.AddNew;
public int RoomImageID {get; set;}
public string ImageURL {get; set;}
public int RoomTypeID {get; set;}


public clsRoomImage()
{
this.RoomImageID = default;
this.ImageURL = default;
this.RoomTypeID = default;


Mode = enMode.AddNew;

}

private clsRoomImage( int RoomImageID,  string ImageURL,  int RoomTypeID)
{
this.RoomImageID = RoomImageID;
this.ImageURL = ImageURL;
this.RoomTypeID = RoomTypeID;


Mode = enMode.Update;

}

private bool _AddNewRoomImage()
{
//call DataAccess Layer 

this.RoomImageID = clsRoomsImagesDataAccess.AddNewRoomImage(this.ImageURL, this.RoomTypeID);

return (this.RoomImageID != -1);

}

private bool _UpdateRoomImage()
{
//call DataAccess Layer 

return clsRoomsImagesDataAccess.UpdateRoomImage(this.RoomImageID, this.ImageURL, this.RoomTypeID);

}

public static clsRoomImage Find(int RoomImageID)
{
string ImageURL = default;
int RoomTypeID = default;


if(clsRoomsImagesDataAccess.GetRoomImageInfoByID(RoomImageID, ref ImageURL, ref RoomTypeID))
return new clsRoomImage( RoomImageID,  ImageURL,  RoomTypeID);
else
return null;

}

        public bool Save()
        {
            

            switch  (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRoomImage())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateRoomImage();

            }




            return false;
        }

public static DataTable GetAllRoomsImages(){return clsRoomsImagesDataAccess.GetAllRoomsImages();}

public static bool DeleteRoomImage(int RoomImageID){return  clsRoomsImagesDataAccess.DeleteRoomImage(RoomImageID);}

public static bool isRoomImageExist(int RoomImageID){return clsRoomsImagesDataAccess.IsRoomImageExist(RoomImageID);}


}

}