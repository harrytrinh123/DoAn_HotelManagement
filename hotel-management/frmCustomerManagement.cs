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
            qlCustomer = new clsCustomer();
            ListViewItem item;

            lvwDSKhachHang.Items.Clear();
            foreach(Customer customer in qlCustomer.GetCustomers())
            {
                item = new ListViewItem();
                item.Text = customer.id_Customer;
                item.SubItems.Add(customer.name);
                item.SubItems.Add(customer.sex);
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
            }
        }
    }
}
