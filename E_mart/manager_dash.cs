//using LiveCharts;
//using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_mart
{
    public partial class manager_dash : Form
    {
        private object revenueBindingBindiSource;

        public manager_dash()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            /*
              
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var  = (from o in revenueBindingSource.DataSource as List<Revenue>
                         select new { Product_ID = o.Product_ID }); Distinct();
            foreach( )
            {
                List<double> Product_Quentity = new List<double>();
                for(int Product_ID =1; Product_ID<=10; Product_ID++)
                {
                    double Quentity = 0;
                    var data = from o in revenueBindingBindiSource as List<Revenue>
                               where o.Product_ID.Equals(Product_ID) && o.Product_Name.Equals(ProductName)
                               orderby o.Product_ID ascending
                               select new { o.Quentity, o.Product_ID };
                    if (data.SingleOrDefault() != null)
                        Quentity = data.SingleOrDefault().Quentity;
                    Quentity.Add(Quentity);
                }
                series.Add(new LineSeries()); { Title = Product_ID.Product_ID.ToString();,Product_Quentity = new ChartValues<double>(Product_Quentity); };

                cartesianChart1.Series = series;

            }
            */
        }
            

        private void manager_dash_Load(object sender, EventArgs e)
        {
            /*
            revenueBindingBindiSource.DataSource = new List<Revenue>();
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            { 
                Title="Product_ID",
                //label
               
            });
            revenueBindingBindiSource.DataSource = new List<Revenue>();
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Revenue",
                //label

            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right; */
        }
        
        
        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
