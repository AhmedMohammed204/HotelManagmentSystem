using System;

namespace PrecentationLayer.Screens
{
    public partial class frmSettings : SubTitledScreen
    {
        public frmSettings()
        {
            InitializeComponent();
            Title = "Settings";
        }
        public delegate void LogoutEventHandler();
        public event LogoutEventHandler OnLogout;
        private void btnLogout_Click(object sender, EventArgs e)
        {
            OnLogout?.Invoke();
        }
        public delegate void OpenCurrentUserInfoEventHandler();
        public event OpenCurrentUserInfoEventHandler OnOpenCurrentUserInfo;

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            OnOpenCurrentUserInfo?.Invoke();
        }
    }
}
