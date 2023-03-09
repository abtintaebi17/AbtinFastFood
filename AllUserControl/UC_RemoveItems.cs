using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbtinFastFood.AllUserControl
{
    public partial class UC_RemoveItems : UserControl
    {
        function fn = new function();
        string query;
        public UC_RemoveItems()
        {
            InitializeComponent();
        }

        private void lblRemoveItems_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadData()
        {
            query = "select * from Items";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void UC_RemoveItems_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Items where name like '"+txtSearch.Text+"%'";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete item?","Important Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from Items where iid =" + id + "";
                fn.setData(query);
                loadData();
            }

            
        }

        private void UC_RemoveItems_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
