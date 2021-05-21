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

        public Customer checkIfExist(string strCMND)
        {
            //tblMaytinh mttemp = dt.tblMaytinhs.Where(x => x.msMay == maMay).FirstOrDefault();
            Customer temp = dt.Customers.Where(x => x.id_Customer == strCMND).FirstOrDefault();
  
            return temp;
        }

        public IEnumerable<Customer> getListCustomer()
        {
            IEnumerable<Customer> c = from i in dt.Customers
                                      select i;
            return c;
        }
    }
}
