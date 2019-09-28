using DAL.DAL;
using DTO;
using EF;
using System.Collections.Generic;
using TOOLS;

namespace BUL
{
    public class NhanVienBUL
    {
        public static List<NhanVienDTO> LoadNhanVien()
        {
            return NhanVienDAL.LoadNhanVien();
        }

        public static List<NhanVienDTO> LoadNhanVienDaThoiViec()
        {
            return NhanVienDAL.LoadNhanVienDaThoiViec();
        }

        public static NhanVienDTO CapNhat(NhanVienDTO nv)
        {
            return NhanVienDAL.CapNhat(nv);
        }

        public static NhanVienDTO Them(NhanVienDTO nv)
        {
            return NhanVienDAL.Them(nv);
        }

        public static bool Them(List<NhanVienDTO> lstNhanVienDTO)
        {
            List<NHANVIEN> lstNhanVien = new List<NHANVIEN>();
            for(int i = 0; i<lstNhanVienDTO.Count; i++)
            {
                lstNhanVien.Add(MyConvert.Convert_NhanVienDTO_To_NhanVien(lstNhanVienDTO[i]));
            }
            return NhanVienDAL.Them(lstNhanVien);
        }

        public static bool Xoa(int maNhanVien)
        {
            return NhanVienDAL.Xoa(maNhanVien);
        }
    }
}
