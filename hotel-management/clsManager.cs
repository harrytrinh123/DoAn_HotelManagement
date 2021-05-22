using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    public class clsManager : clsKetNoi
    {
        qlKhachSanDataContext dt;
        public clsManager()
        {
            dt = getDatacontex();
        }

        public Manager CheckIfExist(string id)
        {
            Manager temp = (from n in dt.Managers
                          where n.id_Manager.Equals(id)
                          select n).FirstOrDefault();
            return temp;
        }
    }
}
