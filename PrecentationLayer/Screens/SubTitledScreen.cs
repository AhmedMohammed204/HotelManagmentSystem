using System;

namespace PrecentationLayer.Screens
{
    public partial class SubTitledScreen : TitledScreen
    {
        public SubTitledScreen()
        {
            InitializeComponent();
        }
        public event clsGlobal.BackHandler OnBack;
        protected void btnBack_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke();
        }

    }
}
