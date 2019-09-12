using DAL.DAL;
using EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class BaoHiemBUL
    {
        public static List<BAOHIEM> Load(int maNhanVien)
        {
            List<BAOHIEM> lstBaoHiem = BaoHiemDAL.Load(maNhanVien);
            if(lstBaoHiem.Count > 0)
            {
                return lstBaoHiem;
            }
            return null;
        }

        public static BAOHIEM Them(BAOHIEM bh)
        {
            return BaoHiemDAL.Them(bh);

        }

        public static bool Xoa(string soBaoHiem)
        {
            return BaoHiemDAL.Xoa(soBaoHiem);
        }

        public static bool CapNhat(BAOHIEM bh)
        {
            return BaoHiemDAL.CapNhat(bh);
        }
    }
}
