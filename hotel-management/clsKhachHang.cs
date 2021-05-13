using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    public class clsKhachHang : clsKetNoi
    {
        qlKhachSanDataContext dt;
        public clsKhachHang()
        {
            dt = getDatacontex();
        }
        public IEnumerable<Person> GetDSKH()
        {
            IEnumerable<Person> q;
            q = from n in dt.Persons
                    select n;


            return q;
        }
    }
}
