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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd1;
        
        SqlDataAdapter da;
      

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BillScroBar_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panal_Invoice.Visible = true;

            if (txt_pid.Text.Length == 0)
            {
                lbl_1.Text = "Cannot be null or Cannot be greater than 6 value for product id";
                panel1.Visible = false;
                panal_Invoice.Visible = false;
            }
            else if (txt_pname.Text.Length == 0 || txt_pname.Text.Any(char.IsDigit))
            {
                lbl_2.Text = "Cannot be null or Cannot be insert number for product name";
                panel1.Visible = false;
                panal_Invoice.Visible = false;
            }
            else if (txt_qun.Text.Length == 0 || txt_qun.Text.Any(char.IsLetter))
            {

                lbl_3.Text = "Cannot be null or Cannot be insert letter for quantity";
                panel1.Visible = false;
                panal_Invoice.Visible = false;
            }

            con = new SqlConnection("Data Source=LAPTOP-FK0M22U2;Initial Catalog=Product;Integrated Security=True");
            con.Open();
            cmd1 = new SqlCommand("SELECT QUN FROM Product WHERE PID='"+txt_pid.Text+"'", con);
            cmd1.Parameters.AddWithValue("PID", txt_pid.Text);
            SqlDataReader rh;
            rh = cmd1.ExecuteReader();
            if(rh.Read())
            {
                //txt_pname.Text= rh["PNAME"].ToString();
                string c= rh["QUN"].ToString();
                txt_qun.Text = c;

            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            con.Close();
           
            
           
            
           
           

          
           
            
        
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int a;
                a = 1 + Convert.ToInt32(txt_qun.Text);
                txt_qun.Text = Convert.ToString(a);
            }
            catch(Exception)
            {
                MessageBox.Show("")
            }
       
;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txt_qun.Text) - 1;
            txt_qun.Text = Convert.ToString(a);

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            

            

            
            panel1.Visible = false;
            panal_Invoice.Visible = false;

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_pid.Clear();
            txt_pname.Clear();
            txt_qun.Clear();
            panel1.Visible = false;
            panal_Invoice.Visible = false;
            lbl_1.Text = " ";
            lbl_2.Text = " ";
            lbl_3.Text = " ";
            su_itemlable1.Text = " ";
            su_itemlable2.Text = " ";
            su_itemlable3.Text = " ";
            su_itemlable4.Text = " ";
            su_itemlable5.Text = " ";
            su_pricelable1.Text = " ";
            su_pricelable2.Text = " ";
            su_pricelable3.Text = " ";
            su_pricelable4.Text = " ";
            su_pricelable5.Text = " ";
            lbl_dis.Text = " ";
            lbl_tot.Text = " ";
            



        }

        private void btn_suadd1_Click(object sender, EventArgs e)
        {
            if(txt_pid.Text == "1")
            {
                lbl_bill2.Text = su_itemlable1.Text;
                lbl_quan2.Text = "1";
                lbl_price2.Text = su_pricelable1.Text;
                
            }
            else if (txt_pid.Text == "2")
            {
                lbl_bill2.Text = su_itemlable1.Text;
                lbl_quan2.Text = "1";
                lbl_price2.Text = su_pricelable1.Text;

            }
            else if (txt_pid.Text == "3")
            {
                lbl_bill2.Text = su_itemlable1.Text;
                lbl_quan2.Text = "1";
                lbl_price2.Text = su_pricelable1.Text;

            }
            else if (txt_pid.Text == "4")
            {
                lbl_bill2.Text = su_itemlable1.Text;
                lbl_quan2.Text = "1";
                lbl_price2.Text = su_pricelable1.Text;

            }
            else if (txt_pid.Text == "5")
            {
                lbl_bill2.Text = su_itemlable1.Text;
                lbl_quan2.Text = "1";
                lbl_price2.Text = su_pricelable1.Text;

            }

        }

        private void btn_suadd2_Click(object sender, EventArgs e)
        {
            if (txt_pid.Text == "1")
            {
                lbl_bill3.Text = su_itemlable2.Text;
                lbl_quan3.Text = "1";
                lbl_price3.Text = su_pricelable2.Text;

            }
            else if (txt_pid.Text == "2")
            {
                lbl_bill3.Text = su_itemlable2.Text;
                lbl_quan3.Text = "1";
                lbl_price3.Text = su_pricelable2.Text;

            }
            else if (txt_pid.Text == "3")
            {
                lbl_bill3.Text = su_itemlable2.Text;
                lbl_quan3.Text = "1";
                lbl_price3.Text = su_pricelable2.Text;

            }
            else if (txt_pid.Text == "4")
            {
                lbl_bill3.Text = su_itemlable2.Text;
                lbl_quan3.Text = "1";
                lbl_price3.Text = su_pricelable2.Text;

            }
            else if (txt_pid.Text == "5")
            {
                lbl_bill3.Text = su_itemlable2.Text;
                lbl_quan3.Text = "1";
                lbl_price3.Text = su_pricelable2.Text;

            }

        }

        private void btn_suadd3_Click(object sender, EventArgs e)
        {
            if (txt_pid.Text == "1")
            {
                lbl_bill4.Text = su_itemlable3.Text;
                lbl_quan4.Text = "1";
                lbl_price4.Text = su_pricelable3.Text;

            }
            else if (txt_pid.Text == "2")
            {
                lbl_bill4.Text = su_itemlable3.Text;
                lbl_quan4.Text = "1";
                lbl_price4.Text = su_pricelable3.Text;

            }
            else if (txt_pid.Text == "3")
            {
                lbl_bill4.Text = su_itemlable3.Text;
                lbl_quan4.Text = "1";
                lbl_price4.Text = su_pricelable3.Text;

            }
            else if (txt_pid.Text == "4")
            {
                lbl_bill4.Text = su_itemlable3.Text;
                lbl_quan4.Text = "1";
                lbl_price4.Text = su_pricelable3.Text;

            }
            else if (txt_pid.Text == "5")
            {
                lbl_bill4.Text = su_itemlable3.Text;
                lbl_quan4.Text = "1";
                lbl_price4.Text = su_pricelable3.Text;

            }

        }

        private void btn_suadd4_Click(object sender, EventArgs e)
        {
            if (txt_pid.Text == "1")
            {
                lbl_bill5.Text = su_itemlable4.Text;
                lbl_quan5.Text = "1";
                lbl_price5.Text = su_pricelable4.Text;

            }
            else if (txt_pid.Text == "2")
            {
                lbl_bill5.Text = su_itemlable4.Text;
                lbl_quan5.Text = "1";
                lbl_price5.Text = su_pricelable4.Text;

            }
            else if (txt_pid.Text == "3")
            {
                lbl_bill5.Text = su_itemlable4.Text;
                lbl_quan5.Text = "1";
                lbl_price5.Text = su_pricelable4.Text;

            }
            else if (txt_pid.Text == "4")
            {
                lbl_bill5.Text = su_itemlable4.Text;
                lbl_quan5.Text = "1";
                lbl_price5.Text = su_pricelable4.Text;

            }
            else if (txt_pid.Text == "5")
            {
                lbl_bill5.Text = su_itemlable4.Text;
                lbl_quan5.Text = "1";
                lbl_price5.Text = su_pricelable4.Text;

            }

        }

        private void btn_suadd5_Click(object sender, EventArgs e)
        {
            if (txt_pid.Text == "1")
            {
                lbl_bill6.Text = su_itemlable5.Text;
                lbl_quan6.Text = "1";
                lbl_price6.Text = su_pricelable5.Text;

            }
            else if (txt_pid.Text == "2")
            {
                lbl_bill6.Text = su_itemlable5.Text;
                lbl_quan6.Text = "1";
                lbl_price6.Text = su_pricelable5.Text;

            }
            else if (txt_pid.Text == "3")
            {
                lbl_bill6.Text = su_itemlable5.Text;
                lbl_quan6.Text = "1";
                lbl_price6.Text = su_pricelable5.Text;

            }
            else if (txt_pid.Text == "4")
            {
                lbl_bill6.Text = su_itemlable5.Text;
                lbl_quan6.Text = "1";
                lbl_price6.Text = su_pricelable5.Text;

            }
            else if (txt_pid.Text == "5")
            {
                lbl_bill6.Text = su_itemlable5.Text;
                lbl_quan6.Text = "1";
                lbl_price6.Text = su_pricelable5.Text;

            }

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            double p1 = Convert.ToDouble(lbl_price1.Text);
            double p2 = Convert.ToDouble(lbl_price2.Text);
            double p3 = Convert.ToDouble(lbl_price3.Text);
            double p4 = Convert.ToDouble(lbl_price4.Text);
            double p5 = Convert.ToDouble(lbl_price5.Text);
            double p6 = Convert.ToDouble(lbl_price6.Text);
            double q1 = Convert.ToDouble(lbl_quan1.Text);
            double q2 = Convert.ToDouble(lbl_quan2.Text); 
            double q3 = Convert.ToDouble(lbl_quan3.Text);
            double q4 = Convert.ToDouble(lbl_quan4.Text); 
            double q5 = Convert.ToDouble(lbl_quan5.Text);
            double q6 = Convert.ToDouble(lbl_quan6.Text);
            double rs = (p1 * q1) + (p2 * q2) + (p3 * q3) + (p4 * q4) + (p5 * q5) + (p6 * q6);
            double dis = rs * 0.05;
            double tot = rs - dis;
            lbl_dis.Text = Convert.ToString(dis);
            lbl_tot.Text = Convert.ToString(tot);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
