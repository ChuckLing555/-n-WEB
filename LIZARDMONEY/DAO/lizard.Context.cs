﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLCT_LIZARDett : DbContext
    {
        public QLCT_LIZARDett()
            : base("name=QLCT_LIZARDett")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHITIETCHITIEU> CHITIETCHITIEU { get; set; }
        public virtual DbSet<CHITIETTHUNHAP> CHITIETTHUNHAP { get; set; }
        public virtual DbSet<KHOANNO> KHOANNO { get; set; }
        public virtual DbSet<KHOANVAY> KHOANVAY { get; set; }
        public virtual DbSet<LOAICHITIEU> LOAICHITIEU { get; set; }
        public virtual DbSet<LOAITHUNHAP> LOAITHUNHAP { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNG { get; set; }
        public virtual DbSet<PHANHOI> PHANHOI { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOAN { get; set; }
    }
}
