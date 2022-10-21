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
    public partial class Manage_emp : Form
    {
        public Manage_emp()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        

        private void btn_addemp_Click(object sender, EventArgs e)
        {
            employer_reg obj = new employer_reg();
            obj.ShowDialog();
            //OpenChildForm(new employer_reg());

        }

        private void btn_viewE_Click(object sender, EventArgs e)
        {
            try
            {
                if (combox_emp.SelectedIndex == 0)
                {
                    String b;
                    b = txt_emp.Text;
                    
              
                    
                    dataGridView1.DataSource = db.getData("select * from Employee where Emp_ID='" + txt_emp.Text + "'");
                }
                else if (combox_emp.SelectedIndex == 1)
                {
                    String c;
                    c=txt_emp.Text;
                    dataGridView1.DataSource = db.getData("select * from Employee where Emp_Name LIKE='" + txt_emp.Text + "%'");
                }
                
                
                   

                
            }
            catch (Exception)
            {
                MessageBox.Show(this,"Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = db.getData("select * from Employee");
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        }
    }
}
