using System;
using System.Windows.Forms;

namespace PrecentationLayer.Lib
{
    public partial class ctrlTextboxUpdateDetails : UserControl
    {
        public ctrlTextboxUpdateDetails()
        {
            InitializeComponent();
            txtDetails.ForeColor = clsColors.Gold;
        }
        #region Custom Config
        string _Info { get; set; }
        string _Details { get; set; }


        public string Details
        {
            get { return _Details; }
            set { _Details = value; txtDetails.Text = _Details; }
        }
        public string Info
        {
            get { return _Info; }
            set { _Info = value; lblInfo.Text = _Info; }
        }

        public bool OnlyNumbers
        {
            get { return txtDetails.OnlyNumbers; }
            set { txtDetails.OnlyNumbers = value; }
        }

        #endregion
        private void txtDetails_TextChanged(object sender, EventArgs e)
        {
            Details = txtDetails.Text;
        }
    }
}
