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

        public bool Delete(Customer cs)
        {
            if(checkIfExist(cs.id_Customer) != null)
            {
                using (System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction())
                {
                    try
                    {
                        dt.Transaction = myTran;
                        dt.Customers.DeleteOnSubmit(cs);
                        dt.SubmitChanges();
                        dt.Transaction.Commit();
                        return true;
                    }
                    catch (Exception e)
                    {
                        dt.Transaction.Rollback();
                        throw new Exception(e.Message);
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public bool Insert(Customer cs)
        {
            if (checkIfExist(cs.id_Customer) == null)
            {
                using (System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction())
                {
                    try
                    {
                        dt.Transaction = myTran;
                        dt.Customers.InsertOnSubmit(cs);
                        dt.SubmitChanges();
                        dt.Transaction.Commit();
                        return true;
                    }
                    catch (Exception e)
                    {
                        dt.Transaction.Rollback();
                        throw new Exception(e.Message);
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public bool Update(Customer cs)
        {
            using (System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction())
            {
                try
                {
                    dt.Transaction = myTran;

                    IQueryable<Customer> tmp = from x in dt.Customers
                                               where x.id_Customer.Equals(cs.id_Customer)
                                               select x;
                    tmp.First().id_Customer = cs.id_Customer;
                    tmp.First().name = cs.name;
                    tmp.First().phone = cs.phone;
                    tmp.First().sex = cs.sex;
                    tmp.First().birthday = cs.birthday;
                    tmp.First().address = cs.address;

                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dt.Transaction.Rollback();
                    throw new Exception(ex.Message);
                }
            }
        }
        public IEnumerable<Customer> getListCustomer()
        {
            IEnumerable<Customer> c = from i in dt.Customers
                                      select i;
            return c;
        }
    }
}
