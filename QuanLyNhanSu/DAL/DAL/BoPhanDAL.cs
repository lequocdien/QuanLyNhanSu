using DTO;
using EF;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAL
{
    public class BoPhanDAL
    {
        public static List<BOPHAN> LoadBoPhan()
        {
            QuanLyNhanSuEntities db = DataProvider.dbContext;
            return db.BOPHANs.ToList();
        }

        public static List<BoPhanDTO> LoadSoLuongNhanVienTungBoPhan()
        {
            QuanLyNhanSuEntities db = DataProvider.dbContext;
            return db.Database.SqlQuery<BoPhanDTO>("sp_SoLuongNhanVienTungBoPhan").ToList();
        }
        
        public static BoPhanDTO ThemBoPhan(BoPhanDTO boPhanDTO)
        {
            try
            {
                BOPHAN boPhan = new BOPHAN();
                boPhan.TenBP = boPhanDTO.TenBP;
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                boPhan = db.BOPHANs.Add(boPhan);
                db.SaveChanges();
                boPhanDTO.MaBP = boPhan.MaBP;
                boPhanDTO.TenBP = boPhan.TenBP;
                boPhanDTO.SoLuong = 0;
                return boPhanDTO;
            }
            catch
            {
                return null;
            }
            
        }

        public static BoPhanDTO SuaBoPhan(BoPhanDTO boPhanDTO)
        {
            try
            {
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                BOPHAN boPhan = db.BOPHANs.SingleOrDefault(i => i.MaBP == boPhanDTO.MaBP);
                boPhan.TenBP = boPhanDTO.TenBP;
                db.SaveChanges();
                return boPhanDTO;
            }
            catch
            {
                return null;
            }
        }

        public static bool XoaBoPhan(int maBoPhanCanXoa)
        {
            try
            {
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                BOPHAN boPhan = db.BOPHANs.SingleOrDefault(i => i.MaBP == maBoPhanCanXoa);
                boPhan = db.BOPHANs.Remove(boPhan);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
