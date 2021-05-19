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
            Customer mttemp = (from n in dt.Customers
                                 where n.id_Customer.Equals(strCMND)
                                 select n).FirstOrDefault();
            if (mttemp != null)
                return mttemp;
            return null;
        }

        public IEnumerable<Customer> GetCustomers() => dt.Customers;

    }
}
