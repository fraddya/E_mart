﻿using System;
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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=VIVOBOOK;Initial Catalog=e_martlocalhost;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        public login()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Client WHERE Client_username='"+txt_username.Text+"' and Client_psw='"+txt_psw.Text+"'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if(dr[0].ToString() == "Manager")
                {
                    ulog.type = "M";
                }
                else if(dr[0].ToString() == "Employer")
                {
                    ulog.type = "E";
                }
                Home fh = new Home();
                fh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your Name or Password", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
