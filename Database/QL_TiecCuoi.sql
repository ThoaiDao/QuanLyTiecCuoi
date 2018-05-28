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
--Tai Khoan
insert into TaiKhoan values(N'NguyenThaiDuong',N'12345')
insert into TaiKhoan values(N'DaoAnhNuHuyenThoai',N'12346')
insert into TaiKhoan values(N'TruongThiThuThien',N'12347')
go
select * from TaiKhoan
--Thong Tin Sanh
go 
Create table ThongTinSanh1
(
	LoaiSanh char(100) primary key,
	TenSanh nvarchar(100) not null,
	SoLuongBanToiDa float not null,
	DonGiaToiThieu money not null,
	GhiChu nvarchar(100)
)
go 
insert into ThongTinSanh1 values(N'S1',N'A_1',N'500',N'50000000','Trống Ca Tôi')
insert into ThongTinSanh1 values(N'S2',N'B_2',N'450',N'45000000','Full')
insert into ThongTinSanh1 values(N'S3',N'C_3',N'400',N'40000000','Trống Ca Trưa')
insert into ThongTinSanh1 values(N'S4',N'D_4',N'350',N'35000000','Full')
insert into ThongTinSanh1 values(N'S6',N'E_5',N'300',N'30000000','Trống')
insert into ThongTinSanh1 values(N'S7',N'E_5',N'300',N'30000000','Trống')
go
select * from ThongTinSanh1
--them sanh moi
go
create proc ThemSanhMoi
@LoaiSanh char(100),
@TenSanh nvarchar(100),
@SoLuongBanToiDa float,
@DonGiaToiThieu money,
@GhiChu nvarchar(100)
as
begin
	insert into ThongTinSanh1 values(@LoaiSanh, @TenSanh, @SoLuongBanToiDa, @DonGiaToiThieu, @GhiChu)

end
go


--ThucDoninsert into ThemSanhMoi values(N'S5',N'E_5',N'300',N'30000000','Trống')
Create table ThucDon
(
	MaThucDon char(100) primary key,
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

insert into ThucDon values(N'TDON1',N'Chả Giò Rế Hà Nội',N'Gà Ấp Chảo + Bánh Bao',N'Dê Hấp Lá Tía Tô',N'Tôm Sông Rang Muối',N'Lẩu Thái Hải Sản',N'Thanh Nhiệt Sâm Sâm',N'Heniken',N'Pepsi',N'2000000')
insert into ThucDon values(N'TDON2',N'Suop Cua Gà Xé',N'Gà Bó Xôi',N'Bò Nấu Đậu + Bánh Mì',N'Vịt Quay Bắc Kinh',N'Lẩu Nắm Hải Sản',N'Chè Hạt Sen',N'Tiger Bạc',N'Trà Xanh',N'1800000')
insert into ThucDon values(N'TDON3',N'Gỏi Gó Sen Tôm Thit',N'Gà Hấp Hành + Xôi',N'Cá Điêu Hồng Chưng Tương',N'Chim Cút Roti + Bánh Mì',N'Lẩu Thái Hải Sản',N'Chè Hạt Sen',N'Heniken',N'Cocacola',N'2000000')
insert into ThucDon values(N'TDON4',N'Suop Hải Sản Nấm Tuyết',N'Gà Nấu Lagu + Bánh Mì',N'Cá Điêu Hồng Hấp HongKong',N'Gà Bó Xôi',N'Lẩu Cua Đồng',N'Rau Câu Ngũ Sắc',N'Tiger',N'Pepsi',N'1800000')
insert into ThucDon values(N'TDON5',N'Chả Giò Venus',N'Chim Cút Roti + Bánh Mì',N'Tôm Sông Rang Muối',N'Cá Điêu Hồng Chưng Tương',N'Lẩu Cá Bớp',N'Chè Khúc Bạch',N'Heniken',N'Pepsi',N'2000000')
go
select * from ThucDon
-- Dich Vu
go
create table DichVu
(
	MaDichVu  char(100) primary key,
	Ruou nvarchar(100),
	BanhKem nvarchar(100),
	Mc nvarchar(100),
	BanNhac nvarchar(100),
	CaSi nvarchar(100),
	Dj nvarchar(100),
	GiaDichVu money
)
go

insert into DichVu values(N'DV1','Rượuvang',N'2Tầng',N'Minh Anh',N'Band 1', N'NhưYến',N'Dan',1000000)
insert into DichVu values(N'DV2','RượuVang',N'3Tầng',N'Ngọc Như',N'Band 2',N'NgọcBích',N'Black', 2000000)
insert into DichVu values(N'DV3','RượuVang',N'4Tầng',N'Anh Tuấn',N'Band 3',N'HoàngNgọc',N'DN', 3000000)
insert into DichVu values(N'DV4','RượuVang',N'5Tầng',N'Tuấn Khang',N'Band 4',N'NguyênKhang',N'Mie', 4000000)
go
select * from DichVu
--Thong Tin Khach Hang
go
Create table ThongTinkhachHang
(
	MaKhachHang char(100) primary key,
	NgayLap date not null,
	TenKhachHang nvarchar(100) not null,
	TenChuRe nvarchar(100) not null,
	TenCoDau nvarchar(100) not null,
	DiaChi nvarchar(100) not null,
	DienThoai nvarchar(100) not null,
	Email nvarchar(100) not null,
	NgayToChuc date not null
)
go
Insert into ThongTinKhachHang (MaKhachHang, NgayLap, TenKhachHang, TenChuRe, TenCoDau, DiaChi, DienThoai,Email, NgayToChuc) 
Values('sề' , '3/30/2018' , 'hjmj' , 'fbgf' , 'dfvf' , 'dbg' , 'fbf', 'fbf', '7/12/2018')

insert into ThongTinKhachHang values(N'KH1','3/12/2018',N'Nguyễn Thành Tài',N'Nguyễn Thành Tài',N'Hoàng Thị Bích Ngọc',N'Thị Trấn Bến Cầu,Huyện Bến Cầu Tỉnh Tây Ninh',N'0169356263',N'nguyentai23998@gmail.com',N'12/2/2018')
insert into ThongTinKhachHang values(N'KH2',N'4/10/2018',N'Hà Như Ý',N'Hà Như Ý',N'Nguyễn Thị Tố Như',N'Phường Linh Trung, Quận Thủ Đức, Tp.Hồ Chí Minh',N'0162345347',N'nhuy1998@gmail.com',N'12/12/2018')
insert into ThongTinKhachHang values(N'KH3','7/11/2018','Nguyễn Thị Thu','Nguyễn Hoàng Anh','Nguyễn Thị Thu','Phường Linh Trung, Quận Thủ Đức, Tp.Hồ Chí Minh','01624675674','thu@gmail.com','26/12/2018')
insert into ThongTinKhachHang values(N'KH4','3/12/2018',N'Nguyễn Thành ',N'Nguyễn Thành',N'Hoàng Thị Ngọc',N'Thị Trấn Bến Cầu,Huyện Bến Cầu Tỉnh Tây Ninh',N'0169356263',N'nguyentai23998@gmail.com',N'12/2/2018')
insert into ThongTinKhachHang values(N'KH5',N'4/10/2018',N'Hà Như Ý',N'Hà Như ',N'Nguyễn Thị Vân',N'Phường Linh Trung, Quận Thủ Đức, Tp.Hồ Chí Minh',N'0162345347',N'nhuy1998@gmail.com',N'12/12/2018')
go
select TenKhachHang from ThongTinkhachHang
--Thong Tin Dat Tiec
go
Create table ThongTinDatTiec1
(
	MaDatTiec char(100) primary key,
	MaKhachHang char(100) foreign key references ThongTinKhachHang(MaKhachHang),
	LoaiSanh char(100) foreign key references ThongTinSanh1(LoaiSanh),
	MaThucDon char(100) foreign key references ThucDon(MaThucDon),
	MaDichVu char(100) foreign key references DichVu(MaDichVu),
	SoLuongNhanVien int not null,
	TrangThai nvarchar(100) not null, -- Da dat || Chua Dat
	Ca nvarchar(100) not null
	
)
ALTER TABLE ThongTinDatTiec1 ADD SoLuongBan int
go 

insert into ThongTinDatTiec1 values(N'DT1',N'KH1',N'S2',N'TDON3',N'DV1',N'50',N'Chua Dat',N'Trưa')
insert into ThongTinDatTiec1 values(N'DT2',N'KH2',N'S1',N'TDON2',N'DV2',N'55',N'Da Dat',N'Tối')
insert into ThongTinDatTiec1 values(N'DT3',N'KH3',N'S3',N'TDON4',N'DV3',N'45',N'Chua Dat',N'Trưa')
insert into ThongTinDatTiec1 values(N'DT4',N'KH4',N'S1',N'TDON2',N'DV2',N'55',N'Sẵn Sàng',N'Tối')
insert into ThongTinDatTiec1 values(N'DT5',N'KH5',N'S3',N'TDON4',N'DV3',N'45',N'Chưa Sẵn sàng',N'Trưa')
go
select * from ThongTinDatTiec1
--Hóa Don
go
Create table HoaDon
(
	MaHoaDon char(100) primary key,
	MaKhachHang char(100) foreign key references ThongTinKhachHang(MaKhachHang),
	MaDatTiec char(100) foreign key references ThongTinDatTiec(MaDatTiec),
	ThucDon char(100) foreign key references ThucDon(MaThucDon),
	DichVu char(100) foreign key references DichVu(MaDichVu),
	TienThucDon money not null,
	TienDichVu money,
	TienPhat money,
	TongTienHoaDon money not null,
	TienCoc money not null,
	TienConLai money 
)

go
--Nhan Vien tiep tan
Create table NhanVienTiepTan
(
	MaNhanVien char(100) primary key,
	TenNhanVien nvarchar(100) not null,
	SoDienThoai nvarchar(100) not null,
	DiaChi nvarchar(100) not null,
	Ca nvarchar(100) not null
)
go
insert into NhanVienTiepTan values(N'', N'', N'',N'', N'')
insert into NhanVienTiepTan values(N'01', N'Huyền Thoại', N'01223810110',N'Hoàng Diệu 2', N'Sáng')
insert into NhanVienTiepTan values(N'02', N'Thu Thiên', N'01223810111',N'Hoàng Diệu 3', N'Trưa')
insert into NhanVienTiepTan values(N'03', N'Thái Dương', N'01223810112',N'Hoàng Diệu 4', N'Tối')
insert into NhanVienTiepTan values(N'04', N'Duy Tân', N'01223810113',N'Hoàng Diệu 5', N'Sáng')
go
select * from NhanVienTiepTan
--Nhan Vien Trông Tiec
go

Create table NhanVien
(
	MaNhanVien char(100) primary key,
	TenNhanVien nvarchar(100) not null,
	SoDienThoai nvarchar(100) not null,
	DiaChi nvarchar(100) not null,
	LoaiSanh char(100) foreign key references ThongTinSanh(LoaiSanh),
	ChucVu nvarchar(100) not null,
	Ca nvarchar(100) not null
)
go

insert into NhanVien values(N'01', N'Huyền Thoại', N'01223810110',N'Hoàng Diệu 2',N'S1',N'Tiếp tân', N'Sáng')
insert into NhanVien values(N'02', N'Thu Thiên', N'01223810111',N'Hoàng Diệu 3',N'S3',N'Phục Vụ', N'Trưa')
insert into NhanVien values(N'03', N'Thái Dương', N'01223810112',N'Hoàng Diệu 4',N'S2',N'Phục Vụ', N'Tối')
insert into NhanVien values(N'04', N'Duy Tân', N'01223810113',N'Hoàng Diệu 5',N'S4',N'Phục Vụ', N'Sáng')
go
select * from NhanVien
go
Insert into ThongTinKhachHang (MaKhachHang, TenKhachHang, TenChuRe, TenCoDau, DiaChi, DienThoai,EMail) Values('aa' ,'aa' , 'aa' , 'aa' , 'aa' , '12', 'aa')
-- bao cao doanh thu
Create table BaoCaoDoanhThu
(
	MaBaoCao char(100) primary key,
	MaNhanVien char(100) foreign key references NhanVien(MaNhanVien),
	ThangBaoCao nvarchar(100) not null,
	NamBaoCao nvarchar(100) not null,
	NgayLap date not null,
	SoLuongTiec int 
)
go
insert

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
--test
create proc usp_getTaiKhoan
@TenDangNhap nvarchar (100)
as
begin
	select * from TaiKhoan where TenDangNhap = @TenDangNhap
end
go
-- dang nhap
select * from TaiKhoan where TenDangNhap = 'DaoAnhNuHuyenThoai' and MatKhau = '12346' OR TenDangNhap = 'NguyenThaiDuong' and MatKhau ='12345' OR TenDangNhap = 'TruongThiThuThien' and MatKhau = '12347'
go
-- load thong tin sanh
select * from ThongTinSanh
--trang thai sanh
insert ThongTinSanh(TenSanh, GhiChu) values (N'SA', N'Trong')
insert ThongTinSanh(TenSanh, GhiChu) values (N'SB', N'Full')
insert ThongTinSanh(TenSanh, GhiChu) values (N'SC', N'Trong Toi')
insert ThongTinSanh(TenSanh, GhiChu) values (N'SD', N'Trong Trua')
go
select MaThucDon from ThucDon
go
select MaDichVu from DichVu
go

select MonKhaiVi from ThucDon1 where MaThucDon = N'" + a + "'

Insert into ThongTinDatTiec1 (SoLuongBan, SoLuongNhanVien) Values('3' ,'3')
Insert into ThongTinKhachHang (MaKhachHang, NgayLap, TenKhachHang, TenChuRe, TenCoDau, DiaChi, DienThoai,EMail, NgayToChuc) 
Values('a2' , '4/10/2018' , 'a' , 'a' ,'a' ,'a',1, 'a', '4/10/2018')

Insert into ThongTinKhachHang (MaKhachHang, NgayLap, TenKhachHang, TenChuRe, TenCoDau, DiaChi, DienThoai,EMail, NgayToChuc) Values('dvfd' , '21/05/2018' , 'dfvf' , 'fbgf' , 'fbfg' , 'dbg' , '56', 'fbf', '21/05/2018')

Insert into ThongTinDatTiec1 (SoLuongBan, SoLuongNhanVien,TrangThai,Ca,MaDatTiec) Values(544 ,4,'Chua Dat','Trua','bfg')
Insert into ThongTinDatTiec1 (SoLuongBan, SoLuongNhanVien,TrangThai,Ca,MaDatTiec) Values(234 ,324,'Chua Dat','Trua','DT1')