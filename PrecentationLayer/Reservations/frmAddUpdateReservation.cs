using PrecentationLayer.Lib;
using PrecentationLayer.Rooms;
using PrecentationLayer.Screens;
using ReservationsBusinessLayer;
using System;
using System.Windows.Forms;
using UtilLibrary;

namespace PrecentationLayer.Reservations
{
    public partial class frmAddUpdateReservation : SubTitledScreen
    {
        #region Class Init
        enum enMode { AddNew, Update };
        enMode _Mode { get; set; }
        clsReservation Reservation { get; set; }
        public frmAddUpdateReservation(int ReservationID)
        {
            InitializeComponent();
            _LoadData(ReservationID);
        }
        void _LoadData(int ReservationID)
        {
            if (ReservationID == -1)
            {
                Title = "Add New Reservation";
                _Mode = enMode.AddNew;
                Reservation = new clsReservation();
                return;
            }
            _Mode = enMode.Update;
            Title = "Update Reservation";
            Reservation = clsReservation.Find(ReservationID);
            if (Reservation == null)
            {
                clsMessageBox.ErrorMessage("Reservation not found!");
                return;
            }
            _LoadReservationInfo();
        }
        void _LoadReservationInfo()
        {
            ctrlGetAvailableRoom1.Enabled = false;
            ctrlGetAvailableRoom1.Visible = false;
            ctrlGetAvailableRoom1.Room = Reservation.Room;
            lblRoomInfo.Visible = true;
            LoadPerson(Reservation.PersonID);
            mcPeriod.SelectionStart = Reservation.StartDay;
            mcPeriod.SelectionEnd = Reservation.EndDay;
            lblFees.Details = ((int)Reservation.PaidFees).ToString();
        }
        public void LoadPerson(int PersonID)
        {
            ctrlPersonInfoWithFilters1.Enabled = false;
            ctrlPersonInfoWithFilters1.PersonID = PersonID.ToString();
            ctrlPersonInfoWithFilters1.Find();
        }
        private void frmAddUpdateReservation_Load(object sender, EventArgs e)
        {
            this.AcceptButton = ctrlPersonInfoWithFilters1.FindButton;
            mcPeriod.MinDate = DateTime.Now;

        }
        #endregion

        #region Calc fees 
        int _TotalSelectedDays()
        {
            return ((mcPeriod.SelectionRange.End - mcPeriod.SelectionRange.Start).Days );
        }
        int _TotalFees()
        {
            return ctrlGetAvailableRoom1.Room.fees * _TotalSelectedDays();
        }
        #endregion

        #region Events
        private void ctrlGetAvailableRoom1_OnRoomFound(int obj)
        {
            if (!ctrlGetAvailableRoom1.Enabled) return;
            clsMessageBox.InfoMessage($"Room Found with ID = {obj}");
            lblFees.Details = _TotalFees().ToString();
        }
        private void mcPeriod_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (ctrlGetAvailableRoom1.Room == null)
                return;

            lblFees.Details = _TotalFees().ToString();
        }
        public event Action<int> OnClickOpenRoomInfo;
        private void ctrlGetAvailableRoom1_OnRoomInfoClicked(int obj)
        {

            clsOpenSubForm.Open(new frmRoomInfo(ctrlGetAvailableRoom1.Room.RoomID));
        }
        private void lblRoomInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsOpenSubForm.Open(new frmRoomInfo(ctrlGetAvailableRoom1.Room.RoomID));

        }
        #endregion

        #region Save
        bool _IsValidToSave()
        {
            if (ctrlPersonInfoWithFilters1.PersonInfo.PersonInfo == null)
            {
                clsMessageBox.ErrorMessage("There is no person to make a reservation to");
                return false;
            }
            else if (ctrlGetAvailableRoom1.Room == null)
            {
                clsMessageBox.ErrorMessage("Please click on find room");
                return false;
            }
            else if (_TotalSelectedDays() == 0)
            {
                clsMessageBox.ErrorMessage("You can't book part of day \n\nMake sure start day not equal end day");
                return false;
            }
            else
            {

                return true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsValidToSave())
                return;
            int RoomID = ctrlGetAvailableRoom1.Room.RoomID;
            double Fees = Convert.ToDouble(lblFees.Details);
            DateTime StartDay = mcPeriod.SelectionRange.Start, EndDay = mcPeriod.SelectionRange.End;
            if (_Mode == enMode.AddNew)
            {
                Reservation = ctrlPersonInfoWithFilters1.PersonInfo.PersonInfo.BookRoom(RoomID, clsGlobal.CurrentUser.UserID, Fees, StartDay, EndDay);

                if (Reservation == null)
                {
                    clsMessageBox.ErrorMessage();
                    return;
                }
            }
            else
            {
                Reservation.StartDay = StartDay;
                Reservation.EndDay = EndDay;
                Reservation.PaidFees = Convert.ToDecimal(Fees);

                if (!Reservation.Save())
                {
                    clsMessageBox.ErrorMessage();
                    return;
                }
            }

            _LoadData(Reservation.ReservationID);
        }
        #endregion

    }
}
