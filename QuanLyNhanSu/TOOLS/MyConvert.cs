using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using DTO;
using EF;

namespace TOOLS
{
    public class MyConvert
    {
        public static byte[] ImageToBinary(Image img)
        {
            if(img != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            return null;
        }

        public static Image BinaryToImage(byte[] data)
        {
            if(data != null)
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        public static NhanVienDTO Convert_NhanVien_To_NhanVienDTO(NHANVIEN nv)
        {
            NhanVienDTO nvDTO = new NhanVienDTO();
            nvDTO.MaNV = nv.MaNV;
            nvDTO.HoLot = nv.HoLot;
            nvDTO.Ten = nv.Ten;
            nvDTO.CMND = nv.CMND;
            nvDTO.GioiTinh = nv.GioiTinh;
            nvDTO.NgaySinh = nv.NgaySinh;
            nvDTO.DienThoai = nv.DienThoai;
            nvDTO.HinhAnh = nv.HinhAnh;
            nvDTO.DiaChi = nv.DiaChi;
            nvDTO.MaTrinhDo = nv.MaTrinhDo;
            nvDTO.MaBP = nv.MaBP;
            nvDTO.MaChucVu = nv.MaChucVu;
            nvDTO.DaThoiViec = nv.DaThoiViec;
            nvDTO.TenTrinhDo = nv.TRINHDO.TenTrinhDo;
            nvDTO.TenBP = nv.BOPHAN.TenBP;
            nvDTO.TenChucVu = nv.CHUCVU.TenChucVu;
            return nvDTO;
        }

        public static NHANVIEN Convert_NhanVienDTO_To_NhanVien(NhanVienDTO nvDTO)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MaNV = nvDTO.MaNV;
            nv.HoLot = nvDTO.HoLot;
            nv.Ten = nvDTO.Ten;
            nv.CMND = nvDTO.CMND;
            nv.GioiTinh = nvDTO.GioiTinh;
            nv.NgaySinh = nvDTO.NgaySinh;
            nv.DienThoai = nvDTO.DienThoai;
            nv.HinhAnh = nvDTO.HinhAnh;
            nv.DiaChi = nvDTO.DiaChi;
            nv.MaTrinhDo = nvDTO.MaTrinhDo;
            nv.MaBP = nvDTO.MaBP;
            nv.MaChucVu = nvDTO.MaChucVu;
            nv.DaThoiViec = nvDTO.DaThoiViec;
            return nv;
        }
    }
}
