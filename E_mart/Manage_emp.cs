using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_mart
{
    public partial class Manage_emp : Form
    {
        public Manage_emp()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        private void btn_addemp_Click(object sender, EventArgs e)
        {
            employer_reg obj = new employer_reg();
            obj.ShowDialog();
            //OpenChildForm(new employer_reg());
        }

        private void btn_viewE_Click(object sender, EventArgs e)
        {
            
        }
    }
}
