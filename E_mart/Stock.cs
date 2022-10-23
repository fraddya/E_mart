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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }
        // SqlConnection con;
        // SqlDataAdapter da;

        DataBase db = new DataBase();


        private void btn_viewS_Click(object sender, EventArgs e)
        {
           // con = new SqlConnection("Data Source=LAPTOP-MNKQHADG\\SQLEXPRESS;Initial Catalog=e_martlocalhost;Integrated Security=True"); //Nathu
            try
            {
                if (combox_stocktype.SelectedIndex == 0)
                {

                    dataGridView1.DataSource = db.getData("Select * from Product where Product_ID='" + txt_stock.Text + "' ");
                    
                }
                if (combox_stocktype.SelectedIndex == 1)
                {
                    dataGridView1.DataSource = db.getData("Select * from Product where Product_Name = '" + txt_stock.Text + "'");
                   // DataTable dt = new DataTable();
                   // da.Fill(dt);
                    //dataGridView1.DataSource = dt;
                    //con.Close();
                }

            }
            catch(SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Something Wrong", "Error", MessageBoxButtons.OK);
            }
            catch(Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Check Again", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
                //con = new SqlConnection("Data Source=LAPTOP-MNKQHADG\\SQLEXPRESS;Initial Catalog=e_martlocalhost;Integrated Security=True"); //Nathu
            try
            {

                dataGridView1.DataSource = db.getData("Select * from Product ");
               // DataTable dt = new DataTable();
               // da.Fill(dt);
               // dataGridView1.DataSource = dt;
               // con.Close();
            }
            catch(SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Something Wrong", "Error", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Check Again", "Error", MessageBoxButtons.OK);
            }
        

        }
    }
}
