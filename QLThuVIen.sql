CREATE DATABASE QLThuVien
GO
USE QLThuVien
GO
--Bảng bằng cấp--
CREATE TABLE BANGCAP
(	
	MaBangCap char(10) PRIMARY KEY,
	TenBangCap nvarchar(100) not null
)
GO
--Bảng nhân viên--
CREATE TABLE NHANVIEN
(	MaNhanVien int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	HoTenNhanVien nvarchar(100),
	NgaySinh datetime,
	DiaChi nvarchar(100),
	DienThoai char(10),
	MaBangCap char(10),
	foreign key (MaBangCap) references BANGCAP(MaBangCap)
)
GO
--Bảng sách--
CREATE TABLE SACH
(	MaSach char(10) PRIMARY KEY,
	TenSach nvarchar(100),
	TacGia nvarchar(100),
	NamXuatBan int,
	NhaXuatBan nvarchar(50),
	TriGia float,
	NgayNhap datetime
) 
GO
--Bảng đọc giả--
CREATE TABLE DOCGIA
(	MaDocGia char(10) PRIMARY KEY,
	HoTenDocGia nvarchar(100),
	NgaySinh datetime,
	DiaChi nvarchar(100),
	Email nvarchar(100),
	NgayLapThe datetime,
	NgayHetHan datetime,
	TienNo float
)
GO
--Bảng phiếu thu tiền--
CREATE TABLE PHIEUTHUTIEN
(	MaPhieuThuTien char(15) PRIMARY KEY,
	SoTienNo float,
	SoTienThu float,
	MaDocGia char(10),
	MaNhanVien int,
	foreign key (MaDocGia) references DOCGIA(MaDocGia), 
	foreign key (MaNhanVien) references NHANVIEN(MaNhanVien)
) 
GO
--Bảng phiếu mượn sách--
CREATE TABLE PHIEUMUONSACH
(	MaPhieuMuon int IDENTITY(1,1) PRIMARY KEY,
	NgayMuon datetime,
	MaDocGia char(10),
	foreign key (MaDocGia) references DOCGIA(MaDocGia)
)
GO
--Bảng chi tiết phiếu mượn--
CREATE TABLE CHITIETPHIEUMUON
(	MaSach char(10),
	MaPhieuMuon int,
	NgayTra datetime,
	primary key (MaSach,MaPhieuMuon),
	foreign key (MaSach) references SACH(MaSach),
	foreign key (MaPhieuMuon) references PHIEUMUONSACH(MaPhieuMuon)
) 
GO
--Bảng đăng nhập
CREATE TABLE DANGNHAP
(	
	TenTaiKhoan nvarchar(20) PRIMARY KEY,
	MatKhau nvarchar(640) not null
)
GO


USE QLThuVien
GO

INSERT INTO SACH(MaSach,TenSach, TacGia, NamXuatBan, NhaXuatBan, TriGia, NgayNhap)
VALUES
('Sach01', N'OnePiece Tập 91', N'Aoyama Gosho', 2018, N'Kim Đồng', 21700, '2020-05-12'),
('Sach02', N'Mắt Biếc (Bản Đặc Biệt)', N'Nguyễn Nhật Ánh', 2019, N'NXB Trẻ', 220000, '2019-01-24'),
('Sach03', N'Lũ Trẻ Đường Tàu', N'E.Nesbit', 2020, N'NXB Trẻ', 39000, '2020-01-20'),
('Sach04', N'Sống Mòn', N'Nam Cao', 2016, N'NXB Văn Học', 39530, '2016-08-07'),
('Sach05', N'ĐI TÌM BẢN SẮC TIẾNG VIỆT', N'Trịnh Sâm', 2018, N'NXB Trẻ', 65000, '2018-07-31'),
('Sach06', N'Đắc Nhân Tâm', N'unknown', 2005, N'NXB Trẻ', 69000, '2017-09-25'),
('Sach07', N'Quẳng gánh lo âu và vui sống', N'unknown', 2009, N'NXB Trẻ', 49000, '2016-09-10'),
('Sach08', N'Nhà giả kim', N'unknown', 2018, N'NXB Trẻ', 100000, '2019-07-24'),
('Sach09', N'Đường bay', N'Tony Pham', 2003, N'NXB Trẻ', 274645, '2019-07-20'),
('Sach10', N'Cà phê buổi sáng', N'Tony', 2006, N'Kim Đồng', 100985, '2019-03-24'),
('Sach11', N'Tự học', N'Unknown', 2002, N'Kim Đồng', 2222, '2019-04-19'),
('Sach12', N'Đương đầu với thất bại, vững bước về tương lai', N'Mr.Cao', 2001, N'Kim Đồng', 60400101, '2017-07-17')

INSERT INTO BANGCAP(MaBangCap, TenBangCap)
VALUES 
('BC01', N'Cao Đẳng'),
('BC02', N'Đại Học'),
('BC03', N'Thạc Sĩ'),
('BC04', N'Tiến Sĩ')

INSERT INTO NHANVIEN(HoTenNhanVien, NgaySinh, DiaChi, DienThoai, MaBangCap)
VALUES
(N'Nguyễn Văn Bình', '1990-05-07', N'24 Sương Nguyệt Ánh, Q.Gò Vấp, TP.HCM', '0545785358', 'BC01'),
(N'Trần Ánh Tuyết', '1982-10-17', N'317 Nguyễn Văn Công, Q.Gò Vấp, TP.HCM', '0324567545', 'BC03'),
(N'Võ Minh Tuấn', '1980-03-20', N'897 CMT8, Q.Tân Bình, TP.HCM', '0834642121', 'BC02'),
(N'Nguyễn Lê Anh Hải', '1978-06-24', N' 112 Võ Văn Tần, Q.3, TP.HCM', '0246746857', 'BC04'),
(N'Lương Xuân Hiệp', '1996-06-13', N'788/43 Nguyễn Kiệm, Q.Qò Vấp, TP.HCM', '0436746059', 'BC02')


INSERT INTO DOCGIA(MaDocGia, HoTenDocGia, NgaySinh, DiaChi, Email, NgayLapThe, NgayHetHan, TienNo)
VALUES
('DG01', N'Nguyễn Trường Toàn', '2003-05-07', N'24 Lê Hồng Phong, Q.10, TP.HCM', 'toan.nt@gmail.com', '2020-01-20','2020-05-20', 0),
('DG02', N'Trần Vũ Hiếu', '2001-10-17', N'117 Nguyễn Trãi, Q.5, TP.HCM','hieu.tv@gmail.com', '2019-12-24','2020-04-24', 20000),
('DG03', N'Võ Minh Vương', '2000-03-20', N'97 3 Tháng 2, Q.11, TP.HCM', 'vuong.vm@gmail.com', '2020-02-12','2020-06-12', 32000),
('DG04', N'Lê Anh Bảo', '1999-06-24', N' 112 Võ Văn Ngân, Q.2, TP.HCM', 'bao.la@gmail.com', '2020-03-20','2020-07-20', 40000),
('DG05', N'Vũ Thị Mai', '2005-06-13', N'88/3 Thành Thái, Q.10, TP.HCM', 'mai.vt@gmail.com', '2020-02-05','2020-06-05', 15000),
('DG06', N'Phạm Nguyễn Hoài Thương', '2001-04-06', N'Bình Phước', 'pnht@gmail.com', '2020-02-05','2020-06-05', 11000)

INSERT INTO PHIEUMUONSACH(NgayMuon, MaDocGia)
VALUES
('2020-05-22', 'DG01'), --1
('2020-03-20', 'DG02'), --2
('2020-04-01', 'DG03'), --3
('2020-02-28', 'DG04'), --4
('2019-12-17', 'DG04'), --5
('2019-03-22', 'DG05') --6

INSERT INTO CHITIETPHIEUMUON(MaSach, MaPhieuMuon, NgayTra)
VALUES
('Sach01', 1, null),
('Sach02', 1, null),
('Sach03', 1, null),
('Sach04', 2, null),
('Sach05', 3, null),
('Sach06', 4, null), 
('Sach07', 5, null),
('Sach08', 6, null),
('Sach09', 2, '2020-12-17'),
('Sach10', 3, '2020-11-16'),
('Sach11', 4, '2019-5-2'),
('Sach12', 5, '2019-6-4')

INSERT INTO DANGNHAP(TenTaiKhoan, MatKhau)
VALUES 
('toan', 'c4ca4238a0b923820dcc509a6f75849b'),
('thuan', 'c4ca4238a0b923820dcc509a6f75849b'),
('khiet', 'c4ca4238a0b923820dcc509a6f75849b'),
('quang', 'c4ca4238a0b923820dcc509a6f75849b'),
('nhat', 'c4ca4238a0b923820dcc509a6f75849b')



