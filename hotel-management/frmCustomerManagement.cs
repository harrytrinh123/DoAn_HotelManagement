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
    public partial class frmCustomerManagement : Form
    {
        public frmCustomerManagement()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn hãy lưu thông tin trước khi thoát!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
