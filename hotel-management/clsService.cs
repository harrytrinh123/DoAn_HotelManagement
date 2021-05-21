using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    public class clsService : clsKetNoi
    {
        qlKhachSanDataContext dt;
        public clsService()
        {
            dt = getDatacontex();
        }

        clsServiceStyle ServiceStyle = new clsServiceStyle();

        public IQueryable<dynamic> GetAllService()
        {
            var s = from a in dt.Services
                    join n in dt.ServiceStyles
                    on a.id_SeviceStyle equals n.id_SeviceStyle
                    select new { a.id_Service, a.Name_Service, a.Price, n.NameStyle, n.id_SeviceStyle};
            return s;
        }

        public Service CheckIfExist(string id)
        {
            Service temp = (from n in dt.Services
                          where n.id_Service.Equals(id)
                          select n).FirstOrDefault();
            return temp;
        }

        public int InsertService(Service s)
        {
            using (System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction())
            {
                try
                {
                    dt.Transaction = myTran;
                    if(CheckIfExist(s.id_Service) != null)
                    {
                        
                        return 0;
                    }
                    else
                    {
                        dt.Services.InsertOnSubmit(s);
                        dt.SubmitChanges();
                        dt.Transaction.Commit();
                        return 1;
                    }
                }catch(Exception ex)
                {
                    dt.Transaction.Rollback();
                    throw new Exception("Error Insert Service !!" + ex.Message);
                }
            }
        }

        public int DeleteService(Service s)
        {
            using(System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction())
            {
                try
                {
                    dt.Transaction = myTran;
                    if(CheckIfExist(s.id_Service) != null)
                    {
                        dt.Services.DeleteOnSubmit(s);
                        dt.SubmitChanges();
                        dt.Transaction.Commit();
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }catch(Exception ex)
                {
                    dt.Transaction.Rollback();
                    throw new Exception("Error Delete Service" + ex.Message);
                }
            }
        }

        public void ChangeService(Service s)
        {
            using(System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction())
            {
                try
                {
                    dt.Transaction = myTran;
                    IEnumerable<Service> temp = (from n in dt.Services
                                                 where n.id_Service.Equals(s.id_Service)
                                                 select n);
                    temp.First().Name_Service = s.Name_Service;
                    temp.First().Price = s.Price;
                    temp.First().id_SeviceStyle = s.id_SeviceStyle;

                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                }catch(Exception ex)
                {
                    dt.Transaction.Rollback();
                    throw new Exception("Error Change Service" + ex.Message);
                }
            }
        }

        public IEnumerable<dynamic> FindIndex(string id)
        {
            var s = from a in dt.Services
                    join n in dt.ServiceStyles
                    on a.id_SeviceStyle equals n.id_SeviceStyle
                    where a.Name_Service.Equals(id)
                    select new { a.id_Service, a.Name_Service, a.Price, n.NameStyle, n.id_SeviceStyle };
            return s;

        }
    }
}
