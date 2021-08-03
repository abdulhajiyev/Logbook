using System.Windows.Forms;

namespace Logbook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData != Keys.Escape) return;
            if
            (
                MessageBox.Show
                (
                    "Do you want to quit ?",
                    "Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                ) == DialogResult.Yes
            )
            {
                Application.Exit();
            }
        }
    }
}
