﻿using DTO;
using EF;
using System;
using System.Collections.Generic;
using System.Linq;
using TOOLS;

namespace DAL.DAL
{
    public class NhanVienDAL
    {
        public static List<NhanVienDTO> LoadNhanVien()
        {
            try
            {
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                var query = from nv in db.NHANVIENs
                            where nv.DaThoiViec == false
                            select new NhanVienDTO
                            {
                                MaNV = nv.MaNV,
                                HoLot = nv.HoLot,
                                Ten = nv.Ten,
                                CMND = nv.CMND,
                                GioiTinh = nv.GioiTinh,
                                NgaySinh = nv.NgaySinh,
                                DienThoai = nv.DienThoai,
                                HinhAnh = nv.HinhAnh,
                                DiaChi = nv.DiaChi,
                                MaBP = nv.MaBP,
                                MaChucVu = nv.MaChucVu,
                                TenBP = nv.BOPHAN.TenBP,
                                TenChucVu = nv.CHUCVU.TenChucVu,
                                DaThoiViec = nv.DaThoiViec
                            };
                return query.ToList();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

        }

        public static NhanVienDTO CapNhat(NhanVienDTO nv)
        {
            try
            {
                QuanLyNhanSuEntities db = DataProvider.dbContext;
                NHANVIEN nvUpdated = db.NHANVIENs.SingleOrDefault(i => i.MaNV == nv.MaNV);
                if (nvUpdated != null)
                {
                    nvUpdated.HoLot = nv.HoLot;
                    nvUpdated.Ten = nv.Ten;
                    nvUpdated.CMND = nv.CMND;
                    nvUpdated.GioiTinh = nv.GioiTinh;
                    nvUpdated.NgaySinh = nv.NgaySinh;
                    nvUpdated.DienThoai = nv.DienThoai;
                    nvUpdated.HinhAnh = nv.HinhAnh;
                    nvUpdated.DiaChi = nv.DiaChi;
                    nvUpdated.MaBP = nv.MaBP;
                    nvUpdated.MaChucVu = nv.MaChucVu;
                    nvUpdated.DaThoiViec = nv.DaThoiViec;
                    db.SaveChanges();
                }
                return MyConvert.Convert_NhanVien_To_NhanVienDTO(nvUpdated);
            }
            catch
            {
                return null;
            }
        }

        public static NhanVienDTO Them(NhanVienDTO nvDTO)
        {
            NHANVIEN nv = MyConvert.Convert_NhanVienDTO_To_NhanVien(nvDTO);
            QuanLyNhanSuEntities db = DataProvider.dbContext;
            NHANVIEN nvAdded = db.NHANVIENs.Add(nv);
            db.SaveChanges();
            return MyConvert.Convert_NhanVien_To_NhanVienDTO(nvAdded);
        }

        public static bool Them(List<NHANVIEN> lstNhanVien)
        {
            QuanLyNhanSuEntities db = DataProvider.dbContext;
            List<NHANVIEN> lstNhanVienInserted = db.NHANVIENs.AddRange(lstNhanVien).ToList();
            if(lstNhanVien.Count == lstNhanVienInserted.Count)
            {
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool Xoa(int maNhanVien)
        {
            QuanLyNhanSuEntities db = DataProvider.dbContext;
            NHANVIEN nv = db.NHANVIENs.SingleOrDefault(i => i.MaNV == maNhanVien);
            nv = db.NHANVIENs.Remove(nv);
            db.SaveChanges();
            if(nv != null)
            {
                return true;
            }
            return false;
        }
    }
}
