using System.Windows.Forms;

namespace PrecentationLayer.Lib
{
    public partial class PrimaryTextBox : TextBox
    {
        public enum enMode { Show = 0, Hide = 1 }
        private enMode _Mode;
        public enMode Mode
        {
            get { return _Mode; }
            set
            {
                _Mode = value;
                switch (_Mode)
                {
                    case enMode.Show:
                        ShowChar();
                        break;
                    case enMode.Hide:
                        HideChar();
                        break;

                }
            }
        }
        private bool _OnlyNumbers { get; set; }
        public bool OnlyNumbers
        {
            get { return _OnlyNumbers; }
            set
            {
                _OnlyNumbers = value;

                if (_OnlyNumbers) this.KeyPress += KeyPressEventHandler;

            }
        }
        public PrimaryTextBox()
        {
            InitializeComponent();
            this.Font = clsFont.MainFont;
            this.Tag = "Hide";
            OnlyNumbers = false;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void HideChar()
        {
            this.PasswordChar = '*';
            this.Tag = "Show";
        }

        private void ShowChar()
        {
            this.PasswordChar = '\0';
            this.Tag = "Hide";
        }

        private void KeyPressEventHandler(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
