﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HienNhiDTOs
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class CuaHangEntities : DbContext
    {
        public CuaHangEntities()
            : base("name=CuaHangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ChiTietHDBH> ChiTietHDBHs { get; set; }
        public DbSet<ChiTietHDNH> ChiTietHDNHs { get; set; }
        public DbSet<ChiTietSBH> ChiTietSBHs { get; set; }
        public DbSet<GiaBan> GiaBans { get; set; }
        public DbSet<HoaDonBanHang> HoaDonBanHangs { get; set; }
        public DbSet<HoaDonNhapHang> HoaDonNhapHangs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<LoaiSP> LoaiSPs { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<SoBanHang> SoBanHangs { get; set; }
        public DbSet<SoChiTieuCuaHang> SoChiTieuCuaHangs { get; set; }
    
        public virtual int spGetGiaBan(string maKH, string maSP, ObjectParameter giaBan)
        {
            var maKHParameter = maKH != null ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(string));
    
            var maSPParameter = maSP != null ?
                new ObjectParameter("MaSP", maSP) :
                new ObjectParameter("MaSP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spGetGiaBan", maKHParameter, maSPParameter, giaBan);
        }
    }
}
