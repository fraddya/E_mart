using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_mart
{
    public partial class report_form : Form
    {
        public report_form()
        {
            InitializeComponent();
        }

        private void report_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'static_report.Product' table. You can move, or remove it, as needed.
            this.ProductTableAdapter.Fill(this.static_report.Product);

            this.reportViewer1.RefreshReport();
        }
    }
}
