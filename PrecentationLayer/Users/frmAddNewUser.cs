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
using UtilLibrary;

namespace PrecentationLayer.Users
{
    public partial class frmAddNewUser : SubTitledScreen
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }
        bool _IsValidToSave()
        {
            clsUser temp = clsUser.FindByPersonID(ctrlPersonInfoWithFilters1.PersonInfo.PersonInfo.PersonID);
            if (ctrlPersonInfoWithFilters1.PersonInfo == null)
            {
                clsMessageBox.ErrorMessage("Person not found");
                return false;
            }
            else if(clsUser.Find(txtUsername.Details) != null)
            {
                clsMessageBox.ErrorMessage("Username is already used");
                return false;

            }
            
            else if (temp != null && temp.IsActive)
            {
                clsMessageBox.ErrorMessage("Person is already connected with user");
                return false;
            }
            else if (txtPassword.Details.Length < 8)
            {
                clsMessageBox.ErrorMessage("Password should be more than 8 characters");
                return false;
            }
            else if (txtPassword.Details != txtConfirmPass.Details)
            {
                clsMessageBox.ErrorMessage("Password doesn't match");
                return false;
            }
            else
                return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsValidToSave()) return;
            clsUser user = new clsUser();
            user.Username = txtUsername.Details;
            user.Password = txtPassword.Details;
            user.IsActive = true;
            user.PersonID = ctrlPersonInfoWithFilters1.PersonInfo.PersonInfo.PersonID;
            if(!user.Save())
            {
                clsMessageBox.ErrorMessage();
                return;
            }
            else
            {
                clsMessageBox.DoneMessage("User added successfully");
                ctrlPersonInfoWithFilters1.Enabled = false;
                groupBox1.Enabled = false;
                btnSave.Enabled = false;
            }
        }
    }
}
