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
                else if (customer.sex.Equals("FM"))
                    item.SubItems.Add("Nữ");
                else
                    item.SubItems.Add("Khác");

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
                else if (item.sex.Equals("FM"))
                {
                    cboGioiTinh.SelectedItem = cboGioiTinh.Items[1];
                }
                else
                    cboGioiTinh.SelectedItem = cboGioiTinh.Items[2];

                dTimeNgaySinh.Value = item.birthday;
                btnXoa.Enabled = true;

                btnThem.Text = "Thêm";
                btnCapNhat.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
                btnCapNhat.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnThem.Text.Equals("Thêm"))
            {
                btnThem.Text = "Lưu";
                btnXoa.Enabled = false;

                SetUpControls();
                txtID.Enabled = true;
            }
            else
            {
                btnThem.Text = "Thêm";
                txtID.Enabled = false;

                AddCustomer();
                LoadListView();
            }
        }

        private void AddCustomer()
        {
            try
            {
                Customer customer = CreateCustomer();
                if (qlCustomer.Insert(customer))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Lỗi! Đã có ID trong danh sách!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Customer CreateCustomer()
        {
            if(txtID.Text.Trim().Length <= 0)
            {
                throw new Exception("Lỗi! ID không phù hợp!");
            }
            if(txtTenKH.Text.Trim().Length <= 0)
            {
                throw new Exception("Lỗi! Tên không phù hợp!");
            }
            if(txtDiaChi.Text.Trim().Length <= 0)
            {
                throw new Exception("Lỗi! Địa chỉ không phù hợp!");
            }
            if(txtSoDT.Text.Trim().Length <= 0)
            {
                throw new Exception("Lỗi! Số điện thoại không phù hợp!");
            }    
            if(dTimeNgaySinh.Value.CompareTo(DateTime.Now) >= 0)
            {
                throw new Exception("Lỗi! Ngày sinh không phù hợp");
            }

            string sex;

            if (cboGioiTinh.Text.Equals("Nam"))
                sex = "M";
            else if (cboGioiTinh.Text.Equals("Nữ"))
                sex = "FM";
            else
                sex = "";

            Customer customer = new Customer()
            {
                id_Customer = txtID.Text.Trim(),
                address = txtDiaChi.Text.Trim(),
                birthday = dTimeNgaySinh.Value,
                name = txtTenKH.Text.Trim(),
                phone = txtSoDT.Text.Trim(),
                sex = sex
            };

            return customer;
        }

        private void SetUpControls()
        {
            txtID.Text = "";
            txtID.Enabled = false;
            txtDiaChi.Text = "";
            txtSoDT.Text = "";
            txtTenKH.Text = "";
            cboGioiTinh.SelectedIndex = 2;
            dTimeNgaySinh.Value = DateTime.Now;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;

            if(MessageBox.Show("Bạn có xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string idCustomer;

                foreach (ListViewItem item in lvwDSKhachHang.SelectedItems)
                {
                    idCustomer = ((Customer)item.Tag).id_Customer;
                    qlCustomer.Delete(qlCustomer.checkIfExist(idCustomer));
                }
            }

            SetUpControls();
            LoadListView();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                qlCustomer.Update(CreateCustomer());
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadListView();
        }
    }
}
