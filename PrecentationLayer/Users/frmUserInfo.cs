using PrecentationLayer.Screens;
using System;

namespace PrecentationLayer.Users
{
    public partial class frmUserInfo : SubTitledScreen
    {

        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            Title = "User Info";
            ctrlUserInfo1.LoadInfo(UserID);
        }
        public event Action<int> OnClickUpdatePerson;

        private void ctrlUserInfo1_OnClickUpdate(int obj)
        {
            OnClickUpdatePerson?.Invoke(obj);
        }
    }
}
