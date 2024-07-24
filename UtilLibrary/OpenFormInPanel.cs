using System.Windows.Forms;
using System.Collections.Generic;
namespace UtilLibrary
{
    /// <summary>
    /// To open form in panel
    /// </summary>
    public static class OpenFormInPanel
    {
        private static List<Form> FormPool = new List<Form>();
        public static Panel Panel { get; set; }
        public static Form activeForm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ChildForm">Form to open</param>
        public static void Open(Form ChildForm, bool ClosePrevFrom = true)
        {

            if(!ClosePrevFrom)
                FormPool.Add(ChildForm);
            else
                CloseAllForms();


            if (activeForm != null && ClosePrevFrom)
            {
                activeForm.Close();
                
            }
            if(ClosePrevFrom) 
                activeForm = ChildForm;


            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            Panel.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        static void CloseAllForms()
        {
            foreach (Form Form in FormPool)
            {
                Form.Close();
            }

            FormPool.Clear();
        }
    }
}
