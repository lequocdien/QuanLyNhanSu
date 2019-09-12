using EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class BaoHiemDAL
    {
        public static List<BAOHIEM> Load(int maNhanVien)
        {
            QuanLyNhanSuEntities db = DataProvider.dbContext;
            return db.BAOHIEMs.Where(i => i.MaNV == maNhanVien).ToList();
        }

        public static BAOHIEM Them(BAOHIEM bh)
        {
            try
            {
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                bh = db.BAOHIEMs.Add(bh);
                if (bh != null)
                {
                    db.SaveChanges();
                    return bh;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

        }

        public static bool Xoa(string soBaoHiem)
        {
            try
            {
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                BAOHIEM bh = db.BAOHIEMs.SingleOrDefault(i => i.SoBH == soBaoHiem);
                db.BAOHIEMs.Remove(bh);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhat(BAOHIEM bh)
        {
            try
            {
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                BAOHIEM bhUpdate = db.BAOHIEMs.SingleOrDefault(i => i.SoBH == bh.SoBH);
                bhUpdate.NgayCap = bh.NgayCap;
                bhUpdate.NoiCap = bh.NoiCap;
                bhUpdate.NoiKhamBenh = bh.NoiKhamBenh;
                bhUpdate.NgayHetHan = bh.NgayHetHan;
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
