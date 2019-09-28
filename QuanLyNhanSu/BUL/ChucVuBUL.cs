using DAL.DAL;
using DTO;
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

        public static List<ChucVuDTO> LoadSoLuongNhanVienTungChucVu()
        {
            return ChucVuDAL.LoadSoLuongNhanVienTungChucVu();
        }

        public static ChucVuDTO ThemChucVu(ChucVuDTO chucVuDTO)
        {
            return ChucVuDAL.ThemChucVu(chucVuDTO);
        }

        public static ChucVuDTO SuaChucVu(ChucVuDTO chucVuDTO)
        {
            return ChucVuDAL.SuaChucVu(chucVuDTO);
        }

        public static ChucVuDTO XoaChucVu(ChucVuDTO chucVuDTO)
        {
            return ChucVuDAL.XoaChucVu(chucVuDTO);
        }
    }
}
