using PrecentationLayer.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilLibrary;

namespace PrecentationLayer.Lib
{
    public static class clsOpenSubForm
    {
         
        public static void Open(SubTitledScreen frm)
        {
            frm.OnClose += () => { frm.Close(); };
            OpenFormInPanel.Open(frm, false);
        }
    }
}
