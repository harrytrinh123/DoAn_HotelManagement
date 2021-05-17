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

        public Account Exist(Account a)
        {
            var account = (from x in dt.Accounts
                           where x.username == a.username
                           select x).FirstOrDefault();
            return account;
        }

        public bool CheckAccount(Account a)
        {
            Account account = Exist(a);
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
