create database QLCT_LIZARD
go

use QLCT_LIZARD
go

create table NGUOIDUNG (
	ID int IDENTITY(1,1) PRIMARY KEY, 
	TenDangNhap nvarchar(50),
	AnhDaiDien nvarchar(max),
	MatKhau nvarchar(max),
	HoTen nvarchar(50),
	Email nvarchar(30),
	MaPin char(8),
	TrangThai bit
)

create table TAIKHOAN (
	ID int,
	MaTaiKhoan int IDENTITY(1,1),
	SoTien float,
	TenTaiKhoan nvarchar(30),
	GhiChu nvarchar(max),
	TrangThai bit,
	primary key (MaTaiKhoan, ID)
)

create table KHOANVAY (
	MaKV int IDENTITY(1,1) primary key,
	ID int, 
	MaTaiKhoan int,
	SoTienVay float,
	NgayChoVay date,
	NgayTra date,
	NguoiNo nvarchar(50),
	GhiChu nvarchar(max),
	TrangThai bit
)

create table KHOANNO (
	MaKN int IDENTITY(1,1) primary key,
	ID int, 
	MaTaiKhoan int,
	SoTienNo float,
	NgayMuonNo date,
	NgayTra date,
	NguoiVay nvarchar(50),
	GhiChu nvarchar(max),
	TrangThai bit
)

create table LOAICHITIEU (
	MaLoaiCT int IDENTITY(1,1)  primary key,
	TenChiTieu nvarchar(50),
	TrangThai bit
)

create table LOAITHUNHAP (
	MaLoaiTN int IDENTITY(1,1) primary key,
	TenThuNhap nvarchar(50), 
	TrangThai bit
)

create table CHITIETCHITIEU (
	MaCT int IDENTITY(1,1) primary key,
	ID int,
	MaLoaiCT int,
	MaTaiKhoan int, 
	SoTienCT float,
	NgayChi date,
	GhiChu nvarchar(max),
	TrangThai bit
)

create table CHITIETTHUNHAP (	
	MaTN int IDENTITY(1,1) primary key,
	ID int,
	MaLoaiTN int,
	MaTaiKhoan int, 
	SoTienTN float,
	NgayThu date,
	GhiChu nvarchar(max),
	TrangThai bit
)

create table PHANHOI
(
	MaPH int IDENTITY(1,1) primary key,
	ID int,
	TenNguoiDung nvarchar(50), 
	LienLac varchar(30),
	YKien nvarchar(max)
)

alter table TAIKHOAN
	add constraint PK_TAIKHOAN_NGUOIDUNG
		foreign key (ID)
			references NGUOIDUNG(ID)

alter table KHOANVAY
	add constraint PK_KHOANVAY_NGUOIDUNG
		foreign key (ID)
			references NGUOIDUNG(ID)

alter table KHOANNO
	add constraint PK_KHOANNO_NGUOIDUNG
		foreign key (ID)
			references NGUOIDUNG(ID)

alter table KHOANNO
	add constraint PK_KHOANNO_TAIKHOAN
		foreign key (MaTaiKhoan, ID)
			references TAIKHOAN(MaTaiKhoan, ID)

alter table KHOANVAY
	add constraint PK_KHOANVAY_TAIKHOAN
		foreign key (MaTaiKhoan, ID)
			references TAIKHOAN(MaTaiKhoan, ID)

alter table CHITIETCHITIEU
	add constraint PK_CTCT_NGUOIDUNG
		foreign key (ID)
			references NGUOIDUNG(ID)

alter table CHITIETTHUNHAP
	add constraint PK_CTTN_NGUOIDUNG
		foreign key (ID)
			references NGUOIDUNG(ID)


alter table CHITIETCHITIEU
	add constraint PK_CTCT_LOAICHITIEU
		foreign key (MaLoaiCT)
			references LOAICHITIEU(MaLoaiCT)

alter table CHITIETTHUNHAP
	add constraint PK_CTTN_LOAITHUNHAP
		foreign key (MaLoaiTN)
			references LOAITHUNHAP(MaLoaiTN)

alter table CHITIETCHITIEU
	add constraint PK_CTCT_TAIKHOAN
		foreign key (MaTaiKhoan, ID)
			references TAIKHOAN(MaTaiKhoan, ID)
			
alter table CHITIETTHUNHAP
	add constraint PK_CTTN_TAIKHOAN
		foreign key (MaTaiKhoan, ID)
			references TAIKHOAN(MaTaiKhoan, ID)

alter table PHANHOI
	add constraint PK_PHANHOI_NGUOIDUNG
		foreign key (ID)
			references NGUOIDUNG(ID)

-- Thêm dữ liệu cho Loại Chi tiêu
insert into LOAICHITIEU values(N'Ăn uống', 1)
insert into LOAICHITIEU values(N'Mua sắm', 1)
insert into LOAICHITIEU values(N'Vận chuyển', 1)
insert into LOAICHITIEU values(N'Giải trí', 1)
insert into LOAICHITIEU values(N'Nhà cửa', 1)
insert into LOAICHITIEU values(N'Gia đình', 1)
insert into LOAICHITIEU values(N'Sức khỏe', 1)
insert into LOAICHITIEU values(N'Thú nuôi', 1)
insert into LOAICHITIEU values(N'Du lịch', 1)
insert into LOAICHITIEU values(N'Khác', 1)

-- Thêm dữ liệu cho loại thu nhập
insert into LOAITHUNHAP values(N'Tiền Lương', 1)
insert into LOAITHUNHAP values(N'Tiền trợ cấp', 1)
insert into LOAITHUNHAP values(N'Tiền tiết kiệm', 1)
insert into LOAITHUNHAP values( N'Khác', 1)

select * from LOAICHITIEU
select * from LOAITHUNHAP