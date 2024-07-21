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
        public bool IsVacant { get; set; }
        public int HotleID { get; set; }


        public clsRoom()
        {
            this.RoomID = default;
            this.Capacity = default;
            this.AllowChildern = default;
            this.fees = default;
            this.IsVacant = default;
            this.HotleID = default;


            Mode = enMode.AddNew;

        }

        private clsRoom(int RoomID, byte Capacity, bool AllowChildern, int fees, bool IsVacant, int HotleID)
        {
            this.RoomID = RoomID;
            this.Capacity = Capacity;
            this.AllowChildern = AllowChildern;
            this.fees = fees;
            this.IsVacant = IsVacant;
            this.HotleID = HotleID;


            Mode = enMode.Update;

        }

        private bool _AddNewRoom()
        {
            //call DataAccess Layer 

            this.RoomID = clsRoomsDataAccess.AddNewRoom(this.Capacity, this.AllowChildern, this.fees, this.IsVacant, this.HotleID);

            return (this.RoomID != -1);

        }

        private bool _UpdateRoom()
        {
            //call DataAccess Layer 

            return clsRoomsDataAccess.UpdateRoom(this.RoomID, this.Capacity, this.AllowChildern, this.fees, this.IsVacant, this.HotleID);

        }

        public static clsRoom Find(int RoomID)
        {
            byte Capacity = default;
            bool AllowChildern = default;
            int fees = default;
            bool IsVacant = default;
            int HotleID = default;


            if (clsRoomsDataAccess.GetRoomInfoByID(RoomID, ref Capacity, ref AllowChildern, ref fees, ref IsVacant, ref HotleID))
                return new clsRoom(RoomID, Capacity, AllowChildern, fees, IsVacant, HotleID);
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