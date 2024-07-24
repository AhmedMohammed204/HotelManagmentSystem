using System;
using System.Data;
using System.Windows.Forms;
using UtilLibrary;

namespace PrecentationLayer.Lib
{
    public partial class ctrlDataGridWithSearch : UserControl
    {
        public ctrlDataGridWithSearch()
        {
            InitializeComponent();
            DGV = dgvData;
        }
        public DataTable data;
        public void LoadData(DataTable dt)
        {
            data = dt;
            dgvData.DataSource = data;
            _FillFilters();
        }

        void _FillFilters()
        {
            cbFillters.Items.Clear();
            foreach (DataColumn Column in data.Columns)
            {
                cbFillters.Items.Add(Column.ColumnName);
            }
            if(cbFillters.Items.Count > 0)
                cbFillters.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("Please load data before fillter your txt");
                return;
            }
            if (string.IsNullOrEmpty(cbFillters.Text) || string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                dgvData.DataSource = data;
                return;
            }

            clsFilterDGV.Filter(txtSearch.Text, cbFillters.Text, dgvData, data);
        }

        public void OnlyNumbers(bool OnlyNum)
        {
            txtSearch.OnlyNumbers = OnlyNum;
        }

        public void Menu(ContextMenuStrip cts)
        {
            dgvData.ContextMenuStrip = cts;
        }

        public DataGridView DGV { get; set; }
    }
}
