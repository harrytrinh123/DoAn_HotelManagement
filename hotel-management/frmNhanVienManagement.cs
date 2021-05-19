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
    public partial class frmNhanVienManagement : Form
    {
        public frmNhanVienManagement()
        {
            InitializeComponent();
        }

        //tạo biến toàn cục
        
        private clsStaff Staff;
        private clsAccount Account;
        private IEnumerable<Staff> ListStaff;
        private IEnumerable<Account> ListAccount;

        private void frmNhanVienManagement_Load(object sender, EventArgs e)
        {
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.Items.Add("Khác");

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnDoiMatkhau.Enabled = true;
            

            Staff = new clsStaff();
            Account = new clsAccount();

            createListView(lvwDSNV);
            createListAccount(lvwListAccount);

            ListStaff = Staff.getListStaff();
            ListAccount = Account.GetListAccount();

            LoadItemToView(lvwDSNV, ListStaff);
            LoadItemToView(lvwListAccount, ListAccount);
        }

        //Tạo listview cho danh sách account
        private void createListAccount(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;

            lvw.Columns.Add("Tài khoản", 250);
            lvw.Columns.Add("Mật khẩu", 205);
        }

        //Tạo listview cho danh sách nhân viên
        private void createListView(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;

            lvw.Columns.Add("Mã nhân viên", 150);
            lvw.Columns.Add("Tên nhân viên", 200);
            lvw.Columns.Add("Giới tính", 100);
            lvw.Columns.Add("Ngày sinh", 150);
            lvw.Columns.Add("Địa chỉ", 200);
            lvw.Columns.Add("SĐT", 200);
        }

        #region Load Danh sách lên View
        //Staff
        private void LoadItemToView(ListView lvw, IEnumerable<Staff> list)
        {
            lvw.Items.Clear();
            ListViewItem item;
            foreach(Staff i in list)
            {
                item = GreateItemStaff(i);
                lvw.Items.Add(item);
            }
        }

        //Account
        private void LoadItemToView(ListView lvw, IEnumerable<Account> list)
        {
            lvw.Items.Clear();
            ListViewItem item;
            foreach (Account i in list)
            {
                item = GreateItemAccount(i);
                lvw.Items.Add(item);
            }
        }

        #endregion

        #region Tạo các Item để hỗ trợ cho việc load danh sách lên ListView

        //Account
        private ListViewItem GreateItemAccount(Account i)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(i.username);
            lvwItem.SubItems.Add(i.password);
            lvwItem.Tag = i;
            lvwItem.ImageIndex = 0;

            return lvwItem;
        }

        //Staff
        private ListViewItem GreateItemStaff(Staff m)
        {
            ListViewItem lvwItem;
            //xử lý ngày sinh
            string birthday = Convert.ToString(m.birthday);
            string [] day = birthday.Split(' ');

            //add ItemToListView
            lvwItem = new ListViewItem(m.id_Staff);
            lvwItem.SubItems.Add(m.name);
            
            //xử lý giới tính
            if (m.sex.ToString().Equals("M"))
                lvwItem.SubItems.Add("Nam");
            else if (m.sex.ToString().Equals("FM"))
                lvwItem.SubItems.Add("Nữ");
            else
                lvwItem.SubItems.Add("Khác");

            lvwItem.SubItems.Add(day[0]);
            lvwItem.SubItems.Add(m.address);
            lvwItem.SubItems.Add(m.phone);
            lvwItem.Tag = m;
            lvwItem.ImageIndex = 0;
            return lvwItem;
        }

        #endregion
        private void lvwDSNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staff staff = null;
            if(lvwDSNV.SelectedItems.Count > 0)
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                staff = (Staff)lvwDSNV.SelectedItems[0].Tag;
                StaffToTextBox(staff);
            }
        }

        private void lvwListAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account account = null;
            if(lvwListAccount.SelectedItems.Count > 0)
            {
                btnDoiMatkhau.Enabled = true;

                account = (Account)lvwListAccount.SelectedItems[0].Tag;
                AccountToTextBox(account);
            }
        }

        #region Load data từ ListView sang TextBox
        private void AccountToTextBox(Account account)
        {
            txtTaiKhoan.Text = account.username;
            txtMatKhau.Text = account.password;
        }

        private void StaffToTextBox(Staff staff)
        {
            txtMaNV.Text = staff.id_Staff;
            txtTen.Text = staff.name;

            if (staff.sex.ToString().Equals("M"))
            {
                cboGioiTinh.SelectedIndex = 0;
            }
            else if(staff.sex.ToString().Equals("FM"))
            {
                cboGioiTinh.SelectedIndex = 1;
            }
            else
            {
                cboGioiTinh.SelectedIndex = 2;
            }

            dtpNgaySinh.Value = staff.birthday;
            txtDiaChi.Text = staff.address;
            txtSDT.Text = staff.phone;
        }

        #endregion

        #region Tạo các Item hỗ trợ cho việc Insert
        private Account CreateAccount()
        {
            Account a  = new Account();
            a.username = txtTaiKhoan.Text;
            a.password = txtMatKhau.Text;

            return a;
        }

        private Staff CreateStaff()
        {
            Staff staff = new Staff();
            staff.id_Staff = txtMaNV.Text;
            staff.name = txtTen.Text;

            if (cboGioiTinh.SelectedItem.ToString().Equals("Nam"))
                staff.sex = "M";
            else if(cboGioiTinh.SelectedItem.ToString().Equals("Nữ"))
                staff.sex = "FM";

            staff.birthday = dtpNgaySinh.Value;
            staff.address = txtDiaChi.Text;
            staff.phone = txtSDT.Text;

            return staff;
        }

        #endregion

        private void btnThem_Click(object sender, EventArgs e)
        {
            Staff staff = CreateStaff();
            Account account = CreateAccount();

            Account.InsertAccount(account);
            Staff.InsertStaff(staff);

            LoadItemToView(lvwDSNV, ListStaff);
            LoadItemToView(lvwListAccount, ListAccount);

            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res;
            Staff s;
            int index;
            if(lvwDSNV.SelectedItems.Count > 0)
            {
                res = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    for(int i = 0; i < lvwDSNV.SelectedItems.Count; ++i)
                    {
                        index = lvwDSNV.SelectedIndices[i];
                        s = (Staff)lvwDSNV.Items[index].Tag;

                        Staff.DeleteStaff(s);
                        //Xóa account theo id Staff
                        Account.DeleteAccount(s.id_Staff);
                    }

                    LoadItemToView(lvwDSNV, ListStaff);
                    LoadItemToView(lvwListAccount, ListAccount);
                    btnXoa.Enabled = false;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(lvwDSNV.SelectedItems.Count > 0)
            {
                Staff s = CreateStaff();
                Staff.ChangeStaff(s);

                LoadItemToView(lvwDSNV, ListStaff);
                btnSua.Enabled = false;
            }
        }

        private void btnDoiMatkhau_Click(object sender, EventArgs e)
        {
            if(lvwListAccount.SelectedItems.Count > 0)
            {
                Account a = CreateAccount();
                Account.ChangePass(a);
                LoadItemToView(lvwListAccount, ListAccount);
            }
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Chưa thể tìm kiếm theo Tên ra Mật khẩu được
           //Staff s = (Staff)(Staff.FindIndex(txtTimKiem.Text));

            ListStaff = Staff.FindIndex(txtTimKiem.Text);
            ListAccount = Account.FindIndex(txtTimKiem.Text);

            LoadItemToView(lvwDSNV, ListStaff);
            LoadItemToView(lvwListAccount, ListAccount);

            txtTimKiem.Clear();
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            ListStaff = Staff.getListStaff();
            ListAccount = Account.GetListAccount();

            LoadItemToView(lvwDSNV, ListStaff);
            LoadItemToView(lvwListAccount, ListAccount);
        }
    }
}
