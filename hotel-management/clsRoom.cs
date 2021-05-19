using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
   
    class clsRoom : clsKetNoi
    {
        qlKhachSanDataContext qlKS;

        public clsRoom()
        {
            qlKS = getDatacontex();
        }


        //lấy all các phòng
        public IEnumerable<Room> getALLRoom()
        {
            IEnumerable<Room> q = from n in qlKS.Rooms
                                  select n;
            return q;
        }

        //lấy nguyên bản thông tin của phòng
        public IEnumerable<Room> getThongTinPhong(string strMaPhong)
        {
            IEnumerable<Room> q;
            if (strMaPhong.Equals(""))
                q = from n in qlKS.Rooms
                    select n;
            else
                q = from n in qlKS.Rooms
                    where n.id_Room.Equals(strMaPhong)
                    select n;
            return q;
        }

        //kiểm tra trùng 
        public Room chkIfExist(string strMaPhong)
        {
            Room temp = (from n in qlKS.Rooms
                         where n.id_Room.Equals(strMaPhong)
                         select n).FirstOrDefault();
            if (temp != null)
                return temp;
            return null;
        }

        //thêm phòng 
        public int insertRoom(Room r)
        {
            System.Data.Common.DbTransaction myTran = qlKS.Connection.BeginTransaction();
                try
                {
                    qlKS.Transaction = myTran;
                    if (chkIfExist(r.id_Room) != null)
                    {
                        return 0;
                    }    
                    else
                    {
                        qlKS.Rooms.InsertOnSubmit(r);
                        qlKS.SubmitChanges();
                        qlKS.Transaction.Commit();
                        return 1;
                    }
                }
                catch (Exception ex)
                {
                    qlKS.Transaction.Rollback();
                    throw new Exception("Lỗi không thêm phòng được!" + ex.Message);
                }
        }

        //event xóa Phòng
        public int deleteRoom(Room r)
        {
            System.Data.Common.DbTransaction myTran = qlKS.Connection.BeginTransaction();
                try
                {
                    qlKS.Transaction = myTran;
                    if (chkIfExist(r.id_Room) != null)
                    {
                        qlKS.Rooms.DeleteOnSubmit(r);
                        qlKS.SubmitChanges();
                        qlKS.Transaction.Commit();
                        return 1;
                    }
                    return 0;
                }
                catch (Exception ex)
                {
                    qlKS.Transaction.Rollback();
                    throw new Exception("Lỗi không thể xóa thông tin Phòng này!" + ex.Message);
                }
        }

        //event Sửa Phòng
        public bool updateRoom(Room r)
        {
            System.Data.Common.DbTransaction myTran = qlKS.Connection.BeginTransaction();
            try
            {
                qlKS.Transaction = myTran;
                IEnumerable<Room> tam = (from n in qlKS.Rooms
                                         where n.id_Room == r.id_Room
                                         select n);
                tam.First().RoomNumber = r.RoomNumber;
                tam.First().Grade = r.Grade;
                tam.First().Status = r.Status;
                tam.First().Note = r.Note;
                qlKS.SubmitChanges();
                qlKS.Transaction.Commit();
                return true;
            }
            catch(Exception ex)
            {
                qlKS.Transaction.Rollback();
                throw new Exception("Lỗi không thể sửa thông tin Phòng này!");
            }
        }

    }
}
