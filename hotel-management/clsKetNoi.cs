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
            string strKetNoi = @"Data Source=.;Initial Catalog=QLKS;User ID=sa;Password=21112001Ty";
            qlKS = new qlKhachSanDataContext(strKetNoi);
            qlKS.Connection.Open();
            return qlKS;
        }
    }
}
