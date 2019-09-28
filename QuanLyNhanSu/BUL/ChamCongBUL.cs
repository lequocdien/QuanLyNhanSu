using DAL.DAL;
using DTO;
using EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class ChamCongBUL
    {
        public static List<ChamCongDTO> LoadBangChamCongTheoNgay(int ngay, int thang, int nam)
        {
            return ChamCongDAL.LoadBangChamCongTheoNgay(ngay, thang, nam);
        }

        public static bool ChamCongNhanVien(List<CHAMCONG> lstChamCong)
        {
            return ChamCongDAL.ChamCongNhanVien(lstChamCong);
        }
    }
}
