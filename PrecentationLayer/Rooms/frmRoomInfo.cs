using PrecentationLayer.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrecentationLayer.Rooms
{
    public partial class frmRoomInfo : SubTitledScreen
    {
        public frmRoomInfo(int RoomID)
        {
            InitializeComponent();
            ctrlRoomInfo1.LoadInfo(RoomID);
        }
    }
}
