//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOPDONG
    {
        public string SoHD { get; set; }
        public Nullable<int> KyLanThu { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<System.DateTime> NgayKy { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<int> MaLoaiHD { get; set; }
    
        public virtual LOAIHOPDONG LOAIHOPDONG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
