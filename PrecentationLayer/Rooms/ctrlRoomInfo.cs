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
using UtilLibrary;

namespace PrecentationLayer.Rooms
{
    public partial class ctrlRoomInfo : UserControl
    {
        public ctrlRoomInfo()
        {
            InitializeComponent();
        }
        public clsRoom Room { get; set; }
        public void LoadInfo(int RoomID)
        {
            Room = clsRoom.Find(RoomID);
            if(Room == null)
            {
                clsMessageBox.ErrorMessage();
                return;
            }
            LoadDetails();
        }
        void LoadDetails()
        {
            lblRoomID.Details = Room.RoomID.ToString();
            lblCapacity.Details = Room.Capacity.ToString();
            lblFess.Details = Room.fees.ToString();
            lblSingleBeds.Details = Room?.TotalSingleBeds.ToString();
            lblDoubleBeds.Details = Room?.TotalDoubleBeds.ToString();
            lblRoomType.Details = Room.RoomType.Name;
            lblFloor.Details = Room.Floor.ToString();
            lblAllowChildren.Details = Room.AllowChildern.ToString();
        }

    }
}
