-- Account
-- Thong tin sanh
-- Thuc don
-- Dich vu
-- thong tin khach hang
-- thong tin dat tiec
-- lap hoa don
-- nhan vien 
-- bao cao
Create table TaiKhoan
(
	id int identity primary key,
	TenDangNhap nvarchar(100) not null,
	MatKhau nvarchar(1000 ) not null
)
go 
Create table ThongTinSanh
(
	LoaiSanh char(5) primary key,
	TenSanh nvarchar(10) not null,
	SoLuongBanToiDa float not null,
	DonGiaToiThieu money not null,
	GhiChu nvarchar(30)
)
go 
Create table ThucDon
(
	MaThucDon char(5) primary key,
	MonKhaiVi nvarchar(100) not null,
	MonChinh1 nvarchar(100)not null,
	MonChinh2 nvarchar(100) not null,
	MonChinh3 nvarchar(100) not null,
	Lau nvarchar(100) not null,
	TrangMieng nvarchar(100) not null,
	Bia nvarchar(100) not null,
	NuocNgot nvarchar(100)not null,
	GiaThucDon money not null
)
go
create table DichVu
(
	MaDichVu  char(5) primary key,
	Ruou nvarchar(10),
	BanhKem nvarchar(10),
	Mc nvarchar(30),
	BanNhac nvarchar(10),
	CaSi nvarchar(15),
	Dj nvarchar(15),
	GiaDichVu money
)
go

Create table ThongTinkhachHang
(
	MaKhachHang char(5) primary key,
	NgayLap date not null,
	TenKhachHang nvarchar(100) not null,
	TenChuRe nvarchar(100) not null,
	TenCoDau nvarchar(100) not null,
	DiaChi nvarchar(100) not null,
	DienThoai nvarchar(15) not null,
	Email nvarchar(100) not null,
	NgayToChuc date not null
)
go
Create table ThongTinDatTiec
(
	MaDatTiec char(5) primary key,
	MaKhachHang char(5) foreign key references ThongTinKhachHang(MaKhachHang),
	LoaiSanh char(5) foreign key references ThongTinSanh(LoaiSanh),
	MaThucDon char(5) foreign key references ThucDon(MaThucDon),
	MaDichVu char(5) foreign key references DichVu(MaDichVu),
	SoLuongNhanVien int not null,
	TrangThai nvarchar(30) not null, -- Da dat || Chua Dat
	Ca nvarchar(5) not null
)
go 
Create table HoaDon
(
	MaHoaDon char(5) primary key,
	MaKhachHang char(5) foreign key references ThongTinKhachHang(MaKhachHang),
	MaDatTiec char(5) foreign key references ThongTinDatTiec(MaDatTiec),
	ThucDon char(5) foreign key references ThucDon(MaThucDon),
	DichVu char(5) foreign key references DichVu(MaDichVu),
	TienThucDon money not null,
	TienDichVu money,
	TienPhat money,
	TongTienHoaDon money not null,
	TienCoc money not null,
	TienConLai money 
)
go
Create table NhanVien
(
	MaNhanVien char(5) primary key,
	TenNhanVien nvarchar(30) not null,
	SoDienThoai nvarchar(15) not null,
	DiaChi nvarchar(40) not null,
	LoaiSanh char(5) foreign key references ThongTinSanh(LoaiSanh),
	ChucVu nvarchar(10) not null,
	Ca nvarchar(5) not null
)
go
Create table BaoCaoDoanhThu
(
	MaBaoCao char(5) primary key,
	MaNhanVien char(5) foreign key references NhanVien(MaNhanVien),
	ThangBaoCao nvarchar(4) not null,
	NamBaoCao nvarchar(4) not null,
	NgayLap date not null,
	SoLuongTiec int 
)
go
--Tai Khoan
insert into TaiKhoan values(N'12345',N'Nguyễn Thái Dương')
insert into TaiKhoan values(N'12346',N'Đào Anh Nữ Huyền Thoại')
insert into TaiKhoan values(N'12347',N'Trương Thị Thu Thiên')
go
--ThongTinSanh
insert into ThongTinSanh values(N'Sanh1',N'Sanh A',N'500',N'50000000','')
insert into ThongTinSanh values(N'Sanh2',N'Sanh B',N'450',N'45000000','')
insert into ThongTinSanh values(N'Sanh3',N'Sanh C',N'400',N'40000000','')
insert into ThongTinSanh values(N'Sanh4',N'Sanh D',N'350',N'35000000','')
insert into ThongTinSanh values(N'Sanh5',N'Sanh E',N'300',N'30000000','')
go
--ThucDon
insert into ThucDon values(N'TDON1',N'Chả Giò Rế Hà Nội',N'Gà Ấp Chảo + Bánh Bao',N'Dê Hấp Lá Tía Tô',N'Tôm Sông Rang Muối',N'Lẩu Thái Hải Sản',N'Thanh Nhiệt Sâm Sâm',N'Heniken',N'Pepsi',N'2000000')
insert into ThucDon values(N'TDON2',N'Suop Cua Gà Xé',N'Gà Bó Xôi',N'Bò Nấu Đậu + Bánh Mì',N'Vịt Quay Bắc Kinh',N'Lẩu Nắm Hải Sản',N'Chè Hạt Sen',N'Tiger Bạc',N'Trà Xanh',N'1800000')
insert into ThucDon values(N'TDON3',N'Gỏi Gó Sen Tôm Thit',N'Gà Hấp Hành + Xôi',N'Cá Điêu Hồng Chưng Tương',N'Chim Cút Roti + Bánh Mì',N'Lẩu Thái Hải Sản',N'Chè Hạt Sen',N'Heniken',N'Cocacola',N'2000000')
insert into ThucDon values(N'TDON4',N'Suop Hải Sản Nấm Tuyết',N'Gà Nấu Lagu + Bánh Mì',N'Cá Điêu Hồng Hấp HongKong',N'Gà Bó Xôi',N'Lẩu Cua Đồng',N'Rau Câu Ngũ Sắc',N'Tiger',N'Pepsi',N'1800000')
insert into ThucDon values(N'TDON5',N'Chả Giò Venus',N'Chim Cút Roti + Bánh Mì',N'Tôm Sông Rang Muối',N'Cá Điêu Hồng Chưng Tương',N'Lẩu Cá Bớp',N'Chè Khúc Bạch',N'Heniken',N'Pepsi',N'2000000')
go
--DichVu
insert into DichVu values('DV1','Rượu vang','2 Tầng','Minh Anh','Band 1','Như Yến','Dan')
insert into DichVu values('DV2','Rượu Vang','3 Tầng','Ngọc Như','Band 2','Ngọc Bích','Black')
insert into DichVu values('DV3','Rượu Vang','4 Tầng','Anh Tuấn','Band 3','Hoàng Ngọc','DN')
insert into DichVu values('DV4','Rượu Vang','5 Tầng','Tuấn Khang','Band 4','Nguyên Khang','Mie')
go
--KhachHang
insert into ThongTinKhachHang values(N'KH1','3/12/2018',N'Nguyễn Thành Tài',N'Nguyễn Thành Tài',N'Hoàng Thị Bích Ngọc',N'Thị Trấn Bến Cầu,Huyện Bến Cầu Tỉnh Tây Ninh',N'0169356263',N'nguyentai23998@gmail.com',N'12/2/2018')
insert into ThongTinKhachHang values(N'KH2',N'4/10/2018',N'Hà Như Ý',N'Hà Như Ý',N'Nguyễn Thị Tố Như',N'Phường Linh Trung, Quận Thủ Đức, Tp.Hồ Chí Minh',N'0162345347',N'nhuy1998@gmail.com',N'12/12/2018')
insert into ThongTinKhachHang values(N'KH3','3/11/2018','Nguyễn Thị Thu Thủy','Nguyễn Hoàng Anh Khoa','Nguyễn Thị Thu Thủy','Phường Linh Trung, Quận Thủ Đức, Tp.Hồ Chí Minh','01624675673','thuthuy@gmail.com','24/12/2018')
go
--ThôngTinDatTiet
insert into ThongTinDatTiec values(N'DT1',N'KH1',N'Sanh2',N'TDON3',N'DV1',N'50',N'Chua Dat',N'Trưa')
insert into ThongTinDatTiec values(N'DT2',N'KH2',N'Sanh1',N'TDON2',N'DV2',N'55',N'Da Dat',N'Tối')
insert into ThongTinDatTiec values(N'DT3',N'KH3',N'Sanh3',N'TDON4',N'DV3',N'45',N'Chua Dat',N'Trưa')
insert into ThongTinDatTiec values(N'DT4',N'KH4',N'Sanh1',N'TDON3',N'DV1',N'50',N'Chua Dat',N'Tối')
insert into ThongTinDatTiec values(N'DT5',N'KH5',N'Sanh1',N'TDON2',N'DV2',N'55',N'Da Dat',N'Trưa')
insert into ThongTinDatTiec values(N'DT6',N'KH6',N'Sanh3',N'TDON4',N'DV3',N'45',N'Chua Dat',N'Tối')
go
--Hoa don

-- Nhan vien
--Bao cao
--Thong tin Danh Sach sanh 
create proc DanhsachSanh
as
begin
	select * from ThongTinSanh
end
go

--Thong tin tiec cuoi
create proc ThongTinTiec
as
begin
	select * from ThucDon
	select * from DichVu
end
go

-- Them mot hop dong moi
create proc ThemHopDong
@MaDatTiec nvarchar(5),
@NgayLap date,
@TenKhachHang nvarchar(30),
@TenChuRe nvarchar(30),
@TenCoDau nvarchar(30),
@DiaChi nvarchar(50),
@DienThoai nvarchar(15),
@Email nvarchar(40),
@NgayToChuc date,
@LoaiSanh char(5),
@Ca nvarchar(5),
@SoLuongBan int,
@SoLuongNhanVien int,
@MaThucDon char(5),
@MaDichVu char(5),
@TrangThai nvarchar(30)
as
begin
	insert into ThongTinDatTiec values ( @MaDatTiec, @LoaiSanh, @Ca, @SoLuongBan, @SoLuongNhanVien, @MaThucDon, @MaDichVu, @TrangThai)
end
go

--Kiem tra sanh trong hay khong 
create proc KiemTraSanh
@TrangThai nvarchar(30)
as
begin
	if exists (select * from ThongTinDatTiec where TrangThai = @TrangThai and TrangThai = "Chua Dat")
	begin 
		update ThongTinDatTiec set TrangThai = "Da Dat"
		where TrangThai = @TrangThai
	end
	else
	begin
		return
	end
end
go
--