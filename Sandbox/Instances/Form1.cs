using System;
using System.Windows.Forms;

namespace Instances
{
    public partial class Form1 : Form
    {
        private frmDialog frm;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frmDialog d = new frmDialog())
            {
                if (d.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("OK Selected");
                }
                else
                {
                    MessageBox.Show("Cancel Selected");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm = new frmDialog();
            frm.Show();
        }

        private void btnShowValue_Click(object sender, EventArgs e)
        {
            if (frm == null)
            {
                MessageBox.Show(
                    "no instance currently available",
                    Application.ProductName, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation
                );
            }
            else
            {
                lblValue.Text = $"Value = {frm.Counter}";
                lblSquare.Text = $"Square = {Helpers.Square(frm.Counter)}";
            }
        }

    }
}
