using System;
using System.Windows.Forms;
using UsersBusinessLayer;
using UtilLibrary;

namespace PrecentationLayer.Lib
{
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent();
        }
        public clsUser UserInfo { get; set; }
        public void LoadInfo(int UserID)
        {
            UserInfo = clsUser.Find(UserID);
            if (UserInfo == null)
            {
                clsMessageBox.ErrorMessage("User not found");
                return;
            }
            _FillUserDetails();
        }

        private void _FillUserDetails()
        {

            ctrlPersonInfo1.LoadInfo(UserInfo.PersonID);
            InfoUsername.Details = UserInfo.Username;
            InfoIsActive.Details = UserInfo.IsActive.ToString();

        }
        public event Action<int> OnClickUpdate;
        private void ctrlPersonInfo1_OnClickUpdate(int obj)
        {
            OnClickUpdate?.Invoke(obj);
        }
    }
}
