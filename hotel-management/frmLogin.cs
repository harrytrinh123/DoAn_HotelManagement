using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel_management
{
    public partial class frmLogin : Form
    {
        private clsAccount qlAccount = new clsAccount();
        public Account account;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            account = new Account()
            {
                username = txtUsername.Text,
                password = txtPassword.Text
            };

            if (qlAccount.CheckAccount(account))
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Username hoặc Password không đúng!", "Thông báo");
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).Text = "";
        }
    }
}
