using System;
using System.Data;
using StegiHotel_databaseDataAccessLayer;
namespace HotelImagesBusinessLayer
{

public class clsHotelImage
{
public enum enMode { AddNew = 0, Update = 1 };
public enMode Mode = enMode.AddNew;
public int HotelImageID {get; set;}
public string ImageURL {get; set;}
public int HotelID {get; set;}


public clsHotelImage()
{
this.HotelImageID = default;
this.ImageURL = default;
this.HotelID = default;


Mode = enMode.AddNew;

}

private clsHotelImage( int HotelImageID,  string ImageURL,  int HotelID)
{
this.HotelImageID = HotelImageID;
this.ImageURL = ImageURL;
this.HotelID = HotelID;


Mode = enMode.Update;

}

private bool _AddNewHotelImage()
{
//call DataAccess Layer 

this.HotelImageID = clsHotelImagesDataAccess.AddNewHotelImage(this.ImageURL, this.HotelID);

return (this.HotelImageID != -1);

}

private bool _UpdateHotelImage()
{
//call DataAccess Layer 

return clsHotelImagesDataAccess.UpdateHotelImage(this.HotelImageID, this.ImageURL, this.HotelID);

}

public static clsHotelImage Find(int HotelImageID)
{
string ImageURL = default;
int HotelID = default;


if(clsHotelImagesDataAccess.GetHotelImageInfoByID(HotelImageID, ref ImageURL, ref HotelID))
return new clsHotelImage( HotelImageID,  ImageURL,  HotelID);
else
return null;

}

        public bool Save()
        {
            

            switch  (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewHotelImage())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateHotelImage();

            }




            return false;
        }

public static DataTable GetAllHotelImages(){return clsHotelImagesDataAccess.GetAllHotelImages();}

public static bool DeleteHotelImage(int HotelImageID){return  clsHotelImagesDataAccess.DeleteHotelImage(HotelImageID);}

public static bool isHotelImageExist(int HotelImageID){return clsHotelImagesDataAccess.IsHotelImageExist(HotelImageID);}


}

}