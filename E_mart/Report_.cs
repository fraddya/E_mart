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
    public partial class Report_ : Form
    {
        public Report_()
        {
            InitializeComponent();
        }

        private void Report__Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Employer' table. You can move, or remove it, as needed.
            this.EmployerTableAdapter.Fill(this.DataSet1.Employer);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
