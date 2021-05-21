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
    public partial class frmBookRoom : Form
    {
        public frmBookRoom()
        {
            InitializeComponent();
        }

        clsBookRoom b;
        clsCustomer c;
        clsRoom r;
        clsJoinBRandRom jBR;
        private void frmBookRoom_Load(object sender, EventArgs e)
        {
            b = new clsBookRoom();
            IEnumerable<BookRoom> br = b.getListBookRoom();
            c = new clsCustomer();
            r = new clsRoom();
            jBR = new clsJoinBRandRom();
            createTitle(lvwDSDatPhong);
            loadRoomListView(lvwDSDatPhong, br);
        }

        // load dữ liệu lên list view
        private void loadRoomListView(ListView lvwDSDatPhong, IEnumerable<BookRoom> br)
        {
            lvwDSDatPhong.Items.Clear();
            ListViewItem lvwItem;
            foreach (BookRoom i in br)
            {
                lvwItem = createItem(i);
                lvwDSDatPhong.Items.Add(lvwItem);
            }
        }

        private ListViewItem createItem(BookRoom i)
        {
            ListViewItem item;
            item = new ListViewItem(i.id_BookRoom);
            item.SubItems.Add(i.peopleCount.ToString());
            item.SubItems.Add(i.dateBooking.ToString());
            item.SubItems.Add(i.Checkin_Date.ToString());
            item.SubItems.Add(i.Checkout_Date.ToString());
            item.SubItems.Add(i.id_Room);
            item.SubItems.Add(i.id_Customer);
            item.Tag = i;
            return item;
        }

        private void createTitle(ListView lvwDSDatPhong)
        {
            lvwDSDatPhong.Columns.Add("ID BookRoom", 60);
            lvwDSDatPhong.Columns.Add("Số lượng khách hàng", 60);
            lvwDSDatPhong.Columns.Add("Ngày đặt phòng", 140);
            lvwDSDatPhong.Columns.Add("Ngày nhận phòng", 140);
            lvwDSDatPhong.Columns.Add("Ngày trả phòng", 140);
            lvwDSDatPhong.Columns.Add("ID Phòng", 60);
            lvwDSDatPhong.Columns.Add("ID Khác hàng", 60);

            lvwDSDatPhong.View = View.Details;
            //lvwDSDatPhong.GridLines = true;
            //lvwDSDatPhong.FullRowSelect = true;
        }

        // sự kiện chọn chuyển sang text box
        private void lvwDSDatPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookRoom br = null;
            if (lvwDSDatPhong.SelectedItems.Count > 0)
            {
                br = (BookRoom)lvwDSDatPhong.SelectedItems[0].Tag;
                dataToTextBox(br);
                DoiMauButton(btn101, btn102, btn103, btn104, btn105, btn106, btn107, btn108, btn109, btn110, btn111, btn112);
                DoiMauButton(btn102, btn101, btn103, btn104, btn105, btn106, btn107, btn108, btn109, btn110, btn111, btn112);
                DoiMauButton(btn103, btn102, btn101, btn104, btn105, btn106, btn107, btn108, btn109, btn110, btn111, btn112);
                DoiMauButton(btn104, btn102, btn103, btn101, btn105, btn106, btn107, btn108, btn109, btn110, btn111, btn112);
                DoiMauButton(btn105, btn102, btn103, btn104, btn101, btn106, btn107, btn108, btn109, btn110, btn111, btn112);
                DoiMauButton(btn106, btn102, btn103, btn104, btn105, btn101, btn107, btn108, btn109, btn110, btn111, btn112);
                DoiMauButton(btn107, btn102, btn103, btn104, btn105, btn106, btn101, btn108, btn109, btn110, btn111, btn112);
                DoiMauButton(btn108, btn102, btn103, btn104, btn105, btn106, btn107, btn101, btn109, btn110, btn111, btn112);
                DoiMauButton(btn109, btn102, btn103, btn104, btn105, btn106, btn107, btn108, btn101, btn110, btn111, btn112);
                DoiMauButton(btn110, btn102, btn103, btn104, btn105, btn106, btn107, btn108, btn109, btn101, btn111, btn112);
                DoiMauButton(btn111, btn102, btn103, btn104, btn105, btn106, btn107, btn108, btn109, btn110, btn101, btn112);
                DoiMauButton(btn112, btn102, btn103, btn104, btn105, btn106, btn107, btn108, btn109, btn110, btn111, btn101);
            }
        }

        private void dataToTextBox(BookRoom br)
        {
            //lấy thông tin bookroom
            txtBookRoom.Text = br.id_BookRoom;
            txtCMND.Text = br.id_Customer;
            txtCountKH.Text = br.peopleCount.ToString();
            dTimeNgayNhan.Value = br.Checkin_Date;
            dTimeNgayTra.Value = br.Checkout_Date;
            dTimeDatPhong.Value = br.dateBooking;

            //Lấy thông tin khách đặt phòng
            foreach (Customer item in c.getListCustomer())
            {
                if (br.id_Customer.Equals(item.id_Customer))
                {
                    txtHoTen.Text = item.name;
                    txtDiaChi.Text = item.address;
                    txtSoDienThoai.Text = item.phone;
                    dTimeNgaySinh.Value = item.birthday;
                    cboGioiTinh.Text = item.sex;
                }
            }

            //lấy thông tên phòng
            foreach (Room i in r.getListRoom())
            {
                if (br.id_Room.Equals(i.id_Room))
                {
                    txtPhong.Text = i.RoomNumber;
                    cboLoaiPhong.Text = i.id_RoomStyle;
                }
            }

        }
        //đổi màu button
        void DoiMauButton(Button btn1, Button btn2, Button btn3, Button btn4, Button btn5, Button btn6, Button btn7, Button btn8, 
                          Button btn9, Button btn10, Button btn11, Button btn12)
        {
            if (txtPhong.Text.Equals(btn1.Text))
            {
                btn1.BackColor = Color.Red;
                btn2.BackColor = Color.FromArgb(224, 224, 224);
                btn3.BackColor = Color.FromArgb(224, 224, 224);
                btn4.BackColor = Color.FromArgb(224, 224, 224);
                btn5.BackColor = Color.FromArgb(224, 224, 224);
                btn6.BackColor = Color.FromArgb(224, 224, 224);
                btn7.BackColor = Color.FromArgb(224, 224, 224);
                btn8.BackColor = Color.FromArgb(224, 224, 224);
                btn9.BackColor = Color.FromArgb(224, 224, 224);
                btn10.BackColor = Color.FromArgb(224, 224, 224);
                btn11.BackColor = Color.FromArgb(224, 224, 224);
                btn12.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void btnDatPhong_Click_1(object sender, EventArgs e)
        {
            foreach (BookRoom item in b.getListBookRoom())
            {
                if (txtBookRoom.Text == item.id_BookRoom)
                {
                    MessageBox.Show("Trùng mã phòng", "Thông báo");
                    return;
                }
            }
            foreach (var item in jBR.getNumberRoom())
            {
                if (txtPhong.Text.Equals(item.sophong))
                {
                    MessageBox.Show("Phòng đã có người đặt", "Thông báo");
                    return;
                }
            }
            BookRoom br = createBookRoom();
            b.insertBookRoom(br);
            IEnumerable<BookRoom> getBR = b.getListBookRoom();
            loadRoomListView(lvwDSDatPhong, getBR);
        }

        private BookRoom createBookRoom()
        {
            string room_number = txtPhong.Text;
            string id_room = r.GetRoomByNumberRoom(room_number).id_Room;
            BookRoom br = b.GetBookRoomByIDRoom(id_room);

            if (br == null)
            {
                br = new BookRoom()
                {
                    id_BookRoom = txtBookRoom.Text,
                    peopleCount = Convert.ToInt32(txtCountKH.Text),
                    dateBooking = dTimeDatPhong.Value,
                    Checkin_Date = dTimeNgayNhan.Value,
                    Checkout_Date = dTimeNgayTra.Value,
                    id_Room = id_room,
                    id_Customer = txtCMND.Text,                   
                };
               
            }
            return br;
        }
        //tìm phòng
        private void btnTimPhong_Click(object sender, EventArgs e)
        {
            if(txtTimPhong.Text != "")
            {
                foreach (var item in jBR.getNumberRoom())
                {
                    if (txtTimPhong.Text.Equals(item.sophong))// kiểm tra mã phòng có trong danh sách book room hay không
                    {
                        IEnumerable<BookRoom> br = b.getListBookRoom();
                        string strSearch = SearchIdRoomInClassJoin(br);
                        if (strSearch != null)
                        {
                            br = b.GetIEnumerableBookRoomByIDRoom(strSearch); // tìm id room trong book room dựa trên từ khóa 
                            loadRoomListView(lvwDSDatPhong, br);
                            //index=lvwDSDatPhong.SelectedIndices[0];
                            //lvwDSDatPhong.Items[index].Selected = true;
                            //lvwDSDatPhong.Focus();
                            txtTimPhong.Clear();
                            return;
                        }
                    }
                }
                MessageBox.Show("Phòng còn trống, không có trong danh sách đặt phòng", "Thông báo");
            }
            else
            {
                MessageBox.Show("Chưa nhập số phòng", "Thông báo");
                return;
            }

        }

        //tìm id room của bảng book rom trong bảng hỗn loạn trả về 1 id
        private string SearchIdRoomInClassJoin(IEnumerable<BookRoom> br)
        {
            foreach (BookRoom item in br)
            {
                foreach (var j in jBR.getNumberRoom())
                {
                    if((txtTimPhong.Text==j.sophong)&&(item.id_Room == j.maphong))
                    {
                        return j.maphong.ToString();
                    }
                }
            }
            return null;
        }
        //dấu x
        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // click đổi màu button
        private void btn101_Click(object sender, EventArgs e)
        {
            ClickDoiMauButton(btn101, btn102, btn103, btn104, btn105, btn106, btn107, btn108, btn109, btn110, btn111, btn112);
            ClickDoiMauButton(btn102, btn101, btn103, btn104, btn105, btn106, btn107, btn108, btn109, btn110, btn111, btn112);
            ClickDoiMauButton(btn103, btn102, btn101, btn104, btn105, btn106, btn107, btn108, btn109, btn110, btn111, btn112);
            ClickDoiMauButton(btn104, btn102, btn103, btn101, btn105, btn106, btn107, btn108, btn109, btn110, btn111, btn112);
            ClickDoiMauButton(btn105, btn102, btn103, btn104, btn101, btn106, btn107, btn108, btn109, btn110, btn111, btn112);
            ClickDoiMauButton(btn106, btn102, btn103, btn104, btn105, btn101, btn107, btn108, btn109, btn110, btn111, btn112);
            ClickDoiMauButton(btn107, btn102, btn103, btn104, btn105, btn106, btn101, btn108, btn109, btn110, btn111, btn112);
            ClickDoiMauButton(btn108, btn102, btn103, btn104, btn105, btn106, btn107, btn101, btn109, btn110, btn111, btn112);
            ClickDoiMauButton(btn109, btn102, btn103, btn104, btn105, btn106, btn107, btn108, btn101, btn110, btn111, btn112);
            ClickDoiMauButton(btn110, btn102, btn103, btn104, btn105, btn106, btn107, btn108, btn109, btn101, btn111, btn112);
            ClickDoiMauButton(btn111, btn102, btn103, btn104, btn105, btn106, btn107, btn108, btn109, btn110, btn101, btn112);
            ClickDoiMauButton(btn112, btn102, btn103, btn104, btn105, btn106, btn107, btn108, btn109, btn110, btn111, btn101);
        }

        void ClickDoiMauButton(Button btn1, Button btn2, Button btn3, Button btn4, Button btn5, Button btn6, Button btn7, Button btn8,
                          Button btn9, Button btn10, Button btn11, Button btn12)
        {
            if (btn1.Focused == true)
            {
                btn1.BackColor = Color.Yellow;
                txtPhong.Text = btn1.Text;
                btn2.BackColor = Color.FromArgb(224, 224, 224);
                btn3.BackColor = Color.FromArgb(224, 224, 224);
                btn4.BackColor = Color.FromArgb(224, 224, 224);
                btn5.BackColor = Color.FromArgb(224, 224, 224);
                btn6.BackColor = Color.FromArgb(224, 224, 224);
                btn7.BackColor = Color.FromArgb(224, 224, 224);
                btn8.BackColor = Color.FromArgb(224, 224, 224);
                btn9.BackColor = Color.FromArgb(224, 224, 224);
                btn10.BackColor = Color.FromArgb(224, 224, 224);
                btn11.BackColor = Color.FromArgb(224, 224, 224);
                btn12.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BookRoom fix_br = createBookRoom();
            b.FixBookRoom(fix_br);
            IEnumerable<BookRoom> getBR = b.getListBookRoom();
            loadRoomListView(lvwDSDatPhong, getBR);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlgHoiXoa;
            BookRoom remove_book;
            int vitTriThuc;
            if (lvwDSDatPhong.SelectedItems.Count > 0)//co chon
            {
                dlgHoiXoa = MessageBox.Show("Bạn chắc xóa?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dlgHoiXoa == DialogResult.Yes)
                {
                    for (int i = 0; i < lvwDSDatPhong.SelectedItems.Count; i++)
                    {
                        vitTriThuc = lvwDSDatPhong.SelectedIndices[i];
                        remove_book = (BookRoom)lvwDSDatPhong.Items[vitTriThuc].Tag;
                        b.deleteMayTinh(remove_book);
                    }
                    IEnumerable<BookRoom> dsBook = b.getListBookRoom();
                    loadRoomListView(lvwDSDatPhong, dsBook);
                }
            }
        }
    }
}
