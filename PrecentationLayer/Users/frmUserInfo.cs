using PrecentationLayer.Lib;
using PrecentationLayer.People;
using PrecentationLayer.Screens;
using System;

namespace PrecentationLayer.Users
{
    public partial class frmUserInfo : SubTitledScreen
    {
        int _UserID;
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            Title = "User Info";
            _Load();
        }
        void _Load()
        {
            ctrlUserInfo1.LoadInfo(_UserID);

        }
        public event Action<int> OnClickUpdatePerson;

        private void ctrlUserInfo1_OnClickUpdate(int obj)
        {
            clsOpenSubForm.Open(new frmAddUpdatePerson(obj));
            _Load();
        }

        private void ctrlUserInfo1_OnClickUpdateUserInfo(int obj)
        {
            clsOpenSubForm.Open(new frmUpdateUser(obj));
            _Load();
        }
    }
}
