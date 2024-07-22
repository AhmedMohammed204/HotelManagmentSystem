using System;
using System.Data;
using StegiHotel_databaseDataAccessLayer;
namespace HotlesBusinessLayer
{

public class clsHotle
{
public enum enMode { AddNew = 0, Update = 1 };
public enMode Mode = enMode.AddNew;
public int HotleID {get; set;}
public string Address {get; set;}
public int CountryID {get; set;}
public string Description {get; set;}
public string Name {get; set;}


public clsHotle()
{
this.HotleID = default;
this.Address = default;
this.CountryID = default;
this.Description = default;
this.Name = default;


Mode = enMode.AddNew;

}

private clsHotle( int HotleID,  string Address,  int CountryID,  string Description,  string Name)
{
this.HotleID = HotleID;
this.Address = Address;
this.CountryID = CountryID;
this.Description = Description;
this.Name = Name;


Mode = enMode.Update;

}

private bool _AddNewHotle()
{
//call DataAccess Layer 

this.HotleID = clsHotlesDataAccess.AddNewHotle(this.Address, this.CountryID, this.Description, this.Name);

return (this.HotleID != -1);

}

private bool _UpdateHotle()
{
//call DataAccess Layer 

return clsHotlesDataAccess.UpdateHotle(this.HotleID, this.Address, this.CountryID, this.Description, this.Name);

}

public static clsHotle Find(int HotleID)
{
string Address = default;
int CountryID = default;
string Description = default;
string Name = default;


if(clsHotlesDataAccess.GetHotleInfoByID(HotleID, ref Address, ref CountryID, ref Description, ref Name))
return new clsHotle( HotleID,  Address,  CountryID,  Description,  Name);
else
return null;

}

        public bool Save()
        {
            

            switch  (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewHotle())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateHotle();

            }




            return false;
        }

public static DataTable GetAllHotles(){return clsHotlesDataAccess.GetAllHotles();}

public static bool DeleteHotle(int HotleID){return  clsHotlesDataAccess.DeleteHotle(HotleID);}

public static bool isHotleExist(int HotleID){return clsHotlesDataAccess.IsHotleExist(HotleID);}


}

}