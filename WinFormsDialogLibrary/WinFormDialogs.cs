using System.Windows.Forms;

namespace WinFormsDialogLibrary
{
    public static class WinFormDialogs
    {
        public static bool Question(string pText)
        {
            return (MessageBox.Show(pText, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }
    }
}
