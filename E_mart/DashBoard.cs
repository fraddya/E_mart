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

        Customer_Check obj1 = new Customer_Check();

        Fordashboard obj2 = new Fordashboard();
            
      
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BillScroBar_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            try
            {
                //con = new SqlConnection("Data Source=LAPTOP-FK0M22U2;Initial Catalog=e_martlocalhost;Integrated Security=True");//Nadya
                con = new SqlConnection("Data Source=VIVOBOOK;Initial Catalog=e_martlocalhost;Integrated Security=True");//Fraddya

                if (txt_pid.Text.Length == 0 || txt_pid.Text.Any(char.IsLetter))
                {
                    lbl_1.Text = "Cannot be null or Cannot be Enter Letter";
                }
                else if (txt_qun.Text.Length == 0 || txt_qun.Text.Any(char.IsLetterOrDigit))
                {

                    lbl_3.Text = "Cannot be null or Cannot be Enter letter";
                }
                if (txt_pid.Text.Any(char.IsDigit))
                {
                   
                   

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
                        txt_pname.Text = rj["Product_Name"].ToString();
                        lbl_get.Text = rj["Product_category"].ToString();
                        lbl_unit.Text = rj["category_unit_no"].ToString();
                        if (txt_qun.Text != "")
                        {


                            if (Convert.ToInt32(s) < Convert.ToInt32(g))
                            {
                                if (Convert.ToInt16(s) > 0)
                                {
                                    if (lbl_bill1.Text == "")
                                    {
                                        lbl_quan1.Text = s;
                                        lbl_quan1.Visible = true;
                                        lbl_bill1.Text = txt_pname.Text;
                                        lbl_price1.Text = rj["Product_Price"].ToString();
                                        lbl_price1.Visible = true;
                                        int c = Convert.ToInt16(lbl_quan1.Text) * Convert.ToInt16(lbl_price1.Text);
                                        lbl_tot.Text = (c).ToString();
                                        lbl_gettot.Text = lbl_tot.Text;
                                    }
                                    else if (lbl_bill2.Text == "")
                                    {
                                        lbl_quan2.Text = s;
                                        lbl_quan2.Visible = true;
                                        lbl_bill2.Text = txt_pname.Text;
                                        lbl_price2.Text = rj["Product_Price"].ToString();
                                        lbl_price2.Visible = true;
                                        int a = Convert.ToInt16(lbl_gettot.Text);
                                        int c = Convert.ToInt16(lbl_quan2.Text) * Convert.ToInt16(lbl_price2.Text);
                                        lbl_tot.Text = (a + c).ToString();
                                        lbl_gettot.Text = lbl_tot.Text;
                                    }
                                    else if (lbl_bill3.Text == "")
                                    {
                                        lbl_quan3.Text = s;
                                        lbl_quan3.Visible = true;
                                        lbl_bill3.Text = txt_pname.Text;
                                        lbl_price3.Text = rj["Product_Price"].ToString();
                                        lbl_price3.Visible = true;
                                        int a = Convert.ToInt16(lbl_gettot.Text);
                                        int c = Convert.ToInt16(lbl_quan3.Text) * Convert.ToInt16(lbl_price3.Text);
                                        lbl_tot.Text = (a + c).ToString();
                                        lbl_gettot.Text = lbl_tot.Text;
                                    }
                                    else if (lbl_bill4.Text == "")
                                    {
                                        lbl_quan4.Text = s;
                                        lbl_quan4.Visible = true;
                                        lbl_bill4.Text = txt_pname.Text;
                                        lbl_price4.Text = rj["Product_Price"].ToString();
                                        lbl_price4.Visible = true;
                                        int a = Convert.ToInt16(lbl_gettot.Text);
                                        int c = Convert.ToInt16(lbl_quan4.Text) * Convert.ToInt16(lbl_price4.Text);
                                        lbl_tot.Text = (a + c).ToString();
                                        lbl_gettot.Text = lbl_tot.Text;
                                    }
                                    else if (lbl_bill5.Text == "")
                                    {
                                        lbl_quan5.Text = s;
                                        lbl_quan5.Visible = true;
                                        lbl_bill5.Text = txt_pname.Text;
                                        lbl_price5.Text = rj["Product_Price"].ToString();
                                        lbl_price5.Visible = true;

                                    }
                                    else if (lbl_bill6.Text == "")
                                    {
                                        lbl_quan6.Text = s;
                                        lbl_quan6.Visible = true;
                                        lbl_bill6.Text = txt_pname.Text;
                                        lbl_price6.Text = rj["Product_Price"].ToString();
                                        lbl_price6.Visible = true;
                                        int a = Convert.ToInt16(lbl_gettot.Text);
                                        int c = Convert.ToInt16(lbl_quan6.Text) * Convert.ToInt16(lbl_price6.Text);
                                        lbl_tot.Text = (a + c).ToString();
                                        lbl_gettot.Text = lbl_tot.Text;
                                    }
                                    else
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Bill is Full", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MetroFramework.MetroMessageBox.Show(this,"value cannot be minus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                            else
                            {
                                lbl_bill1.Text = " ";
                                lbl_price1.Text = " ";
                                txt_qun.Clear();
                                MetroFramework.MetroMessageBox.Show(this,"Not enough product ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this,"No Data Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                        lbl_3.Text = "";
                    }



                    if (txt_pid.Text != "" && txt_qun.Text != "")
                    {
                        panel3.Visible = true;
                        lbl_1.Visible = false;

                        if (Convert.ToInt32(lbl_unit.Text) == 1)
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_1.Image = Properties.Resources.Mango;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_1.Image = Properties.Resources.fish2;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_1.Image = Properties.Resources.Pumpkin;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_1.Image = Properties.Resources.Vitaminc;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_1.Image = Properties.Resources.Beef;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_1.Image = Properties.Resources.Yogurt;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_2.Image = Properties.Resources.Banana;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_2.Image = Properties.Resources.Tuna;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_2.Image = Properties.Resources.Carrot;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_2.Image = Properties.Resources.Piriton;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_2.Image = Properties.Resources.Pork;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_2.Image = Properties.Resources.fresh_milk;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_3.Image = Properties.Resources.Pineapple;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_3.Image = Properties.Resources.fish3;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_3.Image = Properties.Resources.Leeks;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_3.Image = Properties.Resources.Zerizine;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_3.Image = Properties.Resources.Sausage;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_3.Image = Properties.Resources.Cheese;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_4.Image = Properties.Resources.Orange;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_4.Image = Properties.Resources.fish4;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_4.Image = Properties.Resources.Tomato;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_4.Image = Properties.Resources.Parasitamol;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_4.Image = Properties.Resources.Egg;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_4.Image = Properties.Resources.Butter;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_5.Image = Properties.Resources.Watermelon;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_5.Image = Properties.Resources.fish5;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_5.Image = Properties.Resources.Potato;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_5.Image = Properties.Resources.Vitamin;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_5.Image = Properties.Resources.Mutton;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_5.Image = Properties.Resources.Faluda;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_1.Image = Properties.Resources.Apple;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_1.Image = Properties.Resources.fish6;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_1.Image = Properties.Resources.Bean;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_1.Image = Properties.Resources.Panadol;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_1.Image = Properties.Resources.Chicken;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_1.Image = Properties.Resources.Icecream;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_2.Image = Properties.Resources.Banana;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_2.Image = Properties.Resources.Tuna;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_2.Image = Properties.Resources.Carrot;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_2.Image = Properties.Resources.Piriton;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_2.Image = Properties.Resources.Pork;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_2.Image = Properties.Resources.fresh_milk;
                                }

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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_3.Image = Properties.Resources.Pineapple;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_3.Image = Properties.Resources.fish3;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_3.Image = Properties.Resources.Leeks;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_3.Image = Properties.Resources.Zerizine;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_3.Image = Properties.Resources.Sausage;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_3.Image = Properties.Resources.Cheese;
                                }

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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_4.Image = Properties.Resources.Orange;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_4.Image = Properties.Resources.fish4;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_4.Image = Properties.Resources.Tomato;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_4.Image = Properties.Resources.Parasitamol;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_4.Image = Properties.Resources.Egg;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_4.Image = Properties.Resources.Butter;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_5.Image = Properties.Resources.Watermelon;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_5.Image = Properties.Resources.fish5;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_5.Image = Properties.Resources.Potato;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_5.Image = Properties.Resources.Vitamin;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_5.Image = Properties.Resources.Mutton;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_5.Image = Properties.Resources.Faluda;
                                }

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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_1.Image = Properties.Resources.Mango;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_1.Image = Properties.Resources.fish2;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_1.Image = Properties.Resources.Pumpkin;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_1.Image = Properties.Resources.Vitaminc;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_1.Image = Properties.Resources.Beef;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_1.Image = Properties.Resources.Yogurt;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_2.Image = Properties.Resources.Apple;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_2.Image = Properties.Resources.fish6;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_2.Image = Properties.Resources.Bean;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_2.Image = Properties.Resources.Panadol;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_2.Image = Properties.Resources.Chicken;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_2.Image = Properties.Resources.Icecream;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_3.Image = Properties.Resources.Pineapple;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_3.Image = Properties.Resources.fish3;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_3.Image = Properties.Resources.Leeks;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_3.Image = Properties.Resources.Zerizine;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_3.Image = Properties.Resources.Sausage;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_3.Image = Properties.Resources.Cheese;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_4.Image = Properties.Resources.Orange;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_4.Image = Properties.Resources.fish4;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_4.Image = Properties.Resources.Tomato;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_4.Image = Properties.Resources.Parasitamol;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_4.Image = Properties.Resources.Egg;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_4.Image = Properties.Resources.Butter;
                                }

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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_5.Image = Properties.Resources.Watermelon;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_5.Image = Properties.Resources.fish5;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_5.Image = Properties.Resources.Potato;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_5.Image = Properties.Resources.Vitamin;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_5.Image = Properties.Resources.Mutton;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_5.Image = Properties.Resources.Faluda;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_1.Image = Properties.Resources.Mango;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_1.Image = Properties.Resources.fish2;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_1.Image = Properties.Resources.Pumpkin;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_1.Image = Properties.Resources.Vitaminc;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_1.Image = Properties.Resources.Beef;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_1.Image = Properties.Resources.Yogurt;
                                }

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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_2.Image = Properties.Resources.Banana;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_2.Image = Properties.Resources.Tuna;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_2.Image = Properties.Resources.Carrot;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_2.Image = Properties.Resources.Piriton;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_2.Image = Properties.Resources.Pork;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_2.Image = Properties.Resources.fresh_milk;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_3.Image = Properties.Resources.Apple;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_3.Image = Properties.Resources.fish6;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_3.Image = Properties.Resources.Bean;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_3.Image = Properties.Resources.Panadol;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_3.Image = Properties.Resources.Chicken;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_3.Image = Properties.Resources.Icecream;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_4.Image = Properties.Resources.Orange;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_4.Image = Properties.Resources.fish4;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_4.Image = Properties.Resources.Tomato;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_4.Image = Properties.Resources.Parasitamol;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_4.Image = Properties.Resources.Egg;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_4.Image = Properties.Resources.Butter;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_5.Image = Properties.Resources.Watermelon;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_5.Image = Properties.Resources.fish5;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_5.Image = Properties.Resources.Potato;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_5.Image = Properties.Resources.Vitamin;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_5.Image = Properties.Resources.Mutton;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_5.Image = Properties.Resources.Faluda;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_1.Image = Properties.Resources.Mango;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_1.Image = Properties.Resources.fish2;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_1.Image = Properties.Resources.Pumpkin;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_1.Image = Properties.Resources.Vitaminc;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_1.Image = Properties.Resources.Beef;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_1.Image = Properties.Resources.Yogurt;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_2.Image = Properties.Resources.Banana;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_2.Image = Properties.Resources.Tuna;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_2.Image = Properties.Resources.Carrot;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_2.Image = Properties.Resources.Piriton;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_2.Image = Properties.Resources.Pork;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_2.Image = Properties.Resources.fresh_milk;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_3.Image = Properties.Resources.Pineapple;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_3.Image = Properties.Resources.fish3;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_3.Image = Properties.Resources.Leeks;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_3.Image = Properties.Resources.Zerizine;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_3.Image = Properties.Resources.Sausage;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_3.Image = Properties.Resources.Cheese;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_4.Image = Properties.Resources.Apple;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_4.Image = Properties.Resources.fish6;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_4.Image = Properties.Resources.Bean;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_4.Image = Properties.Resources.Panadol;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_4.Image = Properties.Resources.Chicken;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_4.Image = Properties.Resources.Icecream;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_5.Image = Properties.Resources.Watermelon;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_5.Image = Properties.Resources.fish5;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_5.Image = Properties.Resources.Potato;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_5.Image = Properties.Resources.Vitamin;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_5.Image = Properties.Resources.Mutton;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_5.Image = Properties.Resources.Faluda;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_1.Image = Properties.Resources.Mango;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_1.Image = Properties.Resources.fish2;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_1.Image = Properties.Resources.Pumpkin;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_1.Image = Properties.Resources.Vitaminc;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_1.Image = Properties.Resources.Beef;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_1.Image = Properties.Resources.Yogurt;
                                }

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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_2.Image = Properties.Resources.Banana;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_2.Image = Properties.Resources.Tuna;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_2.Image = Properties.Resources.Carrot;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_2.Image = Properties.Resources.Piriton;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_2.Image = Properties.Resources.Pork;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_2.Image = Properties.Resources.fresh_milk;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_3.Image = Properties.Resources.Pineapple;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_3.Image = Properties.Resources.fish3;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_3.Image = Properties.Resources.Leeks;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_3.Image = Properties.Resources.Zerizine;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_3.Image = Properties.Resources.Sausage;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_3.Image = Properties.Resources.Cheese;
                                }
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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_4.Image = Properties.Resources.Orange;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_4.Image = Properties.Resources.fish4;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_4.Image = Properties.Resources.Tomato;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_4.Image = Properties.Resources.Parasitamol;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_4.Image = Properties.Resources.Egg;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_4.Image = Properties.Resources.Butter;
                                }

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
                                if (lbl_get.Text == "Fruit")
                                {
                                    this.img_5.Image = Properties.Resources.Apple;

                                }
                                else if (lbl_get.Text == "Fish")
                                {
                                    this.img_5.Image = Properties.Resources.fish6;
                                }
                                else if (lbl_get.Text == "Vegetable")
                                {
                                    this.img_5.Image = Properties.Resources.Bean;
                                }
                                else if (lbl_get.Text == "Medicine")
                                {
                                    this.img_5.Image = Properties.Resources.Panadol;
                                }
                                else if (lbl_get.Text == "Meat")
                                {
                                    this.img_5.Image = Properties.Resources.Chicken;
                                }
                                else if (lbl_get.Text == "DiaryFood")
                                {
                                    this.img_5.Image = Properties.Resources.Icecream;
                                }
                            }
                            con.Close();

                        }
                    }
                }
            }
            catch(NullReferenceException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot be null", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Enter numbers only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot divide by ZERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int a;
                a = 1 + Convert.ToInt32(txt_qun.Text);
                txt_qun.Text = Convert.ToString(a);
            }
            catch (NullReferenceException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot be null", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Enter numbers only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot divide by ZERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            try
            {
                int a;
                a = Convert.ToInt32(txt_qun.Text) - 1;
                if (a >= 0)
                {
                    txt_qun.Text = Convert.ToString(a);
                }
                else if (a < 0)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Invalid Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot be null", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Enter numbers only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot divide by ZERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

            
            lbl_gettot.Visible = false;//total bill bucket
            lbl_get.Visible = false;//get category from table
            lbl_qunget1.Visible = false;//update for get quantity from table
            lbl_qunget2.Visible = false;
            lbl_qunget3.Visible = false;
            lbl_qunget4.Visible = false;
            lbl_qunget5.Visible = false;
            lbl_qunget6.Visible = false;
            lbl_qunset1.Visible = false;//insert new value to table
            lbl_qunset2.Visible = false;
            lbl_qunset3.Visible = false;
            lbl_qunset4.Visible = false;
            lbl_qunset5.Visible = false;
            lbl_qunset6.Visible = false;
            lbl_unit.Visible = false;//get unit number from table
            lbl_data.Visible = false;//get first label quantity from table
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
            panel3.Visible = false;
            lbl_cid.Visible = false;//customer id
            lbl_cid1.Visible = false;//total
            lbl_date.Visible = false;//date
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            
            txt_pid.Clear();
            txt_pname.Clear();
            txt_qun.Clear();
            
            lbl_1.Text = " ";
            lbl_2.Text = " ";
            lbl_3.Text = " ";
        }

        private void btn_suadd1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbl_bill2.Text == "")
                {
                    lbl_bill2.Text = su_itemlable1.Text;
                    lbl_price2.Text = su_pricelable1.Text;
                    lbl_quan2.Text = Convert.ToString(1);
                    lbl_price2.Visible = true;
                    lbl_quan2.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan2.Text) * Convert.ToInt16(lbl_price2.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill3.Text == "")
                {
                    lbl_bill3.Text = su_itemlable1.Text;
                    lbl_price3.Text = su_pricelable1.Text;
                    lbl_quan3.Text = Convert.ToString(1);
                    lbl_price3.Visible = true;
                    lbl_quan3.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan3.Text) * Convert.ToInt16(lbl_price3.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill4.Text == "")
                {
                    lbl_bill4.Text = su_itemlable1.Text;
                    lbl_price4.Text = su_pricelable1.Text;
                    lbl_quan4.Text = Convert.ToString(1);
                    lbl_price4.Visible = true;
                    lbl_quan4.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan4.Text) * Convert.ToInt16(lbl_price4.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill5.Text == "")
                {
                    lbl_bill5.Text = su_itemlable1.Text;
                    lbl_price5.Text = su_pricelable1.Text;
                    lbl_quan5.Text = Convert.ToString(1);
                    lbl_price5.Visible = true;
                    lbl_quan5.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan5.Text) * Convert.ToInt16(lbl_price5.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill6.Text == "")
                {
                    lbl_bill6.Text = su_itemlable1.Text;
                    lbl_price6.Text = su_pricelable1.Text;
                    lbl_quan6.Text = Convert.ToString(1);
                    lbl_price6.Visible = true;
                    lbl_quan6.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan6.Text) * Convert.ToInt16(lbl_price6.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Bill is full now ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NullReferenceException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot be null", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Enter numbers only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot divide by ZERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btn_suadd2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbl_bill2.Text == "")
                {
                    lbl_bill2.Text = su_itemlable2.Text;
                    lbl_price2.Text = su_pricelable2.Text;
                    lbl_quan2.Text = Convert.ToString(1);
                    lbl_price2.Visible = true;
                    lbl_quan2.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan2.Text) * Convert.ToInt16(lbl_price2.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill3.Text == "")
                {
                    lbl_bill3.Text = su_itemlable2.Text;
                    lbl_price3.Text = su_pricelable2.Text;
                    lbl_quan3.Text = Convert.ToString(1);
                    lbl_price3.Visible = true;
                    lbl_quan3.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan3.Text) * Convert.ToInt16(lbl_price3.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill4.Text == "")
                {
                    lbl_bill4.Text = su_itemlable2.Text;
                    lbl_price4.Text = su_pricelable2.Text;
                    lbl_quan4.Text = Convert.ToString(1);
                    lbl_price4.Visible = true;
                    lbl_quan4.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan4.Text) * Convert.ToInt16(lbl_price4.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill5.Text == "")
                {
                    lbl_bill5.Text = su_itemlable2.Text;
                    lbl_price5.Text = su_pricelable2.Text;
                    lbl_quan5.Text = Convert.ToString(1);
                    lbl_price5.Visible = true;
                    lbl_quan5.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan5.Text) * Convert.ToInt16(lbl_price5.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill6.Text == "")
                {
                    lbl_bill6.Text = su_itemlable2.Text;
                    lbl_price6.Text = su_pricelable2.Text;
                    lbl_quan6.Text = Convert.ToString(1);
                    lbl_price6.Visible = true;
                    lbl_quan6.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan6.Text) * Convert.ToInt16(lbl_price6.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Bill is full now ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NullReferenceException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot be null", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Enter numbers only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot divide by ZERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_suadd3_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbl_bill2.Text == "")
                {
                    lbl_bill2.Text = su_itemlable3.Text;
                    lbl_price2.Text = su_pricelable3.Text;
                    lbl_quan2.Text = Convert.ToString(1);
                    lbl_price2.Visible = true;
                    lbl_quan2.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan2.Text) * Convert.ToInt16(lbl_price2.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill3.Text == "")
                {
                    lbl_bill3.Text = su_itemlable3.Text;
                    lbl_price3.Text = su_pricelable3.Text;
                    lbl_quan3.Text = Convert.ToString(1);
                    lbl_price3.Visible = true;
                    lbl_quan3.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan3.Text) * Convert.ToInt16(lbl_price3.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill4.Text == "")
                {
                    lbl_bill4.Text = su_itemlable3.Text;
                    lbl_price4.Text = su_pricelable3.Text;
                    lbl_quan4.Text = Convert.ToString(1);
                    lbl_price4.Visible = true;
                    lbl_quan4.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan4.Text) * Convert.ToInt16(lbl_price4.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill5.Text == "")
                {
                    lbl_bill5.Text = su_itemlable3.Text;
                    lbl_price5.Text = su_pricelable3.Text;
                    lbl_quan5.Text = Convert.ToString(1);
                    lbl_price5.Visible = true;
                    lbl_quan5.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan5.Text) * Convert.ToInt16(lbl_price5.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill6.Text == "")
                {
                    lbl_bill6.Text = su_itemlable3.Text;
                    lbl_price6.Text = su_pricelable3.Text;
                    lbl_quan6.Text = Convert.ToString(1);
                    lbl_price6.Visible = true;
                    lbl_quan6.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan6.Text) * Convert.ToInt16(lbl_price6.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Bill is full now ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NullReferenceException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot be null", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Enter numbers only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot divide by ZERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_suadd4_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbl_bill2.Text == "")
                {
                    lbl_bill2.Text = su_itemlable4.Text;
                    lbl_price2.Text = su_pricelable4.Text;
                    lbl_quan2.Text = Convert.ToString(1);
                    lbl_price2.Visible = true;
                    lbl_quan2.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan4.Text) * Convert.ToInt16(lbl_price4.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill3.Text == "")
                {
                    lbl_bill3.Text = su_itemlable4.Text;
                    lbl_price3.Text = su_pricelable4.Text;
                    lbl_quan3.Text = Convert.ToString(1);
                    lbl_price3.Visible = true;
                    lbl_quan3.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan3.Text) * Convert.ToInt16(lbl_price3.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill4.Text == "")
                {
                    lbl_bill4.Text = su_itemlable4.Text;
                    lbl_price4.Text = su_pricelable4.Text;
                    lbl_quan4.Text = Convert.ToString(1);
                    lbl_price4.Visible = true;
                    lbl_quan4.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan4.Text) * Convert.ToInt16(lbl_price4.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill5.Text == "")
                {
                    lbl_bill5.Text = su_itemlable4.Text;
                    lbl_price5.Text = su_pricelable4.Text;
                    lbl_quan5.Text = Convert.ToString(1);
                    lbl_price5.Visible = true;
                    lbl_quan5.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan5.Text) * Convert.ToInt16(lbl_price5.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill6.Text == "")
                {
                    lbl_bill6.Text = su_itemlable4.Text;
                    lbl_price6.Text = su_pricelable4.Text;
                    lbl_quan6.Text = Convert.ToString(1);
                    lbl_price6.Visible = true;
                    lbl_quan6.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan6.Text) * Convert.ToInt16(lbl_price6.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Bill is full now ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NullReferenceException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot be null", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Enter numbers only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Cannot divide by ZERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_suadd5_Click(object sender, EventArgs e)
        {
           try
           {
                if (lbl_bill2.Text == "")
                {
                    lbl_bill2.Text = su_itemlable5.Text;
                    lbl_price2.Text = su_pricelable5.Text;
                    lbl_quan2.Text = Convert.ToString(1);
                    lbl_price2.Visible = true;
                    lbl_quan2.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan5.Text) * Convert.ToInt16(lbl_price5.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill3.Text == "")
                {
                    lbl_bill3.Text = su_itemlable5.Text;
                    lbl_price3.Text = su_pricelable5.Text;
                    lbl_quan3.Text = Convert.ToString(1);
                    lbl_price3.Visible = true;
                    lbl_quan3.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan3.Text) * Convert.ToInt16(lbl_price3.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill4.Text == "")
                {
                    lbl_bill4.Text = su_itemlable5.Text;
                    lbl_price4.Text = su_pricelable5.Text;
                    lbl_quan4.Text = Convert.ToString(1);
                    lbl_price4.Visible = true;
                    lbl_quan4.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan4.Text) * Convert.ToInt16(lbl_price4.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill5.Text == "")
                {
                    lbl_bill5.Text = su_itemlable5.Text;
                    lbl_price5.Text = su_pricelable5.Text;
                    lbl_quan5.Text = Convert.ToString(1);
                    lbl_price5.Visible = true;
                    lbl_quan5.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan5.Text) * Convert.ToInt16(lbl_price5.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else if (lbl_bill6.Text == "")
                {
                    lbl_bill6.Text = su_itemlable5.Text;
                    lbl_price6.Text = su_pricelable5.Text;
                    lbl_quan6.Text = Convert.ToString(1);
                    lbl_price6.Visible = true;
                    lbl_quan6.Visible = true;
                    int a = Convert.ToInt16(lbl_gettot.Text);
                    int c = Convert.ToInt16(lbl_quan6.Text) * Convert.ToInt16(lbl_price6.Text);
                    lbl_tot.Text = (a + c).ToString();
                    lbl_gettot.Text = lbl_tot.Text;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Bill is full", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           }
           catch (NullReferenceException)
           {
                MetroFramework.MetroMessageBox.Show(this,"Cannot be null", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           catch (FormatException)
           {
                MetroFramework.MetroMessageBox.Show(this,"Enter numbers only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           catch (DivideByZeroException)
           {
                MetroFramework.MetroMessageBox.Show(this,"Cannot divide by ZERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

           }
           catch (Exception)
           {
                MetroFramework.MetroMessageBox.Show(this,"Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }


        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
           try
           {
                con.Open();
                SqlDataReader ab6;
                cmd2 = new SqlCommand("SELECT Product_queantity FROM Product WHERE Product_Name ='" + lbl_bill1.Text + "'", con);
                cmd2.Parameters.AddWithValue("Product_Name", lbl_bill1.Text);

                ab6 = cmd2.ExecuteReader();
                if (ab6.Read())
                {
                    lbl_qunget1.Text = ab6["Product_queantity"].ToString();

                }
                con.Close();

                con.Open();
                SqlDataReader ab7;
                cmd2 = new SqlCommand("SELECT Product_queantity FROM Product WHERE Product_Name ='" + lbl_bill2.Text + "'", con);
                cmd2.Parameters.AddWithValue("Product_Name", lbl_bill2.Text);

                ab7 = cmd2.ExecuteReader();
                if (ab7.Read())
                {
                    lbl_qunget2.Text = ab7["Product_queantity"].ToString();

                }
                con.Close();

                con.Open();
                SqlDataReader ab8;
                cmd2 = new SqlCommand("SELECT Product_queantity FROM Product WHERE Product_Name ='" + lbl_bill3.Text + "'", con);
                cmd2.Parameters.AddWithValue("Product_Name", lbl_bill3.Text);

                ab8 = cmd2.ExecuteReader();
                if (ab8.Read())
                {
                    lbl_qunget3.Text = ab8["Product_queantity"].ToString();

                }
                con.Close();

                con.Open();
                SqlDataReader ab9;
                cmd2 = new SqlCommand("SELECT Product_queantity FROM Product WHERE Product_Name ='" + lbl_bill4.Text + "'", con);
                cmd2.Parameters.AddWithValue("Product_Name", lbl_bill4.Text);

                ab9 = cmd2.ExecuteReader();
                if (ab9.Read())
                {
                    lbl_qunget4.Text = ab9["Product_queantity"].ToString();

                }
                con.Close();

                con.Open();
                SqlDataReader ab10;
                cmd2 = new SqlCommand("SELECT Product_queantity FROM Product WHERE Product_Name ='" + lbl_bill5.Text + "'", con);
                cmd2.Parameters.AddWithValue("Product_Name", lbl_bill5.Text);

                ab10 = cmd2.ExecuteReader();
                if (ab10.Read())
                {
                    lbl_qunget5.Text = ab10["Product_queantity"].ToString();

                }
                con.Close();

                con.Open();
                SqlDataReader ab11;
                cmd2 = new SqlCommand("SELECT Product_queantity FROM Product WHERE Product_Name ='" + lbl_bill6.Text + "'", con);
                cmd2.Parameters.AddWithValue("Product_Name", lbl_bill6.Text);

                ab11 = cmd2.ExecuteReader();
                if (ab11.Read())
                {
                    lbl_qunget6.Text = ab11["Product_queantity"].ToString();

                }
                con.Close();

                int ac1 = Convert.ToInt16(lbl_qunget1.Text) - Convert.ToInt16(lbl_quan1.Text);
                lbl_qunset1.Text = ac1.ToString();
                int ac2 = Convert.ToInt16(lbl_qunget2.Text) - Convert.ToInt16(lbl_quan2.Text); ;
                lbl_qunset2.Text = ac2.ToString();
                int ac3 = Convert.ToInt16(lbl_qunget3.Text) - Convert.ToInt16(lbl_quan3.Text); ;
                lbl_qunset3.Text = ac3.ToString();
                int ac4 = Convert.ToInt16(lbl_qunget4.Text) - Convert.ToInt16(lbl_quan4.Text); ;
                lbl_qunset4.Text = ac4.ToString();
                int ac5 = Convert.ToInt16(lbl_qunget5.Text) - Convert.ToInt16(lbl_quan5.Text); ;
                lbl_qunset5.Text = ac5.ToString();
                int ac6 = Convert.ToInt16(lbl_qunget6.Text) - Convert.ToInt16(lbl_quan6.Text); ;
                lbl_qunset6.Text = ac6.ToString();

                con.Open();
                cmd2 = new SqlCommand("UPDATE Product SET Product_queantity = '" + lbl_qunset1.Text + "' WHERE Product_Name = '" + lbl_bill1.Text + "'", con);
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

                lbl_cid.Text = Fordashboard.value;
                lbl_cid1.Text= Fordashboard.value1;
                
                if(lbl_cid1.Text != "")
                {
                    int tot = Convert.ToInt32(lbl_tot.Text);
                    int dis = tot * 20 / 100;
                    int ftot = tot - dis;
                    lbl_tot.Text = (ftot).ToString();
                    lbl_dis.Text = (dis).ToString();

                }
                else
                {
                    lbl_dis.Text = (0).ToString();
                }

                lbl_date.Text = DateTime.Now.ToShortDateString();


                

               
                con.Open();
                
                cmd2 = new SqlCommand("INSERT INTO Invoice VALUES('"+lbl_cid.Text+ "','" + lbl_date.Text + "','" + lbl_tot.Text+"','"+lbl_dis.Text+"','" + lbl_bill1.Text+"','"+lbl_bill2.Text+"','"+lbl_bill3.Text+"','"+lbl_bill4.Text+"','"+lbl_bill5.Text+"','"+lbl_bill6.Text+"','"+lbl_quan1.Text+"','"+lbl_quan2.Text+ "','"+lbl_quan3.Text+"','"+lbl_quan4.Text+"','"+lbl_quan5.Text+"','"+lbl_quan6.Text+"','"+lbl_price1.Text+"','"+lbl_price2.Text+"','"+lbl_price3.Text+"','"+lbl_price4.Text+"','"+lbl_price5.Text+ "','"+lbl_price6.Text+"')", con);
                int a= cmd2.ExecuteNonQuery();
                if(a==1)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Succesed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
           }
           catch (NullReferenceException)
           {
                MetroFramework.MetroMessageBox.Show(this,"Cannot be null", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
            catch (FormatException)
           {
                MetroFramework.MetroMessageBox.Show(this,"Enter numbers only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           catch (DivideByZeroException)
           {
                MetroFramework.MetroMessageBox.Show(this,"Cannot divide by ZERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

           }
           catch (Exception)
           {
                MetroFramework.MetroMessageBox.Show(this,"Check Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }
    
        



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_newbill_Click(object sender, EventArgs e)
        {
            

            lbl_qunget1.Text = (0).ToString();
            lbl_qunget2.Text = (0).ToString();
            lbl_qunget3.Text = (0).ToString();
            lbl_qunget4.Text = (0).ToString();
            lbl_qunget5.Text = (0).ToString();
            lbl_qunget6.Text = (0).ToString();

            lbl_qunset1.Text = "";
            lbl_qunset2.Text = "";
            lbl_qunset3.Text = "";
            lbl_qunset4.Text = "";
            lbl_qunset5.Text = "";
            lbl_qunset6.Text = "";

            su_itemlable1.Text = "";
            su_itemlable2.Text = "";
            su_itemlable3.Text = "";
            su_itemlable4.Text = "";
            su_itemlable5.Text = "";

            su_pricelable1.Text = "";
            su_pricelable2.Text = "";
            su_pricelable3.Text = "";
            su_pricelable4.Text = "";
            su_pricelable5.Text = "";

            panel3.Visible = false;

            lbl_bill1.Text = "";
            lbl_bill2.Text = "";
            lbl_bill3.Text = "";
            lbl_bill4.Text = "";
            lbl_bill5.Text = "";
            lbl_bill6.Text = "";

            lbl_quan1.Text = (0).ToString();
            lbl_quan2.Text = (0).ToString();
            lbl_quan3.Text = (0).ToString();
            lbl_quan4.Text = (0).ToString();
            lbl_quan5.Text = (0).ToString();
            lbl_quan6.Text = (0).ToString();

            lbl_price1.Text = (0).ToString();
            lbl_price2.Text = (0).ToString();
            lbl_price3.Text = (0).ToString();
            lbl_price4.Text = (0).ToString();
            lbl_price5.Text = (0).ToString();
            lbl_price6.Text = (0).ToString();

            lbl_tot.Text = "";

            lbl_get.Text = "";

            lbl_gettot.Text = "";

            lbl_unit.Text = "";

            lbl_data.Text = "";

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

            txt_pid.Clear();
            txt_pname.Clear();
            txt_qun.Clear();

            lbl_1.Text = " ";
            lbl_2.Text = " ";
            lbl_3.Text = " ";

            lbl_cid.Text = "";

            lbl_cid1.Text = "";

            lbl_data.Text = "";

        }

        private void btn_forreg_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_freg_Click(object sender, EventArgs e)
        { 
            if (txt_pid.Text != "" && txt_pname.Text != "" && txt_qun.Text != "" && lbl_tot.Text != "")
            {
                obj1.ShowDialog();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"First you fill the value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
