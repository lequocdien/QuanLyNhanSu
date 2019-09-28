using DTO;
using EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class ChamCongDAL
    {
        public static List<ChamCongDTO> LoadBangChamCongTheoNgay(int ngay, int thang, int nam)
        {
            QuanLyNhanSuEntities db = DataProvider.dbContext;
            return db.Database.SqlQuery<ChamCongDTO>("sp_ChamCongNhanVien @ngay, @thang, @nam", new SqlParameter("@ngay", ngay), new SqlParameter("@thang", thang), new SqlParameter("@nam", nam)).ToList();
        }

        public static bool ChamCongNhanVien(List<CHAMCONG> lstChamCong)
        {
            try
            {
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                db.CHAMCONGs.AddRange(lstChamCong);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
