-- Account
-- Thong tin sanh
-- Thuc don
-- Dich vu
-- thong tin khach hang
-- thong tin dat tiec
-- lap hoa don
-- nhan vien 
-- bao cao



--Tai Khoan
Create table TaiKhoan
(
	id int identity(1,1) primary key,
	TenDangNhap nvarchar(100) not null,
	MatKhau nvarchar(1000 ) not null
)
go
insert into TaiKhoan values(N'ThaiDuong',N'1')
insert into TaiKhoan values(N'HuyenThoai',N'2')
insert into TaiKhoan values(N'ThuThien',N'3')
insert into TaiKhoan values(N'DuyTan',N'4')
go
select * from TaiKhoan 
delete from TaiKhoan
drop table TaiKhoan

-- ThongTinSanh
go
Create table ThongTinSanh
(
	id int identity(1,1) primary key,
	LoaiSanh nvarchar(100) ,
	TenSanh nvarchar(100) not null default N'Chưa Đặt Tên',
	SoLuongBanToiDa int not null,
	DonGiaToiThieu money not null,
	GhiChu nvarchar(100) default N'Trống',
	TiSoPhat float default 0.01
)
go

insert into ThongTinSanh values(N'Loai A',N'Kim Cương',N'500',N'50000000','Không', 0.01)
insert into ThongTinSanh values(N'Loai B',N'Bạch Kim',N'450',N'45000000','Không', 0.01)
insert into ThongTinSanh values(N'Loai C',N'Vàng',N'400',N'40000000','Không', 0.01)
insert into ThongTinSanh values(N'Loai D',N'Bạc',N'350',N'35000000','Không', 0.01)
insert into ThongTinSanh values(N'Loai E',N'Đồng',N'300',N'30000000','Không', 0.01)
--

go
select * from ThongTinSanh
delete from ThongTinSanh
drop table ThongTinSanh


--ThucDon
Create table ThucDon
(
	id int identity,
	MaThucDon varchar(100),
	MonKhaiVi nvarchar(100) not null,
	MonChinh1 nvarchar(100)not null,
	MonChinh2 nvarchar(100) not null,
	MonChinh3 nvarchar(100) not null,
	Lau nvarchar(100) not null,
	TrangMieng nvarchar(100) not null,
	Bia nvarchar(100) not null,
	NuocNgot nvarchar(100)not null,
	GiaThucDon money not null
	primary key(id)
)
insert into ThucDon values(N'TĐ 1',N'Chả Giò Rế Hà Nội',N'Gà Ấp Chảo + Bánh Bao',N'Dê Hấp Lá Tía Tô',N'Tôm Sông Rang Muối',N'Lẩu Thái Hải Sản',N'Thanh Nhiệt Sâm Sâm',N'Heniken',N'Pepsi',N'2000000')
insert into ThucDon values(N'TĐ 2',N'Suop Cua Gà Xé',N'Gà Bó Xôi',N'Bò Nấu Đậu + Bánh Mì',N'Vịt Quay Bắc Kinh',N'Lẩu Nắm Hải Sản',N'Chè Hạt Sen',N'Tiger Bạc',N'Trà Xanh',N'1800000')
insert into ThucDon values(N'TĐ 3',N'Gỏi Gó Sen Tôm Thit',N'Gà Hấp Hành + Xôi',N'Cá Điêu Hồng Chưng Tương',N'Chim Cút Roti + Bánh Mì',N'Lẩu Thái Hải Sản',N'Chè Hạt Sen',N'Heniken',N'Cocacola',N'2000000')
insert into ThucDon values(N'TĐ 4',N'Suop Hải Sản Nấm Tuyết',N'Gà Nấu Lagu + Bánh Mì',N'Cá Điêu Hồng Hấp HongKong',N'Gà Bó Xôi',N'Lẩu Cua Đồng',N'Rau Câu Ngũ Sắc',N'Tiger',N'Pepsi',N'1800000')
insert into ThucDon values(N'TĐ 5',N'Chả Giò Venus',N'Chim Cút Roti + Bánh Mì',N'Tôm Sông Rang Muối',N'Cá Điêu Hồng Chưng Tương',N'Lẩu Cá Bớp',N'Chè Khúc Bạch',N'Heniken',N'Pepsi',N'2000000')
go
select * from ThucDon
delete from ThucDon
Drop table ThucDon
go

--DichVu
create table DichVu
(
	id int identity ,
	MaDichVu  varchar(100),
	Ruou nvarchar(100),
	BanhKem nvarchar(100),
	Mc nvarchar(100),
	BanNhac nvarchar(100),
	CaSi nvarchar(100),
	Dj nvarchar(100),
	GiaDichVu money,
	primary key(id)
)
go
select * from DichVu
delete from DichVu
Drop table  DichVu
insert into DichVu values(N'DV1',N'Rượu Vang',N'2Tầng',N'Minh Anh',N'Band 1', N'NhưYến',N'Dan',1000000)
insert into DichVu values(N'DV2',N'Rượu Vang',N'3Tầng',N'Ngọc Như',N'Band 2',N'NgọcBích',N'Black', 2000000)
insert into DichVu values(N'DV3',N'Rượu Vang',N'4Tầng',N'Anh Tuấn',N'Band 3',N'HoàngNgọc',N'DN', 3000000)
insert into DichVu values(N'DV4',N'Rượu Vang',N'5Tầng',N'Tuấn Khang',N'Band 4',N'NguyênKhang',N'Mie', 4000000)
go
drop table DichVu
go

-- Tiec
Create table Tiec
(
	id  int identity(1,1),
	Ca nvarchar(20),
	TrangThai nvarchar(100) default N'Chưa săn sàng'
)
insert into Tiec values (N'Trưa', N'Chưa sẵn sàng')
insert into Tiec values (N'Tối', N'sẵn sàng')
select * from Tiec
drop table Tiec

-- Thong tin khach hang

Create table ThongTinkhachHang
(
	id int identity(1,1),
	MaKhachHang  AS RIGHT('KH' + CAST(id AS VARCHAR(5)), 5) PERSISTED,
	NgayLap date not null,
	TenKhachHang nvarchar(100) not null,
	TenChuRe nvarchar(100) not null,
	TenCoDau nvarchar(100) not null,
	DiaChi nvarchar(100) not null,
	DienThoai nvarchar(100) not null,
	Email nvarchar(100) not null,
	NgayToChuc date not null,
	TienCoc money,
	primary key(id)
)

Drop table ThongTinkhachHang;




go
insert into ThongTinKhachHang values('3/12/2018',N'Nguyễn Thành Tài',N'Nguyễn Thành Tài',N'Hoàng Thị Bích Ngọc',N'Thị Trấn Bến Cầu,Huyện Bến Cầu Tỉnh Tây Ninh',N'0169356263',N'nguyentai23998@gmail.com','12/2/2018')
insert into ThongTinKhachHang values('4/10/2018',N'Hà Như Ý',N'Hà Như Ý',N'Nguyễn Thị Tố Như',N'Phường Linh Trung, Quận Thủ Đức, Tp.Hồ Chí Minh',N'0162345347',N'nhuy1998@gmail.com','12/12/2018')

select * from ThongTinkhachHang
delete from ThongTinkhachHang
drop table ThongTinkhachHang
go

-- Thong Tin Dat tiec
Create table ThongTinDatTiec
(
	id int identity(1,1) ,
	MaDatTiec  AS RIGHT('DT' + CAST(id AS VARCHAR(5)), 5) PERSISTED,
	IDNhanVien int FOREIGN KEY REFERENCES NhanVienTiepTan(id),
	IDThongTinKhachHang int FOREIGN KEY REFERENCES ThongTinKhachHang(id),
	IdLoaiSanh int FOREIGN KEY REFERENCES ThongTinSanh(id),
	IdDichVu int FOREIGN KEY REFERENCES DichVu(id),
	IdThucDon int FOREIGN KEY REFERENCES ThucDon(id),
	SoLuongNhanVien int not null,
	SoLuongBan int,
	TrangThai nvarchar(100) not null, 
	Ca nvarchar(100) not null,
	primary key(id )
)
go
Select a.*,p.NgayToChuc,p.NgayLap,p.Email,p.TenKhachHang,p.DiaChi,p.DienThoai,NhanVienTiepTan.TenNhanVien,c.*,d.*
from ThongTinDatTiec a
left join ThongTinKhachHang p on p.id = a.IDThongTinKhachHang
left join NhanVienTiepTan on NhanVienTiepTan.id = a.IDNhanVien
left join DichVu c on c.id = a.IdDichVu
left join ThucDon d on d.id = a.IdThucDon

insert into ThongTinDatTiec values(N'Loai A',N'DV3',N'TĐ 1',50,400,N'Chua Dat',N'Trưa')
insert into ThongTinDatTiec values(N'Loai B',N'DV1',N'TĐ 2',50,500,N'Chua Dat',N'Toi')
insert into ThongTinDatTiec values(N'Loai C',N'DV4',N'TĐ 3',50,600,N'Chua Dat',N'Toi')
insert into ThongTinDatTiec values(N'Loai D',N'DV2',N'TĐ 4',50,700,N'Chua Dat',N'Toi')

Insert into ThongTinKhachHang ( NgayLap, TenKhachHang, TenChuRe, TenCoDau, DiaChi, DienThoai,EMail, NgayToChuc) Values('05/25/2018' , 'fvfr' , 'rbvrf' , 'brfb' , 'rbvr' , '345', 'btg', '05/25/2018')
Insert into ThongTinDatTiec (LoaiSanh,MaDichVu,MaThucDon,SoLuongNhanVien, SoLuongBan,TrangThai,Ca) Values('Loai A','DV3','TÐ 1','35' , '435', 'Chua Dat','Trua' )
go
go
Drop table ThongTinDatTiec
select * from ThongTinDatTiec
delete from ThongTinDatTiec
drop table ThongTinDatTiec
----
Select a.*,p.NgayToChuc,p.NgayLap,p.Email,p.TenKhachHang,p.DiaChi,p.DienThoai,NhanVienTiepTan.TenNhanVien,c.*,d.*
from ThongTinDatTiec a
left join ThongTinKhachHang p on p.id = a.IDThongTinKhachHang
left join NhanVienTiepTan on NhanVienTiepTan.id = a.IDNhanVien
left join DichVu c on c.id = a.IdDichVu
left join ThucDon d on d.id = a.IdThucDon
 where MaDatTiec ='DT001'

 Select a.*,p.NgayToChuc,p.NgayLap,p.Email,p.TenKhachHang,p.DiaChi,p.DienThoai,p.TienCoc, NhanVienTiepTan.TenNhanVien,c.*,d.*, e.DonGiaToiThieu, e.TiSoPhat
            from ThongTinDatTiec a
            left join ThongTinKhachHang p on p.id = a.IDThongTinKhachHang
            left join NhanVienTiepTan on NhanVienTiepTan.id = a.IDNhanVien
            left join DichVu c on c.id = a.IdDichVu
            left join ThucDon d on d.id = a.IdThucDon
            left join ThongTinSanh e on e.id = a.IdLoaiSanh
             where MaDatTiec ='DT001'

--Lap Hop dong ( table ThongTinkHach hang + table thong tin dat tiec)
go
select *  
from ThongTinkhachHang inner join ThongTinDatTiec on ThongTinKhachHang.id = ThongTinDatTiec.id
Select a.*, p.*
from ThongTinDatTiec a
 inner join ThongTinKhachHang p on p.id = a.IDThongTinKhachHang


create proc sp_ThanhToan
as
begin
	select ThongTinKhachHang.NgayLap , ThongTinKhachHang.NgayToChuc, NhanVienTiepTan.TenNhanVien, ThongTinKhachHang.TenKhachHang,ThongTinKhachHang.DiaChi, ThongTinKhachHang.DienThoai, ThongTinKhachHang.Email
from ThongTinkhachHang inner join ThongTinDatTiec on ThongTinKhachHang.id = ThongTinDatTiec.id
						inner join NhanVienTiepTan on NhanVienTiepTan.id = ThongTinDatTiec.id

end

select ThongTinKhachHang.NgayLap , ThongTinKhachHang.NgayToChuc, NhanVienTiepTan.TenNhanVien, ThongTinKhachHang.TenKhachHang,ThongTinKhachHang.DiaChi, ThongTinKhachHang.DienThoai, ThongTinKhachHang.Email
from ThongTinkhachHang inner join ThongTinDatTiec on ThongTinKhachHang.id = ThongTinDatTiec.id
						inner join NhanVienTiepTan on NhanVienTiepTan.id = ThongTinDatTiec.id
go 

--Hoa Don Thanh Toan
Create table HoaDon
(
	id int identity(1,1) primary key,
	MaHoaDon  AS RIGHT('HĐ' + CAST(id AS VARCHAR(7)), 7) PERSISTED,
	IdMaDatTiec int FOREIGN KEY REFERENCES ThongTinDatTiec(id),
	IDThongTinKhachHang int FOREIGN KEY REFERENCES ThongTinKhachHang(id),
	IdLoaiSanh int FOREIGN KEY REFERENCES ThongTinSanh(id),
	IdDichVu int FOREIGN KEY REFERENCES DichVu(id),
	IdThucDon int FOREIGN KEY REFERENCES ThucDon(id),
	TienPhat money,
	TongTienHoaDon money not null,
	TienCoc money not null,
	TienConLai money ,
	
)
go
create proc sp_HoaDon
as
begin
	Select h.id, h.MaHoaDon,t.MaDatTiec,p.MaKhachhang, p.TenKhachHang, s.DonGiaToiThieu as TienSanh, dv.GiaDichVu, td.GiaThucDon, h.TienPhat, h.TienCoc, h.TongTienHoaDon ,h.TienConLai
	from HoaDon h
	left join ThongTinKhachHang p on p.id = h.IDThongTinKhachHang
	left join ThongTinDatTiec t on t.id = h.IdMaDatTiec
	left join ThongTinSanh s on s.id = h.IdLoaiSanh
	left join DichVu dv on dv.id=h.IdDichVu
	left join ThucDon td on td.id=h.IdThucDon
end

go
 --where MaDatTiec ='DT001'


select * from HoaDon
delete from HoaDon
drop table HoaDon


-- Nhan vien tiep tan
Create table NhanVienTiepTan
(
	id int identity(1,1) primary key,
	MaNhanVien nvarchar(100),-- AS RIGHT('NV' + CAST(id AS VARCHAR(5)), 5) PERSISTED,
	TenNhanVien nvarchar(100) ,
	SoDienThoai nvarchar(100) ,
	DiaChi nvarchar(100) ,
	Ca nvarchar(100),
	
)
go
select * from NhanVienTiepTan
Drop table NhanVienTiepTan
go

insert into NhanVienTiepTan values( N'NV1',N'Huyền Thoại', N'01223810110',N'Hoàng Diệu 2', N'Sáng')
insert into NhanVienTiepTan values(N'NV2', N'Thu Thiên', N'01223810111',N'Hoàng Diệu 3', N'Trưa')
insert into NhanVienTiepTan values( N'NV3',N'Thái Dương', N'01223810112',N'Hoàng Diệu 4', N'Tối')
insert into NhanVienTiepTan values(N'NV4', N'Duy Tân', N'01223810113',N'Hoàng Diệu 5', N'Sáng')
go
select * from NhanVienTiepTan
delete from NhanVienTiepTan



-- Nhan vien
go
Create table NhanVien
(
	id int identity(5,1) primary key,
	MaNhanVien AS RIGHT('NV' + CAST(id AS VARCHAR(5)), 5) PERSISTED,
	TenNhanVien nvarchar(100) not null,
	SoDienThoai nvarchar(100) not null,
	DiaChi nvarchar(100) not null,
	LoaiSanh nvarchar(100) ,
	ChucVu nvarchar(100) not null,
	Ca nvarchar(100) not null,

)
Update NhanVien set TenNhanVien='Duy1',SoDienThoai='01223810113',DiaChi='Hoàng Di?u 5',LoaiSanh = 'Loai E',ChucVu='Qu?n lý',Ca='Sáng' where TenNhanVien = 'NV008'

insert into NhanVien values( N'Hoa', N'01223810110',N'Hoàng Diệu 2',N'Loai A', N'Phục vụ', N'Sáng')
insert into NhanVien values( N'Hồng', N'01223810111',N'Hoàng Diệu 3',N'Loai B', N'Giám Sát', N'Trưa')
insert into NhanVien values( N'Cúc', N'01223810112',N'Hoàng Diệu 4',N'Loai C', N'Phục vụ', N'Tối')
insert into NhanVien values( N'Duy', N'01223810113',N'Hoàng Diệu 5',N'Loai E', N'Quản lý', N'Sáng')
insert into NhanVien values( N'Hoàng', N'01223811234',N'Hoàng Diệu 6',N'Loai A', N'Phục vụ', N'Sáng')
insert into NhanVien values( N'Mai', N'01223811235',N'Hoàng Diệu 7',N'Loai B', N'Giám Sát', N'Trưa')
insert into NhanVien values( N'Ngọc', N'01223811236',N'Hoàng Diệu 8',N'Loai C', N'Phục vụ', N'Tối')
insert into NhanVien values( N'Uyên', N'01223811237',N'Hoàng Diệu9',N'Loai E', N'Quản lý', N'Sáng')
go
select * from NhanVien
drop table NhanVien




--Bao cao

Create table BaoCaoDoanhThu
(
	id int identity(1,1) primary key,
	MaBaoCao AS RIGHT('BC00' + CAST(id AS VARCHAR(5)), 5) PERSISTED,
	MaNhanVien nvarchar(100),
	ThangBaoCao nvarchar(100) not null,
	NamBaoCao nvarchar(100) not null,
	NgayLap date not null,
	SoLuongTiec int,

)
go
select * from BaoCaoDoanhThu
drop table BaoCaoDoanhThu
go


 




                                                                                                                                                                              ', MaDichVu='DV3                                                                                                 ', SoLuongNhanVien='24',TrangThai='Chua S?n sàng', Ca='Trua' where MaDatTiec = 'gbgf'