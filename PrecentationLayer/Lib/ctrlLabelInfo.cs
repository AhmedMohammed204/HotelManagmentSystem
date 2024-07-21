using System.Windows.Forms;

namespace PrecentationLayer
{
    public partial class ctrlLabelInfo : UserControl
    {
        public ctrlLabelInfo()
        {
            InitializeComponent();
            lblDetails.ForeColor = clsColors.Gold;
            Details = "Details";
            Info = "Info";
        }
        string _Info { get; set; }
        string _Details { get; set; }


        public string Details
        {
            get { return _Details; }
            set { _Details = value; lblDetails.Text = _Details; }
        }
        public string Info
        {
            get { return _Info; }
            set { _Info = value; lblInfo.Text = _Info; }
        }
    }
}
