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
    
    public partial class TANGCA
    {
        public int MaTangCa { get; set; }
        public Nullable<int> Ngay { get; set; }
        public Nullable<int> Thang { get; set; }
        public Nullable<int> Nam { get; set; }
        public Nullable<int> SoGio { get; set; }
        public Nullable<int> SoPhut { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<int> MaLoaiCa { get; set; }
    
        public virtual LOAICA LOAICA { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
