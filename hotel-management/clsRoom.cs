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

        public Room LayThongTinPhong(string idRoom)
        {
            var q = from d in dt.Rooms
                    where d.id_Room == idRoom
                    select d;
            return q.FirstOrDefault();

        }

        public Room GetRoomByNumberRoom(string room_number)
        {
            var room = (from x in dt.Rooms
                        where x.RoomNumber.Equals(room_number)
                        select x).FirstOrDefault();

            return room;
        }

        public Room Exist(string id_room)
        {
            var room = (from x in dt.Rooms
                        where x.id_Room.Equals(id_room)
                        select x).FirstOrDefault();

            return room;
        }

        public IEnumerable<Room> getListRoom()
        {
            IEnumerable<Room> r = from i in dt.Rooms
                                  select i;
            return r;
        }

        public IEnumerable<Room> getSoPandIDP()
        {
            IEnumerable<Room> r = (IEnumerable<Room>)(from i in dt.Rooms
                                                      select new { idphong = i.id_Room });
            return r;
        }

        public int insertBookRoom(Room r)
        {
            System.Data.Common.DbTransaction br = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = br;
                dt.Rooms.InsertOnSubmit(r);
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return 1;
            }
            catch (Exception e)
            {
                dt.Transaction.Rollback();
                throw new Exception(e.Message);
            }
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
