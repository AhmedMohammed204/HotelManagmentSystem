using StegiHotel_databaseDataAccessLayer;
using System.Data;
namespace RoomTypesBusinessLayer
{

    public class clsRoomType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int RoomTypeID { get; set; }
        public decimal Fees { get; set; }


        public clsRoomType()
        {
            this.RoomTypeID = default;
            this.Fees = default;


            Mode = enMode.AddNew;

        }

        private clsRoomType(int RoomTypeID, decimal Fees)
        {
            this.RoomTypeID = RoomTypeID;
            this.Fees = Fees;


            Mode = enMode.Update;

        }

        private bool _AddNewRoomType()
        {
            //call DataAccess Layer 

            this.RoomTypeID = clsRoomTypesDataAccess.AddNewRoomType(this.Fees);

            return (this.RoomTypeID != -1);

        }

        private bool _UpdateRoomType()
        {
            //call DataAccess Layer 

            return clsRoomTypesDataAccess.UpdateRoomType(this.RoomTypeID, this.Fees);

        }

        public static clsRoomType Find(int RoomTypeID)
        {
            decimal Fees = default;


            if (clsRoomTypesDataAccess.GetRoomTypeInfoByID(RoomTypeID, ref Fees))
                return new clsRoomType(RoomTypeID, Fees);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
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

        public static DataTable GetAllRoomTypes() { return clsRoomTypesDataAccess.GetAllRoomTypes(); }

        public static bool DeleteRoomType(int RoomTypeID) { return clsRoomTypesDataAccess.DeleteRoomType(RoomTypeID); }

        public static bool isRoomTypeExist(int RoomTypeID) { return clsRoomTypesDataAccess.IsRoomTypeExist(RoomTypeID); }


    }

}