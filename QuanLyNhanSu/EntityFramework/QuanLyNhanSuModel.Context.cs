﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyNhanSuEntities : DbContext
    {
        public QuanLyNhanSuEntities()
            : base("name=QuanLyNhanSuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BANGCHAMCONG> BANGCHAMCONGs { get; set; }
        public virtual DbSet<BAOHIEM> BAOHIEMs { get; set; }
        public virtual DbSet<BOPHAN> BOPHANs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<HOPDONG> HOPDONGs { get; set; }
        public virtual DbSet<KHAUTRU> KHAUTRUs { get; set; }
        public virtual DbSet<LOAICA> LOAICAs { get; set; }
        public virtual DbSet<LOAICONG> LOAICONGs { get; set; }
        public virtual DbSet<LOAIHOPDONG> LOAIHOPDONGs { get; set; }
        public virtual DbSet<LOAITRINHDO> LOAITRINHDOes { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHANVIEN_KHAUTRU> NHANVIEN_KHAUTRU { get; set; }
        public virtual DbSet<NHANVIEN_NGHIPHEP> NHANVIEN_NGHIPHEP { get; set; }
        public virtual DbSet<NHANVIEN_PHUCAP> NHANVIEN_PHUCAP { get; set; }
        public virtual DbSet<NHANVIEN_TRINHDO> NHANVIEN_TRINHDO { get; set; }
        public virtual DbSet<PHUCAP> PHUCAPs { get; set; }
        public virtual DbSet<QLUNGLUONG> QLUNGLUONGs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TANGCA> TANGCAs { get; set; }
        public virtual DbSet<TRINHDO> TRINHDOes { get; set; }
    }
}