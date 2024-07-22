using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace PrecentationLayer
{
    public partial class PrimaryButton : Guna2Button
    {
        public PrimaryButton()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            this.FillColor = clsColors.Gold;
            this.ForeColor = Color.Black;
            this.Font = clsFont.MainFont;
            this.Size = new Size(140, 52);
            this.BorderRadius = 10;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
