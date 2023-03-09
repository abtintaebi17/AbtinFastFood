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
    public partial class UC_UpdateItems : UserControl
    {
        function fn = new function();
        string query;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            query = "select * from Items";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Items where name like '" + txtSearch.Text + "%'";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string category = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtCategory.Text = category;
            txtItemName.Text = name;
            txtPrice.Text = price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update Items set name='"+txtItemName.Text+"',category = '"+txtCategory.Text+"',price="+txtPrice.Text+"where iid = "+id+"";
            fn.setData(query);
            loadData();

            txtCategory.Clear();
            txtItemName.Clear();
            txtPrice.Clear();

        }
    }
}
