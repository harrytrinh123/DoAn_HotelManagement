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
                    where s.Status == false
                    select new {cmnd = d.id_Customer, tenKH = d.name, soDT = d.phone, ngayNhan = c.Checkin_Date, ngayTra = c.Checkout_Date, soPhong = s.RoomNumber, idRoom = s.id_Room };
            return q;
        }

        public IEnumerable<dynamic> GetDSDangThue()
        {

            var q = from d in dt.Customers
                    join c in dt.BookRooms on d.id_Customer equals c.id_Customer
                    join s in dt.Rooms on c.id_Room equals s.id_Room
                    where s.Status == true
                    select new { cmnd = d.id_Customer, tenKH = d.name, soDT = d.phone, ngayNhan = c.Checkin_Date, ngayTra = c.Checkout_Date, soPhong = s.RoomNumber, idRoom = s.id_Room, roomStatus = s.Status };
            return q;
        }

        public IEnumerable<dynamic> getDSDichVu(string idBookRoom)
        {

            var q = from r in dt.BookRooms
                    join s in dt.Bill_Services on r.id_BookRoom equals s.id_BookRoom
                    join x in dt.Services on s.id_Service equals x.id_Service
                    where r.id_BookRoom.Equals(idBookRoom)
                    select new { idRoom = r.id_Room, idService = x.id_Service, serviceName =x.Name_Service, price = x.Price, count = s.Service_Count };
            return q;

        }
    }
}
