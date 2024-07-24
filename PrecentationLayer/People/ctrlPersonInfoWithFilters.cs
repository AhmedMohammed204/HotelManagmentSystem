using PeopleBusinessLayer;
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
using UtilLibrary;

namespace PrecentationLayer.People
{
    public partial class ctrlPersonInfoWithFilters : UserControl
    {
        public ctrlPersonInfoWithFilters()
        {
            InitializeComponent();
            FindButton = btnFind;
            ctrlPersonInfo1.UpdateButton.Visible = false;
            PersonInfo = ctrlPersonInfo1;
        }
        public ctrlPersonInfo PersonInfo { get; set; }
        string _PersonID {  get; set; }
        public string PersonID
        {
            get { return _PersonID; }
            set {  _PersonID = value; txtPersonID.Details = _PersonID; }
        }
        public Button FindButton { get; set; }
         bool _AllowFilters {  get; set; }
        public bool AllowFilters
        {
            get { return _AllowFilters; }
            set { _AllowFilters = value; gbFilters.Enabled = _AllowFilters; }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {

            Find();                

        }
        public void Find()
        {
            if (string.IsNullOrEmpty(txtPersonID.Details))
            {
                clsMessageBox.InfoMessage("you can not find without putting a person id");
                return;
            }

            ctrlPersonInfo1.LoadInfo(Convert.ToInt32(txtPersonID.Details));
        }
    }
}
