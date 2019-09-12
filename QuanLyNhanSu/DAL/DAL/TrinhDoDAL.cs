using EF;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAL
{
    public class TrinhDoDAL
    {
        public static List<TRINHDO> LoadTrinhDo()
        {
            QuanLyNhanSuEntities db = DataProvider.dbContext;
            return db.TRINHDOes.ToList();
        }
    }
}
