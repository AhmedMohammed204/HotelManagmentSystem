using System.Data;
using System.Windows.Forms;

namespace UtilLibrary
{
    public static class clsFilterDGV
    {
        public static void Filter(string Text, string ColumnToSearchIn, DataGridView dgv, DataTable DefualtDataTable)
        {
            if (string.IsNullOrEmpty(ColumnToSearchIn))
                return;


            DataTable dt = DefualtDataTable;
            if (string.IsNullOrEmpty(Text))
            {
                dgv.DataSource = dt;
                return;
            }
            DataView dataView = new DataView(dt);


            dataView.RowFilter = $"CONVERT({ColumnToSearchIn}, 'System.String') Like '{Text}%'";
            dgv.DataSource = dataView;
            //dataView.Dispose();
        }

    }
}
