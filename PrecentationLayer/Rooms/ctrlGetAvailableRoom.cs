using RoomsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrecentationLayer
{
    public partial class ctrlGetAvailableRoom : UserControl
    {
        public ctrlGetAvailableRoom()
        {
            InitializeComponent();
        }
        public clsRoom Room { get; set; }

        public event Action<int> OnRoomFound;
        public event Action<int> OnRoomInfoClicked;
        
        private void btnFind_Click(object sender, EventArgs e)
        {
            Room = clsRoom.GetAvailableRoom((int)Capacity.Value, cbChildren.Checked);
            if(Room == null)
            {
                lblRoomInfo.Visible = false;
                return;
            }
            lblRoomInfo.Visible = true;
            OnRoomFound?.Invoke(Room.RoomID);
        }


        public void Find(int capacity, bool AllowChildren)
        {
            Capacity.Value = capacity; cbChildren.Checked = AllowChildren;
            btnFind.PerformClick();
            gbAvailableRooms.Enabled = false;
        }

        private void lblRoomInfo_LinkClicked(object sender, EventArgs e)
        {
            OnRoomInfoClicked?.Invoke(Room.RoomID);
        }
    }
}
