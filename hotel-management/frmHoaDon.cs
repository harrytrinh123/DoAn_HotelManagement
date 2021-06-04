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
    public partial class frmHoaDon : Form
    {
        private IEnumerable<dynamic> _dsDichVu;
        private string _idCustomer;
        private string _idBRoom;
        private string _idRoom;
        public frmHoaDon(IEnumerable<dynamic> dsDichVu,string idCustomer, string idBRoom, string idRoom)
        {
            InitializeComponent();
            this._dsDichVu = dsDichVu;
            this._idCustomer = idCustomer;
            this._idBRoom = idBRoom;
            this._idRoom = idRoom;
        }
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            TaoTieuDeCot(lvwDichVu);
            LoadThongTin();
            DuaDataVaoLvwDichVu(lvwDichVu, _dsDichVu);
        }

        void LoadThongTin()
        {
            clsCustomer CUS = new clsCustomer();
            Customer cus = CUS.checkIfExist(_idCustomer);
            lblTen.Text = cus.name;
            lblCMND.Text = cus.id_Customer;
            lblSoDT.Text = cus.phone;
            lblDiaChi.Text = cus.address;

            clsRoom ROOM = new clsRoom();
            var room = ROOM.LayThongTinPhong(_idRoom);
            lblTenPhong.Text = room.RoomNumber;

            clsStyleRoom SROOM = new clsStyleRoom();
            var SRoom = SROOM.GetRoomStyle(room.id_RoomStyle);
            lblLoaiPhong.Text = SRoom.NameStyle;
            double giaPhong = (double)SRoom.Price;
            lblDonGia.Text = giaPhong.ToString();

            // So dem
            clsBookRoom BROOM = new clsBookRoom();
            var BRoom = BROOM.GetThongTinBookRoom(_idRoom);
            lblNgayDen.Text = BRoom.Checkin_Date.ToString();
            var soDem = (BRoom.Checkout_Date - BRoom.Checkin_Date).TotalDays;
            lblSoDem.Text = soDem.ToString();

            double tienPhong = soDem * giaPhong;
            lblTienPhong.Text = string.Format("{0:0,0 vnđ}", tienPhong);

            double tienDV = TinhTienDichVu();
            lblDichVu.Text = string.Format("{0:0,0 vnđ}", tienDV);

            double tongTien = tienDV + tienPhong;
            lblTongTien.Text = string.Format("{0:0,0 vnđ}", tongTien);
        }

        void TaoTieuDeCot(ListView lvw)
        {
            //tao cot
            lvw.Columns.Add("STT", 100);
            lvw.Columns.Add("Tên dịch vụ", 200);
            lvw.Columns.Add("Số lần sử dụng: ", 200);
            lvw.Columns.Add("Đơn giá", 200);
            lvw.Columns.Add("Tiền phải trả", 200);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;

        }
        int i = 0;
        ListViewItem GreateItem(dynamic dv)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem((i++).ToString());
            lvwItem.SubItems.Add(dv.serviceName);
            lvwItem.SubItems.Add(dv.count.ToString());
            lvwItem.SubItems.Add(string.Format("{0:0,0 vnđ}", dv.price));
            lvwItem.SubItems.Add(string.Format("{0:0,0 vnđ}", dv.count * dv.price));
            lvwItem.Tag = dv;//nhet vao de su dung muc dich khac (mu dich 1)
            return lvwItem;
        }

        private void DuaDataVaoLvwDichVu(ListView lvw, IEnumerable<dynamic> dsDichVu)
        {
            lvw.Items.Clear();
            ListViewItem item;
            foreach (var dv in dsDichVu)
            {
                item = GreateItem(dv);
                lvw.Items.Add(item);
            }
        }

        private double TinhTienDichVu()
        {
            double tongTien = 0;
            foreach(var item in _dsDichVu)
            {
                tongTien = tongTien +  (double)item.count * (double)item.price;
            }
            return tongTien;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
