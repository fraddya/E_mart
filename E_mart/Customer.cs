using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace E_mart
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        //DataBase db = new DataBase();


        private void Customer_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            /*
            try
            {

                if (string.IsNullOrEmpty(txt_CName.Text))
                {
                    MessageBox.Show("Name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_CName.Focus();
                }
                else if (txt_CName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("First Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_CName.Focus();
                }

                else if (string.IsNullOrEmpty(txt_address.Text))
                {
                    MessageBox.Show("Address can not be empty or can not have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_address.Focus();
                }
                /*
                else if (!Regex.IsMatch(txt_tel.Text, @"^\+\d{1,7}$"))
                {
                    MessageBox.Show("Enter Valid Telephone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_tel.Focus();
                }
                
                else if (txt_email.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_email.Focus();
                }
                else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MessageBox.Show("Enter a valid email. Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_email.Focus();
                }
                else
                {
                    string query = "Insert into Member Values('" + txt_CName.Text + "','" + txt_address.Text + "','" + txt_tel.Text + "','" +
                        "" + DOB_picker.Value + "','" + txt_nic.Text + "','" + txt_email.Text + "')";

                    int i = db.save_update_delete(query);

                    if (i == 1)
                        MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
          
        }

        private void txt_CName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
