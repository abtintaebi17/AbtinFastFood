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
    public partial class UC_Order : UserControl
    {
        function fn = new function();
        string query;
        public UC_Order()
        {
            InitializeComponent();
        }

        private void UC_Order_Load(object sender, EventArgs e)
        {
            nudQuantity.Text = "0";
            listBox1.Text = "";
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cboCategory.Text;
            query = "select name from items where category = '"+category+"'";
            showItemList(query);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string category = cboCategory.Text;
            query = "select name from items where category = '" + category + "'and name like'" + txtsearch.Text+"%'";
            showItemList(query);
        }
        private void showItemList (string query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudQuantity.ResetText();
            txtTotal.Clear();

            string text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;

            query = "select price from items where name = '" + text + "'";
            DataSet ds = fn.GetData(query);
            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            if(txtsearch.Text == "Search")
            {
                txtsearch.Text = "";
                txtsearch.ForeColor = Color.Black;
            }
        }

        private void txtsearch_Leave(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                txtsearch.Text = "Search";
                txtsearch.ForeColor = Color.Silver;
            }


        }

        private void nudQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(nudQuantity.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            txtTotal.Text = (quan * price).ToString();


        }
        protected int n,total = 0;
        int amount;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            catch { }

            total -= amount;
            lblTotal.Text = "Toman." + total;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                dataGridView1.Rows[n].Cells[2].Value = nudQuantity.Text;
                dataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;
                dataGridView1.Rows[n].Cells[4].Value = DateTime.Now;


                total = total + int.Parse(txtTotal.Text);
                lblTotal.Text = "Toman." + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            query = "insert into Orderss (category,itemname,totalprice,time) values ('" + cboCategory.Text + "' , '" + txtItemName.Text + "' , '" + txtTotal.Text + "' , '"+DateTime.Now+"')";
            fn.setData(query);





        }
    }
}
