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
using System.Data;

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
        SqlDataAdapter da;


        private void btn_addemp_Click(object sender, EventArgs e)
        {
            employer_reg obj = new employer_reg();
            obj.ShowDialog();
            //OpenChildForm(new employer_reg());
        }

        private void btn_viewE_Click(object sender, EventArgs e)
        {
            //con = new SqlConnection("Data Source=LAPTOP-FK0M22U2;Initial Catalog=e_martlocalhost;Integrated Security=True");//Nadiya
            con = new SqlConnection("Data Source=VIVOBOOK;Initial Catalog=e_martlocalhost;Integrated Security=True");//Fraddya
            try
            {
                if (txt_emp.Text.Length == 0)
                {
                    lbl_1.Text = "Cannot be Null";
                }
                if (combox_emp.SelectedIndex == 0)
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT * FROM Employer WHERE Emp_ID = '" + txt_emp.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();


                }

                else if (combox_emp.SelectedIndex == 1)
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT * FROM Employer WHERE Emp_Name = '" + txt_emp.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();

                }
                else if (combox_emp.SelectedIndex == 2)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Employer WHERE Emp_Name = '" + txt_emp.Text + "' OR  Emp_ID = '" + txt_emp.Text + "'", con);
                    int a = cmd.ExecuteNonQuery();
                    if (a == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this,"Employer data Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this,"Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();



                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
            }
           
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT * FROM Employer", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
