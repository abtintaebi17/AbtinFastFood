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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            this.ActiveControl = txtUsername;
            txtUsername.Focus();
        }

        private void lnkGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                Dashboard ds = new Dashboard("Admin");
                ds.Show();
                this.Hide();
            }
        }

        private void btnCloseLp_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }

        }
    }
}
