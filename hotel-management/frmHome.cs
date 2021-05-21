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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookRoom frm = new frmBookRoom();
            frm.Show();
        }
    }
}
