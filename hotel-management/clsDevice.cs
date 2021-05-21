using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hotel_management
{
    class clsDevice : clsKetNoi
    {
        qlKhachSanDataContext dt;
        public clsDevice()
        {
            dt = getDatacontex();
        }
        //Hàm lấy danh sách thiết bị
        public IEnumerable<Equipment> getListEquipment()
        {
            IEnumerable<Equipment> m = from n in dt.Equipments
                                   select n;

            return m;
        }
        public Equipment CheckIfExist(string id)
        {
            Equipment temp = (from n in dt.Equipments
                              where n.id_Equipment.Equals(id)
                          select n).FirstOrDefault();
            return temp;
        }
        public int InsertEquipment(Equipment Equipment)
        {
            using (System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction())
            {
                try
                {
                    dt.Transaction = myTran;
                    if (CheckIfExist(Equipment.id_Equipment) != null)
                    {
                        return 0;
                    }
                    else
                    {
                        dt.Equipments.InsertOnSubmit(Equipment);
                        dt.SubmitChanges();
                        dt.Transaction.Commit();
                        return 1;
                    }
                }
                catch (Exception ex)
                {
                    dt.Transaction.Rollback();
                    throw new Exception("Error Insert!!" + ex.Message);
                }
            }

        }
        public int DeleteEquipment(Equipment Equipment)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(Equipment.id_Equipment) != null)
                {
                    dt.Equipments.DeleteOnSubmit(Equipment);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Erorr Delete!!" + ex.Message);
            }
        }
        public int ChangeEquipment(Equipment Equipment)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<Equipment> temp = (from n in dt.Equipments
                                              where n.id_Equipment == Equipment.id_Equipment
                                          select n);
              
                temp.First().id_Equipment = Equipment.id_Equipment;
                temp.First().name_Equipment = Equipment.name_Equipment;
                temp.First().Price = Equipment.Price;

                dt.SubmitChanges();
                dt.Transaction.Commit();

                return 1;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Error Change Staff!! " + ex.Message);
            }
        }
        public IEnumerable<Equipment> FindIndex(string id)
        {
            IEnumerable<Equipment> m = from n in dt.Equipments
                                       where n.id_Equipment.Equals(id) || n.name_Equipment.Equals(id)
                                   select n;
            return m;
        }
    }
}

