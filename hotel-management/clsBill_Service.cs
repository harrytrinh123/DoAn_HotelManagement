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

        public bool CapNhatSoLuong(string idBookRoom, string idService, int soLuong)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction(); 
            try
            {
                dt.Transaction = myTran;
                var tam = from n in dt.Services
                          join b in dt.Bill_Services
                          on n.id_Service equals b.id_Service
                          join bo in dt.BookRooms
                          on b.id_BookRoom equals bo.id_BookRoom
                          where b.id_BookRoom.Equals(idBookRoom)
                          where b.id_Service.Equals(idService)
                          select b;
                tam.FirstOrDefault().Service_Count = soLuong;
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
