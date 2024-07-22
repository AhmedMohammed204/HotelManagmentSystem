using MyClassLibrary;
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
using UtilLibrary;

namespace PrecentationLayer.Users
{
    public partial class ctrlUpdateUser : UserControl
    {
        public ctrlUpdateUser()
        {
            InitializeComponent();
            ctrlUserInfo1.PersonInfo.UpdateButton.Visible = false;
        }
        public void LoadUser(int UserID)
        {
            if (!ctrlUserInfo1.LoadInfo(UserID)) return;
            txtUsername.Details = ctrlUserInfo1.UserInfo.Username;
            txtPassword.Details = string.Empty;
            txtConfirmPassword.Details = string.Empty;
        }
        bool _IsValidToSave()
        {
            if(string.IsNullOrEmpty(txtUsername.Details) || string.IsNullOrEmpty(txtConfirmPassword.Details) || string.IsNullOrEmpty(txtPassword.Details))
            {
                clsMessageBox.ErrorMessage("Fill all details before save");
                return false;
            }
            clsUser temp = clsUser.Find(txtUsername.Details);
            if (temp != null && temp.Username != clsGlobal.CurrentUser.Username)
            {
                clsMessageBox.ErrorMessage("Username is already exist");
                return false;
            }

            if(txtConfirmPassword.Details != txtPassword.Details)
            {
                clsMessageBox.ErrorMessage("Password doesn't match");
                return false;
            }


            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsValidToSave())
                return;
            ctrlUserInfo1.UserInfo.Username = txtUsername.Details;
            ctrlUserInfo1.UserInfo.Password = clsHashing.Hash( txtPassword.Details);
            if(!ctrlUserInfo1.UserInfo.Save())
            {
                clsMessageBox.ErrorMessage("There was an error");
                return;
            }
            clsMessageBox.DoneMessage("User Updated Successfully");
            LoadUser(ctrlUserInfo1.UserInfo.UserID);
            
        }
    }
}
