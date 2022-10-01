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
    public partial class employer_reg : Form
    {
        public employer_reg()
        {
            InitializeComponent();
        }


        DataBase db = new DataBase(); 

        private void btn_regE_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_EName.Text))
                {
                    MessageBox.Show("Name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_EName.Focus();
                }
                else if (txt_EName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("First Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_EName.Focus();
                }

                else if (string.IsNullOrEmpty(txt_Eaddress.Text))
                {
                    MessageBox.Show("Address can not be empty or can not have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Eaddress.Focus();
                }
                /*
                else if (!Regex.IsMatch(txt_tel.Text, @"^\+\d{1,7}$"))
                {
                    MessageBox.Show("Enter Valid Telephone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_tel.Focus();
                }
                */
                else if (txt_Eemail.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Eemail.Focus();
                }
                else if (!Regex.IsMatch(txt_Eemail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MessageBox.Show("Enter a valid email. Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Eemail.Focus();
                }
                else
                {

                    string query = "Insert into Client values ('" + txt_EName.Text + "', '" + txt_Eaddress.Text + "', '" + txt_Etel.Text + "',  '" + DOB_pickerE.Value + "', '" + txt_Enic.Text + "', '" + txt_Eemail.Text + "') ";
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
    }
}
