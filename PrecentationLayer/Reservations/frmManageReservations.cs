using PrecentationLayer.Screens;
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
    public partial class frmManageReservations : ShowDataScreen
    {
        public frmManageReservations()
        {
            
            InitializeComponent();
            Title = "Manage Reservations";
            _LoadData();

        }
        void _LoadData()
        {
            DataGrid.LoadData(clsReservation.GetAllReservations());
            DataGrid.Menu(contextMenuStrip1);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ReservationID = (int)DataGrid.DGV.CurrentRow.Cells[0].Value;

            if(MessageBox.Show($"Are you sure you want to delete this reservation ID = {ReservationID}?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (clsReservation.DeleteReservation(ReservationID))
                    clsMessageBox.DoneMessage("Reservation Deleted Successfully!");
                else
                    clsMessageBox.ErrorMessage();
            }


            _LoadData();
        }
        public event Action OnClickAddNew;
        public event Action<int> OnClickUpdateNew;
        public event Action<int> OnClickShowRoomInfo;
        public event Action<int> OnClickShowReservationInfo;
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            OnClickAddNew?.Invoke();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ReservationID = (int)DataGrid.DGV.CurrentRow.Cells[0].Value;
            OnClickUpdateNew?.Invoke(ReservationID);
        }

        private void showRoomInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RoomID = (int)DataGrid.DGV.CurrentRow.Cells["RoomID"].Value;
            OnClickShowRoomInfo?.Invoke(RoomID);
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ReservationID = (int)DataGrid.DGV.CurrentRow.Cells[0].Value;
            OnClickShowReservationInfo?.Invoke(ReservationID);
        }
    }
}
