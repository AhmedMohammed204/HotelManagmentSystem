using PrecentationLayer.Lib;
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
using UsersBusinessLayer;

namespace PrecentationLayer.Users
{
    public partial class frmManageUsers : ShowDataScreen
    {
        public frmManageUsers()
        {
            InitializeComponent();

            DataGrid.LoadData(clsUser.GetAllUsers());
            this.DataGrid.Menu(contextMenuStrip1);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewUser frm = new frmAddNewUser();
            frm.OnClose += () => { DataGrid.LoadData(clsUser.GetAllUsers()); };
            clsOpenSubForm.Open(frm);
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)DataGrid.DGV.CurrentRow.Cells["UserID"].Value;
            clsOpenSubForm.Open(new frmUserInfo(UserID));

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)DataGrid.DGV.CurrentRow.Cells["UserID"].Value;
            clsOpenSubForm.Open(new frmUpdateUser(UserID));
        }
    }
}
