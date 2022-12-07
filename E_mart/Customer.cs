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
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace E_mart
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        


        private void Customer_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=VIVOBOOK;Initial Catalog=e_martlocalhost;Integrated Security=True");//Fraddya
            //con = new SqlConnection("Data Source=LAPTOP-MNKQHADG\\SQLEXPRESS;Initial Catalog=e_martlocalhost;Integrated Security=True");//Nathu
            //try
             //{
            con.Open(); 
                
                if (string.IsNullOrEmpty(txt_CName.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_CName.Focus();
                }
                if (txt_CName.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this,"First Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_CName.Focus();
                }

                if (string.IsNullOrEmpty(txt_address.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Address can not be empty or can not have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_address.Focus();
                }

                /*else if (!Regex.IsMatch(txt_tel.Text, @"^\+\d{1,7}$"))
                 {
                     MessageBox.Show("Enter Valid Telephone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     txt_tel.Focus();
                 }
                */

                else if (txt_email.Text.Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Please Enter Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_email.Focus();
                }
                else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Enter a valid email. Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_email.Focus();
                }
                else
                {
                cmd = new SqlCommand("Insert into Client(Client_Name,Client_address,Client_TP,Client_NIC,Client_Email,Client_DOB) values('" + txt_CName.Text + "','" + txt_address.Text + "','" + txt_tel.Text + "', '" + txt_nic.Text + "','" + txt_email.Text + "', '" + DOB_picker.Value + "')", con);
                //cmd = new SqlCommand("Insert into test values ('"+txt_CName.Text+"','"+txt_email.Text+"','"+txt_address+"')", con);
                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                        MessageBox.Show(this, "Registration Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Registration Unsuccess ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();


            if (checkBox_email.Checked == true)
            {
                string fromMail = "ssisithasiranga@gmail.com";
                string fromPassword = "zsuzsoiqmkelayye";

                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = "E mart";
                message.To.Add(new MailAddress(txt_email.Text));
                message.Body = "<html><body><H1>Dear " + txt_CName.Text + ", </H1><br> <br><br>Your sucessfull registerd!! <br> Use " + txt_nic.Text + " As your Customer ID</body></html>";
                message.IsBodyHtml = true;
                var smtpClient = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true,
                };
                smtpClient.Send(message);


            };


            //}


            /*
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            */
        }

        private void txt_CName_TextChanged(object sender, EventArgs e)
        { 

        }
    }
}
