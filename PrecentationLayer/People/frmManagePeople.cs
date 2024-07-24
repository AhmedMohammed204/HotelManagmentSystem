using PeopleBusinessLayer;
using PrecentationLayer.Lib;
using PrecentationLayer.Reservations;
using PrecentationLayer.Screens;
using System;

namespace PrecentationLayer.People
{
    public partial class frmManagePeople : ShowDataScreen
    {
        public frmManagePeople()
        {
            InitializeComponent();
            Title = "Manage People";
        }
        private void _LoadData()
        {
            DataGrid.LoadData(clsPerson.GetAllPeople());
            DataGrid.Menu(contextMenuStrip1);
        }
        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        public event Action OnClickAddNewPerson;
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            OnClickAddNewPerson?.Invoke();
            _LoadData();
        }
        public event Action<int> OnClickUpdatePerson;
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)DataGrid.DGV.CurrentRow.Cells[0].Value;
            OnClickUpdatePerson?.Invoke(PersonID);
            _LoadData();
        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            clsOpenSubForm.Open(new frmAddUpdatePerson(-1));                                                             
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)DataGrid.DGV.CurrentRow.Cells[0].Value;

            clsOpenSubForm.Open(new frmPersonInfo(PersonID));
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)DataGrid.DGV.CurrentRow.Cells[0].Value;

            frmAddUpdateReservation frm = new frmAddUpdateReservation(-1);
            frm.LoadPerson(PersonID);
            clsOpenSubForm.Open(frm);
        }
    }
}
