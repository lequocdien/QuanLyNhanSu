using DAL.DAL;
using EF;
using System.Collections.Generic;

namespace BUL
{
    public class BoPhanBUL
    {
        public static List<BOPHAN> LoadBoPhan()
        {
            return BoPhanDAL.LoadBoPhan();
        }
    }
}
