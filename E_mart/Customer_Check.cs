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
    public partial class Customer_Check : Form
    {
        public Customer_Check()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;

        Fordashboard obj = new Fordashboard();

        private void btn_enterc_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-FK0M22U2;Initial Catalog=e_martlocalhost;Integrated Security=True");//Nadiya

                if(txt_cidc.Text.Length == 0 || txt_cidc.Text.Any(char.IsLetter))
                {
                    lbl_valid.Text = "Cannot be null or Cannot be Enter Letter";
                }
                con.Open();
                

                SqlDataReader ab5;
                cmd = new SqlCommand("SELECT Client_ID FROM Client WHERE Client_ID ='" + txt_cidc.Text + "'", con);
                cmd.Parameters.AddWithValue("Customer_ID", txt_cidc.Text);

                ab5 = cmd.ExecuteReader();
                if (ab5.Read())
                {
                    lbl_1.Text = ab5["Client_ID"].ToString();
                    if (lbl_1.Text != "")
                    {
                        Fordashboard.value1 = lbl_1.Text;
                        MetroFramework.MetroMessageBox.Show(this,"You are Registerd Customer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this,"You are not Registerd Customer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                con.Close();


                Fordashboard.value = txt_cidc.Text;
                this.Close();
            }
            catch (FormatException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Please enter numbers only", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch(DivideByZeroException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot divide by ZERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Customer_Check_Load(object sender, EventArgs e)
        {
            lbl_1.Visible = false;
        }
    }
}
