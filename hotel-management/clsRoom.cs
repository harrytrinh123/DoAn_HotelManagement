using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    class clsRoom : clsKetNoi
    {
        qlKhachSanDataContext db;
        public clsRoom()
        {
            db = getDatacontex();
        }

        public Room GetRoomByNumberRoom(string room_number)
        {
            var room = (from x in db.Rooms
                        where x.RoomNumber.Equals(room_number)
                        select x).FirstOrDefault();

            return room;
        }

        public Room Exist(string id_room)
        {
            var room = (from x in db.Rooms
                        where x.id_Room.Equals(id_room)
                        select x).FirstOrDefault();

            return room;
        }

        public IEnumerable<Room> getListRoom()
        {
            IEnumerable<Room> r = from i in db.Rooms
                                  select i;
            return r;
        }

        public IEnumerable<Room> getSoPandIDP()
        {
            IEnumerable<Room> r = (IEnumerable<Room>)(from i in db.Rooms
                                  select new { idphong = i.id_Room });
            return r;
        }

        public int insertBookRoom(Room r)
        {
            System.Data.Common.DbTransaction br = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = br;
                db.Rooms.InsertOnSubmit(r);
                db.SubmitChanges();
                db.Transaction.Commit();
                return 1;
            }
            catch (Exception e)
            {
                db.Transaction.Rollback();
                throw new Exception(e.Message);
            }
        }

        
    }
}
