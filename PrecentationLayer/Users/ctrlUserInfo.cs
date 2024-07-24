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
            PersonInfo = ctrlPersonInfo1;
            btnUpdateUser = btnUpdateUserInfo;
        }
        public clsUser UserInfo { get; set; }
        public ctrlPersonInfo PersonInfo { get; set; }
        public Button btnUpdateUser { get; set; }
        public bool LoadInfo(int UserID)
        {
            UserInfo = clsUser.Find(UserID);
            if (UserInfo == null)
            {
                clsMessageBox.ErrorMessage("User not found");
                return false;
            }
            _FillUserDetails();
            return true;
        }

        private void _FillUserDetails()
        {

            ctrlPersonInfo1.LoadInfo(UserInfo.PersonID);
            InfoUsername.Details = UserInfo.Username;
            InfoIsActive.Details = UserInfo.IsActive.ToString();

        }
        public event Action<int> OnClickUpdate;
        public event Action<int> OnClickUpdateUserInfo;
        private void ctrlPersonInfo1_OnClickUpdate(int obj)
        {
            OnClickUpdate?.Invoke(obj);
        }

        private void btnUpdateUserInfo_Click(object sender, EventArgs e)
        {
            OnClickUpdateUserInfo?.Invoke(UserInfo.UserID);
        }
    }
}
