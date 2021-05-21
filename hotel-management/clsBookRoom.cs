using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    class clsBookRoom: clsKetNoi
    {
        qlKhachSanDataContext db;
        public clsBookRoom()
        {
            db = getDatacontex();
        }

        public IEnumerable<BookRoom> getListBookRoom()
        {
            IEnumerable<BookRoom> b = from i in db.BookRooms
                                      select i;
            return b;
        }

        public IEnumerable<BookRoom> GetIEnumerableBookRoomByIDRoom(string id_room)
        {
            IEnumerable<BookRoom> book;
            if (id_room.Equals(""))//chon goc
                book = from n in db.BookRooms
                    select n;
            else
                book = from n in db.BookRooms
                    where n.id_Room.Contains(id_room)
                    select n;
            return book;
        }

        public BookRoom GetBookRoomByIDRoom(string id_room)
        {
            BookRoom tmp = db.BookRooms.Where(x => x.id_Room.Equals(id_room)).FirstOrDefault();
            return tmp;
        }

        public BookRoom CheckExist(string id_BookRoom)
        {
            BookRoom tmp = db.BookRooms.Where(x => x.id_BookRoom.Equals(id_BookRoom)).FirstOrDefault();
            return tmp;
        }
        // hông hiểu
        // chạy lại á hả

        public int insertBookRoom(BookRoom b)
        {
            using (System.Data.Common.DbTransaction br = db.Connection.BeginTransaction())
            {
                try
                {
                    db.Transaction = br;
                    if (CheckExist(b.id_BookRoom) != null)
                        return 0;
                    else
                    {
                        db.BookRooms.InsertOnSubmit(b);
                        db.SubmitChanges();
                        db.Transaction.Commit();
                        return 1;
                    }
                }
                catch (Exception e)
                {
                    db.Transaction.Rollback();
                    throw new Exception("Lỗi không thêm được" + e.Message);
                }
            }
        }

        public IEnumerable<BookRoom> getListCoMa(IEnumerable<BookRoom> ma)
        {
            IEnumerable<BookRoom> q;
            q = from n in db.BookRooms
                where n.id_Room.Equals(ma)
                select n;
            return q;
        }

        public bool FixBookRoom(BookRoom br)
        {
            using(System.Data.Common.DbTransaction fixBookRoom= db.Connection.BeginTransaction())
            {
                try
                {
                    db.Transaction = fixBookRoom;
                    IEnumerable<BookRoom> fix = from i in db.BookRooms
                                                where i.id_BookRoom == br.id_BookRoom
                                                select i;
                    fix.First().peopleCount = br.peopleCount;
                    fix.First().dateBooking = br.dateBooking;
                    fix.First().Checkin_Date = br.Checkin_Date;
                    fix.First().Checkout_Date = br.Checkout_Date;
                    fix.First().id_Customer = br.id_Customer;
                    fix.First().id_Room = br.id_Room;

                    db.SubmitChanges();
                    db.Transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Transaction.Rollback();
                    throw new Exception("Lỗi không sữa được");
                }
            }
        }

        public int deleteMayTinh(BookRoom remove_book)
        {
            System.Data.Common.DbTransaction myTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = myTran;

                if (CheckExist(remove_book.id_BookRoom) != null)// thay
                {
                    db.BookRooms.DeleteOnSubmit(remove_book);
                    db.SubmitChanges();
                    db.Transaction.Commit();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                db.Transaction.Rollback();
                throw new Exception("Loi không sửa được " + ex.Message);

            }
        }
    }
}
