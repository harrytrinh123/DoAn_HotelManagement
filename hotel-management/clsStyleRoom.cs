using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    public class clsStyleRoom : clsKetNoi
    {
        qlKhachSanDataContext dt;
        public clsStyleRoom()
        {
            dt = getDatacontex();
        }

        public RoomStyle GetRoomStyle(string idRoomStyle)
        {
            var q = from n in dt.RoomStyles
                    where n.id_RoomStyle.Equals(idRoomStyle)
                    select n;
            return q.FirstOrDefault();
        }
    }
}
