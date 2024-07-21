using System.Windows.Forms;

namespace UtilLibrary
{
    /// <summary>
    /// To open form in panel
    /// </summary>
    public static class OpenFormInPanel
    {
        public static Panel Panel { get; set; }
        public static Form activeForm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ChildForm">Form to open</param>
        public static void Open(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            Panel.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();



        }
    }
}
