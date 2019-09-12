using DAL.DAL;
using EF;
using System.Collections.Generic;

namespace BUL
{
    public class ChucVuBUL
    {
        public static List<CHUCVU> LoadChucVu()
        {
            return ChucVuDAL.LoadChucVu();
        }
    }
}
