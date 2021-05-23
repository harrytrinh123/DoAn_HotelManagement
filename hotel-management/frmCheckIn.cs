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
    public partial class frmCheckIn : Form
    {
        private string _idRoom;
        private string _idCustomer;
        clsHonLoan HL = new clsHonLoan();
        public frmCheckIn()
        {
            InitializeComponent();
        }

        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            TaoTieuDeCot(lvwDSNhanPhong);
            clsHonLoan honLoan = new clsHonLoan();
            var dsNP = honLoan.GetDSNhanPhong();
            DuaDataVaoLvwDSNhanPhong(lvwDSNhanPhong, dsNP);
            txtTim.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTim.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void label12_Click_2(object sender, EventArgs e)
        {
            this.Close();
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
            lvwItem.Tag = ttNhan;
            lvwItem.Tag = ttNhan;//nhet vao de su dung muc dich khac (mu dich 1)
            return lvwItem;
        }

        private void DuaDataVaoLvwDSNhanPhong(ListView lvw, IEnumerable<dynamic> dsNhanPhong)
        {
            lvw.Items.Clear();
            ListViewItem itemNP;
            foreach (var np in dsNhanPhong)
            {
                itemNP = GreateItem(np);
                lvw.Items.Add(itemNP);
            }
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
            for (int i = 0; i < lvwDSNhanPhong.Items.Count; i++)
            {
                dp = (dynamic)lvwDSNhanPhong.Items[i].Tag;
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
        private void btnTim_Click(object sender, EventArgs e)
        {
            string strThongTinTim = txtTim.Text;
            int viTriTim = TimKiem(strThongTinTim);
            int viTriChonTruoc;
            //if(viTriTim!=-1)//tim thay
            if (viTriTim >= 0)
            {
                if (lvwDSNhanPhong.SelectedItems.Count > 0)
                {
                    viTriChonTruoc = lvwDSNhanPhong.SelectedIndices[0];
                    lvwDSNhanPhong.Items[viTriChonTruoc].Selected = false;
                }
                lvwDSNhanPhong.Items[viTriTim].Selected = true;
                lvwDSNhanPhong.Focus();
            }
            var dp = (dynamic)(lvwDSNhanPhong.SelectedItems[0].Tag);
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
                _idCustomer = res.id_Customer;
            }
            else
            {
                MessageBox.Show("Số CMND chưa đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            clsRoom Room = new clsRoom();
            Room roomUp = Room.LayThongTinPhong(_idRoom);
            roomUp.Note = txtGhiChu.Text;
            Room.CapNhatTinhTrangPhong(_idRoom, roomUp);
            DuaDataRoomVaoTextBox(Room.LayThongTinPhong(_idRoom));

            clsBookRoom BookRoom = new clsBookRoom();
            BookRoom bRoomUp = BookRoom.GetThongTinBookRoom(_idRoom);
            bRoomUp.dateBooking = dTimeNgayDat.Value;
            bRoomUp.Checkin_Date = dTimeNgayNhan.Value;
            BookRoom.SuaThongTinBookRoomCuaKH(bRoomUp ,_idCustomer);

            clsHonLoan honLoan = new clsHonLoan();
            var dsNP = honLoan.GetDSNhanPhong();
            DuaDataVaoLvwDSNhanPhong(lvwDSNhanPhong, dsNP);
        }

        void XuLyHoTroAutocomlet()
        {

            IEnumerable<dynamic> dsDatPhong;
            dsDatPhong = HL.GetDSNhanPhong();
            txtTim.AutoCompleteCustomSource.Clear();
            if (radTimTheoMa.Checked)
            {
                foreach (var dp in dsDatPhong)
                {
                    txtTim.AutoCompleteCustomSource.Add(dp.cmnd);
                }
            }
            else//theo CPU
            {
                foreach (var dp in dsDatPhong)
                {
                    txtTim.AutoCompleteCustomSource.Add(dp.tenKH);
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

        private void lvwDSNhanPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDSNhanPhong.SelectedItems.Count > 0)
            {
                var dp = (dynamic)(lvwDSNhanPhong.SelectedItems[0].Tag);
                string cmnd = dp.cmnd;
                string idRoom = dp.idRoom;
                ShowThongTinDatPhong(cmnd, idRoom);
            }
        }
    }
}
