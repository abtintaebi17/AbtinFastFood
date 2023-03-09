using AbtinFastFood.AllUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbtinFastFood
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(string user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                btnAdditem.Hide();
                btnRemoveItem.Hide();
                btnUpdateItem.Hide();

            }
            else if (user == "Admin")
            {
                btnAdditem.Show();
                btnRemoveItem.Show();
                btnUpdateItem.Show();
            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void lnlLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }

        private void btnAdditem_Click(object sender, EventArgs e)
        {
            uC_AddItem1.Visible = true;
            uC_AddItem1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddItem1.Visible = false;
            uC_Order1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_RemoveItems1.Visible = false;
            uC_Report1.Visible = false;


        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            uC_welcome1.SendToBack();
            uC_Order1.Visible = true;
            uC_Order1.BringToFront();
            
        }

        private void uC_AddItem1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Order1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            uC_RemoveItems1.Visible = true;
            uC_RemoveItems1.BringToFront();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            uC_Report1.Visible = true;
            uC_Report1.BringToFront();

        }
    }
}
