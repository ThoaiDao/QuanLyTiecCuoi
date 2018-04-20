-- ??ng Nh?p
-- S?nh
-- Lo?i S?nh
-- Tr?ng Thái S?nh
-- Phi?u ??t ti?c c??i
-- Khách Hàng
-- Chi ti?t ??t s?nh
-- Phi?u ??t ti?c c??i
-- Khách hàng
-- Chi ti?t ??t món
-- Món ?n
-- Chi ti?t ??t d?ch v?
-- D?ch v?
-- Hóa ??n
-- Nhân Viên
CREATE TABLE DangNhap
(
	DisplayName NVARCHAR(100) PRIMARY KEY,
	UserName NVARCHAR(100) NOT NULL,
	Password INT NOT NULL
)
GO
CREATE TABLE LoaiSanh
(
	MaLoaiSanh VARCHAR(10)PRIMARY KEY,
	TenLoaiSanh VARCHAR(20),
	DonGiaBanToiThieu DECIMAL(10,0)
)
GO
CREATE TABLE Sanh
(
	MaSanh VARCHAR(10) PRIMARY KEY ,
	TenSanh VARCHAR(20),
	MaLoaiSanh VARCHAR(10),
	SoLuongBanToiDa INT,
	GhiChu VARCHAR(100),
	FOREIGN KEY(MaLoaiSanh) REFERENCES LoaiSanh(MaLoaiSanh),
)
GO
CREATE TABLE LoaiCa
(
	MaLoaiCa VARCHAR(10)PRIMARY KEY,
	TenLoaiCa VARCHAR(50),
	MoTa VARCHAR(100)
)
GO

CREATE TABLE TrangThaiSanh
(
	MaTrangThai VARCHAR(10) PRIMARY KEY,
	MaSanh VARCHAR(10) ,
	Ngay DATE NOT NULL,
	MaLoaiCa VARCHAR(10),
	TrangThai BIT,
	FOREIGN KEY(MaSanh) REFERENCES Sanh(MaSanh),
	FOREIGN KEY(MaLoaiCa) REFERENCES LoaiCa(MaLoaiCa),
)
GO 
CREATE TABLE KhachHang
(
	MaKhachHang VARCHAR(10) PRIMARY KEY,
	TenChuRe VARCHAR(50) ,
	TenCoDau VARCHAR(50),
	DienThoai INT
)
GO
CREATE TABLE PhieuDatTiec
(
	MaPhieuDatTiec VARCHAR(10) PRIMARY KEY,
	MaKhachHang VARCHAR(10) NOT NULL,
	Ngay DATE NOT NULL,
	MaLoaiCa VARCHAR(10),
	TienCoc DECIMAL (10,0) NOT NULL
	FOREIGN KEY(MaKhachHang) REFERENCES KhachHang(MaKhachHang),
	FOREIGN KEY(MaLoaiCa) REFERENCES LoaiCa(MaLoaiCa)
)
GO
CREATE TABLE ChiTietDatSanh
(
	MaChiTietDatSanh VARCHAR(10) PRIMARY KEY,
	MaPhieuDatTiec VARCHAR(10) NOT NULL,
	MaSanh VARCHAR(10) NOT NULL,
	SoBanChinhThuc INT,
	SoBanDuTru INT,
	DonGiaBan DECIMAL (10,0),
	FOREIGN KEY(MaPhieuDatTiec) REFERENCES PhieuDatTiec(MaPhieuDatTiec),
	FOREIGN KEY(MaSanh) REFERENCES Sanh(MaSanh)
)
GO 
CREATE TABLE MonAn
(
	MaMonAn VARCHAR(10) PRIMARY KEY,
	TenMonAn VARCHAR(50),
	DonGia DECIMAL(10,0)
)
GO 
CREATE TABLE ChiTietDatMon
(
	MaChiTietDatMon VARCHAR(10) PRIMARY KEY,
	MaPhieuDatTiec VARCHAR(10) NOT NULL,
	MaMonAn VARCHAR(10) NOT NULL,
	GhiChu VARCHAR,
	FOREIGN KEY(MaPhieuDatTiec) REFERENCES PhieuDatTiec(MaPhieuDatTiec),
	FOREIGN KEY(MaMonAn) REFERENCES MonAn(MaMonAn)
)
GO
CREATE TABLE DichVu
(
	MaDichVu VARCHAR(10) PRIMARY KEY,
	TenDichVu VARCHAR(50),
	DonGia DECIMAL(10,0)
)
GO
CREATE TABLE ChiTietDatDichVu
(
	MaChiTietDatDichVu VARCHAR(10) PRIMARY KEY,
	MaPhieuDatTiec VARCHAR(10) NOT NULL,
	MaDichVu VARCHAR(10) NOT NULL,
	SoLuong INT,
	ThanhTien DECIMAL(10,0),
	FOREIGN KEY(MaPhieuDatTiec) REFERENCES PhieuDatTiec(MaPhieuDatTiec),
	FOREIGN KEY(MaDichVu) REFERENCES DichVu(MaDichVu),
)
GO
CREATE TABLE HoaDon
(
	MaHoaDon VARCHAR(10) PRIMARY KEY,
	MaPhieuDatTiec VARCHAR(10) NOT NULL,
	SoBanDuTruDaDung INT,
	NgayThanhToan DATE NOT NULL,
	TongTienBan DECIMAL(10,0),
	TongTienDichVu DECIMAL(10,0),
	IienPhat DECIMAL(10,0),
	TongTienHoaDon DECIMAL(10,0),
	TienDatCoc DECIMAL(10,0),
	TienConThieu DECIMAL(10,0),
	FOREIGN KEY(MaPhieuDatTiec) REFERENCES PhieuDatTiec(MaPhieuDatTiec),
)
GO 
CREATE TABLE NHANVIEN
(
	MaNhanVien VARCHAR(10) PRIMARY KEY,
	TenNhanVien VARCHAR(50),
	MaSanh VARCHAR(10),
	MaLoaiCa VARCHAR(10),
	SoLuongNhanVien INT,
	FOREIGN KEY(MaSanh) REFERENCES Sanh(MaSanh),
	FOREIGN KEY(MaLoaiCa) REFERENCES LoaiCa(MaLoaiCa),
)

