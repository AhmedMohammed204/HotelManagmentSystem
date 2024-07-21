using System.Drawing;
using System.Windows.Forms;

namespace PrecentationLayer
{
    public partial class PrimaryButton : Button
    {
        public PrimaryButton()
        {
            InitializeComponent();
            this.BackColor = clsColors.Gold;
            this.ForeColor = Color.Black;
            this.Font = clsFont.MainFont;
            this.Size = new Size(140, 52);
            this.FlatStyle = FlatStyle.Flat;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
