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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Product' table. You can move, or remove it, as needed.
            this.ProductTableAdapter.Fill(this.DataSet1.Product);

            this.reportViewer1.RefreshReport();
        }

        private void report_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client.Client' table. You can move, or remove it, as needed.
            this.ClientTableAdapter.Fill(this.client.Client);

            this.reportViewer2.RefreshReport();
        }
    }
}
