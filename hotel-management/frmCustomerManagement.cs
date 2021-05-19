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
        clsCustomer qlCustomer;

        public frmCustomerManagement()
        {
            InitializeComponent();

            qlCustomer = new clsCustomer();
        }

        private void label12_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            CreateListView();
            LoadListView();
        }

        private void LoadListView()
        {
            ListViewItem item;

            lvwDSKhachHang.Items.Clear();
            foreach(Customer customer in qlCustomer.GetCustomers())
            {
                item = new ListViewItem();
                item.Text = customer.id_Customer;
                item.SubItems.Add(customer.name);

                if (customer.sex.Equals("M"))
                    item.SubItems.Add("Nam");
                else
                    item.SubItems.Add("Nữ");

                item.SubItems.Add(customer.birthday.ToString("dd/MM/yyyy"));
                item.SubItems.Add(customer.address);
                item.SubItems.Add(customer.phone);
                item.Tag = customer;

                lvwDSKhachHang.Items.Add(item);
            }
        }

        private void CreateListView()
        {
            lvwDSKhachHang.GridLines = true;
            lvwDSKhachHang.FullRowSelect = true;
            lvwDSKhachHang.View = View.Details;

            // Columns
            lvwDSKhachHang.Columns.Add("ID", 150);
            lvwDSKhachHang.Columns.Add("Tên", 200);
            lvwDSKhachHang.Columns.Add("Giới Tính", 100);
            lvwDSKhachHang.Columns.Add("Ngày sinh", 150);
            lvwDSKhachHang.Columns.Add("Địa chỉ", 300);
            lvwDSKhachHang.Columns.Add("SĐT", 200);
        }

        private void lvwDSKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvwDSKhachHang.SelectedItems.Count > 0)
            {
                Customer item = (Customer)lvwDSKhachHang
                                .SelectedItems[lvwDSKhachHang.SelectedItems.Count - 1]
                                .Tag;
                txtTenKH.Text = item.name;
                txtSoDT.Text = item.phone;
                txtDiaChi.Text = item.address;
                txtID.Text = item.id_Customer;
                
                if(item.sex.Equals("M"))
                {
                    cboGioiTinh.SelectedItem = cboGioiTinh.Items[0];
                }
                else
                {
                    cboGioiTinh.SelectedItem = cboGioiTinh.Items[1];
                }

                dTimeNgaySinh.Value = item.birthday;
                btnXoa.Enabled = true;

                if(btnThem.Text.Equals("Lưu"))
                {
                    btnThem.Text = "Thêm";
                }
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnThem.Text.Equals("Thêm"))
            {
                btnThem.Text = "Lưu";
                btnXoa.Enabled = false;
                txtID.Enabled = true;

                txtID.Text = "";
                txtDiaChi.Text = "";
                txtSoDT.Text = "";
                txtTenKH.Text = "";
                cboGioiTinh.SelectedIndex = 0;
                dTimeNgaySinh.Value = DateTime.Now;
            }
            else
            {
                btnThem.Text = "Thêm";
                txtID.Enabled = false;


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;

            if(MessageBox.Show("Bạn có xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Customer customer;

                foreach (ListViewItem item in lvwDSKhachHang.SelectedItems)
                {
                    customer = (Customer)item.Tag;
                    try
                    {
                        qlCustomer.DeleteCustomer(customer);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo");
                    }
                }
            }

        }
    }
}
