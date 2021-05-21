using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace hotel_management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());

            //frmLogin login = new frmLogin();
            //if(login.ShowDialog() == DialogResult.Yes)
            //{
            //    Account account = login.account;
            //    if(account.username.Split('_')[0].Equals("NV"))
            //    {
            //        Application.Run(new frmMain(account));
            //    }
            //    else
            //    {
            //        Application.Run(new frmMainManagement(account));
            //    }
            //}
        }
    }
}
