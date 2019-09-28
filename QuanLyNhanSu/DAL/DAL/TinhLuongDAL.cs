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
    public class TinhLuongDAL
    {
        public static List<TinhLuongDTO> TinhLuongTatCaNhanVien(int thang, int nam, double lcb, double ltc)
        {
            try
            {
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                return db.Database.SqlQuery<TinhLuongDTO>("sp_TinhLuongTatCaNhanVien @thang, @nam, @luongCoBan, @luongTangCa", new SqlParameter("@thang", thang), new SqlParameter("@nam", nam), new SqlParameter("@luongCoBan", lcb), new SqlParameter("@luongTangCa", ltc)).ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
