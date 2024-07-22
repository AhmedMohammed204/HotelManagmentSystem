using PrecentationLayer.People;
using PrecentationLayer.Screens;
using PrecentationLayer.Users;
using System;
using System.Windows.Forms;
using UtilLibrary;

namespace PrecentationLayer
{
    public partial class frmMain : Screen
    {
        public frmMain()
        {
            InitializeComponent();


            lblTitle.ForeColor = clsColors.Gold;
            lblTitle.BackColor = clsColors.LightBrown;
            this.WindowState = FormWindowState.Maximized;
            OpenFormInPanel.activeForm = null;
        }
        private void _OpenMainScreen()
        {
            if (OpenFormInPanel.activeForm == null)
                return;

            OpenFormInPanel.activeForm.Close();
        }

        #region Handle Close
        private bool CloseAllApplication = true;
        public delegate void OnCloseApplication(bool CloseAllApplication);
        public event OnCloseApplication ApplicationClose;
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e) { ApplicationClose(CloseAllApplication); }
        #endregion



    }
}
