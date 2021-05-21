using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    public class clsRoom : clsKetNoi
    {
        qlKhachSanDataContext dt;
        public clsRoom()
        {
            dt = getDatacontex();
        }

        //hoang code
        public Room LayThongTinPhongCuaKhach(string cmnd)
        {
            var q = from d in dt.Customers
                    join c in dt.BookRooms on d.id_Customer equals c.id_Customer
                    join s in dt.Rooms on c.id_Room equals s.id_Room
                    select s;
            return q.FirstOrDefault();

        }
        public Room LayThongTinPhong(string idRoom)
        {
            var q = from d in dt.Rooms
                    where d.id_Room == idRoom
                    select d;
            return q.FirstOrDefault();

        }
        public bool CapNhatTinhTrangPhong(string idRoom, Room room)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                var tam = from n in dt.Rooms
                          where n.id_Room == idRoom
                        select n;
                tam.First().Status = true;
                tam.First().Note = room.Note;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Loi the cap nhat tinh trang phong " + ex.Message);

            }
        }
    }
}
