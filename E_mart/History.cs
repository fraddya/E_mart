using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_mart
{
    public partial class History : Form
    {
        SqlConnection con;
        SqlDataAdapter da;

        public History()
        {
            InitializeComponent();
        }

        private void btn_viewH_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-MNKQHADG\\SQLEXPRESS;Initial Catalog=e_martlocalhost;Integrated Security=True");//Nathu
            if (combox_H.SelectedIndex == 0)
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Invoice  where Customer_ID = '" + txt_invoiceidH.Text + "' ", con);
                dtp_H.Visible = false;

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (combox_H.SelectedIndex == 1)
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Invoice where dtp_H = '" + dtp_H.Value + "' ", con);
            txt_invoiceidH.Visible = false;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();


            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-MNKQHADG\\SQLEXPRESS;Initial Catalog=e_martlocalhost;Integrated Security=True");//Nathu
            con.Open();
            da = new SqlDataAdapter("Select * from Invoice ", con);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
