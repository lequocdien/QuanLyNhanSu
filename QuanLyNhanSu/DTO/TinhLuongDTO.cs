using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinhLuongDTO
    {
        public int MaNV { set; get; }
        public string HoLot { set; get; }
        public string Ten { set; get; }
        public string TenLoaiCong { set; get; }
        public decimal HeSo { set; get; }
        public int SoNgayLam { set; get; }
        public double SoGioLam { set; get; }
        public double Luong { set; get; }
    }
}
