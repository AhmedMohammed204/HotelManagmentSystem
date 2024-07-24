using PrecentationLayer.Lib;
using PrecentationLayer.People;
using PrecentationLayer.Rooms;
using PrecentationLayer.Screens;
using PrecentationLayer.Users;
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
    public partial class frmReservationInfo : SubTitledScreen
    {
        public frmReservationInfo(int ReservationID)
        {
            InitializeComponent();
            ctrlReservationInfo1.LoadData(ReservationID);
        }

        private void ctrlReservationInfo1_OnClickCreatedByUserInfo(int obj)
        {
            clsOpenSubForm.Open(new frmUserInfo(obj));
        }

        private void ctrlReservationInfo1_OnClickPersonInfo(int obj)
        {
            clsOpenSubForm.Open(new frmPersonInfo(obj));
        }

        private void ctrlReservationInfo1_OnClickRoomInfo(int obj)
        {
            clsOpenSubForm.Open(new frmRoomInfo(obj));
        }
    }
}
