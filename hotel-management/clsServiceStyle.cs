using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    class clsServiceStyle : clsKetNoi
    {
        qlKhachSanDataContext dt;
        
        public clsServiceStyle()
        {
            dt = getDatacontex();
        }

        public IQueryable<ServiceStyle>GetListNameServiceStyle()
        {
            var listName = from n in dt.ServiceStyles
                           select n;
            return listName;
        }

        public string GetIdServiceStyle(string name)
        {
            var q = (from n in dt.ServiceStyles
                     where n.NameStyle.Equals(name)
                     select n.id_SeviceStyle).FirstOrDefault();

            return q;
        }

        public IEnumerable<ServiceStyle> GetAllList()
        {
            var ss = from n in dt.ServiceStyles
                     select n;
            return ss;
        }

        public ServiceStyle CheckIfExist(string id)
        {
            ServiceStyle temp = (from n in dt.ServiceStyles
                                 where n.id_SeviceStyle.Equals(id)
                                 select n).FirstOrDefault();
            return temp;
        }

        public int InsertServiceStyle(ServiceStyle ss)
        {
            using(System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction())
            {
                try
                {
                    dt.Transaction = myTran;
                    if(CheckIfExist(ss.id_SeviceStyle) != null)
                    {
                        return 0;
                    }
                    else
                    {
                        dt.ServiceStyles.InsertOnSubmit(ss);
                        dt.SubmitChanges();
                        dt.Transaction.Commit();
                        return 1;
                    }
                }catch(Exception ex)
                {
                    dt.Transaction.Rollback();
                    throw new Exception("Error Insert Service" + ex.Message);
                }
            }
        }

        public int DeleteServiceStyle(ServiceStyle ss)
        {
            using(System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction())
            {
                try
                {
                    dt.Transaction = myTran;
                    if(CheckIfExist(ss.id_SeviceStyle) != null)
                    {
                        dt.ServiceStyles.DeleteOnSubmit(ss);
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
                    throw new Exception("Error Del Service Style " + ex.Message);
                }
            }
        }

        public void ChangeServiceStyle(ServiceStyle ss)
        {
            using(System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction())
            {
                try
                {
                    dt.Transaction = myTran;

                    ServiceStyle temp = (from n in dt.ServiceStyles
                                         where n.id_SeviceStyle.Equals(ss.id_SeviceStyle)
                                         select n).FirstOrDefault();
                    temp.NameStyle = ss.NameStyle;

                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                }
                catch (Exception ex)
                {
                    dt.Transaction.Rollback();
                    throw new Exception("Error Change Service Style " + ex.Message);
                }

            }
        }

        public IEnumerable<ServiceStyle> FindIndex(string name)
        {
            var m = (from n in dt.ServiceStyles
                     where n.NameStyle.Equals(name)
                     select n);
            return m;
        }
    }
}
