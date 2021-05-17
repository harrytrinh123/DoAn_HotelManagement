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
    public partial class frmMainManagement : Form
    {
        private Account account;

        public frmMainManagement(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dụng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
        private void OpenFormInPanel(object Formhijo)
        {
            if (this.panel_workarea.Controls.Count > 0)
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
            OpenFormInPanel(new frmHomeManagement());
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmServiceManagement());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmNhanVienManagement());
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmRoomManagement());
        }

        private void btnTrangThietBi_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmDeviceManagement());
        }

        private void frmMainManagement_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmHomeManagement());
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmRoomManagement());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
