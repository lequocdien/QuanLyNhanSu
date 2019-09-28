using DAL.DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class TinhLuongBUL
    {
        public static List<TinhLuongDTO> TinhLuongTatCaNhanVien(int thang, int nam, double lcb, double ltc)
        {
            return TinhLuongDAL.TinhLuongTatCaNhanVien(thang, nam, lcb, ltc);
        }
    }
}
