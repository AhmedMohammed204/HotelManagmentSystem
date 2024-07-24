using PrecentationLayer.Lib;
using PrecentationLayer.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilLibrary;

namespace PrecentationLayer.People
{
    public partial class frmPersonInfo : SubTitledScreen
    {
        public frmPersonInfo(int PersonID)
        {
            InitializeComponent();
            ctrlPersonInfo1.LoadInfo(PersonID);
        }

        private void ctrlPersonInfo1_OnClickUpdate(int obj)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(obj);
            frm.OnClose += () => { frm.Close(); };
            OpenFormInPanel.Open(frm, false);
        }

        private void ctrlPersonInfo1_OnClickUpdate_1(int obj)
        {
            clsOpenSubForm.Open(new frmAddUpdatePerson(obj));
            ctrlPersonInfo1.LoadInfo(obj);

        }
    }
}
