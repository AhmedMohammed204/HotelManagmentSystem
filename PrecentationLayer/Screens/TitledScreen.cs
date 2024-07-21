namespace PrecentationLayer.Screens
{
    public partial class TitledScreen : Screen
    {
        public string Title { get { return lblTitle.Text; } set { lblTitle.Text = value; } }
        public TitledScreen()
        {
            InitializeComponent();
            lblTitle.ForeColor = clsColors.Smoke;
        }
    }
}
