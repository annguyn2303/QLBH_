USE [master]
GO
/****** Object:  Database [QLBH_winform]    Script Date: 24/05/2022 02:53:06 PM ******/
CREATE DATABASE [QLBH_winform]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBH_winform', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLBH_winform.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBH_winform_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLBH_winform_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLBH_winform] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH_winform].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBH_winform] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBH_winform] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBH_winform] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBH_winform] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBH_winform] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBH_winform] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBH_winform] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBH_winform] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH_winform] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBH_winform] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBH_winform] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBH_winform] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBH_winform] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBH_winform] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBH_winform] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBH_winform] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBH_winform] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBH_winform] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBH_winform] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBH_winform] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBH_winform] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBH_winform] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBH_winform] SET RECOVERY FULL 
GO
ALTER DATABASE [QLBH_winform] SET  MULTI_USER 
GO
ALTER DATABASE [QLBH_winform] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBH_winform] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBH_winform] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBH_winform] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLBH_winform] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLBH_winform] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLBH_winform] SET QUERY_STORE = OFF
GO
USE [QLBH_winform]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 24/05/2022 02:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaSP] [char](10) NOT NULL,
	[MaHD] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDon_1] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 24/05/2022 02:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](50) NOT NULL,
	[MaKH] [char](10) NOT NULL,
	[MaNV] [char](10) NOT NULL,
	[ThanhTien] [int] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 24/05/2022 02:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [char](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](4) NULL,
	[DienThoai] [char](15) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiNhanVien]    Script Date: 24/05/2022 02:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNhanVien](
	[MaLoaiNhanVien] [char](2) NOT NULL,
	[TenLoaiNhanVien] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 24/05/2022 02:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoai] [char](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 24/05/2022 02:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](4) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [char](15) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[account] [varchar](50) NULL,
	[matkhau] [varchar](max) NULL,
	[MaCV] [char](2) NULL,
	[Email] [nvarchar](50) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 24/05/2022 02:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [char](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[DVTinh] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[MaLoai] [char](10) NOT NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang1] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang1]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [QLBH_winform] SET  READ_WRITE 
GO
SELECT* FROM QLBH_winform.dbo.KhachHang
SELECT* FROM QLBH_winform.dbo.LoaiNhanVien
SELECT* FROM QLBH_winform.dbo.LoaiSanPham
SELECT* FROM QLBH_winform.dbo.SanPham
SELECT* FROM QLBH_winform.dbo.HoaDon
SELECT* FROM QLBH_winform.dbo.ChiTietHoaDon
SELECT* FROM QLBH_winform.dbo.NhanVien


