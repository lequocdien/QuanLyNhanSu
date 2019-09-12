using DAL.DAL;
using EF;
using System.Collections.Generic;

namespace BUL
{
    public class TrinhDoBUL
    {
        public static List<TRINHDO> LoadTrinhDo()
        {
            return TrinhDoDAL.LoadTrinhDo();
        }
    }
}
