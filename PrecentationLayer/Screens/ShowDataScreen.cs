using PrecentationLayer.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrecentationLayer.Screens
{
    public partial class ShowDataScreen : SubTitledScreen
    {
        public ctrlDataGridWithSearch DataGrid {  get; set; }
        public ShowDataScreen()
        {
            InitializeComponent();
            DataGrid = ctrlDataGridWithSearch1;
        }
    }
}
