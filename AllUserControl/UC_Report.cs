using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbtinFastFood.AllUserControl
{
    public partial class UC_Report : UserControl
    {
        function fn = new function();
        string query;

        public UC_Report()
        {
            InitializeComponent();
        }
        string date1;
        string date2;

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            date1 = dateTimePicker1.Value.Year + "_" + dateTimePicker1.Value.Month + "_" + dateTimePicker1.Value.Day; 
            date2 = dateTimePicker2.Value.Year + "_" + dateTimePicker2.Value.Month + "_" + dateTimePicker2.Value.Day;

            query = "select * from Orderss where time between '"+date1+"' and '"+date2+"'";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
