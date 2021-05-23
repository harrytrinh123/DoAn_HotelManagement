using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data.Common;

namespace hotel_management
{
    public partial class frmRoomManagement : Form
    {
        public frmRoomManagement()
        {
            InitializeComponent();
        }

        clsRoom room;
        clsStyleRoom roomstyle;

      
        private void frmRoomManagement_Load(object sender, EventArgs e)
        {
            cboThongTinPhongTang.Items.Add("1");
            cboThongTinPhongTang.Items.Add("2");
            cboThongTinPhongTang.Items.Add("3");
            cboThongTinPhongTang.Items.Add("4");
            cboThongTinPhongTang.Items.Add("5");
            cboThongTinPhongTang.Items.Add("6");
            cboThongTinPhongTang.Items.Add("7");
            cboThongTinPhongTang.Items.Add("8");
            cboThongTinPhongTang.Items.Add("9");
            cboThongTinPhongTang.Items.Add("10");
            cboThongTinPhongTang.Items.Add("11");
            cboThongTinPhongTang.Items.Add("12");


            //load lvw Danh Sách Phòng
            createColumnsListRoom(lvwDanhSachPhong);
            room = new clsRoom();
            IEnumerable<Room> lstRoom = room.getALLRoom();
            LoadRoomLenLvw(lvwDanhSachPhong, lstRoom);

            //load lvw Danh Sách Loại Phòng
            createColumnsRoomStyle(lvwDanhSachLoaiPhong);
            roomstyle = new clsStyleRoom();
            IEnumerable<RoomStyle> lstRoomStyle = roomstyle.getALLRoomStyle();
            LoadRoomStyleLenLvw(lvwDanhSachLoaiPhong, lstRoomStyle);

            //autocomlet
           // txtTimKiemThongTinPhong.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txtTimKiemThongTinPhong.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //tạo tiêu đề cột cho Danh Sách Phòng
        void createColumnsListRoom(ListView lvw)
        {
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;

            lvw.Columns.Add("ID Phòng", 120);
            lvw.Columns.Add("Số Phòng", 120);
            lvw.Columns.Add("Tầng", 80);
            lvw.Columns.Add("Trạng thái", 120);
            lvw.Columns.Add("Lưu ý", 180);
            lvw.Columns.Add("ID Loại Phòng", 160);
        }
        //load phòng lên lvw Danh Sách Phòng
        void LoadRoomLenLvw(ListView lvwRoom, IEnumerable<Room> lstRoom)
        {
            lvwRoom.Items.Clear();
            ListViewItem ItemRoom;
            foreach (Room r in lstRoom)
            {
                ItemRoom = CreateItemRoom(r);
                lvwRoom.Items.Add(ItemRoom);
            }
        }
        ListViewItem CreateItemRoom(Room r)
        {
            ListViewItem lvwItem = new ListViewItem();
            lvwItem.Text = r.id_Room;
            lvwItem.SubItems.Add(r.RoomNumber);
            lvwItem.SubItems.Add(r.Grade);
            lvwItem.SubItems.Add(r.Status.ToString());
            lvwItem.SubItems.Add(r.Note);
            lvwItem.SubItems.Add(r.id_RoomStyle);
            lvwItem.Tag = r;

            return lvwItem;
        }

        //tạo tiêu đề cột cho Danh Sách Loại Phòng
        void createColumnsRoomStyle(ListView lvw)
        {
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;

            lvw.Columns.Add("ID Loại Phòng", 180);
            lvw.Columns.Add("Tên Loại Phòng", 180);
            lvw.Columns.Add("Giá Loại Phòng", 180);

        }
        //load phòng lên lvw Danh Sách Loại Phòng
        void LoadRoomStyleLenLvw(ListView lvwRoomStyle, IEnumerable<RoomStyle> lstRoomStyle)
        {
            lvwRoomStyle.Items.Clear();
            ListViewItem ItemRoomStyle;
            foreach (RoomStyle rs in lstRoomStyle)
            {
                ItemRoomStyle = CreateItemRoomStyle(rs);
                lvwRoomStyle.Items.Add(ItemRoomStyle);
            }
        }
        ListViewItem CreateItemRoomStyle(RoomStyle rs)
        {
            ListViewItem lvwItemRoomStyle = new ListViewItem();
            lvwItemRoomStyle.Text = rs.id_RoomStyle;
            lvwItemRoomStyle.SubItems.Add(rs.NameStyle);
            lvwItemRoomStyle.SubItems.Add(rs.Price.ToString());
            lvwItemRoomStyle.Tag = rs;

            return lvwItemRoomStyle;
        }

        //load ngược lại qua các txt, cbo Danh Sách Phòng
        private void lvwDanhSachPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Room r = null; 
            if(lvwDanhSachPhong.SelectedItems.Count > 0)
            {
                r = (Room)lvwDanhSachPhong.SelectedItems[0].Tag;
                RoomToTxt(r);
                btnXoaThongTinPhong.Enabled = true;
                btnSuaThongTinPhong.Enabled = true;
            }
        }
        void RoomToTxt(Room r)
        {
            txtThongTinPhongID.Text = r.id_Room;
            txtThongTinPhongSoPhong.Text = r.RoomNumber;
            cboThongTinPhongTang.Text = r.Grade;
            txtThongTinPhongTrangThai.Text = r.Status.ToString();
            txtThongTinPhongLuuY.Text = r.Note;
            txtThongTinIDLoaiPhong.Text = r.id_RoomStyle;
        }

        //load ngược lại qua các txt Danh Sách Loại Phòng
        private void lvwDanhSachLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomStyle rs = null;
            if(lvwDanhSachLoaiPhong.SelectedItems.Count > 0)
            {
                rs = (RoomStyle)lvwDanhSachLoaiPhong.SelectedItems[0].Tag;
                RoomStyleToTxt(rs);
                btnXoaLoaiPhong.Enabled = true;
                btnSuaLoaiPhong.Enabled = true;
            }
        }
        void RoomStyleToTxt(RoomStyle rs)
        {
            txtLoaiPhongID.Text = rs.id_RoomStyle;
            txtLoaiPhongTen.Text = rs.NameStyle;
            txtLoaiPhongGia.Text = rs.Price.ToString();
        }


        //event thêm vào Danh Sách Phòng
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            IEnumerable<Room> lstRoom = room.getALLRoom();
            Room r = createRoom();
            foreach (Room item in room.getALLRoom())
            {
                if(txtThongTinPhongID.Text == item.id_Room)
                {
                    MessageBox.Show("Trùng ID phòng!. Nhập lại", "Thông báo");
                    return;
                }
            }

            room.insertRoom(r);
            LoadRoomLenLvw(lvwDanhSachPhong, lstRoom);
            txtThongTinPhongID.Clear();
            txtThongTinPhongSoPhong.Clear();
            cboThongTinPhongTang.Text = "";
            txtThongTinPhongTrangThai.Clear();
            txtThongTinPhongLuuY.Clear();
            txtThongTinIDLoaiPhong.Clear();
        }
        Room createRoom()
        {
            Room r = new Room();
            r.id_Room = txtThongTinPhongID.Text;
            r.RoomNumber = txtThongTinPhongSoPhong.Text;
            r.Grade = cboThongTinPhongTang.Text;
            r.Status = Convert.ToBoolean(txtThongTinPhongTrangThai.Text);
            r.Note = txtThongTinPhongLuuY.Text;
            r.id_RoomStyle = txtThongTinIDLoaiPhong.Text;

            return r;
        }

        //event thêm vào Danh Sách Loại Phòng
        private void btnThemLoaiPhong_Click(object sender, EventArgs e)
        {
            IEnumerable<RoomStyle> lstRoomStyle = roomstyle.getALLRoomStyle();
            RoomStyle rs = createRoomStyle();
            foreach (RoomStyle item in roomstyle.getALLRoomStyle())
            {
                if(txtLoaiPhongID.Text == item.id_RoomStyle)
                {
                    MessageBox.Show("Trùng ID loại phòng!. Nhập lại", "Thông báo");
                    return;
                }
            }

            roomstyle.insertRoomStyle(rs);
            LoadRoomStyleLenLvw(lvwDanhSachLoaiPhong, lstRoomStyle);
            txtLoaiPhongID.Clear();
            txtLoaiPhongTen.Clear();
            txtLoaiPhongGia.Clear();
        }
        RoomStyle createRoomStyle()
        {
            RoomStyle rs = new RoomStyle();
            rs.id_RoomStyle = txtLoaiPhongID.Text;
            rs.NameStyle = txtLoaiPhongTen.Text;
            rs.Price = Convert.ToDecimal(txtLoaiPhongGia.Text);

            return rs;
        }

        //event xóa trong Danh Sách Phòng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult messge;
            Room r;
            int vitTriThuc;
            IEnumerable<Room> lstRoom = room.getALLRoom();

            if (lvwDanhSachPhong.SelectedItems.Count > 0)
            {
                messge = MessageBox.Show("Bạn có muốn xóa thông tin phòng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if(messge == DialogResult.Yes)
                {
                    for (int i = 0; i < lvwDanhSachPhong.SelectedItems.Count; i++)
                    {
                        vitTriThuc = lvwDanhSachPhong.SelectedIndices[i];
                        r = (Room)lvwDanhSachPhong.Items[vitTriThuc].Tag;
                        room.deleteRoom(r);
                    }
                    LoadRoomLenLvw(lvwDanhSachPhong, lstRoom);
                    txtThongTinPhongID.Clear();
                    txtThongTinPhongSoPhong.Clear();
                    cboThongTinPhongTang.Text = "";
                    txtThongTinPhongTrangThai.Clear();
                    txtThongTinPhongLuuY.Clear();
                    txtThongTinIDLoaiPhong.Clear();
                    btnXoaThongTinPhong.Enabled = false;
                }
            }
        }

        //event xóa trong Danh Sách Loại Phòng
        private void btnXoaLoaiPhong_Click(object sender, EventArgs e)
        {
            DialogResult messge;
            RoomStyle rs;
            int vitTriThuc;
            IEnumerable<RoomStyle> lstRoomStyle = roomstyle.getALLRoomStyle();

            if (lvwDanhSachLoaiPhong.SelectedItems.Count > 0)
            {
                messge = MessageBox.Show("Bạn có muốn xóa thông tin phòng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (messge == DialogResult.Yes)
                {
                    for (int i = 0; i < lvwDanhSachLoaiPhong.SelectedItems.Count; i++)
                    {
                        vitTriThuc = lvwDanhSachLoaiPhong.SelectedIndices[i];
                        rs = (RoomStyle)lvwDanhSachLoaiPhong.Items[vitTriThuc].Tag;
                        roomstyle.deleteRoomStyle(rs);
                    }
                    LoadRoomStyleLenLvw(lvwDanhSachLoaiPhong, lstRoomStyle);
                    txtLoaiPhongID.Clear();
                    txtLoaiPhongTen.Clear();
                    txtLoaiPhongGia.Clear();
                    btnXoaThongTinPhong.Enabled = false;
                }
            }
        }

        //event Sửa trong Danh Sách Phòng
        private void btnSua_Click(object sender, EventArgs e)
        {
            IEnumerable<Room> lstRoom = room.getALLRoom();
            Room r = createRoom();
            room.updateRoom(r);
            LoadRoomLenLvw(lvwDanhSachPhong, lstRoom);
            btnSuaThongTinPhong.Enabled = false;
        }

        //event Sửa trong Danh Sách Loại Phòng
        private void btnSuaLoaiPhong_Click(object sender, EventArgs e)
        {
            IEnumerable<RoomStyle> lstRoomStyle = roomstyle.getALLRoomStyle();
            RoomStyle rs = createRoomStyle();
            roomstyle.updateRoomStyle(rs);
            LoadRoomStyleLenLvw(lvwDanhSachLoaiPhong, lstRoomStyle);
            btnSuaLoaiPhong.Enabled = false;
        }

        //event tìm kiếm trong Danh Sách Phòng
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string strInf = txtTimKiemThongTinPhong.Text;
            int index = Search(strInf);
            int indexBefore;
            if(index >= 0)
            {
                if (lvwDanhSachPhong.SelectedItems.Count > 0)
                {
                    indexBefore = lvwDanhSachPhong.SelectedIndices[0];
                    lvwDanhSachPhong.Items[indexBefore].Selected = false;
                }
                lvwDanhSachPhong.Items[index].Selected = true;
                lvwDanhSachPhong.Focus();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã!", "Thông báo");
            }
        }
        //tìm theo id Phòng và id Loại Phòng
        int Search(string strValue)
        {
            dynamic r;
            for(int i = 0; i < lvwDanhSachPhong.Items.Count; i++)
            {
                r = lvwDanhSachPhong.Items[i].Tag;
                if (r.id_Room.Equals(strValue))
                {
                    return i;
                }
            }
            return -1;
        }

        //event tìm kiếm trong Danh Sách Loại Phòng
        private void btnTimKiemLoaiPhong_Click(object sender, EventArgs e)
        {
            string strInf = txtTimKiemLoaiPhong.Text;
            int index = SearchRoomStyle(strInf);
            int indexBefore;
            if (index >= 0)
            {
                if (lvwDanhSachLoaiPhong.SelectedItems.Count > 0)
                {
                    indexBefore = lvwDanhSachLoaiPhong.SelectedIndices[0];
                    lvwDanhSachLoaiPhong.Items[indexBefore].Selected = false;
                }
                lvwDanhSachLoaiPhong.Items[index].Selected = true;
                lvwDanhSachLoaiPhong.Focus();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã!", "Thông báo");
            }
        }
        int SearchRoomStyle(string strValue)
        {
            dynamic r;
            for (int i = 0; i < lvwDanhSachLoaiPhong.Items.Count; i++)
            {
                r = lvwDanhSachLoaiPhong.Items[i].Tag;
                if (r.id_RoomStyle.Equals(strValue))
                {
                    return i;
                }
            }
            return -1;
        }

        //event Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Bạn có muốn thoát chức năng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (message == DialogResult.Yes)
                this.Close();
        }

        //event xử lý các methods
        //id Room
        private void txtRoomID(object sender, EventArgs e)
        {
            string strID = txtThongTinPhongID.Text;
            if(strID.CheckID() == false)
            {
                MessageBox.Show("Nhập đúng định dạng ID: R-X, R-XX, R-XXX (X là số từ 0-9)", "Thông báo");
                txtThongTinPhongID.SelectAll();
                txtThongTinPhongID.Focus();
            }
        }
        //id StyleRoom
        private void txtStyleRoomID(object sender, EventArgs e)
        {
            string strID = txtLoaiPhongID.Text;
            if (strID.CheckIDStyleRoom() == false)
            {
                MessageBox.Show("Nhập đúng định dạng ID loại phòng: R, RR, RRR (R là các chữ cái từ a-z)", "Thông báo");
                txtLoaiPhongID.SelectAll();
                txtLoaiPhongID.Focus();
            }
        }
        //Số Room
        private void txtNumbersRoom(object sender, EventArgs e)
        {
            string strNR = txtThongTinPhongSoPhong.Text;
            if(strNR.CheckNumbersRoom() == false)
            {
                MessageBox.Show("Nhập đúng định dạng số phòng: X, XX, XXX (X là các số từ 1-9)", "Thông báo");
                txtThongTinPhongSoPhong.SelectAll();
                txtThongTinPhongSoPhong.Focus();
            }
        }
        //chk Tầng
        private void txtGradeRoom(object sender, EventArgs e)
        {
            string strGrs = cboThongTinPhongTang.Text;
            if (strGrs.CheckGradeRoom() == false)
            {
                MessageBox.Show("Nhập đúng định dạng số tầng: X, XX (X là các số từ 0-9, 0 là tầng trệch)", "Thông báo");
                cboThongTinPhongTang.SelectAll();
                cboThongTinPhongTang.Focus();
            }
        }
        //chk trạng thái phòng
        private void txtStatusRoom(object sender, EventArgs e)
        {
            string strSt = txtThongTinPhongTrangThai.Text;
            if (strSt.CheckStatusRoom() == false)
            {
                MessageBox.Show("Nhập đúng định dạng số tầng: True hoặc False", "Thông báo");
                txtThongTinPhongTrangThai.SelectAll();
                txtThongTinPhongTrangThai.Focus();
            }
        }
        //chk id Loại Phòng
        private void txtIDStyleRoomLst(object sender, EventArgs e)
        {
            string strID = txtThongTinIDLoaiPhong.Text;
            if (strID.CheckIDStyleRoomLst() == false)
            {
                MessageBox.Show("Nhập đúng định dạng ID: R, RR, RRR (R là các chữ cái từ a-z)", "Thông báo");
                txtThongTinIDLoaiPhong.SelectAll();
                txtThongTinIDLoaiPhong.Focus();
            }
        }
        //chk Tên Loại Phòng
        private void txtNameStyleRoom(object sender, EventArgs e)
        {
            string strName = txtLoaiPhongTen.Text;
            if (strName.CheckNameStyleRoom() == false)
            {
                MessageBox.Show("Nhập đúng định dạng tên lọai phòng: Vip, Thuong, Cao Cap", "Thông báo");
                txtLoaiPhongTen.SelectAll();
                txtLoaiPhongTen.Focus();
            }
        }
        //chk giá
        private void txtPriceStyleRoom(object sender, EventArgs e)
        {
            string strPr = txtLoaiPhongGia.Text;
            if (strPr.CheckPriceStyleRoom() == false)
            {
                MessageBox.Show("Nhập giá phải lớn hơn 0", "Thông báo");
                txtLoaiPhongGia.SelectAll();
                txtLoaiPhongGia.Focus();
            }
        }
        //Note
        private void txtNoteRoom(object sender, EventArgs e)
        {
            string strNt = txtThongTinPhongLuuY.Text;
            if (strNt.CheckNoteRoom() == false)
            {
                MessageBox.Show("Không nhập số và không nhập quá 22 ký tự", "Thông báo");
                txtThongTinPhongLuuY.SelectAll();
                txtThongTinPhongLuuY.Focus();
            }
        }
    }
}

