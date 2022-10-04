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

        DataBase db = new DataBase();


        private void Customer_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(txt_CName.Text))
                {
                    MessageBox.Show("Name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_CName.Focus();
                }
               
                else if (!Regex.Match(txt_CName.Text, "^[A-Z][a-zA-Z]*$").Success)
                {

                    MessageBox.Show("Invalid first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_CName.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_address.Text))
                {
                    MessageBox.Show("Address can not be empty or can not have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_address.Focus();
                }

                if (!Regex.Match(txt_address.Text   , @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
                {
                   
                    MessageBox.Show("Invalid address", "Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_address.Focus();
                    return;
                }
                if (!Regex.Match(txt_tel.Text, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$").Success)
                {
                   
                    MessageBox.Show("Invalid phone number", "Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_address.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_tel.Text))
                {
                    MessageBox.Show("Telephone number can not be empty or can not have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_address.Focus();
                }
                if (txt_email.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_email.Focus();

                }
                if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
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
            }
          
        }

        private void txt_CName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
