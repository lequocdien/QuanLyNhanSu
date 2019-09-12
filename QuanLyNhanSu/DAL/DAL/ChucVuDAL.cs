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
    }
}
