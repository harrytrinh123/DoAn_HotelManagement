using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    class clsStaff : clsKetNoi
    {
        qlKhachSanDataContext dt;
        public clsStaff()
        {
            dt = getDatacontex();
        }

        //Hàm lấy danh sách nhân viên
        public IEnumerable<Staff> getListStaff()
        {
            IEnumerable<Staff> m = from n in dt.Staffs
                                     select n;

            return m;
        }

        
        public Staff CheckIfExist(string id)
        {
            Staff temp = (from n in dt.Staffs
                          where n.id_Staff.Equals(id)
                          select n).FirstOrDefault();
            return temp;
        }

        public int InsertStaff(Staff staff)
        {
            using (System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction())
            {
                try
                {
                    dt.Transaction = myTran;
                    if (CheckIfExist(staff.id_Staff) != null)
                    {
                        return 0;
                    }
                    else
                    {
                        dt.Staffs.InsertOnSubmit(staff);
                        dt.SubmitChanges();
                        dt.Transaction.Commit();
                        return 1;
                        //Phải tạo account rồi mới tạo được Staff -> mai fix
                    }
                }
                catch (Exception ex)
                {
                    dt.Transaction.Rollback();
                    throw new Exception("Error Insert!!" + ex.Message);
                }
            }
            
        }

        public int DeleteStaff(Staff staff)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if(CheckIfExist(staff.id_Staff) != null)
                {
                    dt.Staffs.DeleteOnSubmit(staff);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
                return 0;
            }catch(Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Erorr Delete!!" + ex.Message);
            }
        }

        public int ChangeStaff(Staff staff)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<Staff> temp = (from n in dt.Staffs
                                          where n.id_Staff == staff.id_Staff
                                          select n);

                temp.First().name = staff.name;
                temp.First().sex = staff.sex;
                temp.First().birthday = staff.birthday;
                temp.First().address = staff.address;
                temp.First().phone = staff.phone;

                dt.SubmitChanges();
                dt.Transaction.Commit();

                return 1;
            }catch(Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Error Change Staff!! " + ex.Message);
            }
        }

        public IEnumerable<Staff> FindIndex(string id)
        {
            IEnumerable<Staff> m = from n in dt.Staffs
                                   where n.id_Staff.Equals(id) || n.name.Equals(id)
                                   select n;

            return m;
        }
    }
}
