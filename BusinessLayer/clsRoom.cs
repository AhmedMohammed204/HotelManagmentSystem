using StegiHotel_databaseDataAccessLayer;
using System.Data;
namespace RoomsBusinessLayer
{

    public class clsRoom
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int RoomID { get; set; }
        public byte Capacity { get; set; }
        public bool AllowChildern { get; set; }
        public int fees { get; set; }
        public int HotleID { get; set; }
        public int RoomTypeID { get; set; }
        public int? TotalSingleBeds { get; set; }
        public int? TotalDoubleBeds { get; set; }


        public clsRoom()
        {
            this.RoomID = default;
            this.Capacity = default;
            this.AllowChildern = default;
            this.fees = default;
            this.HotleID = default;
            this.RoomTypeID = default;
            this.TotalSingleBeds = default;
            this.TotalDoubleBeds = default;


            Mode = enMode.AddNew;

        }

        private clsRoom(int RoomID, byte Capacity, bool AllowChildern, int fees, int HotleID, int RoomTypeID, int TotalSingleBeds, int TotalDoubleBeds)
        {
            this.RoomID = RoomID;
            this.Capacity = Capacity;
            this.AllowChildern = AllowChildern;
            this.fees = fees;
            this.HotleID = HotleID;
            this.RoomTypeID = RoomTypeID;
            this.TotalSingleBeds = TotalSingleBeds;
            this.TotalDoubleBeds = TotalDoubleBeds;


            Mode = enMode.Update;

        }

        private bool _AddNewRoom()
        {
            //call DataAccess Layer 

            this.RoomID = clsRoomsDataAccess.AddNewRoom(this.Capacity, this.AllowChildern, this.fees, this.HotleID, this.RoomTypeID, this.TotalSingleBeds, this.TotalDoubleBeds);

            return (this.RoomID != -1);

        }

        private bool _UpdateRoom()
        {
            //call DataAccess Layer 

            return clsRoomsDataAccess.UpdateRoom(this.RoomID, this.Capacity, this.AllowChildern, this.fees, this.HotleID, this.RoomTypeID, this.TotalSingleBeds, this.TotalDoubleBeds);

        }

        public static clsRoom Find(int RoomID)
        {
            byte Capacity = default;
            bool AllowChildern = default;
            int fees = default;
            int HotleID = default;
            int RoomTypeID = default;
            int TotalSingleBeds = default;
            int TotalDoubleBeds = default;


            if (clsRoomsDataAccess.GetRoomInfoByID(RoomID, ref Capacity, ref AllowChildern, ref fees, ref HotleID, ref RoomTypeID, ref TotalSingleBeds , ref TotalDoubleBeds ))
                return new clsRoom(RoomID, Capacity, AllowChildern, fees, HotleID, RoomTypeID, TotalSingleBeds, TotalDoubleBeds);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRoom())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateRoom();

            }




            return false;
        }

        public static DataTable GetAllRooms() { return clsRoomsDataAccess.GetAllRooms(); }

        public static bool DeleteRoom(int RoomID) { return clsRoomsDataAccess.DeleteRoom(RoomID); }

        public static bool isRoomExist(int RoomID) { return clsRoomsDataAccess.IsRoomExist(RoomID); }


    }

}