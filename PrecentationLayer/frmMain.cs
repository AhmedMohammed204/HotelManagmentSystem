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
            OpenFormInPanel.Panel = pMain;
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

        #region Settings
        private void btnSettings_Click(object sender, EventArgs e)
        {
            _SettingsForm();
        }
        void _SettingsForm()
        {
            frmSettings frm = new frmSettings();
            frm.OnLogout += _Logout;
            frm.OnOpenCurrentUserInfo += _CurrentUserInfo;
            frm.OnBack += _OpenMainScreen;
            OpenFormInPanel.Open(frm);
        }
        private void _Logout()
        {
            CloseAllApplication = false;
            this.Close();
        }
        void _CurrentUserInfo()
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.OnBack += _SettingsForm;
            frm.OnClickUpdatePerson += (PersonID) =>
            {
                frmAddUpdatePerson frm2 = new frmAddUpdatePerson(PersonID);
                frm2.OnBack += _CurrentUserInfo;
                OpenFormInPanel.Open(frm2);
            };
            OpenFormInPanel.Open(frm);
        }
        #endregion

        #region People
        void _AddUpdatePerson(int PersonID, clsGlobal.BackHandler BackHandler)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(PersonID);
            frm.OnBack += BackHandler;
            OpenFormInPanel.Open(frm);
        }
        void _ManagePeopleScreen()
        {
            frmManagePeople frm = new frmManagePeople();
            frm.OnBack += _OpenMainScreen;
            frm.OnClickAddNewPerson += () =>
            {
                _AddUpdatePerson(-1, _ManagePeopleScreen);
            };
            frm.OnClickUpdatePerson += (PersonID) =>
            {
                _AddUpdatePerson(PersonID, _ManagePeopleScreen);
            };
            OpenFormInPanel.Open(frm);
        }
        private void btnManagePeople_Click(object sender, EventArgs e)
        {
            _ManagePeopleScreen();
        }
        #endregion
    }
}
