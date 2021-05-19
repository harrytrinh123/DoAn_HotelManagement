using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    public class clsHonLoan : clsKetNoi
    {
        qlKhachSanDataContext dt;
        public clsHonLoan()
        {
            dt = getDatacontex();
        }


        public IEnumerable<dynamic> GetDSNhanPhong()
        {

            var q = from d in dt.Customers
                    join c in dt.BookRooms on d.id_Customer equals c.id_Customer
                    join s in dt.Rooms on c.id_Room equals s.id_Room
                    where s.Status == true
                    select new {cmnd = d.id_Customer, tenKH = d.name, soDT = d.phone, ngayNhan = c.Checkin_Date, ngayTra = c.Checkout_Date, soPhong = s.RoomNumber, idRoom = s.id_Room };
            return q;
        }
    }
}
