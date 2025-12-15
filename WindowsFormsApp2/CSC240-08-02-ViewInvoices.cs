using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CSC240_08_02_ViewInvoices : Form
    {
        public CSC240_08_02_ViewInvoices()
        {
            InitializeComponent();
            // demo data
            dgvInvoices.Rows.Add("1001", "2025-12-01", "150.00");
            dgvInvoices.Rows.Add("1002", "2025-12-05", "200.50");
        }
    }
}
