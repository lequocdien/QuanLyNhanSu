using DTO;
using EF;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAL
{
    public class ChucVuDAL
    {
        public static List<CHUCVU> LoadChucVu()
        {
            QuanLyNhanSuEntities db = DataProvider.dbContext;
            return db.CHUCVUs.ToList();
        }

        public static List<ChucVuDTO> LoadSoLuongNhanVienTungChucVu()
        {
            QuanLyNhanSuEntities db = DataProvider.dbContext;
            return db.Database.SqlQuery<ChucVuDTO>("sp_SoLuongNhanVienTungChucVu").ToList();
        }

        public static ChucVuDTO ThemChucVu(ChucVuDTO chucVuDTO)
        {
            try
            {
                CHUCVU chucVu = new CHUCVU();
                chucVu.TenChucVu = chucVuDTO.TenChucVu;
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                chucVu = db.CHUCVUs.Add(chucVu);
                db.SaveChanges();
                chucVuDTO.MaChucVu = chucVu.MaChucVu;
                chucVuDTO.TenChucVu = chucVu.TenChucVu;
                chucVuDTO.SoLuong = 0;
                return chucVuDTO;
            }
            catch
            {
                return null;
            }

        }

        public static ChucVuDTO SuaChucVu(ChucVuDTO chucVuDTO)
        {
            try
            {
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                CHUCVU chucVu = db.CHUCVUs.SingleOrDefault(i => i.MaChucVu == chucVuDTO.MaChucVu);
                chucVu.TenChucVu = chucVuDTO.TenChucVu;
                db.SaveChanges();
                return chucVuDTO;
            }
            catch
            {
                return null;
            }
        }

        public static ChucVuDTO XoaChucVu(ChucVuDTO chucVuDTO)
        {
            try
            {
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                CHUCVU cv = db.CHUCVUs.SingleOrDefault(i => i.MaChucVu == chucVuDTO.MaChucVu);
                cv = db.CHUCVUs.Remove(cv);
                db.SaveChanges();
                return chucVuDTO;
            }
            catch
            {
                return null;
            }
        }
    }
}
