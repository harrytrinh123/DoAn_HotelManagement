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

        public Bill_Service checkIfExist(string serviceId, string idBookRoom)
        {
            var temp = from b in dt.Bill_Services
                       where b.id_BookRoom.Equals(idBookRoom) && b.id_Service.Equals(serviceId)
                       select b;
                       
            if (temp != null)
                return temp.FirstOrDefault();
            return null;

            // doi thanh  return mttemp;
        }
        public int insertBillService(Bill_Service bs)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (checkIfExist(bs.id_Service, bs.id_BookRoom) != null)// thay
                    return 0;
                else
                {
                    dt.Bill_Services.InsertOnSubmit(bs);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Loi không thêm được " + ex.Message);

            }
        }

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
