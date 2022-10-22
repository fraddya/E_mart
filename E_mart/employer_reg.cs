using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_mart
{
    public partial class employer_reg : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public employer_reg()
        {
            InitializeComponent();
        }
        

        private void btn_regE_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-MNKQHADG\\SQLEXPRESS;Initial Catalog=e_martlocalhost;Integrated Security=True"); //Nathu
            con.Open();
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
                
              /*  if (!Regex.Match(txt_Eaddress.Text, @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
                {

                    MetroFramework.MetroMessageBox.Show(this, "Invalid address", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Eaddress.Focus();
                    return;
                }
              */
               
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

                   
                    if(rdo_emp.Checked==true)
                    {
                        cmd = new SqlCommand("Insert into Employer (Emp_username,Emp_psw,Emp_Name,Emp_address,Emp_TP,Emp_NIC,Emp_Email,Emp_DOB,Emp_type)Values ('" + txt_uname.Text + "','" + txt_psw + "','" + txt_EName.Text + "', '" + txt_Eaddress.Text + "', '"
                         + txt_Etel.Text + "',   '" + txt_Enic.Text + "', '" + txt_Eemail.Text + "','" + DOB_pickerE.Value + "','Employee') ", con);

                    }
                    else if(rdo_manager.Checked==true)
                    {
                        cmd = new SqlCommand("Insert into Employer (Emp_username,Emp_psw,Emp_Name,Emp_address,Emp_TP,Emp_NIC,Emp_Email,Emp_DOB,Emp_type)Values ('" + txt_uname.Text + "','" + txt_psw + "','" + txt_EName.Text + "', '" + txt_Eaddress.Text + "', '"
                       + txt_Etel.Text + "',   '" + txt_Enic.Text + "', '" + txt_Eemail.Text + "','" + DOB_pickerE.Value + "','Manager') ", con);

                    }

                    int i= cmd.ExecuteNonQuery();
                    if (i == 1)
                        MetroFramework.MetroMessageBox.Show(this, "Registration Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Registration Unsuccess", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
                cmd.Dispose();
            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void employer_reg_Load(object sender, EventArgs e)
        {
           
        }

        private void rdo_emp_CheckedChanged(object sender, EventArgs e)
        {
            /*
            con = new SqlConnection("Data Source=LAPTOP-MNKQHADG\\SQLEXPRESS;Initial Catalog=e_martlocalhost;Integrated Security=True");//Nathu
            con.Open();
           
            string E = "Employee";
            cmd = new SqlCommand("Insert into Employer(Emp_type) Values ('Employee')", con);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            con.Close();
            cmd.Dispose();
            */
        }

        private void rdo_manager_CheckedChanged(object sender, EventArgs e)
        {
            /*
            con = new SqlConnection("Data Source=LAPTOP-MNKQHADG\\SQLEXPRESS;Initial Catalog=e_martlocalhost;Integrated Security=True");//Nathu
            con.Open();
            //string Employee = rdo_emp.ToString();
            string M = "Manager";
            cmd = new SqlCommand("Insert into Employer(Emp_type) Values ('" + M + "')", con);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            con.Close();
            cmd.Dispose();
            */
        }
    }
    }

