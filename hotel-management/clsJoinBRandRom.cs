using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    class clsJoinBRandRom : clsKetNoi
    {
        qlKhachSanDataContext db;
        public clsJoinBRandRom()
        {
            db = getDatacontex();
        }

        public IEnumerable<dynamic> getNumberRoom()
        {
            var q = from i in db.BookRooms
                    join x in db.Rooms
                    on i.id_Room equals x.id_Room
                    select new {maphong=i.id_Room, sophong=x.RoomNumber};
            return q;
        }

        public dynamic GetBookRoomByIDRoom(string id_room)
        {
            var q = getNumberRoom();

            var k = from x in q
                    where x.maphong.Equals(id_room)
                    select new { x.sophong };

            return k.FirstOrDefault();
        }
        
    }
}
