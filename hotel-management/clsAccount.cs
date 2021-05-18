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
    }
}
