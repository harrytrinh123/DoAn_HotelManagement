using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    public class clsCustomer : clsKetNoi
    {
        qlKhachSanDataContext dt;
        public clsCustomer()
        {
            dt = getDatacontex();
        }

        
    }
}
