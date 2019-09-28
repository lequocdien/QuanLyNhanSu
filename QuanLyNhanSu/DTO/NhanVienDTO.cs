using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public int MaNV { get; set; }
        public string HoLot { get; set; }
        public string Ten { get; set; }
        public string CMND { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public byte[] HinhAnh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public Nullable<int> MaTrinhDo { get; set; }
        public Nullable<int> MaBP { get; set; }
        public Nullable<int> MaChucVu { get; set; }
        public string TenBP { get; set; }
        public string TenChucVu { get; set; }
        public string TenTrinhDo { get; set; }
        public bool DaThoiViec { get; set; }
    }
}
