using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    class clsRoomStyle : clsKetNoi
    {
        qlKhachSanDataContext qlKS;

        public clsRoomStyle()
        {
            qlKS = getDatacontex();
        }

        //lấy tất cả các loại phòng
        public IEnumerable<RoomStyle> getALLRoomStyle()
        {
            IEnumerable<RoomStyle> q = from n in qlKS.RoomStyles
                                       select n;
            return q;
        }

        //lấy nguyên bản thông tin của loại phòng
        public IEnumerable<RoomStyle> getThongTinLoaiPhong(string strMaLoaiPhong)
        {
            IEnumerable<RoomStyle> q;
            if (strMaLoaiPhong.Equals(""))
                q = from n in qlKS.RoomStyles
                    select n;
            else
                q = from n in qlKS.RoomStyles
                    where n.id_RoomStyle.Equals(strMaLoaiPhong)
                    select n;
            return q;
        }

        //kiểm tra trùng id loại phòng
        public RoomStyle chkIfExist(string strMaLoaiPhong)
        {
            RoomStyle temp = (from n in qlKS.RoomStyles
                         where n.id_RoomStyle.Equals(strMaLoaiPhong)
                         select n).FirstOrDefault();
            if (temp != null)
                return temp;
            return null;
        }

        //thêm loại phòng
        public int insertRoomStyle(RoomStyle rs)
        {
            System.Data.Common.DbTransaction myTran = qlKS.Connection.BeginTransaction();
            try
            {
                qlKS.Transaction = myTran;
                if (chkIfExist(rs.id_RoomStyle) != null)
                    return 0;
                else
                {
                    qlKS.RoomStyles.InsertOnSubmit(rs);
                    qlKS.SubmitChanges();
                    qlKS.Transaction.Commit();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                qlKS.Transaction.Rollback();
                throw new Exception("Loi không sửa được " + ex.Message);

            }
        }

        //event xóa Phòng
        public int deleteRoomStyle(RoomStyle rs)
        {
            System.Data.Common.DbTransaction myTran = qlKS.Connection.BeginTransaction();
            try
            {
                qlKS.Transaction = myTran;
                if (chkIfExist(rs.id_RoomStyle) != null)
                {
                    qlKS.RoomStyles.DeleteOnSubmit(rs);
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

        //event Sửa Loại Phòng
        public bool updateRoomStyle(RoomStyle rs)
        {
            System.Data.Common.DbTransaction myTran = qlKS.Connection.BeginTransaction();
            try
            {
                qlKS.Transaction = myTran;
                IEnumerable<RoomStyle> tam = (from n in qlKS.RoomStyles
                                         where n.id_RoomStyle == rs.id_RoomStyle
                                         select n);
                tam.First().NameStyle = rs.NameStyle;
                tam.First().Price = rs.Price;
                qlKS.SubmitChanges();
                qlKS.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                qlKS.Transaction.Rollback();
                throw new Exception("Lỗi không thể sửa thông tin Phòng này!");
            }
        }

    }
}
