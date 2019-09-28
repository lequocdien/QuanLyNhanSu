using DAL.DAL;
using DTO;
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

        public static List<BoPhanDTO> LoadSoLuongNhanVienTungBoPhan()
        {
            return BoPhanDAL.LoadSoLuongNhanVienTungBoPhan();
        }

        public static BoPhanDTO ThemBoPhan(BoPhanDTO bp)
        {
            return BoPhanDAL.ThemBoPhan(bp);
        }

        public static BoPhanDTO SuaBoPhan(BoPhanDTO bp)
        {
            return BoPhanDAL.SuaBoPhan(bp);
        }

        public static bool XoaBoPhan(int maBoPhanCanXoa)
        {
            return BoPhanDAL.XoaBoPhan(maBoPhanCanXoa);
        }
    }
}
