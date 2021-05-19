using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    class clsChaotic : clsKetNoi
    {
        qlKhachSanDataContext qlKS;

        public clsChaotic()
        {
            qlKS = getDatacontex();
        }

        //public IQueryable<dynamic> GetPhongLoaiPhongHonLoan()
        //{

        //    IQueryable<dynamic> q = from n in qlKS.Rooms
        //            join x in qlKS.RoomStyles
        //            on n.id_RoomStyle equals x.id_RoomStyle
        //            select new { n.id_Room, n.Grade, n.RoomNumber, x.id_RoomStyle, x.NameStyle, x.Price };
        //    return q;
        //}


    }
}
