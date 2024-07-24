using RoomsBusinessLayer;
using StegiHotel_databaseDataAccessLayer;
using System;
using System.Data;
namespace ReservationsBusinessLayer
{

    public class clsReservation
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ReservationID { get; set; }
        public int RoomID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public decimal PaidFees { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public clsRoom Room { get; set; }

        public clsReservation()
        {
            this.ReservationID = default;
            this.RoomID = default;
            this.PersonID = default;
            this.CreatedByUserID = default;
            this.PaidFees = default;
            this.StartDay = default;
            this.EndDay = default;


            Mode = enMode.AddNew;

        }

        private clsReservation(int ReservationID, int RoomID, int PersonID, int CreatedByUserID, decimal PaidFees, DateTime StartDay, DateTime EndDay)
        {
            this.ReservationID = ReservationID;
            this.RoomID = RoomID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.PaidFees = PaidFees;
            this.StartDay = StartDay;
            this.EndDay = EndDay;
            Room = clsRoom.Find(RoomID);

            Mode = enMode.Update;

        }

        private bool _AddNewReservation()
        {
            //call DataAccess Layer 

            this.ReservationID = clsReservationsDataAccess.AddNewReservation(this.RoomID, this.PersonID, this.CreatedByUserID, this.PaidFees, this.StartDay, this.EndDay);

            return (this.ReservationID != -1);

        }

        private bool _UpdateReservation()
        {
            //call DataAccess Layer 

            return clsReservationsDataAccess.UpdateReservation(this.ReservationID, this.RoomID, this.PersonID, this.CreatedByUserID, this.PaidFees, this.StartDay, this.EndDay);

        }

        public static clsReservation Find(int ReservationID)
        {
            int RoomID = default;
            int PersonID = default;
            int CreatedByUserID = default;
            decimal PaidFees = default;
            DateTime StartDay = default;
            DateTime EndDay = default;


            if (clsReservationsDataAccess.GetReservationInfoByID(ReservationID, ref RoomID, ref PersonID, ref CreatedByUserID, ref PaidFees, ref StartDay, ref EndDay))
                return new clsReservation(ReservationID, RoomID, PersonID, CreatedByUserID, PaidFees, StartDay, EndDay);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewReservation())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateReservation();

            }




            return false;
        }

        public static DataTable GetAllReservations() { return clsReservationsDataAccess.GetAllReservations(); }

        public static bool DeleteReservation(int ReservationID) { return clsReservationsDataAccess.DeleteReservation(ReservationID); }

        public static bool isReservationExist(int ReservationID) { return clsReservationsDataAccess.IsReservationExist(ReservationID); }


    }

}