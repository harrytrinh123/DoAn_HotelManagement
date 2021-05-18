using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    public class clsKetNoi
    {
        qlKhachSanDataContext qlKS;
        public qlKhachSanDataContext getDatacontex()
        {
            string strKetNoi = @"Data Source=DESKTOP-5HV6F7T\SQLEXPRESS01;Initial Catalog=QLKS;Integrated Security=True";
            qlKS = new qlKhachSanDataContext(strKetNoi);
            qlKS.Connection.Open();
            return qlKS;
        }
    }
}
