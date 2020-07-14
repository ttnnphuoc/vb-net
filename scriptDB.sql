USE [Demo]
GO
/****** Object:  StoredProcedure [dbo].[GetAllHangHoa]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllHangHoa]

AS
 
BEGIN
 
select * from tblHangHoa
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllPhanLoai]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[GetAllPhanLoai]

AS 
BEGIN
select * from tblPhanLoai
END
GO
/****** Object:  StoredProcedure [dbo].[GetHangHoa]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetHangHoa]
AS 
BEGIN
select * from tblHangHoa hh left join tblPhanLoai pl on hh.MAPL = pl.MAPL
END
GO
/****** Object:  StoredProcedure [dbo].[GetHangHoaByID]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetHangHoaByID]
@MAVT int

AS 
BEGIN
select * from tblHangHoa where MAVT = @MAVT
END
GO
/****** Object:  StoredProcedure [dbo].[GetHangHoaByMaPL]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[GetHangHoaByMaPL] @MaPL int
AS 
BEGIN
select * from tblHangHoa where MAPL = @MaPL
END

GO
/****** Object:  StoredProcedure [dbo].[Update_tblHangHoa]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Update_tblHangHoa]
@MAVT int,
@TENVT nvarchar(50),
@QUICACH nvarchar(50),
@GIABAN money,
@GHICHU ntext
AS
 
BEGIN
 
UPDATE tblHangHoa
 
SET TENVT =  @TENVT, QUICACH = @QUICACH, GIABAN = @GIABAN, GHICHU = @GHICHU
 
WHERE MAVT = @MAVT
 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateHangHoaByID]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateHangHoaByID]
@MAVT int,
@TENVT nvarchar(50),
@QUICACH nvarchar(50),
@GIABAN money,
@GHICHU text
AS 
BEGIN
update tblHangHoa set
	[TENVT] = @TENVT,
	[QUICACH] = @QUICACH,
	[GIABAN] = @GIABAN,
	[GHICHU] = @GHICHU
where [MAVT] = @MAVT
END
GO
/****** Object:  Table [dbo].[CHITIETDONHANGNHAP]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETDONHANGNHAP](
	[MaDHN] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[TrangThai] [nvarchar](50) NULL,
	[isXoa] [bit] NULL,
 CONSTRAINT [PK_CHITIETDONHANGNHAP] PRIMARY KEY CLUSTERED 
(
	[MaDHN] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETDONHANGXUAT]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETDONHANGXUAT](
	[MaDHX] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[isXoa] [bit] NULL,
 CONSTRAINT [PK_CHITIETDONHANGXUAT_1] PRIMARY KEY CLUSTERED 
(
	[MaDHX] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DAILY]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DAILY](
	[MaDL] [int] IDENTITY(1,1) NOT NULL,
	[MaLoai] [int] NULL,
	[Ten] [nvarchar](50) NULL,
	[SoDT] [varchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[isXoa] [bit] NULL,
 CONSTRAINT [PK_DAILY] PRIMARY KEY CLUSTERED 
(
	[MaDL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DONHANGNHAP]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONHANGNHAP](
	[MaDHN] [int] IDENTITY(1,1) NOT NULL,
	[MaNhaCC] [int] NOT NULL,
	[NgayNhap] [datetime] NULL,
	[MaNV] [int] NULL,
	[isXoa] [bit] NULL,
 CONSTRAINT [PK_DONHANGNHAP] PRIMARY KEY CLUSTERED 
(
	[MaDHN] ASC,
	[MaNhaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DONHANGXUAT]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONHANGXUAT](
	[MaDHX] [int] IDENTITY(1,1) NOT NULL,
	[MaDaiLy] [int] NOT NULL,
	[MaNV] [int] NULL,
	[TrangThai] [nvarchar](50) NULL,
	[isXoa] [bit] NULL,
 CONSTRAINT [PK_DONHANGXUAT] PRIMARY KEY CLUSTERED 
(
	[MaDHX] ASC,
	[MaDaiLy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIDAILY]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIDAILY](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[Cap] [int] NULL,
	[MucChietKhau] [nvarchar](50) NULL,
	[isXoa] [bit] NULL,
 CONSTRAINT [PK_LOAIDAILY] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAISANPHAM]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISANPHAM](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[isXoa] [bit] NULL,
 CONSTRAINT [PK_LOAISANPHAM] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LUUVET]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LUUVET](
	[MaDHX] [int] NOT NULL,
	[MaTram] [int] NOT NULL,
	[MaNV] [int] NOT NULL,
	[TrangThai] [bit] NULL,
	[isXoa] [bit] NULL,
 CONSTRAINT [PK_LUUVET_1] PRIMARY KEY CLUSTERED 
(
	[MaDHX] ASC,
	[MaTram] ASC,
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaCC] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[isXoa] [bit] NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[Gioitinh] [bit] NULL,
	[Ngayvaolam] [date] NULL,
	[isXoa] [bit] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[MaLoai] [int] NULL,
	[MaNCC] [int] NULL,
	[TenSP] [nvarchar](50) NULL,
	[TrongLuong] [float] NULL,
	[ThoiHanSuDung] [smallint] NULL,
	[QuyCachDongGoi] [nvarchar](50) NULL,
	[Gia] [float] NULL,
	[Ghichu] [nvarchar](50) NULL,
	[isXoa] [bit] NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblChucVu]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChucVu](
	[MACV] [int] IDENTITY(1,1) NOT NULL,
	[TENCV] [nvarchar](50) NULL,
	[GHICHU] [ntext] NULL,
 CONSTRAINT [PK_tblChucVu] PRIMARY KEY CLUSTERED 
(
	[MACV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCTPhieuThu]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTPhieuThu](
	[MATHU] [int] NOT NULL,
	[MAXUAT] [int] NOT NULL,
	[SOHD] [nvarchar](20) NULL,
	[NGAYHD] [date] NULL,
	[SOTIENBAN] [money] NULL,
	[SOTIENTHU] [money] NULL,
	[CONLAI] [money] NULL,
	[GHICHU] [text] NULL,
	[LUUMAXUAT] [bit] NULL,
 CONSTRAINT [PK_tblCTPhieuThu] PRIMARY KEY CLUSTERED 
(
	[MATHU] ASC,
	[MAXUAT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCTXuatHang]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTXuatHang](
	[MAXUAT] [int] IDENTITY(1,1) NOT NULL,
	[MAVT] [int] NOT NULL,
	[DONGIAX] [money] NULL,
	[SOLUONGX] [int] NULL,
	[VAT] [decimal](18, 0) NULL,
	[THANHTIENX] [money] NULL,
	[GHICHU] [text] NULL,
	[DVT] [nvarchar](50) NULL,
	[TENVT] [nvarchar](50) NULL,
	[LUUMAVT] [bit] NULL,
 CONSTRAINT [PK_tblCTXuatHang] PRIMARY KEY CLUSTERED 
(
	[MAXUAT] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHangHoa]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHangHoa](
	[MAVT] [int] IDENTITY(1,1) NOT NULL,
	[MAPL] [int] NULL,
	[TENVT] [nvarchar](50) NULL,
	[QUICACH] [nvarchar](50) NULL,
	[GIAMUA] [money] NULL,
	[GIABAN] [money] NULL,
	[DVT] [nvarchar](50) NULL,
	[TYLE] [decimal](18, 0) NULL,
	[GHICHU] [text] NULL,
	[TONKHOMIN] [int] NULL,
	[TONKHOMAX] [int] NULL,
	[TONKHO] [int] NULL,
	[LUUMAVT] [bit] NULL,
	[NgayNhap] [date] NULL,
 CONSTRAINT [PK_tblHangHoa] PRIMARY KEY CLUSTERED 
(
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[MAKH] [int] IDENTITY(1,1) NOT NULL,
	[TENKH] [nvarchar](200) NOT NULL,
	[DIACHI] [text] NOT NULL,
	[DIENTHOAI] [nvarchar](20) NOT NULL,
	[EMAIL] [nvarchar](100) NULL,
	[FAX] [nvarchar](100) NULL,
	[GHICHU] [ntext] NULL,
	[THANG] [nvarchar](20) NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblKho]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKho](
	[MAKHO] [int] IDENTITY(1,1) NOT NULL,
	[TENKHO] [nvarchar](200) NULL,
	[DIACHI] [nvarchar](200) NULL,
	[DIENTHOAI] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](100) NULL,
	[GHICHU] [text] NULL,
 CONSTRAINT [PK_tblKho] PRIMARY KEY CLUSTERED 
(
	[MAKHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MANV] [int] IDENTITY(1,1) NOT NULL,
	[MACV] [int] NOT NULL,
	[TENNV] [nvarchar](200) NOT NULL,
	[CMND] [nvarchar](50) NOT NULL,
	[NGAYSINH] [date] NULL,
	[DIACHI] [text] NULL,
	[DIENTHOAI] [nvarchar](20) NOT NULL,
	[EMAIL] [nvarchar](100) NULL,
	[GHICHU] [ntext] NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPhanLoai]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhanLoai](
	[MAPL] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](200) NULL,
	[GHICHU] [text] NULL,
 CONSTRAINT [PK_tblPhanLoai] PRIMARY KEY CLUSTERED 
(
	[MAPL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPhieuThu]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuThu](
	[MATHU] [int] IDENTITY(1,1) NOT NULL,
	[MAKH] [int] NULL,
	[TENPT] [nvarchar](100) NULL,
	[NGAYT] [date] NULL,
	[SOTIENT] [money] NULL,
	[GHICHU] [text] NULL,
 CONSTRAINT [PK_tblPhieThu] PRIMARY KEY CLUSTERED 
(
	[MATHU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblXuatHang]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblXuatHang](
	[MAXUAT] [int] IDENTITY(1,1) NOT NULL,
	[MAKHO] [nvarchar](50) NULL,
	[MANV] [int] NULL,
	[MAKH] [int] NULL,
	[TENPX] [nvarchar](100) NULL,
	[NGAYXUAT] [date] NULL,
	[NGAYTRA] [date] NULL,
	[SOTIENX] [money] NULL,
	[GHICHU] [text] NULL,
	[CHUNGTUNGOC] [nvarchar](50) NULL,
	[NGAYHD] [date] NULL,
	[VANCHUYEN] [nvarchar](50) NULL,
	[KHONHAP] [nvarchar](50) NULL,
	[CONLAI] [int] NULL,
	[LUUMAXUAT] [bit] NULL,
 CONSTRAINT [PK_tblXuatHang] PRIMARY KEY CLUSTERED 
(
	[MAXUAT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRAM]    Script Date: 2/21/2020 10:45:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRAM](
	[MaTram] [int] IDENTITY(1,1) NOT NULL,
	[TenTram] [nvarchar](50) NULL,
	[isXoa] [bit] NULL,
 CONSTRAINT [PK_TRAM] PRIMARY KEY CLUSTERED 
(
	[MaTram] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (1, 1, 50, NULL, 0)
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (1, 2, 20, N'', 0)
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (2, 2, 50, NULL, 0)
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (3, 3, 50, NULL, 0)
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (4, 4, 50, NULL, 0)
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (5, 5, 50, NULL, 0)
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (6, 6, 50, NULL, 0)
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (7, 7, 50, NULL, 0)
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (8, 8, 50, NULL, 0)
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (9, 9, 50, NULL, 0)
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (10, 10, 50, NULL, 0)
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (11, 11, 50, NULL, 0)
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (12, 12, 50, NULL, 0)
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (13, 13, 50, NULL, 0)
INSERT [dbo].[CHITIETDONHANGNHAP] ([MaDHN], [MaSP], [SoLuong], [TrangThai], [isXoa]) VALUES (14, 14, 50, NULL, 0)
SET IDENTITY_INSERT [dbo].[DAILY] ON 

INSERT [dbo].[DAILY] ([MaDL], [MaLoai], [Ten], [SoDT], [DiaChi], [isXoa]) VALUES (1, 1, N'Đại lý 1', N'0123456', N'1 A Nguyễn Công Trứ, P8, Đà Lạt, Lâm Đồng', 0)
INSERT [dbo].[DAILY] ([MaDL], [MaLoai], [Ten], [SoDT], [DiaChi], [isXoa]) VALUES (2, 1, N'Đại lý 2', N'0123456', N'1 A Trần Bình Trọng, P5, Đà Lạt', 0)
INSERT [dbo].[DAILY] ([MaDL], [MaLoai], [Ten], [SoDT], [DiaChi], [isXoa]) VALUES (3, 1, N'Đại lý 3	', N'1234578', N'1 A Trần Nhân Tông, P5, Đà Lạt	', 0)
INSERT [dbo].[DAILY] ([MaDL], [MaLoai], [Ten], [SoDT], [DiaChi], [isXoa]) VALUES (4, 1, N'Đại lý 4	', N'1234578', N'1A Tôn Thất Tùng, P7, Đà Lạt	', 0)
SET IDENTITY_INSERT [dbo].[DAILY] OFF
SET IDENTITY_INSERT [dbo].[DONHANGNHAP] ON 

INSERT [dbo].[DONHANGNHAP] ([MaDHN], [MaNhaCC], [NgayNhap], [MaNV], [isXoa]) VALUES (1, 1, CAST(0x0000AA9C00000000 AS DateTime), 1, 0)
INSERT [dbo].[DONHANGNHAP] ([MaDHN], [MaNhaCC], [NgayNhap], [MaNV], [isXoa]) VALUES (2, 1, CAST(0x0000AA9C00000000 AS DateTime), 1, 0)
INSERT [dbo].[DONHANGNHAP] ([MaDHN], [MaNhaCC], [NgayNhap], [MaNV], [isXoa]) VALUES (3, 1, CAST(0x0000AA9C00000000 AS DateTime), 1, 0)
INSERT [dbo].[DONHANGNHAP] ([MaDHN], [MaNhaCC], [NgayNhap], [MaNV], [isXoa]) VALUES (4, 2, CAST(0x0000AA9C00000000 AS DateTime), 1, 0)
INSERT [dbo].[DONHANGNHAP] ([MaDHN], [MaNhaCC], [NgayNhap], [MaNV], [isXoa]) VALUES (5, 2, CAST(0x0000AA9C00000000 AS DateTime), 1, 0)
INSERT [dbo].[DONHANGNHAP] ([MaDHN], [MaNhaCC], [NgayNhap], [MaNV], [isXoa]) VALUES (6, 2, CAST(0x0000AA9C00000000 AS DateTime), 1, 0)
INSERT [dbo].[DONHANGNHAP] ([MaDHN], [MaNhaCC], [NgayNhap], [MaNV], [isXoa]) VALUES (7, 2, CAST(0x0000AA9C00000000 AS DateTime), 1, 0)
INSERT [dbo].[DONHANGNHAP] ([MaDHN], [MaNhaCC], [NgayNhap], [MaNV], [isXoa]) VALUES (8, 2, CAST(0x0000AA9C00000000 AS DateTime), 1, 0)
INSERT [dbo].[DONHANGNHAP] ([MaDHN], [MaNhaCC], [NgayNhap], [MaNV], [isXoa]) VALUES (9, 3, CAST(0x0000AA9C00000000 AS DateTime), 1, 0)
INSERT [dbo].[DONHANGNHAP] ([MaDHN], [MaNhaCC], [NgayNhap], [MaNV], [isXoa]) VALUES (10, 3, CAST(0x0000AA9C00000000 AS DateTime), 1, 0)
INSERT [dbo].[DONHANGNHAP] ([MaDHN], [MaNhaCC], [NgayNhap], [MaNV], [isXoa]) VALUES (11, 3, CAST(0x0000AA9C00000000 AS DateTime), 1, 0)
INSERT [dbo].[DONHANGNHAP] ([MaDHN], [MaNhaCC], [NgayNhap], [MaNV], [isXoa]) VALUES (12, 3, CAST(0x0000AADB00000000 AS DateTime), 4, 0)
INSERT [dbo].[DONHANGNHAP] ([MaDHN], [MaNhaCC], [NgayNhap], [MaNV], [isXoa]) VALUES (13, 3, CAST(0x0000AADD00000000 AS DateTime), 11, 0)
INSERT [dbo].[DONHANGNHAP] ([MaDHN], [MaNhaCC], [NgayNhap], [MaNV], [isXoa]) VALUES (14, 2, CAST(0x0000A9D100000000 AS DateTime), 3, 0)
SET IDENTITY_INSERT [dbo].[DONHANGNHAP] OFF
SET IDENTITY_INSERT [dbo].[LOAIDAILY] ON 

INSERT [dbo].[LOAIDAILY] ([MaLoai], [Cap], [MucChietKhau], [isXoa]) VALUES (1, 1, N'1000', 0)
INSERT [dbo].[LOAIDAILY] ([MaLoai], [Cap], [MucChietKhau], [isXoa]) VALUES (2, 2, N'850', 0)
SET IDENTITY_INSERT [dbo].[LOAIDAILY] OFF
SET IDENTITY_INSERT [dbo].[LOAISANPHAM] ON 

INSERT [dbo].[LOAISANPHAM] ([MaLoai], [TenLoai], [isXoa]) VALUES (1, N'Trà', NULL)
INSERT [dbo].[LOAISANPHAM] ([MaLoai], [TenLoai], [isXoa]) VALUES (2, N'Trái cây thông dụng sấy', NULL)
INSERT [dbo].[LOAISANPHAM] ([MaLoai], [TenLoai], [isXoa]) VALUES (3, N'Atiso', NULL)
INSERT [dbo].[LOAISANPHAM] ([MaLoai], [TenLoai], [isXoa]) VALUES (4, N'Hạt, đậu', NULL)
INSERT [dbo].[LOAISANPHAM] ([MaLoai], [TenLoai], [isXoa]) VALUES (5, N'Cà phê', NULL)
SET IDENTITY_INSERT [dbo].[LOAISANPHAM] OFF
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] ON 

INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNhaCC], [GhiChu], [isXoa]) VALUES (1, N'Nhà cung cấp A', N'Nhà cung cấp trà', 0)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNhaCC], [GhiChu], [isXoa]) VALUES (2, N'Nhà cung cấp B', N'Nhà cung cấp cà phê', 0)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNhaCC], [GhiChu], [isXoa]) VALUES (3, N'Nhà cung cấp C', N'Nhà cung cấp còn lại', 0)
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (1, N'Phan Ngọc Bảo', CAST(0x17100B00 AS Date), 1, CAST(0x9A360B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (2, N'Nguyễn Thị Huyền', CAST(0x85110B00 AS Date), 0, CAST(0x52320B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (3, N'Trần Thị Ngọc Mai', CAST(0xF2120B00 AS Date), 0, CAST(0x52320B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (4, N'Nguyễn Thị Toản', CAST(0x18100B00 AS Date), 0, CAST(0x52320B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (5, N'Đàm Đình Chung', CAST(0x11240B00 AS Date), 1, CAST(0x53320B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (6, N'Nguyễn Phan Bích Ngọc', CAST(0x11240B00 AS Date), 0, CAST(0x53320B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (7, N'Hà Vương Ngọc', CAST(0x11240B00 AS Date), 1, CAST(0x53320B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (8, N'Nguyễn Phương Nam', CAST(0x11240B00 AS Date), 1, CAST(0x53320B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (9, N'Trần Đức Lợi', CAST(0x11240B00 AS Date), 1, CAST(0x53320B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (10, N'Nguyễn Sanh Mân', CAST(0x11240B00 AS Date), 1, CAST(0x53320B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (11, N'Nguyễn Trung Toản', CAST(0x16400B00 AS Date), 1, CAST(0x33400B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (12, N'Nguyễn Trung Dũng', CAST(0x18400B00 AS Date), 1, CAST(0x36400B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (13, N'Đàm Thanh Tùng', CAST(0x513D0B00 AS Date), 1, CAST(0x38400B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (14, N'Đàm Thanh Tùng B', CAST(0x60250B00 AS Date), 1, CAST(0x2A2B0B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (15, N'Nguyễn Đức Thanh', CAST(0x07240B00 AS Date), 1, CAST(0x20330B00 AS Date), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Gioitinh], [Ngayvaolam], [isXoa]) VALUES (16, N'Đàm Đình Tiến', CAST(0x1F110B00 AS Date), 0, CAST(0x8D330B00 AS Date), 0)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[SANPHAM] ON 

INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (1, 1, 1, N'Trà sencha hoa lài', 0.5, 24, N'Đóng hộp', 105000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (2, 1, 1, N'Trà sencha hoa cúc', 0.5, 24, N'Đóng hộp', 109000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (3, 1, 1, N'Trà tim sen', 0.5, 24, N'Đóng hộp', 200000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (4, 2, 3, N'Hồng chẻ sấy dẻo', 0.5, 12, N'Đóng hộp', 80000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (5, 2, 3, N'Hồng chén sấy khô', 0.5, 12, N'Đóng hộp', 75000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (6, 3, 3, N'Bông atiso sấy khô', 0.5, 12, N'Đóng hộp', 150000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (7, 3, 3, N'Rễ atiso sấy khô', 0.5, 12, N'Đóng hộp', 200000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (8, 4, 3, N'Đậu phụng', 0.5, 12, N'Bịch', 33000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (9, 4, 3, N'Đậu nành', 0.5, 12, N'Bịch', 35000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (10, 4, 3, N'Đậu hòa lan', 0.5, 12, N'Bịch', 42000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (11, 4, 3, N'Hạt mác ca', 0.5, 12, N'Bịch', 116000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (12, 2, 3, N'Mít sấy', 0.5, 12, N'Bịch', 150000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (13, 2, 3, N'Xoài sấy dẻo', 0.5, 12, N'Bịch', 89000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (14, 2, 3, N'Khoai lang sấy dẻo', 0.5, 12, N'Bịch', 120000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (15, 2, 3, N'Chuối sấy dẻo', 0.5, 12, N'Bịch', 100000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (16, 2, 3, N'Thập cẩm sấy', 0.45, 12, N'Bịch', 75000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (17, 1, 1, N'Trà, trái nhàu túi lọc', 0.5, 24, N'Túi lọc, đóng hộp', 68000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (18, 1, 1, N'Trà tim sen túi lọc', 0.5, 24, N'Túi lọc, đóng hộp', 69000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (19, 1, 1, N'Trà cỏ ngọt túi lọc', 0.5, 24, N'Túi lọc, đóng hộp', 80000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (20, 1, 1, N'Trà hoa cúc túi lọc', 0.5, 24, N'Túi lọc, đóng hộp', 75000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (21, 1, 1, N'Trà atiso túi lọc', 0.5, 24, N'Túi lọc, đóng hộp', 65000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (22, 1, 1, N'Trà gừng túi lọc', 0.5, 24, N'Túi lọc, đóng hộp', 85000, NULL, 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (23, 2, 3, N'Hồng sấy treo Nhật Bản cắt lác', 0.09, 1, N'Cắt lác, bịch, mẫu giấy wasabi', 80000, N'Bảo quản nơi khô ráo, thoáng mát', 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (24, 5, 2, N'Cà phê phối trộn nhẹ', 0.25, 12, N'Bịch', 70000, N'Arabica 50%, Robusta 50%', 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (25, 5, 2, N'Cà phê phối trộn đậm', 0.25, 12, N'Bịch', 74000, N'Arabica 20%, Robusta 80%', 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (26, 5, 2, N'Cà phê phối trộn vừa', 0.25, 12, N'Bịch', 79000, N'Arabica 80%, Robusta 20%', 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (27, 1, 1, N'Thử nghiệm', 0.5, 2, N'Bịch', 100, N'Thành phần cấu tạo', 0)
INSERT [dbo].[SANPHAM] ([MaSP], [MaLoai], [MaNCC], [TenSP], [TrongLuong], [ThoiHanSuDung], [QuyCachDongGoi], [Gia], [Ghichu], [isXoa]) VALUES (28, 1, 1, N'Đậu hòa lan 2	', 0.5, 2, N'Bịch', 200, N'Thành phần cấu tạo', 0)
SET IDENTITY_INSERT [dbo].[SANPHAM] OFF
SET IDENTITY_INSERT [dbo].[tblHangHoa] ON 

INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (24, 1, N'Hàng Hóa 01', N'Quy cách', 10000.0000, 99999.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 2444444444', 1, 10, 100, 0, CAST(0x8E400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (25, 3, N'Hàng Hóa 02', N'Quy cách', 20000.0000, 2000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 2', 2, 20, 200, 1, CAST(0x7B400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (26, 1, N'Hàng Hóa 03', N'Quy cách', 30000.0000, 3002.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 3', 3, 30, 300, 0, CAST(0x71400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (27, 3, N'Hàng Hóa 04', N'Quy cách', 40000.0000, 4000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 4', 4, 40, 400, 1, CAST(0x84400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (28, 1, N'Hàng Hóa 05', N'Quy cách', 50000.0000, 5000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 5gggggggggg', 5, 50, 500, 0, CAST(0x8E400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (29, 2, N'Hàng Hóa 06', N'Quy cách', 60000.0000, 6000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'555555', 6, 60, 600, 1, CAST(0x89400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (30, 3, N'Hàng Hóa 07', N'Quy cách erwewet', 70000.0000, 7000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 7', 7, 70, 700, 0, CAST(0x86400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (31, 2, N'Hàng Hóa 08', N'Quy cách', 80000.0000, 8000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 8', 8, 80, 800, 1, CAST(0x8E400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (32, 2, N'Hàng Hóa 09', N'Quy cách', 90000.0000, 9000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 9', 9, 90, 900, 0, CAST(0x8E400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (33, 3, N'Hàng Hóa 10', N'Quy cách', 100000.0000, 10000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 10', 10, 100, 1000, 1, CAST(0x8E400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (34, 1, N'Hàng Hóa 11', N'Quy cách', 110000.0000, 11000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 11', 11, 110, 1100, 0, CAST(0x7F400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (35, 3, N'Hàng Hóa 12', N'Quy cách', 120000.0000, 12000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 12', 12, 120, 1200, 1, CAST(0x8E400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (36, 1, N'Hàng Hóa 13', N'Quy cách', 130000.0000, 13000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 13', 13, 130, 1300, 0, CAST(0x86400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (37, 3, N'Hàng Hóa 14', N'Quy cách', 140000.0000, 14000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 14', 14, 140, 1400, 1, CAST(0x8E400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (38, 1, N'Hàng Hóa 15', N'Quy cách', 150000.0000, 15000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 15', 15, 150, 1500, 0, CAST(0x74400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (39, 3, N'Hàng Hóa 16', N'Quy cách', 160000.0000, 16000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 16', 16, 160, 1600, 1, CAST(0x72400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (40, 2, N'Hàng Hóa 17', N'Quy cách', 170000.0000, 17000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 17', 17, 170, 1700, 0, CAST(0x78400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (41, 3, N'Hàng Hóa 18', N'Quy cách', 180000.0000, 18000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 18', 18, 180, 1800, 1, CAST(0x8E400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (42, 2, N'Hàng Hóa 19', N'Quy cách', 190000.0000, 19000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 19', 19, 190, 1900, 1, CAST(0x76400B00 AS Date))
INSERT [dbo].[tblHangHoa] ([MAVT], [MAPL], [TENVT], [QUICACH], [GIAMUA], [GIABAN], [DVT], [TYLE], [GHICHU], [TONKHOMIN], [TONKHOMAX], [TONKHO], [LUUMAVT], [NgayNhap]) VALUES (43, 3, N'Hàng Hóa 20', N'Quy cách', 200000.0000, 20000.0000, N'Gói', CAST(1 AS Decimal(18, 0)), N'Ghi chú 20', 20, 200, 2000, 1, CAST(0x7B400B00 AS Date))
SET IDENTITY_INSERT [dbo].[tblHangHoa] OFF
SET IDENTITY_INSERT [dbo].[tblPhanLoai] ON 

INSERT [dbo].[tblPhanLoai] ([MAPL], [TEN], [GHICHU]) VALUES (1, N'Phân Loại 1', N'Ghi chú 1')
INSERT [dbo].[tblPhanLoai] ([MAPL], [TEN], [GHICHU]) VALUES (2, N'Phân Loại 2', N'Ghi chú 2')
INSERT [dbo].[tblPhanLoai] ([MAPL], [TEN], [GHICHU]) VALUES (3, N'Phân Loại 3', N'Ghi chú 3')
SET IDENTITY_INSERT [dbo].[tblPhanLoai] OFF
ALTER TABLE [dbo].[LOAIDAILY] ADD  CONSTRAINT [DF_LOAIDAILY_isXoa]  DEFAULT ((0)) FOR [isXoa]
GO
ALTER TABLE [dbo].[LUUVET] ADD  CONSTRAINT [DF_LUUVET_TTVC]  DEFAULT ((0)) FOR [MaTram]
GO
ALTER TABLE [dbo].[LUUVET] ADD  CONSTRAINT [DF_LUUVET_Tram1]  DEFAULT ((0)) FOR [MaNV]
GO
ALTER TABLE [dbo].[LUUVET] ADD  CONSTRAINT [DF_LUUVET_Tram2]  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[LUUVET] ADD  CONSTRAINT [DF_LUUVET_isXoa]  DEFAULT ((0)) FOR [isXoa]
GO
ALTER TABLE [dbo].[NHACUNGCAP] ADD  CONSTRAINT [DF_NHACUNGCAP_isXoa]  DEFAULT ((0)) FOR [isXoa]
GO
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [DF_NHANVIEN_isXoa]  DEFAULT ((0)) FOR [isXoa]
GO
ALTER TABLE [dbo].[TRAM] ADD  CONSTRAINT [DF_TRAM_isXoa]  DEFAULT ((0)) FOR [isXoa]
GO
