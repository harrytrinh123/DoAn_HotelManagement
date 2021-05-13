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

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            clsKhachHang kh = new clsKhachHang();
            var q = kh.GetDSKH();
            
        }
    }
}
