using PeopleBusinessLayer;
using PrecentationLayer.Screens;
using System;

namespace PrecentationLayer.People
{
    public partial class frmManagePeople : SubTitledScreen
    {
        public frmManagePeople()
        {
            InitializeComponent();
            Title = "Manage People";
        }
        private void _LoadData()
        {
            ctrlDataGridWithSearch1.LoadData(clsPerson.GetAllPeople());
            ctrlDataGridWithSearch1.Menu(contextMenuStrip1);
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
            int PersonID = (int)ctrlDataGridWithSearch1.DGV.CurrentRow.Cells[0].Value;
            OnClickUpdatePerson?.Invoke(PersonID);
            _LoadData();
        }
    }
}
