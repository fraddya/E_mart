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
        

        private void btn_productsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string id, name;
                int quantity;

                id = txt_Pid.Text;
                name = txt_Pname.Text;
                quantity = Convert.ToInt32(txt_queantity.Text);

                con.Open();
                cmd = new SqlCommand("Insert into product (Product_ID,)values (@name,@quantity", con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("quantity", quantity);
               


                if (txt_Pid.Text.Length == 0)
                {
                    MessageBox.Show("product id cannot be blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Pid.Text.Any(char.IsDigit)) //need to check
                {
                    MessageBox.Show("please use string only", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Pname.Text.Length == 0)
                {
                    MessageBox.Show("product name cannot be blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Pname.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("please use string only", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if(txt_queantity.Text.Length==0)
                {
                    MessageBox.Show("queantity cannot be blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txt_Pid.Text = Convert.ToString(id);
                txt_Pname.Text = Convert.ToString(name);
                txt_queantity.Text = Convert.ToString(quantity);

            }
            catch(FormatException)
            {
                MessageBox.Show("enter numbers only", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("cannot divide by zero", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("data cant save", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("data add succesfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(i==0)
            {
                MessageBox.Show("data cant add succesfully", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                con.Close();
        }

        private void txt_queantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_refil_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                
                if (rdo_pid.Checked == true)
                {
                    cmd = new SqlCommand("Update Product set Product_quantity = '" + txt_quentity.Text + "', where Product_ID = '" + txt_Pid.Text + "' ,con");
                    if (txt_quentity.Text.Length == 0)
                    {
                        MessageBox.Show("queantity cannot be blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rdo_product_name.Checked== false)
                {
                    cmd = new SqlCommand("Update Product set Product_quantity = '" + txt_quentity.Text + "', where Product_Name = '" + txt_Pname.Text+ "' ,con");
                    if (txt_quentity.Text.Length == 0)
                    {
                        MessageBox.Show("queantity cannot be blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } 
            catch(Exception)
            {
                MessageBox.Show("data  submit invalid", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int i = cmd.ExecuteNonQuery();
            if(i==1)
            {
                MessageBox.Show("update data successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(i==1)
            {
                MessageBox.Show("update data unsuccesfully", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("select* from product", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {
            


        }
    }
}
