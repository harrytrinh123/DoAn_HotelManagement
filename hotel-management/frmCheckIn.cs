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
    public partial class frmCheckIn : Form
    {
        public frmCheckIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }



        private void label12_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            clsCustomer clsCus = new clsCustomer();
            string cmnd = txtTim.Text;
            Customer res = clsCus.checkIfExist(cmnd);
            if(res!=null) { }
            else
            {
                MessageBox.Show("Số CMND chưa đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
