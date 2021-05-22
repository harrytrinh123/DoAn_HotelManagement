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
                tam.First().Checkin_Date = bRoom.Checkin_Date;
                tam.First().Checkout_Date = bRoom.Checkout_Date;
                tam.First().dateBooking = bRoom.dateBooking;
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

        // COde Minh Phuong
        public IEnumerable<BookRoom> getListBookRoom()
        {
            IEnumerable<BookRoom> b = from i in dt.BookRooms
                                      select i;
            return b;
        }

        public IEnumerable<BookRoom> GetIEnumerableBookRoomByIDRoom(string id_room)
        {
            IEnumerable<BookRoom> book;
            if (id_room.Equals(""))//chon goc
                book = from n in dt.BookRooms
                       select n;
            else
                book = from n in dt.BookRooms
                       where n.id_Room.Contains(id_room)
                       select n;
            return book;
        }

        public BookRoom GetBookRoomByIDRoom(string id_room)
        {
            BookRoom tmp = dt.BookRooms.Where(x => x.id_Room.Equals(id_room)).FirstOrDefault();
            return tmp;
        }

        public BookRoom CheckExist(string id_BookRoom)
        {
            BookRoom tmp = dt.BookRooms.Where(x => x.id_BookRoom.Equals(id_BookRoom)).FirstOrDefault();
            return tmp;
        }
        // hông hiểu
        // chạy lại á hả

        public int insertBookRoom(BookRoom b)
        {
            using (System.Data.Common.DbTransaction br = dt.Connection.BeginTransaction())
            {
                try
                {
                    dt.Transaction = br;
                    if (CheckExist(b.id_BookRoom) != null)
                        return 0;
                    else
                    {
                        dt.BookRooms.InsertOnSubmit(b);
                        dt.SubmitChanges();
                        dt.Transaction.Commit();
                        return 1;
                    }
                }
                catch (Exception e)
                {
                    dt.Transaction.Rollback();
                    throw new Exception("Lỗi không thêm được" + e.Message);
                }
            }
        }

        public IEnumerable<BookRoom> getListCoMa(IEnumerable<BookRoom> ma)
        {
            IEnumerable<BookRoom> q;
            q = from n in dt.BookRooms
                where n.id_Room.Equals(ma)
                select n;
            return q;
        }

        public bool FixBookRoom(BookRoom br)
        {
            using (System.Data.Common.DbTransaction fixBookRoom = dt.Connection.BeginTransaction())
            {
                try
                {
                    dt.Transaction = fixBookRoom;
                    IEnumerable<BookRoom> fix = from i in dt.BookRooms
                                                where i.id_BookRoom == br.id_BookRoom
                                                select i;
                    fix.First().peopleCount = br.peopleCount;
                    fix.First().dateBooking = br.dateBooking;
                    fix.First().Checkin_Date = br.Checkin_Date;
                    fix.First().Checkout_Date = br.Checkout_Date;
                    fix.First().id_Customer = br.id_Customer;
                    fix.First().id_Room = br.id_Room;

                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    dt.Transaction.Rollback();
                    throw new Exception("Lỗi không sữa được");
                }
            }
        }

        public int deleteMayTinh(BookRoom remove_book)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;

                if (CheckExist(remove_book.id_BookRoom) != null)// thay
                {
                    dt.BookRooms.DeleteOnSubmit(remove_book);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Loi không sửa được " + ex.Message);

            }
        }
    }
}
