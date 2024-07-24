using PrecentationLayer.Lib;
using PrecentationLayer.People;
using PrecentationLayer.Reservations;
using PrecentationLayer.Rooms;
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

            menuStrip1.Font = clsFont.MainFont;
            this.WindowState = FormWindowState.Maximized;
            OpenFormInPanel.activeForm = null;
            OpenFormInPanel.Panel = pMain;
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllApplication = false;
            this.Close();
        }

        #endregion

        #region People
        void ShowAllScreen()
        {
            frmManagePeople frm = new frmManagePeople();
            frm.OnClickAddNewPerson += () =>
            {
                AddNewPersonForm(-1, ShowAllScreen);
            };
            frm.OnClickUpdatePerson += (PersonID) =>
            {
                AddNewPersonForm(PersonID, ShowAllScreen);
            };
            frm.OnClose += _OpenMainScreen;

            OpenFormInPanel.Open(frm);
        }
        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllScreen();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPersonForm(-1);
        }


        void AddNewPersonForm(int PersonID, clsGlobal.BackHandler handler = null)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(PersonID);
            if (handler == null)
                handler = _OpenMainScreen;
            frm.OnClose += handler;
            OpenFormInPanel.Open(frm);
        }
        #endregion

        #region Reservations
        void ShowAllReservations()
        {
            frmManageReservations frm = new frmManageReservations();
            frm.OnClose += _OpenMainScreen;
            frm.OnClickAddNew += ()=>
            {
                _AddNewReservation();
            };
            frm.OnClickUpdateNew += (ReservationID) =>
            {
                _AddNewReservation(ReservationID);
            };
            frm.OnClickShowRoomInfo += _RoomInfo;
            frm.OnClickShowReservationInfo += _ReservationInfo;
            OpenFormInPanel.Open(frm);
        }
        private void showAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowAllReservations();
        }
        void _AddNewReservation(int ReservationID = -1)
        {
            frmAddUpdateReservation frm = new frmAddUpdateReservation(ReservationID);
            frm.OnClose += ShowAllReservations;
            frm.OnClickOpenRoomInfo += _RoomInfo;
            OpenFormInPanel.Open(frm);
        }

        void _RoomInfo(int RoomID)
        {
            frmRoomInfo frm = new frmRoomInfo(RoomID);
            frm.OnClose += () => { frm.Close(); };
            OpenFormInPanel.Open(frm,false);
        }

        void _ReservationInfo(int ReservationID)
        {
            clsOpenSubForm.Open(new frmReservationInfo(ReservationID));
        }
        #endregion

        #region Users
        private void showUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.OnClose += _OpenMainScreen;
            OpenFormInPanel.Open(frm);
        }


        private void updateUsernameAndPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateUser frm = new frmUpdateUser(clsGlobal.CurrentUser.UserID);
            frm.OnClose += _OpenMainScreen;
            OpenFormInPanel.Open(frm);
        }
        #endregion

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddNewUser frm = new frmAddNewUser();
            frm.OnClose += _OpenMainScreen;
            OpenFormInPanel.Open(frm);
        }

        private void showAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers frm = new frmManageUsers();
            frm.OnClose += _OpenMainScreen;
            OpenFormInPanel.Open(frm);
        }
    }
}
