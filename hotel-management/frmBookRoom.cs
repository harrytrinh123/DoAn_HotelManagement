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
        int n = 40;
        private void frmBookRoom_Load(object sender, EventArgs e)
        {
            b = new clsBookRoom();
            IEnumerable<BookRoom> br = b.getListBookRoom();
            c = new clsCustomer();
            r = new clsRoom();
            jBR = new clsJoinBRandRom();
            createTitle(lvwDSDatPhong);
            loadRoomListView(lvwDSDatPhong, br);
            
            TaoDayGhe(n);
        }

        void TaoDayGhe(int n)
        {
            Button btn;
            for (int i = 1; i <= n; i++)
            {
                btn = new Button();
                btn.Name = "lbl" + i.ToString();
                btn.Width = 60;
                btn.Height = 60;
                btn.Text = (100+i).ToString();
                btn.BackColor = Color.DarkGray;
                foreach (var item in jBR.getNumberRoom())
                {
                    if (btn.Text.Equals(item.sophong))
                    {
                        btn.BackColor = Color.Red;
                    } 
                }
                btn.Click += new EventHandler(MyClick);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void MyClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;// ép kiểu;
            if (btn.BackColor == Color.DarkGray)
            {
                btn.BackColor = Color.Yellow;
                txtPhong.Text = btn.Text;
            }
            else if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Phòng đã có người đặt, Vui lòng chọn phòng khác", "Thông báo");
            }
            else if(btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.Red;
            }
            else
            {
                btn.BackColor = Color.DarkGray;
                txtPhong.Text = "";
            }
        }

        private void HuyBo_Click(object sender, EventArgs e)
        {
            
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
        void DoiMauButton(Button btn1)
        {
            foreach (var i in jBR.getNumberRoom())
            {
                if (btn1.Text.Equals(i.sophong))
                {
                    btn1.BackColor = Color.Red;
                }
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
            RemoveElement();
            flowLayoutPanel1.Controls.Clear();
            TaoDayGhe(n);
        }

        void RemoveElement()
        {
            txtBookRoom.Clear();
            cboLoaiPhong.SelectedIndex=0;
            txtPhong.Clear();
            txtCountKH.Clear();
            dTimeDatPhong.Value = DateTime.Now;
            dTimeNgayNhan.Value = DateTime.Now;
            dTimeNgayTra.Value = DateTime.Now;
            txtDiaChi.Clear();
            txtHoTen.Clear();
            txtCMND.Clear();
            txtSoDienThoai.Clear();
            dTimeNgaySinh.Value = DateTime.Now;
            cboGioiTinh.SelectedIndex=0;
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
            if (txtTimPhong.Text != "")
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
                    if ((txtTimPhong.Text == j.sophong) && (item.id_Room == j.maphong))
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
            Button btn = (Button)sender;
            if (btn.BackColor == Color.DarkGray)
            {
                btn.BackColor = Color.Yellow;
                txtPhong.Text = btn.Text;
            }
            if (btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.DarkGray;
                txtPhong.Text = "";
            } 
            else if(btn.BackColor == Color.Red)
            {
                MessageBox.Show("Phòng đã có người đặt", "Thông báo");
            }
        }       

        void LoadButton(Button btn)
        {
            foreach(var iteam in jBR.getNumberRoom())
            {
                if(iteam.maphong != btn.Text)
                {
                    if(btn.BackColor != Color.Red)
                    {
                        btn.BackColor = Color.FromArgb(224, 224, 224);
                    }
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            BookRoom fix_br = createBookRoom();

            b.FixBookRoom(fix_br);
            IEnumerable<BookRoom> getBR = b.getListBookRoom();
            loadRoomListView(lvwDSDatPhong, getBR);
            RemoveElement();
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
                    RemoveElement();
                }
            }

            flowLayoutPanel1.Controls.Clear();
            TaoDayGhe(n);
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            IEnumerable<BookRoom> br = b.getListBookRoom();
            loadRoomListView(lvwDSDatPhong, br);
        }
    }
}
