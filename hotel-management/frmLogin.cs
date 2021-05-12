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
        

        public void RemoveTextUN(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        public void RemoveTextPW(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        public void AddTextUSname(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
                txtUsername.Text = "Username";
        }


        private void AddTextPW(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
                txtPassword.Text = "Password";
        }
    }
}
