using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;




namespace E_mart
{
     class DataBase
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public DataBase()
        {
            //con = new SqlConnection("Data Source=e-mart.database.windows.net;Initial Catalog=E_mart;User ID=madse212f-010;Password=********;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //con = new SqlConnection("Data Source=VIVOBOOK;Initial Catalog=Bank;Integrated Security=True");//Fraddy
            //con = new SqlConnection("Data Source=LAPTOP-FK0M22U2;Initial Catalog=e_martlocalhost;Integrated Security=True");//Nadiya
            con = new SqlConnection("Data Source=LAPTOP-MNKQHADG\\SQLEXPRESS;Initial Catalog=e_martlocalhost;Integrated Security=True"); //Nathu
        }
        public void OpenConnection()
        {
            con.Open();
        }
        public void closeConnection()
        {
            con.Close();
        }
        public int save_update_delete(string a)
        {
            OpenConnection();
            cmd = new SqlCommand(a, con);
            int i = cmd.ExecuteNonQuery();
            closeConnection();
            return i;
        }
        public DataTable getData(string a)
        {
            OpenConnection();
            da = new SqlDataAdapter(a, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeConnection();
            return dt;
        }
    }
}
    

