using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChamCongDTO
    {
        public int MaNV { get; set; }
        public string HoLot { get; set; }
        public string Ten { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public string TenTrinhDo { get; set; }
        public string TenBP { get; set; }
        public string TenChucVu { get; set; }
        public int? MaTrangThai { get; set; }
        public double? SoGioTangCa { get; set; }

    }
}
