using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    public class clsBill_Service : clsKetNoi
    {
        qlKhachSanDataContext dt;
        public clsBill_Service()
        {
            dt = getDatacontex();
        }

        //public bool checkExist(string idBRoom, string idService)
        //{
        //    var q = from n in dt.Bill_Services

        //}

        public bool CapNhatSoLuong(string idBRoom, string idService, int soLuong)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction(); 
            try
            {
                dt.Transaction = myTran;
                var tam = (from n in dt.Bill_Services            
                          where (n.id_BookRoom.Equals(idBRoom)
                          && n.id_Service.Equals(idService))
                          select n).FirstOrDefault();
                tam.Service_Count = soLuong;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Loi the cap nhat tinh trang phong " + ex.Message);

            }
        }
    }
}
