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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd1;
        SqlCommand cmd2;
        SqlCommand cmd3;    
      
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BillScroBar_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            
            int i;
            
                panel3.Visible = true;
                

                if (txt_pid.Text.Length == 0 || txt_pid.Text.Any(char.IsLetter))
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

                    lbl_3.Text = "Cannot be null or Cannot be insert letter for quaentity";
                    panel1.Visible = false;
                    panal_Invoice.Visible = false;
                }



                //con = new SqlConnection(""); enter your string
                con = new SqlConnection("Data Source=VIVOBOOK;Initial Catalog=Bank;Integrated Security=True");
                //con = new SqlConnection("Data Source=LAPTOP-FK0M22U2;Initial Catalog=e_martlocalhost;Integrated Security=True");//my
                con.Open();
                cmd1 = new SqlCommand("SELECT Product_queantity,Product_Price,Product_Name,Product_category,category_unit_no FROM Product WHERE Product_ID='" + txt_pid.Text + "'", con);//
                cmd1.Parameters.AddWithValue("Product_ID", txt_pid.Text);
                SqlDataReader rj;
                rj = cmd1.ExecuteReader();
                if (rj.Read())
                {
                    string s = txt_qun.Text;
                    lbl_data.Text = rj["Product_queantity"].ToString();
                    string g = lbl_data.Text;
                if (Convert.ToInt32(s) < Convert.ToInt32(g))
                {
                    lbl_quan1.Text = s ;
                    lbl_quan1.Visible = true;
                }
                else
                {
                    lbl_bill1.Text = " ";
                    lbl_price1.Text = " ";
                    MessageBox.Show("Your adding quaentity value grater than product quaentity please enter less than value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                    
                    txt_pname.Text = rj["Product_Name"].ToString();
                if (Convert.ToInt32(s) < Convert.ToInt32(g))
                {
                    lbl_bill1.Text = txt_pname.Text;
                    lbl_price1.Text = rj["Product_Price"].ToString();
                    lbl_price1.Visible = true;
                    lbl_bill1.Visible = true;
                }
                else { }
                    lbl_get.Text = rj["Product_category"].ToString();
                    lbl_unit.Text = rj["category_unit_no"].ToString();//

                }
                else
                {
                    MessageBox.Show("No Data Found");
                }
                con.Close();

            if(Convert.ToInt32(lbl_unit.Text) == 1)
            {
                Convert.ToString(lbl_unit.Text);
                con.Open();
                SqlDataReader ab1;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 2", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab1 = cmd2.ExecuteReader();
                if (ab1.Read())
                {
                    su_itemlable1.Text = ab1["Product_Name"].ToString();
                    su_pricelable1.Text = ab1["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab2;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 3", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab2 = cmd2.ExecuteReader();
                if (ab2.Read())
                {
                    su_itemlable2.Text = ab2["Product_Name"].ToString();
                    su_pricelable2.Text = ab2["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab3;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 4", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab3 = cmd2.ExecuteReader();
                if (ab3.Read())
                {
                    su_itemlable3.Text = ab3["Product_Name"].ToString();
                    su_pricelable3.Text = ab3["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab4;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 5", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab4 = cmd2.ExecuteReader();
                if (ab4.Read())
                {
                    su_itemlable4.Text = ab4["Product_Name"].ToString();
                    su_pricelable4.Text = ab4["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab5;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 6", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab5 = cmd2.ExecuteReader();
                if (ab5.Read())
                {
                    su_itemlable5.Text = ab5["Product_Name"].ToString();
                    su_pricelable5.Text = ab5["Product_Price"].ToString();
                }
                con.Close();

                

            }
            else if (Convert.ToInt32(lbl_unit.Text) == 2)
            {
                Convert.ToString(lbl_unit.Text);
                con.Open();
                SqlDataReader ab1;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 1", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab1 = cmd2.ExecuteReader();
                if (ab1.Read())
                {
                    su_itemlable1.Text = ab1["Product_Name"].ToString();
                    su_pricelable1.Text = ab1["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab2;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 3", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab2 = cmd2.ExecuteReader();
                if (ab2.Read())
                {
                    su_itemlable2.Text = ab2["Product_Name"].ToString();
                    su_pricelable2.Text = ab2["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab3;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 4", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab3 = cmd2.ExecuteReader();
                if (ab3.Read())
                {
                    su_itemlable3.Text = ab3["Product_Name"].ToString();
                    su_pricelable3.Text = ab3["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab4;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 5", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab4 = cmd2.ExecuteReader();
                if (ab4.Read())
                {
                    su_itemlable4.Text = ab4["Product_Name"].ToString();
                    su_pricelable4.Text = ab4["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab5;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 6", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab5 = cmd2.ExecuteReader();
                if (ab5.Read())
                {
                    su_itemlable5.Text = ab5["Product_Name"].ToString();
                    su_pricelable5.Text = ab5["Product_Price"].ToString();
                }
                con.Close();

            }
            else if (Convert.ToInt32(lbl_unit.Text) == 3)
            {
                Convert.ToString(lbl_unit.Text);
                con.Open();
                SqlDataReader ab1;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 2", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab1 = cmd2.ExecuteReader();
                if (ab1.Read())
                {
                    su_itemlable1.Text = ab1["Product_Name"].ToString();
                    su_pricelable1.Text = ab1["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab2;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 1", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab2 = cmd2.ExecuteReader();
                if (ab2.Read())
                {
                    su_itemlable2.Text = ab2["Product_Name"].ToString();
                    su_pricelable2.Text = ab2["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab3;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 4", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab3 = cmd2.ExecuteReader();
                if (ab3.Read())
                {
                    su_itemlable3.Text = ab3["Product_Name"].ToString();
                    su_pricelable3.Text = ab3["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab4;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 5", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab4 = cmd2.ExecuteReader();
                if (ab4.Read())
                {
                    su_itemlable4.Text = ab4["Product_Name"].ToString();
                    su_pricelable4.Text = ab4["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab5;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 6", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab5 = cmd2.ExecuteReader();
                if (ab5.Read())
                {
                    su_itemlable5.Text = ab5["Product_Name"].ToString();
                    su_pricelable5.Text = ab5["Product_Price"].ToString();
                }
                con.Close();

            }
            else if (Convert.ToInt32(lbl_unit.Text) == 4)
            {
                Convert.ToString(lbl_unit.Text);
                con.Open();
                SqlDataReader ab1;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 2", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab1 = cmd2.ExecuteReader();
                if (ab1.Read())
                {
                    su_itemlable1.Text = ab1["Product_Name"].ToString();
                    su_pricelable1.Text = ab1["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab2;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 3", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab2 = cmd2.ExecuteReader();
                if (ab2.Read())
                {
                    su_itemlable2.Text = ab2["Product_Name"].ToString();
                    su_pricelable2.Text = ab2["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab3;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 1", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab3 = cmd2.ExecuteReader();
                if (ab3.Read())
                {
                    su_itemlable3.Text = ab3["Product_Name"].ToString();
                    su_pricelable3.Text = ab3["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab4;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 5", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab4 = cmd2.ExecuteReader();
                if (ab4.Read())
                {
                    su_itemlable4.Text = ab4["Product_Name"].ToString();
                    su_pricelable4.Text = ab4["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab5;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 6", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab5 = cmd2.ExecuteReader();
                if (ab5.Read())
                {
                    su_itemlable5.Text = ab5["Product_Name"].ToString();
                    su_pricelable5.Text = ab5["Product_Price"].ToString();
                }
                con.Close();

            }
            else if (Convert.ToInt32(lbl_unit.Text) == 5)
            {
                Convert.ToString(lbl_unit.Text);
                con.Open();
                SqlDataReader ab1;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 2", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab1 = cmd2.ExecuteReader();
                if (ab1.Read())
                {
                    su_itemlable1.Text = ab1["Product_Name"].ToString();
                    su_pricelable1.Text = ab1["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab2;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 3", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab2 = cmd2.ExecuteReader();
                if (ab2.Read())
                {
                    su_itemlable2.Text = ab2["Product_Name"].ToString();
                    su_pricelable2.Text = ab2["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab3;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 4", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab3 = cmd2.ExecuteReader();
                if (ab3.Read())
                {
                    su_itemlable3.Text = ab3["Product_Name"].ToString();
                    su_pricelable3.Text = ab3["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab4;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 1", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab4 = cmd2.ExecuteReader();
                if (ab4.Read())
                {
                    su_itemlable4.Text = ab4["Product_Name"].ToString();
                    su_pricelable4.Text = ab4["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab5;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 6", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab5 = cmd2.ExecuteReader();
                if (ab5.Read())
                {
                    su_itemlable5.Text = ab5["Product_Name"].ToString();
                    su_pricelable5.Text = ab5["Product_Price"].ToString();
                }
                con.Close();

            }
            else if (Convert.ToInt32(lbl_unit.Text) == 6)
            {
                Convert.ToString(lbl_unit.Text);
                con.Open();
                SqlDataReader ab1;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 2", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab1 = cmd2.ExecuteReader();
                if (ab1.Read())
                {
                    su_itemlable1.Text = ab1["Product_Name"].ToString();
                    su_pricelable1.Text = ab1["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab2;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 3", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab2 = cmd2.ExecuteReader();
                if (ab2.Read())
                {
                    su_itemlable2.Text = ab2["Product_Name"].ToString();
                    su_pricelable2.Text = ab2["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab3;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 4", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab3 = cmd2.ExecuteReader();
                if (ab3.Read())
                {
                    su_itemlable3.Text = ab3["Product_Name"].ToString();
                    su_pricelable3.Text = ab3["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab4;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 5", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab4 = cmd2.ExecuteReader();
                if (ab4.Read())
                {
                    su_itemlable4.Text = ab4["Product_Name"].ToString();
                    su_pricelable4.Text = ab4["Product_Price"].ToString();
                }
                con.Close();

                con.Open();
                SqlDataReader ab5;
                cmd2 = new SqlCommand("SELECT Product_Name,Product_Price FROM Product WHERE Product_category = '" + lbl_get.Text + "' AND category_unit_no = 1", con);
                cmd2.Parameters.AddWithValue("Product_ID", txt_pid.Text);

                ab5 = cmd2.ExecuteReader();
                if (ab5.Read())
                {
                    su_itemlable5.Text = ab5["Product_Name"].ToString();
                    su_pricelable5.Text = ab5["Product_Price"].ToString();
                }
                con.Close();

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {           
            int a;
            a = 1 + Convert.ToInt32(txt_qun.Text);
            txt_qun.Text = Convert.ToString(a);
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txt_qun.Text) - 1;
            txt_qun.Text = Convert.ToString(a);

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            lbl_get.Visible = false;
            lbl_qunget1.Visible = false;
            lbl_qunget2.Visible = false;
            lbl_qunget3.Visible = false;
            lbl_qunget4.Visible = false;
            lbl_qunget5.Visible = false;
            lbl_qunget6.Visible = false;
            lbl_qunget1.Visible = false;
            lbl_qunget2.Visible = false;
            lbl_qunget3.Visible = false;
            lbl_qunget4.Visible = false;
            lbl_qunget5.Visible = false;
            lbl_qunget6.Visible = false;
            lbl_unit.Visible = false;
            lbl_data.Visible = false;
            lbl_quan1.Visible = false;
            lbl_quan2.Visible = false;
            lbl_quan3.Visible = false;
            lbl_quan4.Visible = false;
            lbl_quan5.Visible = false;
            lbl_quan6.Visible = false;
            lbl_price1.Visible = false;
            lbl_price2.Visible = false;
            lbl_price3.Visible = false;
            lbl_price4.Visible = false;
            lbl_price5.Visible = false;
            lbl_price6.Visible = false;
            lbl_bill1.Visible = false;
            lbl_bill2.Visible = false;
            lbl_bill3.Visible = false;
            lbl_bill4.Visible = false;
            lbl_bill5.Visible = false;
            lbl_bill6.Visible = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_pid.Clear();
            txt_pname.Clear();
            txt_qun.Clear();

            panel3.Visible = false;
            
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

            lbl_bill1.Text = " ";
            lbl_bill2.Text = " ";
            lbl_bill3.Text = " ";
            lbl_bill4.Text = " ";
            lbl_bill5.Text = " ";
            lbl_bill6.Text = " ";

            lbl_quan1.Text = " ";

            lbl_price1.Text = " ";

            lbl_unit.Text = " ";

            lbl_qunget1.Text = " ";

            lbl_qunset1.Text = " ";
            lbl_qunset2.Text = " ";
            lbl_qunset3.Text = " ";
            lbl_qunset4.Text = " ";
            lbl_qunset5.Text = " ";
            lbl_qunset6.Text = " ";

            lbl_data.Text = " ";

            lbl_price2.Text = 0.ToString();
            lbl_price3.Text = 0.ToString();
            lbl_price4.Text = 0.ToString();
            lbl_price5.Text = 0.ToString();
            lbl_price6.Text = 0.ToString();

            lbl_quan2.Text = 0.ToString();
            lbl_quan3.Text = 0.ToString();
            lbl_quan4.Text = 0.ToString();
            lbl_quan5.Text = 0.ToString();
            lbl_quan6.Text = 0.ToString();

            lbl_price2.Visible = false;
            lbl_price3.Visible = false;
            lbl_price4.Visible = false;
            lbl_price5.Visible = false;
            lbl_price6.Visible = false;

            lbl_quan2.Visible = false;
            lbl_quan3.Visible = false;
            lbl_quan4.Visible = false;
            lbl_quan5.Visible = false;
            lbl_quan6.Visible = false;



        }

        private void btn_suadd1_Click(object sender, EventArgs e)
        {
            lbl_bill2.Text = su_itemlable1.Text;
            lbl_price2.Text = su_pricelable1.Text;
            lbl_quan2.Text = Convert.ToString(1);
            lbl_price2.Visible = true;
            lbl_quan2.Visible = true;
            lbl_bill2.Visible = true;

        }

        private void btn_suadd2_Click(object sender, EventArgs e)
        {
            lbl_bill3.Text = su_itemlable2.Text;
            lbl_price3.Text = su_pricelable2.Text;
            lbl_quan3.Text = Convert.ToString(1);
            lbl_price3.Visible = true;
            lbl_quan3.Visible = true;
            lbl_bill3.Visible = true;

        }

        private void btn_suadd3_Click(object sender, EventArgs e)
        {
            lbl_bill4.Text = su_itemlable3.Text;
            lbl_price4.Text = su_pricelable3.Text;
            lbl_quan4.Text = Convert.ToString(1);
            lbl_price4.Visible = true;
            lbl_quan4.Visible = true;
            lbl_bill4.Visible = true;

        }

        private void btn_suadd4_Click(object sender, EventArgs e)
        {
            lbl_bill5.Text = su_itemlable4.Text;
            lbl_price5.Text = su_pricelable4.Text;
            lbl_quan5.Text = Convert.ToString(1);
            lbl_price5.Visible = true;
            lbl_quan5.Visible = true;
            lbl_bill5.Visible = true;

        }

        private void btn_suadd5_Click(object sender, EventArgs e)
        {
            lbl_bill6.Text = su_itemlable5.Text;
            lbl_price6.Text = su_pricelable5.Text;
            lbl_quan6.Text = Convert.ToString(1);
            lbl_price6.Visible = true;
            lbl_quan6.Visible = true;
            lbl_bill6.Visible = true;

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            
            int p1 = Convert.ToInt16(lbl_price1.Text);
            int p2 = Convert.ToInt16(lbl_price2.Text);
            int p3 = Convert.ToInt16(lbl_price3.Text);
            int p4 = Convert.ToInt16(lbl_price4.Text);
            int p5 = Convert.ToInt16(lbl_price5.Text);
            int p6 = Convert.ToInt16(lbl_price6.Text);
            int q1 = Convert.ToInt16(lbl_quan1.Text);
            int q2 = Convert.ToInt16(lbl_quan2.Text);
            int q3 = Convert.ToInt16(lbl_quan3.Text);
            int q4 = Convert.ToInt16(lbl_quan4.Text);
            int q5 = Convert.ToInt16(lbl_quan5.Text);
            int q6 = Convert.ToInt16(lbl_quan6.Text);
            int rs = (p1 * q1) + (p2 * q2) + (p3 * q3) + (p4 * q4) + (p5 * q5) + (p6 * q6);
            double dis = rs * 0.05;
            double tot = rs - dis;
            lbl_dis.Text = Convert.ToString(dis);
            lbl_tot.Text = Convert.ToString(tot);
            lbl_quan1.Text =q1.ToString();

            con.Open();
            SqlDataReader ab1;
            cmd2 = new SqlCommand("SELECT Product_queantity FROM Product WHERE Product_Name ='"+lbl_bill1.Text+"'", con);
            cmd2.Parameters.AddWithValue("Product_Name", lbl_bill1.Text);

            ab1 = cmd2.ExecuteReader();
            if (ab1.Read())
            {
                lbl_qunget1.Text = ab1["Product_queantity"].ToString();
                
            }
            con.Close();

            con.Open();
            SqlDataReader ab2;
            cmd2 = new SqlCommand("SELECT Product_queantity FROM Product WHERE Product_Name ='" + lbl_bill2.Text + "'", con);
            cmd2.Parameters.AddWithValue("Product_Name", lbl_bill2.Text);

            ab2 = cmd2.ExecuteReader();
            if (ab2.Read())
            {
                lbl_qunget2.Text = ab2["Product_queantity"].ToString();

            }
            con.Close();

            con.Open();
            SqlDataReader ab3;
            cmd2 = new SqlCommand("SELECT Product_queantity FROM Product WHERE Product_Name ='" + lbl_bill3.Text + "'", con);
            cmd2.Parameters.AddWithValue("Product_Name", lbl_bill3.Text);

            ab3 = cmd2.ExecuteReader();
            if (ab3.Read())
            {
                lbl_qunget3.Text = ab3["Product_queantity"].ToString();

            }
            con.Close();

            con.Open();
            SqlDataReader ab4;
            cmd2 = new SqlCommand("SELECT Product_queantity FROM Product WHERE Product_Name ='" + lbl_bill4.Text + "'", con);
            cmd2.Parameters.AddWithValue("Product_Name", lbl_bill4.Text);

            ab4 = cmd2.ExecuteReader();
            if (ab4.Read())
            {
                lbl_qunget4.Text = ab4["Product_queantity"].ToString();

            }
            con.Close();

            con.Open();
            SqlDataReader ab5;
            cmd2 = new SqlCommand("SELECT Product_queantity FROM Product WHERE Product_Name ='" + lbl_bill5.Text + "'", con);
            cmd2.Parameters.AddWithValue("Product_Name", lbl_bill5.Text);

            ab5 = cmd2.ExecuteReader();
            if (ab5.Read())
            {
                lbl_qunget5.Text = ab5["Product_queantity"].ToString();

            }
            con.Close();

            con.Open();
            SqlDataReader ab6;
            cmd2 = new SqlCommand("SELECT Product_queantity FROM Product WHERE Product_Name ='" + lbl_bill6.Text + "'", con);
            cmd2.Parameters.AddWithValue("Product_Name", lbl_bill6.Text);

            ab6 = cmd2.ExecuteReader();
            if (ab6.Read())
            {
                lbl_qunget6.Text = ab6["Product_queantity"].ToString();

            }
            con.Close();

            int ac1 = Convert.ToInt16(lbl_qunget1.Text) - Convert.ToInt16(lbl_quan1.Text);
            lbl_qunset1.Text = ac1.ToString();
            int ac2 = Convert.ToInt16(lbl_qunget2.Text) - 1;
            lbl_qunset2.Text = ac2.ToString();
            int ac3 = Convert.ToInt16(lbl_qunget3.Text) - 1;
            lbl_qunset3.Text = ac3.ToString();
            int ac4 = Convert.ToInt16(lbl_qunget4.Text) - 1;
            lbl_qunset4.Text = ac4.ToString();
            int ac5 = Convert.ToInt16(lbl_qunget5.Text) - 1;
            lbl_qunset5.Text = ac5.ToString();
            int ac6 = Convert.ToInt16(lbl_qunget6.Text) - 1;
            lbl_qunset6.Text = ac6.ToString();

            con.Open();
            cmd2 = new SqlCommand("UPDATE Product SET Product_queantity = '"+lbl_qunset1.Text+"' WHERE Product_Name = '"+lbl_bill1.Text+"'",con);
            cmd2.ExecuteNonQuery();
            con.Close();

            con.Open();
            cmd2 = new SqlCommand("UPDATE Product SET Product_queantity = '" + lbl_qunset2.Text + "' WHERE Product_Name = '" + lbl_bill2.Text + "'", con);
            cmd2.ExecuteNonQuery();
            con.Close();

            con.Open();
            cmd2 = new SqlCommand("UPDATE Product SET Product_queantity = '" + lbl_qunset3.Text + "' WHERE Product_Name = '" + lbl_bill3.Text + "'", con);
            cmd2.ExecuteNonQuery();
            con.Close();

            con.Open();
            cmd2 = new SqlCommand("UPDATE Product SET Product_queantity = '" + lbl_qunset4.Text + "' WHERE Product_Name = '" + lbl_bill4.Text + "'", con);
            cmd2.ExecuteNonQuery();
            con.Close();

            con.Open();
            cmd2 = new SqlCommand("UPDATE Product SET Product_queantity = '" + lbl_qunset5.Text + "' WHERE Product_Name = '" + lbl_bill5.Text + "'", con);
            cmd2.ExecuteNonQuery();
            con.Close();

            con.Open();
            cmd2 = new SqlCommand("UPDATE Product SET Product_queantity = '" + lbl_qunset6.Text + "' WHERE Product_Name = '" + lbl_bill6.Text + "'", con);
            cmd2.ExecuteNonQuery();
            con.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
