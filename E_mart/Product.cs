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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=VIVOBOOK;Initial Catalog=e_martlocalhost;Integrated Security=True"); //Fraddya
        //SqlConnection con = new SqlConnection("Data Source=LAPTOP-MNKQHADG\\SQLEXPRESS;Initial Catalog=e_martlocalhost;Integrated Security=True"); //Nathu
        SqlCommand cmd;
        SqlDataAdapter da;
        //  DataBase obj = new DataBase();//
       

        private void btn_productsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                
                con = new SqlConnection("Data Source=DESKTOP-OVGN370\\SQLEXPRESS;Initial Catalog=e_martlocalhostss;Integrated Security=True"); //BHanuka
                
                /*string id, name;
                int quantity;*/
                string category;
               /* id = txt_Pid.Text;
                name = txt_Pname.Text;
                quantity = Convert.ToInt32(txt_queantity.Text);*/

                if (comboBox1.SelectedIndex == 0)
                {
                    category = "fruit";
                    lbl_category.Text = category;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    category = "vegitable";
                    lbl_category.Text = category;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    category = "medicine";
                    lbl_category.Text = category;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    category = "meat";
                    lbl_category.Text = category;
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    category = "fish";
                    lbl_category.Text = category;
                }
                else
                {
                    category = "dairy food";
                    lbl_category.Text = category;
                }

                con.Open();

                /*cmd = new SqlCommand("Insert into product values (@id,@name,@quantity)", con);
                 cmd.Parameters.AddWithValue("id", id);
                 cmd.Parameters.AddWithValue("name", name);
                 cmd.Parameters.AddWithValue("quantity", quantity);*/








                if (txt_Pname.Text.Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this,"product name cannot be blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Pname.Focus();
                    return;
                }
                 if (txt_Pname.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Please use string only", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Pname.Focus();
                    return;
                }

                 if (txt_queantity.Text.Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Queantity cannot be blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_queantity.Focus();
                    return;
                }
                if(System.Text.RegularExpressions.Regex.IsMatch(txt_queantity.Text, "[^0-9]"))
                {
                    MetroFramework.MetroMessageBox.Show(this, "enter numbers only", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_queantity.Focus();
                    return;
                }

                if (comboBox1.Text.Length==0)
                { 
                MetroFramework.MetroMessageBox.Show(this, "Select item", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    /*txt_Pid.Text = Convert.ToString(id);
                    txt_Pname.Text = Convert.ToString(name);
                    txt_queantity.Text = Convert.ToString(quantity);*/
                    cmd = new SqlCommand("INSERT INTO Product (Product_Name,Product_queantity,Product_category)VALUES('" + txt_Pname.Text + "','" + txt_queantity.Text + "','" + lbl_category.Text + "')", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this,"update data successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this,"update data unsuccesfully", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
           catch (FormatException)
            {
                MetroFramework.MetroMessageBox.Show(this,"enter string only", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MetroFramework.MetroMessageBox.Show(this,"cannot divide by zero", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"check again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void txt_queantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_refil_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-OVGN370\\SQLEXPRESS;Initial Catalog=e_martlocalhostss;Integrated Security=True");
            try
                
            {
<<<<<<< Updated upstream
=======
                int s = 0;
                con.Open();
>>>>>>> Stashed changes

                con.Open();
                
                if (rdo_pid.Checked == true)
                {
                    cmd = new SqlCommand("Update Product set Product_quantity = '" + txt_quentity.Text + "', where Product_ID = '" + txt_Pid.Text + "'", con);
                    if(txt_refil.Text.Length==0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "refil cannot be blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_refil.Focus();
                        return;
                    }
                    if (txt_quentity.Text.Length == 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this,"queantity cannot be blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_queantity.Focus();
                        return;
                    }
                    if (System.Text.RegularExpressions.Regex.IsMatch(txt_queantity.Text, "[^0-9]"))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Queantity cannot be blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_queantity.Focus();
                        return;
                    }
                    
                }
                else if (rdo_product_name.Checked == true)
                {
                    cmd = new SqlCommand("Update Product set Product_quantity = '" + txt_quentity.Text + "', where Product_Name = '" + txt_Pname.Text + "'", con);
                    if (txt_refil.Text.Length == 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "refil cannot be blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_refil.Focus();
                        return;
                    }
                    if (txt_quentity.Text.Length == 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this,"queantity cannot be blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (System.Text.RegularExpressions.Regex.IsMatch(txt_queantity.Text, "[^0-9]"))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Queantity cannot be blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_queantity.Focus();
                        return;
                    }
                    SqlDataReader a;
                    cmd=new SqlCommand("Select Product_queantity WHERE Product_ID='"+txt_Pid.Text+"'",con );
                    cmd.Parameters.AddWithValue("Product_ID",txt_Pid.Text);
                    a = cmd.ExecuteReader();
                    if(a.Read())
                    {
                        string c = a["Product_queantity"].ToString();
                        int d = Convert.ToInt32(txt_queantity);
                        if (d < Convert.ToInt32(c))
                        {
                            
                            lbl_1.Text =Convert.ToString( Convert.ToInt16(c) - d);
                        }


                        txt_queantity.Text = lbl_1.Text;
                        cmd = new SqlCommand("Update Product set Product_quantity = '" + txt_quentity.Text + "', where Product_ID = '" + txt_Pid.Text + "'", con);


                    }

                }
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "update data successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "update data unsuccesfully", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"data  submit invalid", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-OVGN370\\SQLEXPRESS;Initial Catalog=e_martlocalhostss;Integrated Security=True"); //BHanuka
            try
            {
               con.Open();
                da = new SqlDataAdapter("select* from product", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "unsuccesfully", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {
            


        }

        private void rdo_pid_CheckedChanged(object sender, EventArgs e)
        {

        }
        int a;
        private void btn_add_Click(object sender, EventArgs e)
        {
            
            a++;
            txt_quentity.Text = a.ToString();
                
        }

       
        private void btn_remove_Click(object sender, EventArgs e)
        {
            
            a--;
            txt_quentity.Text = a.ToString();
            if(a==0)
            {
                MetroFramework.MetroMessageBox.Show(this, "last number is zero", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
