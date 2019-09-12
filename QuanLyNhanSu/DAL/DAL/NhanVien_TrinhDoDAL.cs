using EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAL
{
    public class NhanVien_TrinhDoDAL
    {
        public static List<NHANVIEN_TRINHDO> Load(int maNhanVien)
        {
            try
            {
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                List<NHANVIEN_TRINHDO> lstNVTD = db.NHANVIEN_TRINHDO.Where(i => i.MaNV == maNhanVien).ToList();
                if (lstNVTD.Count > 0)
                {
                    return lstNVTD;
                }
            }
            catch
            {
                return null;
            }
            return null;


        }

        public static List<NHANVIEN_TRINHDO> Them(List<NHANVIEN_TRINHDO> lstNVTD)
        {
            try
            {
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                lstNVTD = db.NHANVIEN_TRINHDO.AddRange(lstNVTD).ToList();
                if (lstNVTD != null)
                {
                    db.SaveChanges();
                    return lstNVTD;
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public static bool Xoa(int maNhanVien)
        {
            try
            {
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                List<NHANVIEN_TRINHDO> lstNVTD = db.NHANVIEN_TRINHDO.Where(i => i.MaNV == maNhanVien).ToList();
                db.NHANVIEN_TRINHDO.RemoveRange(lstNVTD);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhat(List<NHANVIEN_TRINHDO> lstNVTD)
        {
            if (Xoa(lstNVTD[0].MaNV))
            {
                if (Them(lstNVTD) != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
