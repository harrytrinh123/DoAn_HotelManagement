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
    public partial class frmServiceManagement : Form
    {
        public frmServiceManagement()
        {
            InitializeComponent();
        }

        clsService Service;
        clsServiceStyle ServiceStyle;

        IEnumerable<dynamic> ListService;
        IEnumerable<ServiceStyle> ListName_ServiceStyle;
        IEnumerable<ServiceStyle> ListServiceStyle;

        private void frmServiceManagement_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnSuaLDV.Enabled = false;
            btnXoaLDV.Enabled = false;

            Service = new clsService();
            ServiceStyle = new clsServiceStyle();

            ListService = Service.GetAllService();
            ListServiceStyle = ServiceStyle.GetAllList();

            DataToComboBox();
            CreateListView(lvwService);
            CreateListView_LDV(lvwLDV);

            LoadListToView(lvwService, ListService);
            LoadListToView(lvwLDV, ListServiceStyle);

            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        #region Tạo ListView
        private void CreateListView(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;

            lvw.Columns.Add("Mã dịch vụ", 200);
            lvw.Columns.Add("Tên dịch vụ", 200);
            lvw.Columns.Add("Giá", 200);
            lvw.Columns.Add("Loại dịch vụ", 200);
        }

        private void CreateListView_LDV(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;

            lvw.Columns.Add("Mã loại dịch vụ", 200);
            lvw.Columns.Add("Tên loại dịch vụ", 205);
        }

        #endregion

        private void DataToComboBox()
        {
            ListName_ServiceStyle = ServiceStyle.GetListNameServiceStyle();
            foreach(ServiceStyle i in ListName_ServiceStyle)
            {
                cboLDV.Items.Add(i.NameStyle);
            }

        }

        private void LoadListToView(ListView lvw, IEnumerable<dynamic> list)
        {
            lvw.Items.Clear();
            ListViewItem item;

            foreach(dynamic i in list)
            {
                item = GreateItem(i);
                lvw.Items.Add(item);
            }
        }

        #region Tạo Item cho hỗ trợ load lên ListView
        private ListViewItem GreateItem(ServiceStyle i)
        {
            ListViewItem item;
            item = new ListViewItem(i.id_SeviceStyle);
            item.SubItems.Add(i.NameStyle);

            item.Tag = i;
            return item;
        }

        private ListViewItem GreateItem(dynamic i)
        {
            ListViewItem item;
            item = new ListViewItem(i.id_Service);
            item.SubItems.Add(i.Name_Service);
            item.SubItems.Add(i.Price.ToString("#,###,000 VNĐ"));
            item.SubItems.Add(i.NameStyle);

            item.Tag = i;
            return item;
        }

        #endregion


        private void lvwService_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic service = null;
            if(lvwService.SelectedItems.Count > 0)
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                service = lvwService.SelectedItems[0].Tag;
                LoadServiceToTextBox(service);
            }
        }

        private void lvwLDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceStyle service = null;
            if (lvwLDV.SelectedItems.Count > 0)
            {
                btnXoaLDV.Enabled = true;
                btnSuaLDV.Enabled = true;

                service = (ServiceStyle)lvwLDV.SelectedItems[0].Tag;
                LoadServiceStyleToTextBox(service);
            }
        }

        #region Load Listview vào TextBox
        private void LoadServiceToTextBox(dynamic service)
        {
            txtID_DV.Text = service.id_Service;
            txtTenDV.Text = service.Name_Service;
            txtGia.Text = service.Price.ToString().Split('.')[0];
            cboLDV.Text = service.NameStyle;
        }

        private void LoadServiceStyleToTextBox(ServiceStyle ss)
        {
            txtID_LDV.Text = ss.id_SeviceStyle;
            txtTenLDV.Text = ss.NameStyle;
        }

        #endregion

        #region Sự kiện của Dịch Vụ
        private void btnThem_Click(object sender, EventArgs e)
        {
            Service service = CreateService();

            Service.InsertService(service);

            LoadListToView(lvwService, ListService);
            ClearInput();
        }

        private void ClearInput()
        {
            txtID_DV.Clear();
            txtTenDV.Clear();
            txtGia.Clear();
            cboLDV.SelectedIndex = -1 ;
        }

        private Service CreateService()
        {
            Service s = new Service();
            s.id_Service = txtID_DV.Text;
            s.Name_Service = txtTenDV.Text;
            s.Price = Convert.ToDecimal(txtGia.Text);
            s.id_SeviceStyle = ServiceStyle.GetIdServiceStyle(cboLDV.SelectedItem.ToString());
            return s;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res;
            string s;
            int index ;
            if(lvwService.SelectedItems.Count > 0)
            {
                res = MessageBox.Show("Bạn chắc chắn muốn xóa trường này?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    for(int i = 0; i < lvwService.SelectedItems.Count; ++i)
                    {
                        index = lvwService.SelectedIndices[i];
                        s = ((dynamic)lvwService.Items[index].Tag).id_Service;

                        Service.DeleteService(Service.CheckIfExist(s));
                    }

                    LoadListToView(lvwService, ListService);
                    btnXoa.Enabled = false;
                    ClearInput();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(lvwService.SelectedItems.Count > 0)
            {
                Service s = CreateService();
                Service.ChangeService(s);

                LoadListToView(lvwService, ListService);
                btnSua.Enabled = false;
                ClearInput();
            }
        }


        #endregion


        #region Sụ kiện của Loại Dịch Vụ
        private void btnThemLDV_Click(object sender, EventArgs e)
        {
            ServiceStyle ss = CreateServiceStyle();

            ServiceStyle.InsertServiceStyle(ss);

            LoadListToView(lvwLDV, ListServiceStyle);
            ClearInput_1();
        }

        private void ClearInput_1()
        {
            txtID_LDV.Clear();
            txtTenLDV.Clear();
        }

        private ServiceStyle CreateServiceStyle()
        {
            ServiceStyle ss = new ServiceStyle();
            ss.id_SeviceStyle = txtID_LDV.Text;
            ss.NameStyle = txtTenLDV.Text;
            return ss;
        }

        private void btnSuaLDV_Click(object sender, EventArgs e)
        {
            if (lvwLDV.SelectedItems.Count > 0)
            {
                ServiceStyle ss = CreateServiceStyle();
                ServiceStyle.ChangeServiceStyle(ss);

                LoadListToView(lvwLDV, ListServiceStyle);
                ClearInput_1();
            }
        }

        private void btnXoaLDV_Click(object sender, EventArgs e)
        {
            DialogResult res;
            ServiceStyle ss;
            int index;
            if (lvwLDV.SelectedItems.Count > 0)
            {
                res = MessageBox.Show("Bạn chắc chắn muốn xóa trường này?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    for (int i = 0; i < lvwLDV.SelectedItems.Count; ++i)
                    {
                        index = lvwLDV.SelectedIndices[i];
                        ss = (ServiceStyle)lvwLDV.Items[index].Tag;

                        ServiceStyle.DeleteServiceStyle(ss);
                    }

                    LoadListToView(lvwLDV, ListServiceStyle);
                    ClearInput_1();
                }
            }
        }
        #endregion

        private void radDichVu_CheckedChanged(object sender, EventArgs e)
        {
            if (radDichVu.Checked)
            {
                txtTimKiem.AutoCompleteCustomSource.Clear();
                foreach(dynamic i in ListService)
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(i.Name_Service);
                }
            }
        }

        private void radLoaiDichVu_CheckedChanged(object sender, EventArgs e)
        {
            if (radLoaiDichVu.Checked)
            {
                txtTimKiem.AutoCompleteCustomSource.Clear();
                foreach (ServiceStyle i in ListServiceStyle)
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(i.NameStyle);
                }
            }
        }

        private void frmServiceManagement_Click(object sender, EventArgs e)
        {
            ClearInput();
            ClearInput_1();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (radDichVu.Checked)
            {
                ListService = Service.FindIndex(txtTimKiem.Text);
                LoadListToView(lvwService, ListService);
            }
            if (radLoaiDichVu.Checked)
            {
                ListServiceStyle = ServiceStyle.FindIndex(txtTimKiem.Text);
                LoadListToView(lvwLDV, ListServiceStyle);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ListService = Service.GetAllService();
            LoadListToView(lvwService, ListService);
        }

        private void btnLoadView_Click(object sender, EventArgs e)
        {
            ListServiceStyle = ServiceStyle.GetAllList();
            LoadListToView(lvwLDV, ListServiceStyle);
        }
    }
}
