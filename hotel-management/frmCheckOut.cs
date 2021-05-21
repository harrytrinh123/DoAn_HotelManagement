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
    public partial class frmCheckOut : Form
    {
        private string _idCustomer;
        private string _idRoom;
        private string _idBRoom;
        clsHonLoan HL = new clsHonLoan();
        clsCustomer CUS = new clsCustomer();
        clsRoom ROOM = new clsRoom();
        clsService SER = new clsService();
        clsBookRoom BOOKR = new clsBookRoom();
        clsBill_Service BilService = new clsBill_Service();
        public double TongTien { get; set; }
        
        public frmCheckOut()
        {
            InitializeComponent();
        }



        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            TaoTieuDeCot(lvwDSTraPhong);
            var dsTraPhong = HL.GetDSDangThue();
            DuaDataVaoLvwDSNhanPhong(lvwDSTraPhong, dsTraPhong);
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;

            LoadServiceToCBB(cboTenDichVu);
        }

        void TaoTieuDeCot(ListView lvw)
        {
            //tao cot
            lvw.Columns.Add("CMND/CCCD", 100);
            lvw.Columns.Add("Tên KH", 100);
            lvw.Columns.Add("Số điện thoại: ", 100);
            lvw.Columns.Add("Ngày nhận", 100);
            lvw.Columns.Add("Ngày trả", 100);
            lvw.Columns.Add("Số phòng", 100);
            lvw.Columns.Add("Tình trạng", 100);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;

        }

        ListViewItem GreateItem(dynamic ttNhan)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(ttNhan.cmnd);
            lvwItem.SubItems.Add(ttNhan.tenKH);
            lvwItem.SubItems.Add(ttNhan.soDT);
            lvwItem.SubItems.Add(ttNhan.ngayNhan.ToString());
            lvwItem.SubItems.Add(ttNhan.ngayTra.ToString());
            lvwItem.SubItems.Add(ttNhan.soPhong.ToString());
            lvwItem.SubItems.Add((ttNhan.roomStatus) ? "Đang thuê": "Chưa nhận phòng");
            lvwItem.Tag = ttNhan;
            lvwItem.Tag = ttNhan;//nhet vao de su dung muc dich khac (mu dich 1)
            return lvwItem;
        }

        private void DuaDataVaoLvwDSNhanPhong(ListView lvw, IEnumerable<dynamic> dsDangThue)
        {
            lvw.Items.Clear();
            ListViewItem item;
            foreach (var dThue in dsDangThue)
            {
                item = GreateItem(dThue);
                lvw.Items.Add(item);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmHoaDon>().Count() == 1)
                Application.OpenForms.OfType<frmHoaDon>().First().Close();

            var dsDichVu = HL.getDSDichVu(_idBRoom);
            frmHoaDon frm = new frmHoaDon(dsDichVu, _idCustomer, _idBRoom, _idRoom);
            frm.Show();
        }

        void XuLyHoTroAutocomlet()
        {

            IEnumerable<dynamic> dsDangThue;
            dsDangThue = HL.GetDSDangThue();
            txtTimKiem.AutoCompleteCustomSource.Clear();
            if (radTimTheoMa.Checked)
            {
                foreach (var dp in dsDangThue)
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(dp.cmnd);
                }
            }
            else//theo CPU
            {
                foreach (var dp in dsDangThue)
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(dp.tenKH);
                }
            }
        }

        private void radTimTheoMa_CheckedChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
        }

        private void radTimTheoTen_CheckedChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
        }

        private void DuaDataKhachHangVaoTextBox(Customer cus)
        {
            txtCMND.Text = cus.id_Customer;
            txtDiaChi.Text = cus.address;
            txtSoDT.Text = cus.phone;
            txtTenKH.Text = cus.name;
        }

        private void DuaDataBookRoomVaoTextBox(BookRoom bRoom)
        {
            dTimeNgayDat.Value = bRoom.dateBooking;
            dTimeNgayNhan.Value = bRoom.Checkin_Date;
            txtSoNguoi.Text = bRoom.peopleCount.ToString();
        }
        private void DuaDataRoomVaoTextBox(Room room)
        {
            txtSoPhong.Text = room.RoomNumber;
            txtTang.Text = room.Grade;
            txtTinhTrang.Text = room.Status ? "Đang thuê" : "Còn trống";
            txtGhiChu.Text = room.Note;
        }

        int TimKiem(string strGiaTriTim)
        {
            dynamic dp;
            for (int i = 0; i < lvwDSTraPhong.Items.Count; i++)
            {
                dp = (dynamic)lvwDSTraPhong.Items[i].Tag;
                if (radTimTheoMa.Checked)
                {
                    if (dp.cmnd.Equals(strGiaTriTim))
                        return i;
                }
                else
                {
                    if (dp.tenKH.Equals(strGiaTriTim))
                        return i;
                }
            }
            return -1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string strThongTinTim = txtTimKiem.Text;
            int viTriTim = TimKiem(strThongTinTim);
            int viTriChonTruoc;
            //if(viTriTim!=-1)//tim thay
            if (viTriTim >= 0)
            {
                if (lvwDSTraPhong.SelectedItems.Count > 0)
                {
                    viTriChonTruoc = lvwDSTraPhong.SelectedIndices[0];
                    lvwDSTraPhong.Items[viTriChonTruoc].Selected = false;
                }
                lvwDSTraPhong.Items[viTriTim].Selected = true;
                lvwDSTraPhong.Focus();
            }
            var dp = (dynamic)(lvwDSTraPhong.SelectedItems[0].Tag);
            string cmnd = dp.cmnd;
            string idRoom = dp.idRoom;
            ShowThongTinDatPhong(cmnd, idRoom);
        }

        private void ShowThongTinDatPhong(string cmnd, string idRoom)
        {
            clsCustomer clsCus = new clsCustomer();
            Customer res = clsCus.checkIfExist(cmnd);


            if (res != null)
            {

                DuaDataKhachHangVaoTextBox(res);
                clsBookRoom clsBRoom = new clsBookRoom();
                var ttbRoom = clsBRoom.GetThongTinBookRoomCuaKhach(res.id_Customer);
                DuaDataBookRoomVaoTextBox(ttbRoom);

                clsRoom Room = new clsRoom();
                var ttRoom = Room.LayThongTinPhong(idRoom);
                DuaDataRoomVaoTextBox(ttRoom);
                _idRoom = ttRoom.id_Room;
                _idBRoom = ttbRoom.id_BookRoom;
                _idCustomer = res.id_Customer;
            }
            else
            {
                MessageBox.Show("Số CMND chưa đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lvwDSNhanPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDSTraPhong.SelectedItems.Count > 0)
            {
                var dp = (dynamic)(lvwDSTraPhong.SelectedItems[0].Tag);
                string cmnd = dp.cmnd;
                string idRoom = dp.idRoom;
                ShowThongTinDatPhong(cmnd, idRoom);
            }
        }


        private void LoadServiceToCBB(ComboBox cbo)
        {
            foreach(var item in SER.GetAllService())
            {
                cbo.Items.Add(item.Name_Service);
            }
        }


        private void cboTenDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cboTenDichVu.GetItemText(this.cboTenDichVu.SelectedItem);
            Service ser = SER.GetServiceByName(selected);
            string idService = ser.id_Service;
            var dsDV = HL.getDSDichVu(_idBRoom);
            
            
            int count = 0;
            foreach (var item in dsDV)
            {
                if (item.idService == ser.id_Service)
                {
                    count = item.count;
                }
            }
            numUpDown.Value = count;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Room roomUp = ROOM.LayThongTinPhong(_idRoom);
            roomUp.Note = txtGhiChu.Text;
            

            BookRoom bRoomUp = BOOKR.GetThongTinBookRoom(_idRoom);
            bRoomUp.dateBooking = dTimeNgayDat.Value;
            bRoomUp.Checkin_Date = dTimeNgayNhan.Value;
            
            

            var checkRoom = ROOM.CapNhatTinhTrangPhong(_idRoom, roomUp);
            
            var checkBRoom = BOOKR.SuaThongTinBookRoomCuaKH(bRoomUp, _idCustomer);
            var sl = Convert.ToInt32(numUpDown.Value);
            string idService = SER.GetServiceByName(cboTenDichVu.Text).id_Service;
            var checkSRService = BilService.CapNhatSoLuong(_idRoom, idService, sl);
            if(checkBRoom&&checkRoom&&checkSRService)
            {
                DuaDataRoomVaoTextBox(ROOM.LayThongTinPhong(_idRoom));
                DuaDataBookRoomVaoTextBox(bRoomUp);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
