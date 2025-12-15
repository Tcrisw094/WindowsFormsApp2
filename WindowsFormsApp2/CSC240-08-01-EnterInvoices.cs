using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CSC240_08_01_EnterInvoices : Form
    {
        public CSC240_08_01_EnterInvoices()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // minimal save logic: validate and show confirmation
            if (string.IsNullOrWhiteSpace(txtInvoiceNumber.Text))
            {
                MessageBox.Show("Please enter an invoice number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amount = 0m;
            if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // In a classroom exercise store to memory or file is not required. Show confirmation.
            MessageBox.Show("Invoice saved (demo).", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // clear inputs
            txtInvoiceNumber.Text = string.Empty;
            txtDate.Text = string.Empty;
            txtAmount.Text = string.Empty;
        }
    }
}
