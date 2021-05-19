using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    class clsAccount : clsKetNoi
    {
        qlKhachSanDataContext dt;

        public clsAccount()
        {
            dt = getDatacontex();
        }

        public Account Exist(string username)
        {
            var account = (from x in dt.Accounts
                           where x.username == username
                           select x).FirstOrDefault();
            return account;
        }

        public bool CheckAccount(Account a)
        {
            Account account = Exist(a.username);
            if(account == null)
            {
                return false;
            }

            if (a.username.Equals(account.username.Trim()) && a.password.Equals(account.password))
            {
                return true;
            }

            return false;
        }

        //code của Tuấn
        public IEnumerable<Account> GetListAccount()
        {
            IEnumerable<Account> a = from n in dt.Accounts
                                     where n.username.StartsWith("NV")
                                     select n;
            return a;
        }

        public Account CheckIfExist(string id)
        {
            Account a = (from n in dt.Accounts
                         where n.username.Equals(id)
                         select n).FirstOrDefault();
            return a;
        }

        public int InsertAccount(Account a)
        {
            using (System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction())
            {
                try
                {
                    dt.Transaction = myTran;
                    if (CheckIfExist(a.username) != null)
                    {
                        return 0;
                    }
                    else
                    {
                        dt.Accounts.InsertOnSubmit(a);
                        dt.SubmitChanges();
                        dt.Transaction.Commit();
                        return 1;
                    }
                }
                catch (Exception ex)
                {
                    dt.Transaction.Rollback();
                    throw new Exception("Error Insert Account" + ex.Message);
                }
            }


        }

        //Còn sai cần sửa lại
        public int DeleteAccount(string id)
        {
            using (System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction())
            {
                try
                {
                    dt.Transaction = myTran;
                    Account a = (from n in dt.Accounts
                                 where n.username.Equals(id)
                                 select n).FirstOrDefault();
                    if (CheckIfExist(a.username) != null)
                    {
                        dt.Accounts.DeleteOnSubmit(a);
                        dt.SubmitChanges();
                        dt.Transaction.Commit();
                        return 1;
                    }
                    return 0;
                }
                catch (Exception ex)
                {
                    dt.Transaction.Rollback();
                    throw new Exception("Erorr Delete Account!!" + ex.Message);
                }
            }

        }

        public int ChangePass(Account a)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<Account> temp = (from n in dt.Accounts
                                            where n.username == a.username
                                            select n);

                temp.First().password = a.password;

                dt.SubmitChanges();
                dt.Transaction.Commit();

                return 1;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Error Change Password!! " + ex.Message);
            }
        }

        public IQueryable<Account> FindIndex(string id)
        {
            IQueryable<Account> a = (from n in dt.Accounts
                                     where n.username.Equals(id)
                                     select n);

            return a;
        }
    }

}
