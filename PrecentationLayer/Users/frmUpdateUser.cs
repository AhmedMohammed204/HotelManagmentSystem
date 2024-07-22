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

namespace PrecentationLayer.Users
{
    public partial class frmUpdateUser : SubTitledScreen
    {
        public frmUpdateUser(int UserID)
        {
            InitializeComponent();
            Title = "Update User";
            ctrlUpdateUser1.LoadUser(UserID);
        }
    }
}
