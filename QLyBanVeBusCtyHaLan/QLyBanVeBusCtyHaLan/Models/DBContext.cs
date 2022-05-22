namespace QLyBanVeBusCtyHaLan.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBConnectionString")
        {
        }

        public virtual DbSet<BaoCaoBanVe> BaoCaoBanVes { get; set; }
        public virtual DbSet<ChiTietBaoCao> ChiTietBaoCaos { get; set; }
        public virtual DbSet<ChiTietVeThang> ChiTietVeThangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiVe> LoaiVes { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Quyen> Quyens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TuyenXe> TuyenXes { get; set; }
        public virtual DbSet<VeThang> VeThangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoCaoBanVe>()
                .Property(e => e.mabaocao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BaoCaoBanVe>()
                .Property(e => e.maNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BaoCaoBanVe>()
                .Property(e => e.matuyen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BaoCaoBanVe>()
                .HasMany(e => e.ChiTietBaoCaos)
                .WithRequired(e => e.BaoCaoBanVe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChiTietBaoCao>()
                .Property(e => e.mabaocao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietBaoCao>()
                .Property(e => e.maloaive)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietBaoCao>()
                .Property(e => e.dongiaban)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietVeThang>()
                .Property(e => e.maVe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietVeThang>()
                .Property(e => e.hansudung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.maKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.gioitinh)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiVe>()
                .Property(e => e.maloai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiVe>()
                .Property(e => e.dongia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LoaiVe>()
                .HasMany(e => e.ChiTietBaoCaos)
                .WithRequired(e => e.LoaiVe)
                .HasForeignKey(e => e.maloaive)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiVe>()
                .HasMany(e => e.VeThangs)
                .WithRequired(e => e.LoaiVe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.maquyen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.tendangnhap)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.matkhau)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.maNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.cmnd)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.BaoCaoBanVes)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quyen>()
                .Property(e => e.maquyen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TuyenXe>()
                .Property(e => e.matuyen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TuyenXe>()
                .HasMany(e => e.VeThangs)
                .WithRequired(e => e.TuyenXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VeThang>()
                .Property(e => e.maVe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VeThang>()
                .Property(e => e.maKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VeThang>()
                .Property(e => e.maloai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VeThang>()
                .Property(e => e.matuyen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VeThang>()
                .HasMany(e => e.ChiTietVeThangs)
                .WithRequired(e => e.VeThang)
                .WillCascadeOnDelete(false);
        }
    }
}
