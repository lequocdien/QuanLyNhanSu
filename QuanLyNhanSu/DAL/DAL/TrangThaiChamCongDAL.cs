using EF;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAL
{
    public class TrangThaiChamCongDAL
    {
        public static List<TRANGTHAICHAMCONG> Load()
        {
            QuanLyNhanSuEntities db = DataProvider.dbContext;
            return db.TRANGTHAICHAMCONGs.ToList();
        }
    }
}
