using System.Windows.Forms;

namespace UtilLibrary
{
    public static class clsMessageBox
    {
        public static void ErrorMessage(string text = "There was an error", string Title = "Error")
        {
            MessageBox.Show(text, Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void DoneMessage(string text, string Title = "Done")
        {
            MessageBox.Show(text, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void InfoMessage(string text, string Title = "Info")
        {
            MessageBox.Show(text, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
