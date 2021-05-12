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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dụng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result ==DialogResult.Yes)
                {
                    this.Close();
                }

            }
            catch(Exception)
            {
                throw;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmHome());
            //asd
        }

        private void OpenFormInPanel(object Formhijo)
        {
            if(this.panel_workarea.Controls.Count > 0)
            {
                this.panel_workarea.Controls.RemoveAt(0);
            }
            Form fm = Formhijo as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fm.WindowState = FormWindowState.Normal;
            this.panel_workarea.Controls.Add(fm);
            this.panel_workarea.Tag = fm;
            fm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmHome());
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmBookRoom());
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmCheckIn());
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmCheckOut());
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmCustomerManagement());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmLogin fm = new frmLogin();
            fm.Show();
        }
    }
}
