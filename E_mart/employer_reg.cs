using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
                    MetroFramework.MetroMessageBox.Show(this,"Name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_EName.Focus();
                }
               
                if (!Regex.Match(txt_EName.Text, "^[A-Z][a-zA-Z]*$").Success)
                {

                    MetroFramework.MetroMessageBox.Show (this, "Invalid first name", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_EName.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_Eaddress.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Address can not be empty or can not have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Eaddress.Focus();
                }
                if (!Regex.Match(txt_Eaddress.Text, @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
                {

                    MetroFramework.MetroMessageBox.Show(this, "Invalid address", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Eaddress.Focus();
                    return;
                }

                if (txt_Eemail.Text.Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Eemail.Focus();
                }
                if (!Regex.IsMatch(txt_Eemail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Enter a valid email. Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Eemail.Focus();
                }
                else
                {

                    string query = "Insert into Employer (Emp_username,Emp_psw,Emp_Name,Emp_address,Emp_TP,Emp_NIC,Emp_Email,Emp_DOB,Emp_regdate)values (" + txt_EName.Text + "', '" + txt_Eaddress.Text + "', '" + txt_Etel.Text + "',  '" + DOB_pickerE.Value + "', '" + txt_Enic.Text + "', '" + txt_Eemail.Text + "') ";
                    int i = db.save_update_delete(query);
                    if (i == 1)
                        MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void employer_reg_Load(object sender, EventArgs e)
        {

        }
    }
}
