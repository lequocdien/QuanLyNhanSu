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
    }
}
