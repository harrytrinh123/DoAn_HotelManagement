using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    public class clsService : clsKetNoi
    {
        qlKhachSanDataContext dt;
        public clsService()
        {
            dt = getDatacontex();
        }

        public IEnumerable<Service> GetAllService()
        {
            var q = from x in dt.Services
                    select x;
            return q;
        }

    }
}
