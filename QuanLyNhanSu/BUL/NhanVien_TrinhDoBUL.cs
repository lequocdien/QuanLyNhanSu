using DAL.DAL;
using EF;
using System.Collections.Generic;

namespace BUL
{
    public class NhanVien_TrinhDoBUL
    {
        public static List<NHANVIEN_TRINHDO> Load(int maNhanVien)
        {
            return NhanVien_TrinhDoDAL.Load(maNhanVien);
        }

        public static List<NHANVIEN_TRINHDO> Them(List<NHANVIEN_TRINHDO> lstNVTD)
        {
            return NhanVien_TrinhDoDAL.Them(lstNVTD);
        }

        public static bool CapNhat(List<NHANVIEN_TRINHDO> lstNVTD)
        {
            if(lstNVTD.Count > 0){
                return NhanVien_TrinhDoDAL.CapNhat(lstNVTD);
            }
            return false;
        }

        public static bool Xoa(int maNhanVien)
        {
            return NhanVien_TrinhDoDAL.Xoa(maNhanVien);
        }

    }
}
