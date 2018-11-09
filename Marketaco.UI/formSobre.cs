using System.Windows.Forms;

namespace Marketaco.UI
{
    public partial class formSobre : Form
    {
        public formSobre()
        {
            InitializeComponent();
        }

        private void formSobre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void llbIcones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://pt.icons8.com/");
        }
    }
}
