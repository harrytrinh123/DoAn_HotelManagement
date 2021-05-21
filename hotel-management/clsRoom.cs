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

        {

        }
        public Room LayThongTinPhong(string idRoom)
        {
            var q = from d in dt.Rooms
                    where d.id_Room == idRoom
                    select d;
            return q.FirstOrDefault();

        }
        {
            try
            {
            }
            {
            }
        }
    }
}
