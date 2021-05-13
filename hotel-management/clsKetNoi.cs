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
            string strKetNoi = @"Data Source=DESKTOP-BRQK3RI\SQLEXPRESS;Initial Catalog=QL_KS;Integrated Security=True";
            qlKS = new qlKhachSanDataContext(strKetNoi);
            qlKS.Connection.Open();
            return qlKS;
        }
    }
}
