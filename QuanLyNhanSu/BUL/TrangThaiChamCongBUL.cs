using DAL.DAL;
using EF;
using System.Collections.Generic;

namespace BUL
{
    public class TrangThaiChamCongBUL
    {
        public static List<TRANGTHAICHAMCONG> Load()
        {
            return TrangThaiChamCongDAL.Load();
        }
    }
}
