using ReservationsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilLibrary;

namespace PrecentationLayer.Reservations
{
    public partial class ctrlReservationInfo : UserControl
    {
        public ctrlReservationInfo()
        {
            InitializeComponent();
        }
        public clsReservation Reservation { get; set; }
        public void LoadData(int ReservationID)
        {
            Reservation = clsReservation.Find(ReservationID);
            if(Reservation == null)
            {
                clsMessageBox.ErrorMessage();
                lblCreatedByUserInfo.Enabled = lblPersonInfo.Enabled = false;
                return;
            }
        }

        void LoadReservationDetails()
        {
            lblReservationID.Details = Reservation.ReservationID.ToString();
            lblEndDate.Details = Reservation.EndDay.ToShortDateString();
            lblStartDate.Details = Reservation.StartDay.ToShortDateString();
            lblPaidFees.Details = Reservation.PaidFees.ToString();

        }
        public event Action<int> OnClickCreatedByUserInfo;
        public event Action<int> OnClickPersonInfo;
        public event Action<int> OnClickRoomInfo;
        private void lblCreatedByUserInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnClickCreatedByUserInfo?.Invoke(Reservation.CreatedByUserID);
        }

        private void lblPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnClickPersonInfo?.Invoke(Reservation.PersonID);
        }

        private void lblRoomInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnClickRoomInfo?.Invoke(Reservation.RoomID);
        }
    }
}
