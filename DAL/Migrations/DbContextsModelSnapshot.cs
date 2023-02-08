﻿// <auto-generated />
using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(DbContexts))]
    partial class DbContextsModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Models.DiaChi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Nguoidung")
                        .HasColumnType("int");

                    b.Property<string>("diachi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Nguoidung");

                    b.ToTable("diaChis");
                });

            modelBuilder.Entity("DAL.Models.GiamGiaHD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChuongTrinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GiaTri")
                        .HasColumnType("float");

                    b.Property<bool>("KhongGioiHan")
                        .HasColumnType("bit");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("giamGiaHDs");
                });

            modelBuilder.Entity("DAL.Models.GiamGiaSP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("GiaTri")
                        .HasColumnType("float");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("giamGiaSPs");
                });

            modelBuilder.Entity("DAL.Models.GioHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_nguoidung")
                        .HasColumnType("int");

                    b.Property<int>("Id_spct")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_nguoidung");

                    b.HasIndex("Id_spct");

                    b.ToTable("gioHangs");
                });

            modelBuilder.Entity("DAL.Models.HinhAnhSP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_SPCT")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_SPCT");

                    b.ToTable("hinhAnhSPs");
                });

            modelBuilder.Entity("DAL.Models.HoaDon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GiaSP")
                        .HasColumnType("float");

                    b.Property<string>("HinhThucThanhToan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id_GiamGia")
                        .HasColumnType("int");

                    b.Property<int>("Id_diachi")
                        .HasColumnType("int");

                    b.Property<int>("Id_spct")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id_GiamGia");

                    b.HasIndex("Id_diachi");

                    b.HasIndex("Id_spct");

                    b.ToTable("hoaDons");
                });

            modelBuilder.Entity("DAL.Models.Mau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaHex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaRGB")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("maus");
                });

            modelBuilder.Entity("DAL.Models.NguoiDung", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NguoiDungs");
                });

            modelBuilder.Entity("DAL.Models.NhaCungCap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_SPCT")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_SPCT");

                    b.ToTable("nhaCungCaps");
                });

            modelBuilder.Entity("DAL.Models.PhanQuyen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("phanQuyens");
                });

            modelBuilder.Entity("DAL.Models.QuanLi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_phanquyen")
                        .HasColumnType("int");

                    b.Property<string>("Matkhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Id_phanquyen");

                    b.ToTable("quanLis");
                });

            modelBuilder.Entity("DAL.Models.SPCT_Mau", b =>
                {
                    b.Property<int>("Id_mau")
                        .HasColumnType("int");

                    b.Property<int>("Id_spct")
                        .HasColumnType("int");

                    b.HasKey("Id_mau", "Id_spct");

                    b.HasIndex("Id_spct");

                    b.ToTable("sPCT_Maus");
                });

            modelBuilder.Entity("DAL.Models.SanPham", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DanhMuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TheLoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sanPhams");
                });

            modelBuilder.Entity("DAL.Models.SanPhamChiTiet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("GiaNhap")
                        .HasColumnType("float");

                    b.Property<double>("GianBan")
                        .HasColumnType("float");

                    b.Property<int?>("Id_GiamGia")
                        .HasColumnType("int");

                    b.Property<int>("Id_SP")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Id_GiamGia");

                    b.HasIndex("Id_SP");

                    b.ToTable("sanPhamChiTiets");
                });

            modelBuilder.Entity("DAL.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_SPCT")
                        .HasColumnType("int");

                    b.Property<int>("size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_SPCT");

                    b.ToTable("sizes");
                });

            modelBuilder.Entity("DAL.Models.TrangThai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("Gio")
                        .HasColumnType("time");

                    b.Property<int>("Id_hoadon")
                        .HasColumnType("int");

                    b.Property<int>("Id_quanli")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayThang")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id_hoadon");

                    b.HasIndex("Id_quanli");

                    b.ToTable("trangThais");
                });

            modelBuilder.Entity("DAL.Models.DiaChi", b =>
                {
                    b.HasOne("DAL.Models.NguoiDung", "nguoiDung")
                        .WithMany("diaChis")
                        .HasForeignKey("Id_Nguoidung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("nguoiDung");
                });

            modelBuilder.Entity("DAL.Models.GioHang", b =>
                {
                    b.HasOne("DAL.Models.NguoiDung", "nguoiDung")
                        .WithMany("gioHangs")
                        .HasForeignKey("Id_nguoidung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.SanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("gioHangs")
                        .HasForeignKey("Id_spct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("nguoiDung");

                    b.Navigation("sanPhamChiTiet");
                });

            modelBuilder.Entity("DAL.Models.HinhAnhSP", b =>
                {
                    b.HasOne("DAL.Models.SanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("hinhAnhSPs")
                        .HasForeignKey("Id_SPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sanPhamChiTiet");
                });

            modelBuilder.Entity("DAL.Models.HoaDon", b =>
                {
                    b.HasOne("DAL.Models.GiamGiaHD", "giamGiaHD")
                        .WithMany("hoaDons")
                        .HasForeignKey("Id_GiamGia");

                    b.HasOne("DAL.Models.DiaChi", "diaChi")
                        .WithMany("hoaDons")
                        .HasForeignKey("Id_diachi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.SanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("hoaDons")
                        .HasForeignKey("Id_spct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("diaChi");

                    b.Navigation("giamGiaHD");

                    b.Navigation("sanPhamChiTiet");
                });

            modelBuilder.Entity("DAL.Models.NhaCungCap", b =>
                {
                    b.HasOne("DAL.Models.SanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("nhaCungCaps")
                        .HasForeignKey("Id_SPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sanPhamChiTiet");
                });

            modelBuilder.Entity("DAL.Models.QuanLi", b =>
                {
                    b.HasOne("DAL.Models.PhanQuyen", "phanQuyen")
                        .WithMany("quanLis")
                        .HasForeignKey("Id_phanquyen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("phanQuyen");
                });

            modelBuilder.Entity("DAL.Models.SPCT_Mau", b =>
                {
                    b.HasOne("DAL.Models.Mau", "mau")
                        .WithMany("sPCT_Maus")
                        .HasForeignKey("Id_mau")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.SanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("sPCT_Maus")
                        .HasForeignKey("Id_spct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mau");

                    b.Navigation("sanPhamChiTiet");
                });

            modelBuilder.Entity("DAL.Models.SanPhamChiTiet", b =>
                {
                    b.HasOne("DAL.Models.GiamGiaSP", "giamGiaSP")
                        .WithMany("sanPhamChiTiets")
                        .HasForeignKey("Id_GiamGia");

                    b.HasOne("DAL.Models.SanPham", "sanPham")
                        .WithMany("sanPhamChiTiets")
                        .HasForeignKey("Id_SP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("giamGiaSP");

                    b.Navigation("sanPham");
                });

            modelBuilder.Entity("DAL.Models.Size", b =>
                {
                    b.HasOne("DAL.Models.SanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("Sizes")
                        .HasForeignKey("Id_SPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sanPhamChiTiet");
                });

            modelBuilder.Entity("DAL.Models.TrangThai", b =>
                {
                    b.HasOne("DAL.Models.HoaDon", "hoaDon")
                        .WithMany("trangThais")
                        .HasForeignKey("Id_hoadon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.QuanLi", "quanLi")
                        .WithMany("trangThais")
                        .HasForeignKey("Id_quanli")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hoaDon");

                    b.Navigation("quanLi");
                });

            modelBuilder.Entity("DAL.Models.DiaChi", b =>
                {
                    b.Navigation("hoaDons");
                });

            modelBuilder.Entity("DAL.Models.GiamGiaHD", b =>
                {
                    b.Navigation("hoaDons");
                });

            modelBuilder.Entity("DAL.Models.GiamGiaSP", b =>
                {
                    b.Navigation("sanPhamChiTiets");
                });

            modelBuilder.Entity("DAL.Models.HoaDon", b =>
                {
                    b.Navigation("trangThais");
                });

            modelBuilder.Entity("DAL.Models.Mau", b =>
                {
                    b.Navigation("sPCT_Maus");
                });

            modelBuilder.Entity("DAL.Models.NguoiDung", b =>
                {
                    b.Navigation("diaChis");

                    b.Navigation("gioHangs");
                });

            modelBuilder.Entity("DAL.Models.PhanQuyen", b =>
                {
                    b.Navigation("quanLis");
                });

            modelBuilder.Entity("DAL.Models.QuanLi", b =>
                {
                    b.Navigation("trangThais");
                });

            modelBuilder.Entity("DAL.Models.SanPham", b =>
                {
                    b.Navigation("sanPhamChiTiets");
                });

            modelBuilder.Entity("DAL.Models.SanPhamChiTiet", b =>
                {
                    b.Navigation("gioHangs");

                    b.Navigation("hinhAnhSPs");

                    b.Navigation("hoaDons");

                    b.Navigation("nhaCungCaps");

                    b.Navigation("Sizes");

                    b.Navigation("sPCT_Maus");
                });
#pragma warning restore 612, 618
        }
    }
}
