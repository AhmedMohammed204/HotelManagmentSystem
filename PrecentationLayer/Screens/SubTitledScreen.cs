using System;

namespace PrecentationLayer.Screens
{
    public partial class SubTitledScreen : TitledScreen
    {
        public SubTitledScreen()
        {
            InitializeComponent();
        }
        public event clsGlobal.BackHandler OnClose;
        private void btnClose_Click(object sender, EventArgs e)
        {
            OnClose?.Invoke();
        }
    }
}
