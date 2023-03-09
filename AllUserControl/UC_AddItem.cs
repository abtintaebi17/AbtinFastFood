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
    public partial class UC_AddItem : UserControl
    {
        function fn = new function();
        string query;


        public UC_AddItem()
        {
            InitializeComponent();
        }

        private void UC_AddItem_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            query = "insert into Items (name,category,price) values ('" + txtIN.Text + "' , '" + cboCat.Text + "' , '" + txtPr.Text + "')";
            fn.setData(query);
            clearAll();

        }
        public void clearAll()
        {
            cboCat.SelectedIndex = -1;
            txtIN.Clear();
            txtPr.Clear();

        }

    }
}
