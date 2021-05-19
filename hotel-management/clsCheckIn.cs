using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    public class clsCheckIn : clsKetNoi
    {
        qlKhachSanDataContext dt;
        public clsCheckIn()
        {
            dt = getDatacontex();
        }
    }

}
