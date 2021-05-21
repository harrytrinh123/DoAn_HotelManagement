using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    public class clsBookRoom : clsKetNoi
    {
        qlKhachSanDataContext dt;
        public clsBookRoom()
        {
            dt = getDatacontex();
        }



        //hoang code
        public bool SuaThongTinBookRoomCuaKH(BookRoom bRoom, string maKH)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
                try
                {
                dt.Transaction = myTran;
                IQueryable<BookRoom> tam = (from n in dt.BookRooms
                                              where n.id_Customer == maKH
                                              select n);
                //thầy mới sửa 4 field các ban có thể sửa thêm
                //riệng mã không sửa
                tam.First().peopleCount = bRoom.peopleCount;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
                    }
            catch (Exception ex)
                {
                dt.Transaction.Rollback();
                throw new Exception("Loi khong sửa duoc " + ex.Message);

            }
        }

        public BookRoom GetThongTinBookRoomCuaKhach(string strIdCustomer)
        {
            var q = from n in dt.BookRooms
            where n.id_Customer.Equals(strIdCustomer)
                select n;

            return q.FirstOrDefault();
        }

        public BookRoom GetThongTinBookRoom(string roomId)
            {
            var q = from n in dt.BookRooms
                    where n.id_Room.Equals(roomId)
                    select n;

            return q.FirstOrDefault();
        }
    }
}
