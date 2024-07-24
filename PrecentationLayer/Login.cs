using MyClassLibrary;
using PrecentationLayer.Properties;
using System;
using System.Windows.Forms;
using UsersBusinessLayer;
using UtilLibrary;
namespace PrecentationLayer
{
    public partial class Login : Form
    {
        #region init form
        private string _ApplicationName { get; set; }
        public Login()
        {
            InitializeComponent();
            _ApplicationName = "StegiHotle";
            btnClose.BackColor = clsColors.HevyYellow;
            btnLogin.BackColor = clsColors.HevyYellow;

        }
        private void _LoadFromRegistries()
        {
            WinRegistries registries = new WinRegistries(_ApplicationName, WinRegistries.enHKEY.HKEY_CURRENT_USER);
            string Username = registries.Get("Username");
            string Password = registries.Get("Password");

            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                txtUsername.Text = Username;
                txtPassword.Text = Password;
                cbRememberMe.Checked = true;
                btnLogin.Focus();
            }
            else
            {
                txtPassword.Clear();
                txtUsername.Clear();
                cbRememberMe.Checked = false;
                txtPassword.Focus();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _LoadFromRegistries();
        }
        #endregion

        #region Close window
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Perform remember me
        private void PerformanceRememberMe()
        {
            WinRegistries registries = new WinRegistries(_ApplicationName, WinRegistries.enHKEY.HKEY_CURRENT_USER);

            if (cbRememberMe.Checked)
            {
                registries.SetVelue("Username", txtUsername.Text);
                registries.SetVelue("Password", txtPassword.Text);
            }
            else
            {
                registries.SetVelue("Username", string.Empty);
                registries.SetVelue("Password", string.Empty);
            }

        }
        #endregion

        #region Login 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!clsUser.IsAbleToLogin(txtUsername.Text, clsHashing.Hash(txtPassword.Text)))
            {
                clsMessageBox.ErrorMessage("Username or password is not exist.");
                return;
            }

            clsGlobal.CurrentUser = clsUser.Find(txtUsername.Text);
            if (!clsGlobal.CurrentUser.IsActive)
            {
                clsMessageBox.ErrorMessage("User is not active. call your admin");
                clsGlobal.CurrentUser = null;
                return;
            }

            PerformanceRememberMe();
            this.Hide();
            _OpenMainForm();
        }

        private void pbShowHide_Click(object sender, EventArgs e)
        {
            switch (txtPassword.Mode)
            {
                case Lib.PrimaryTextBox.enMode.Show:
                    pbShowHide.Image = Resources.show;
                    txtPassword.Mode = Lib.PrimaryTextBox.enMode.Hide;
                    return;
                case Lib.PrimaryTextBox.enMode.Hide:
                    pbShowHide.Image = Resources.hide;
                    txtPassword.Mode = Lib.PrimaryTextBox.enMode.Show;
                    return;
            }
        }
        #endregion

        #region Open Main Form

        private void _OpenMainForm()
        {
            frmMain frm = new frmMain();
            frm.ApplicationClose += _HandleApplcaitionClosing;
            frm.ShowDialog();
        }
        private void _HandleApplcaitionClosing(bool CloseAllApplication)
        {
            if (CloseAllApplication) this.Close();
            else this.Show();
        }
        #endregion
    }
}
