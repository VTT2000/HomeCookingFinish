using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HomeCooking.Models
{
    public partial class HomeCooking0Context : DbContext
    {
        public HomeCooking0Context()
        {
        }

        public HomeCooking0Context(DbContextOptions<HomeCooking0Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietChuDeCongThuc> ChiTietChuDeCongThucs { get; set; }
        public virtual DbSet<ChiTietCongThucNauAn> ChiTietCongThucNauAns { get; set; }
        public virtual DbSet<ChiTietHoaDonKhachHang> ChiTietHoaDonKhachHangs { get; set; }
        public virtual DbSet<ChiTietKhoBep> ChiTietKhoBeps { get; set; }
        public virtual DbSet<ChuDeCongThuc> ChuDeCongThucs { get; set; }
        public virtual DbSet<CongThucNauAn> CongThucNauAns { get; set; }
        public virtual DbSet<HoaDonKhachHang> HoaDonKhachHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhoBepOnline> KhoBepOnlines { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<LoHang> LoHangs { get; set; }
        public virtual DbSet<LoaiThucPham> LoaiThucPhams { get; set; }
        public virtual DbSet<NhaSanXuat> NhaSanXuats { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<TheoDoiThucPham> TheoDoiThucPhams { get; set; }
        public virtual DbSet<ThucPham> ThucPhams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //optionsBuilder.UseSqlServer("Server=HOANGVU-PC\\DRAGONSERVER;Database=HomeCooking0;Trusted_Connection=True;");
         optionsBuilder.UseSqlServer("Server=DESKTOP-7JKPSMP;Database=HomeCooking0;Trusted_Connection=True;");

      }
    }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChiTietChuDeCongThuc>(entity =>
            {
                entity.HasKey(e => new { e.IdChuDe, e.IdCongThuc });

                entity.ToTable("ChiTietChuDeCongThuc");

                entity.Property(e => e.IdChuDe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCongThuc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdChuDeNavigation)
                    .WithMany(p => p.ChiTietChuDeCongThucs)
                    .HasForeignKey(d => d.IdChuDe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietChuDeCongThuc_ChuDeCongThuc");

                entity.HasOne(d => d.IdCongThucNavigation)
                    .WithMany(p => p.ChiTietChuDeCongThucs)
                    .HasForeignKey(d => d.IdCongThuc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietChuDeCongThuc_CongThucNauAn");
            });

            modelBuilder.Entity<ChiTietCongThucNauAn>(entity =>
            {
                entity.HasKey(e => new { e.IdCongThuc, e.IdFood });

                entity.ToTable("ChiTietCongThucNauAn");

                entity.Property(e => e.IdCongThuc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdFood)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCongThucNavigation)
                    .WithMany(p => p.ChiTietCongThucNauAns)
                    .HasForeignKey(d => d.IdCongThuc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietCongThucNauAn_CongThucNauAn");

                entity.HasOne(d => d.IdFoodNavigation)
                    .WithMany(p => p.ChiTietCongThucNauAns)
                    .HasForeignKey(d => d.IdFood)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietCongThucNauAn_ThucPham");
            });

            modelBuilder.Entity<ChiTietHoaDonKhachHang>(entity =>
            {
                entity.HasKey(e => new { e.IdInvoice, e.IdLoHang });

                entity.ToTable("ChiTietHoaDonKhachHang");

                entity.Property(e => e.IdInvoice)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdLoHang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdInvoiceNavigation)
                    .WithMany(p => p.ChiTietHoaDonKhachHangs)
                    .HasForeignKey(d => d.IdInvoice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietHoaDonKhachHang_HoaDonKhachHang");

                entity.HasOne(d => d.IdLoHangNavigation)
                    .WithMany(p => p.ChiTietHoaDonKhachHangs)
                    .HasForeignKey(d => d.IdLoHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietHoaDonKhachHang_LoHang");
            });

            modelBuilder.Entity<ChiTietKhoBep>(entity =>
            {
                entity.HasKey(e => new { e.IdKhoBep, e.IdInvoice, e.IdLoHang });

                entity.ToTable("ChiTietKhoBep");

                entity.Property(e => e.IdKhoBep)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdInvoice)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdLoHang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.HasOne(d => d.IdInvoiceNavigation)
                    .WithMany(p => p.ChiTietKhoBeps)
                    .HasForeignKey(d => d.IdInvoice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietKhoBep_HoaDonKhachHang");

                entity.HasOne(d => d.IdKhoBepNavigation)
                    .WithMany(p => p.ChiTietKhoBeps)
                    .HasForeignKey(d => d.IdKhoBep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietKhoBep_KhoBepOnline");
            });

            modelBuilder.Entity<ChuDeCongThuc>(entity =>
            {
                entity.HasKey(e => e.IdChuDe);

                entity.ToTable("ChuDeCongThuc");

                entity.Property(e => e.IdChuDe)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("([dbo].[AUTO_IdChuDe]())");

                entity.Property(e => e.LinkHinhAnh)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MoTaChuDe).HasColumnType("ntext");

                entity.Property(e => e.TenChuDe).HasMaxLength(100);
            });

            modelBuilder.Entity<CongThucNauAn>(entity =>
            {
                entity.HasKey(e => e.IdCongThuc);

                entity.ToTable("CongThucNauAn");

                entity.Property(e => e.IdCongThuc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("([dbo].[AUTO_IdCongThuc]())");

                entity.Property(e => e.LinkHinhAnh)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LinkVideo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MoTaMonAn).HasColumnType("ntext");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.TacGia).HasMaxLength(100);

                entity.Property(e => e.TenCongThuc).HasMaxLength(100);
            });

            modelBuilder.Entity<HoaDonKhachHang>(entity =>
            {
                entity.HasKey(e => e.IdInvoice);

                entity.ToTable("HoaDonKhachHang");

                entity.Property(e => e.IdInvoice)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("([dbo].[AUTO_IdInvoice]())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.IdKh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IdKH");

                entity.Property(e => e.IdNv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IdNV");

                entity.Property(e => e.PhuongThucThanhToan).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.HoaDonKhachHangs)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK_HoaDonKhachHang_KhachHang");

                entity.HasOne(d => d.IdNvNavigation)
                    .WithMany(p => p.HoaDonKhachHangs)
                    .HasForeignKey(d => d.IdNv)
                    .HasConstraintName("FK_HoaDonKhachHang_NhanVien");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.IdKh);

                entity.ToTable("KhachHang");

                entity.Property(e => e.IdKh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IdKH")
                    .HasDefaultValueSql("([dbo].[AUTO_IdKH]())");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DiaChi).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SDT");
            });

            modelBuilder.Entity<KhoBepOnline>(entity =>
            {
                entity.HasKey(e => e.IdKhobep)
                    .HasName("PK_KhoBepOnline_1");

                entity.ToTable("KhoBepOnline");

                entity.Property(e => e.IdKhobep)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("([dbo].[AUTO_IdKhobep]())");

                entity.Property(e => e.IdKh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IdKH");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.KhoBepOnlines)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK_KhoBepOnline_KhachHang");
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.HasKey(e => e.IdKhuyenMai);

                entity.ToTable("KhuyenMai");

                entity.Property(e => e.IdKhuyenMai)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("([dbo].[AUTO_IdKhuyenMai]())");

                entity.Property(e => e.MoTaKhuyenMai).HasColumnType("ntext");

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<LoHang>(entity =>
            {
                entity.HasKey(e => e.IdLoHang);

                entity.ToTable("LoHang");

                entity.Property(e => e.IdLoHang)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("([dbo].[AUTO_IdLoHang]())");

                entity.Property(e => e.IdFood)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHetHan).HasColumnType("date");

                entity.Property(e => e.NgayNhapLoHang).HasColumnType("datetime");

                entity.Property(e => e.NgaySanXuat).HasColumnType("date");

                entity.HasOne(d => d.IdFoodNavigation)
                    .WithMany(p => p.LoHangs)
                    .HasForeignKey(d => d.IdFood)
                    .HasConstraintName("FK_LoHang_ThucPham");
            });

            modelBuilder.Entity<LoaiThucPham>(entity =>
            {
                entity.HasKey(e => e.IdLoai);

                entity.ToTable("LoaiThucPham");

                entity.Property(e => e.IdLoai)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("([dbo].[AUTO_IdLoai]())");

                entity.Property(e => e.LinkHinhAnh)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TenLoai).HasMaxLength(100);
            });

            modelBuilder.Entity<NhaSanXuat>(entity =>
            {
                entity.HasKey(e => e.IdNsx);

                entity.ToTable("NhaSanXuat");

                entity.Property(e => e.IdNsx)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IdNSX")
                    .HasDefaultValueSql("([dbo].[AUTO_IdNSX]())");

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.NameNsx)
                    .HasMaxLength(100)
                    .HasColumnName("NameNSX");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.IdNv);

                entity.ToTable("NhanVien");

                entity.Property(e => e.IdNv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IdNV")
                    .HasDefaultValueSql("([dbo].[AUTO_IdNV]())");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DiaChi).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.IdPermission)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.Ten).HasMaxLength(100);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPermissionNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdPermission)
                    .HasConstraintName("FK_NhanVien_Permission");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.IdPermission);

                entity.ToTable("Permission");

                entity.Property(e => e.IdPermission)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("([dbo].[AUTO_IdPermission]())");

                entity.Property(e => e.Ten).HasMaxLength(100);
            });

            modelBuilder.Entity<TheoDoiThucPham>(entity =>
            {
                entity.HasKey(e => e.IdTheoDoi);

                entity.ToTable("TheoDoiThucPham");

                entity.Property(e => e.IdTheoDoi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("([dbo].[AUTO_IdTheoDoi]())");

                entity.Property(e => e.IdFood)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdKh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IdKH");

                entity.HasOne(d => d.IdFoodNavigation)
                    .WithMany(p => p.TheoDoiThucPhams)
                    .HasForeignKey(d => d.IdFood)
                    .HasConstraintName("FK_TheoDoiThucPham_ThucPham");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.TheoDoiThucPhams)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK_TheoDoiThucPham_KhachHang");
            });

            modelBuilder.Entity<ThucPham>(entity =>
            {
                entity.HasKey(e => e.IdFood);

                entity.ToTable("ThucPham");

                entity.Property(e => e.IdFood)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("([dbo].[AUTO_IdFood]())");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DonViTinh).HasMaxLength(20);

                entity.Property(e => e.IdKhuyenMai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdLoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdNsx)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IdNSX");

                entity.Property(e => e.LinkHinhAnh)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NameFood).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.HasOne(d => d.IdKhuyenMaiNavigation)
                    .WithMany(p => p.ThucPhams)
                    .HasForeignKey(d => d.IdKhuyenMai)
                    .HasConstraintName("FK_ThucPham_KhuyenMai");

                entity.HasOne(d => d.IdLoaiNavigation)
                    .WithMany(p => p.ThucPhams)
                    .HasForeignKey(d => d.IdLoai)
                    .HasConstraintName("FK_ThucPham_LoaiThucPham");

                entity.HasOne(d => d.IdNsxNavigation)
                    .WithMany(p => p.ThucPhams)
                    .HasForeignKey(d => d.IdNsx)
                    .HasConstraintName("FK_ThucPham_NhaSanXuat");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
