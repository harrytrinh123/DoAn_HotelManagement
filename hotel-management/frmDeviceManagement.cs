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
    public partial class frmDeviceManagement : Form
    {
        public frmDeviceManagement()
        {
            InitializeComponent();
        }
        private clsDevice Equipment;
        private IEnumerable<Equipment> ListEquipment;
        private void frmDeviceManagement_Load_1(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            createListView(lvwThietBi);
            Equipment = new clsDevice();
            ListEquipment = Equipment.getListEquipment();
            LoadItemToView(lvwThietBi, ListEquipment);
        }
        //Tạo listview cho danh sách thiết bị
        private void createListView(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Id", 200);
            lvw.Columns.Add("Name", 200);
            lvw.Columns.Add("Price", 200);
        }
        //Load danh sách lên view
        private void LoadItemToView(ListView lvw, IEnumerable<Equipment> list)
        {
            lvw.Items.Clear();
            ListViewItem item;
            foreach (Equipment i in list)
            {
                item = GreateItemEquipment(i);
                lvw.Items.Add(item);
            }
        }
        private ListViewItem GreateItemEquipment(Equipment m)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(m.id_Equipment);
            lvwItem.SubItems.Add(m.name_Equipment);
            lvwItem.SubItems.Add(m.Price.ToString());
            lvwItem.Tag = m;
            lvwItem.ImageIndex = 0;
            return lvwItem;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void lvwDSTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipment Equipment = null;
            if (lvwThietBi.SelectedItems.Count > 0)
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                Equipment = (Equipment)lvwThietBi.SelectedItems[0].Tag;
                EquipmentToTextBox(Equipment);
            }
        }
        private void EquipmentToTextBox(Equipment Equipment)
        {           
            textBox1.Text = Equipment.id_Equipment;
            txtTen.Text = Equipment.name_Equipment;
            txtGia.Text = Equipment.Price.ToString();
        }
        private Equipment CreateEquipment()
        {
            Equipment Equipment = new Equipment();
            Equipment.id_Equipment = textBox1.Text;
            Equipment.name_Equipment = txtTen.Text;
            Equipment.Price = Convert.ToDecimal(txtGia.Text);
            return Equipment;
        }
       
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Equipment equipment = CreateEquipment();
            Equipment.InsertEquipment(equipment);
            LoadItemToView(lvwThietBi, ListEquipment);
        }
       
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult res;
            Equipment s;
            int index;
            if (lvwThietBi.SelectedItems.Count > 0)
            {
                res = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    for (int i = 0; i < lvwThietBi.SelectedItems.Count; ++i)
                    {
                        index = lvwThietBi.SelectedIndices[i];
                        s = (Equipment)lvwThietBi.Items[index].Tag;

                        Equipment.DeleteEquipment(s);
                    }

                    LoadItemToView(lvwThietBi, ListEquipment);
                    btnXoa.Enabled = false;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvwThietBi.SelectedItems.Count > 0)
            {
                Equipment s = CreateEquipment();
                Equipment.ChangeEquipment(s);
                LoadItemToView(lvwThietBi, ListEquipment);
                btnSua.Enabled = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ListEquipment = Equipment.FindIndex(txtTimKiem.Text);           
            LoadItemToView(lvwThietBi,ListEquipment);
            txtTimKiem.Clear();
        }

        private void btnALL_Click(object sender, EventArgs e)
        {
            ListEquipment = Equipment.getListEquipment();
            LoadItemToView(lvwThietBi, ListEquipment);            
        }
    }
}
