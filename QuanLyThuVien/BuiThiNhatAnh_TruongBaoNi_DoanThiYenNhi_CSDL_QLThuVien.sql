-- ĐỒ ÁN ỨNG DỤNG
--- ĐỀ TÀI: QUẢN LÝ THƯ VIỆN
--- THÀNH VIÊN TRONG NHÓM:
---- ĐOÀN THỊ YẾN NHI
---- BÙI THỊ NHẬT ANH
---- TRƯƠNG BẢO NY
CREATE DATABASE QuanLyThuVien
GO
USE QuanLyThuVien
GO
--I.Tao bang
--1.Tao bang MUONSACH
CREATE TABLE MUONSACH 
(
	MaMuonSach NVARCHAR(10) PRIMARY KEY NOT NULL,
	MaKhachHang NVARCHAR(10),
	TenKhachHang NVARCHAR(30),
	MaSach NVARCHAR(20),
	TenSach NVARCHAR(30),
	NgayMuonSach DATE,
	NgayHenTra DATE
)
--2. Tao bang LOAISACH
CREATE TABLE LOAISACH 
(
	MaLoaiSach NVARCHAR (20) PRIMARY KEY NOT NULL,
	TenLoaiSach NVARCHAR (50)
)
--3. Tao bang TACGIA
CREATE TABLE TACGIA
(
	MaTacGia NVARCHAR (20) PRIMARY KEY NOT NULL,
	TenTacGia NVARCHAR (30),
	DiaChiTG NVARCHAR (30)
)
--4. Tao Bang KHACHHANG
CREATE TABLE KHACHHANG
(
	MaKhachHang NVARCHAR(10) PRIMARY KEY NOT NULL,
	TenKhachHang NVARCHAR(30),
	SoDienThoaiKH NVARCHAR(30),
	DiaChiKH NVARCHAR(30),
	NgayDK DATE,
	NgayHetHan DATE
)
--5.Tao bang sach//action
CREATE TABLE SACHTHUVIEN
(
	MaSach NVARCHAR(20) PRIMARY KEY NOT NULL,
	TenSach NVARCHAR (30),
	TacGia  NVARCHAR (30),
	AnhSach NVARCHAR(200) ,
    LoaiSach NVARCHAR (30)
)
--6. Dang nhap
CREATE TABLE DangKy
(
	TenTaiKhoan NVARCHAR (20) PRIMARY KEY NOT NULL,
	MatKhau NVARCHAR(20) NOT NULL,
	NhapLaiMatKhau NVARCHAR(20) NOT NULL
)
--7. NHANVIEN
CREATE TABLE NHANVIEN
(
	MaNhanVien NVARCHAR(20) PRIMARY KEY NOT NULL,
	TenNhanVien NVARCHAR(30),
	ChucVu NVARCHAR(20),
	SoDienThoai NVARCHAR(20),
	DiaChi NVARCHAR(50)
)
--3.Tạo bảng TRASACH//action 
CREATE TABLE TRASACH
(
	MaTraSach NVARCHAR(10) PRIMARY KEY NOT NULL,
	MaMuonSach NVARCHAR(10),
	TenKhachHang NVARCHAR(30),
	TenSach NVARCHAR(30),
	NgayHenTra DATE,
	NgayTra DATE,
	PhiPhat MONEY
)
--


--II.Khoa ngoai
--1.Bng MUONSACH_KHACHHANG
GO
ALTER TABLE MUONSACH
ADD CONSTRAINT FK_KHACHHANG_MUONSACH FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang)
--2.B?ng MUONSACH_SACTV
GO
ALTER TABLE MUONSACH
ADD CONSTRAINT FK_SACHTHUVIEN_MUONSACH FOREIGN KEY (MaSach) REFERENCES SACHTHUVIEN(MaSach)
GO
ALTER TABLE TRASACH
ADD CONSTRAINT FK_MUONSACH_TRASACH FOREIGN KEY (MaMuonSach) REFERENCES MUONSACH(MaMuonSach)
--II.Thêm du lieu
--1. Thêm dữ liệu LOAISACH
INSERT INTO LOAISACH(MaLoaiSach, TenLoaiSach)
VALUES (N'S123', N'Thiết Kế Web')
INSERT INTO LOAISACH(MaLoaiSach, TenLoaiSach)
VALUES (N'S124', N'Lập Trình Di động')
INSERT INTO LOAISACH(MaLoaiSach, TenLoaiSach)
VALUES (N'S125', N'Lập trình ứng dụng')
INSERT INTO LOAISACH(MaLoaiSach, TenLoaiSach)
VALUES (N'S126', N'Lập trình IOS')

--2. Thêm du lieu Khách hàng
INSERT INTO KHACHHANG(MaKhachHang, TenKhachHang, SoDienThoaiKH, DiaChiKH, NgayDK, NgayHetHan)
VALUES ('KH1001', N'Nguyễn Văn A', N'01626-587-036', N'Bình Thuận', '2018/12/1', '2018/12/7')
INSERT INTO KHACHHANG(MaKhachHang, TenKhachHang, SoDienThoaiKH, DiaChiKH, NgayDK, NgayHetHan)
VALUES ('KH1002', N'Nguyễn Văn B', N'01626-529-036', N'Bình Định', '2018/12/9', '2018/12/12')
INSERT INTO KHACHHANG(MaKhachHang, TenKhachHang, SoDienThoaiKH, DiaChiKH, NgayDK, NgayHetHan)
VALUES ('KH1003', N'Nguyễn Văn C', N'01626-587-044', N'Bình Thuận', '2018/12/7', '2018/12/10')
INSERT INTO KHACHHANG(MaKhachHang, TenKhachHang, SoDienThoaiKH, DiaChiKH, NgayDK, NgayHetHan)
VALUES ('KH1004', N'Nguyễn Văn D', N'01655-587-036', N'Hà Nội', '2018/9/1', '2018/9/7')
--4. Them sach
INSERT INTO SACHTHUVIEN(MaSach, TenSach, TacGia, AnhSach ,LoaiSach)
VALUES (N'S123', N'Thiết kế web',N'Cố Mạn','E:\dangnhap.jpg', N'Công Nghệ Web')
INSERT INTO SACHTHUVIEN(MaSach, TenSach, TacGia,AnhSach, LoaiSach)
VALUES (N'S124', N'Lập trình di động', N'Xuân Quỳnh','E:\dangnhap.jpg', N'Công Nghệ di động')
INSERT INTO SACHTHUVIEN(MaSach, TenSach, TacGia, AnhSach, LoaiSach)
VALUES (N'S125', N'Lập trình ứng dụng', N'Nguyễn Ngọc Ánh','E:\dangnhap.jpg', N'Công Nghệ ứng dụng')
INSERT INTO SACHTHUVIEN(MaSach, TenSach, TacGia, AnhSach, LoaiSach)
VALUES (N'S126', N'Lập trình web', N'Quỳnh Giao','E:\dangnhap.jpg', N'Công Nghệ Web')
INSERT INTO SACHTHUVIEN(MaSach, TenSach, TacGia, AnhSach, LoaiSach)
VALUES (N'S127', N'Lập trình IOS', N'Xuân Diệu','E:\dangnhap.jpg', N'Công Nghệ ứng dụng')
--1. Thêm du lieu MUONSACH
INSERT INTO MUONSACH(MaMuonSach, MaKhachHang, TenKhachHang, MaSach, TenSach, NgayMuonSach,NgayHenTra)
VALUES ('M02', N'KH1002', N'Nguyễn Văn B', N'S124', N'Lập Trình Di động', '2018/12/1', '2018/12/7')
INSERT INTO MUONSACH(MaMuonSach, MaKhachHang, TenKhachHang, MaSach, TenSach, NgayMuonSach,NgayHenTra)
VALUES ('M03', N'KH1003', N'Nguyễn Văn C', N'S125', N'Lập trình ứng dụng', '2018/9/1', '2018/9/7')
INSERT INTO MUONSACH(MaMuonSach, MaKhachHang, TenKhachHang, MaSach, TenSach, NgayMuonSach,NgayHenTra)
VALUES ('M04', N'KH1004', N'Nguyễn Văn D', N'S126', N'Lập trình IOS','2018/6/1', '2018/6/7')
--3. thêm du lieu vào dang ký
INSERT INTO DangKy (TenTaiKhoan, MatKhau, NhapLaiMatKhau)
VALUES ('nhi', '1234', '1234' ) 
INSERT INTO DangKy (TenTaiKhoan, MatKhau, NhapLaiMatKhau)
VALUES ('nhia', '1234a', '1234a' ) 
INSERT INTO DangKy (TenTaiKhoan, MatKhau, NhapLaiMatKhau)
VALUES ('nhib', '1234b', '1234a' ) 
INSERT INTO DangKy (TenTaiKhoan, MatKhau, NhapLaiMatKhau)
VALUES ('nhic', '1234c', '1234a' ) 

--5. Thêm du lieu nhân viên
INSERT INTO NHANVIEN(MaNhanVien,TenNhanVien,ChucVu,SoDienThoai,DiaChi)
VALUES (N'NV1001', N'Đoàn Yến A', N'Quản lý', '01655-783-067', N'Quận Bình Thạnh')
INSERT INTO NHANVIEN(MaNhanVien, TenNhanVien, ChucVu, SoDienThoai, DiaChi)
VALUES (N'NV1002', N'Đoàn Yến B', N'Nhân viên', N'01655-783-367', N'Quận Tân Bình')
INSERT INTO NHANVIEN(MaNhanVien, TenNhanVien, ChucVu, SoDienThoai, DiaChi)
VALUES (N'NV1003', N'Đoàn Yến C', N'Nhân viên', N'01655-783-567', N'Quận Bình Thạnh')
INSERT INTO NHANVIEN(MaNhanVien, TenNhanVien, ChucVu, SoDienThoai, DiaChi)
VALUES (N'NV1004', N'Đoàn Thị Yến D', N'Nhân viên', N'01655-983-067', N'Quận Phú Nhuận, Hải Phòng')
--6. Thêm du lieu tác gia
INSERT INTO TACGIA(MaTacGia, TenTacGia, DiaChiTG)
VALUES ('TC1010', N'Cố Mạn', N'TP.Hồ Chí Minh')
INSERT INTO TACGIA(MaTacGia, TenTacGia, DiaChiTG)
VALUES ('TC1011', N'Xuân Quỳnh', N'TP.Đà lạt')
INSERT INTO TACGIA(MaTacGia, TenTacGia, DiaChiTG)
VALUES ('TC1012', N'Xuân Diệu', N'Hà Nội')
INSERT INTO TACGIA(MaTacGia, TenTacGia, DiaChiTG)
VALUES ('TC1013', N'Nguyễn Ngọc Ánh', N'Hải Phòng')
INSERT INTO TACGIA(MaTacGia, TenTacGia, DiaChiTG)
VALUES ('TC1014', N'Quỳnh Giao', N'Cần Thơ')
--Thêm dữ liệu
INSERT INTO TRASACH(MaTraSach,MaMuonSach,TenKhachHang,TenSach,NgayHenTra,NgayTra,PhiPhat)
VALUES ('TS01', N'M02', N'Nguyễn Văn A', N'Thiết Kế Web', N'12/12/2018', N'12/14/2018',10000)
INSERT INTO TRASACH(MaTraSach,MaMuonSach,TenKhachHang,TenSach,NgayHenTra,NgayTra,PhiPhat)
VALUES ('TS02', N'M03', N'Nguyễn Văn B', N'Lập Trình Di Động', N'12/12/2018',  N'12/11/2018',0)
INSERT INTO TRASACH(MaTraSach,MaMuonSach,TenKhachHang,TenSach,NgayHenTra,NgayTra,PhiPhat)
VALUES ('TS03', N'M04', N'Nguyễn Văn C', N'Lập trình ứng dụng', N'11/12/2018', N'11/15/2018',15000)


--IV- XÂY DỰNG STORE
--1. Bảng MUONSACH
--1.1. Load
---Load du lieu tu bang MUONSACH
CREATE PROC SP_LOAD_MUONSACH
AS
BEGIN
	SELECT * FROM MUONSACH
END
GO

--1.2. Load
---Load du lieu Mã khách hàng tu bang KHACHHANG sang MUONSACH
CREATE PROC SP_LOAD_MAKHACHHAG
AS
BEGIN
	SELECT MaKhachHang FROM KHACHHANG
END
GO
--1.3.Thêm
---Thêm thông tin mượn sách vao bang MUONSACH
CREATE PROC SP_THEM_MUONSACH
	@MaMuonSach NVARCHAR(10),
	@MaKhachHang NVARCHAR(10),
	@TenKhachHang NVARCHAR(30),
	@MaSach NVARCHAR(20),
	@TenSach NVARCHAR(30),
	@NgayMuonSach SMALLDATETIME,
	@NgayHenTra SMALLDATETIME
AS
BEGIN
	INSERT INTO MUONSACH(MaMuonSach, MaKhachHang, TenKhachHang, MaSach, TenSach, NgayMuonSach,NgayHenTra)
    VALUES (@MaMuonSach, @MaKhachHang, @TenKhachHang, @MaSach, @TenSach, @NgayMuonSach, @NgayHenTra)
END
GO
--1.4 Sửa
---Sửa thông tin mượn sách tu bang MUONSACH
CREATE PROC SP_SUA_MUONSACH
	@MaMuonSach NVARCHAR(10),
	@MaKhachHang NVARCHAR(10),
	@TenKhachHang NVARCHAR(30),
	@MaSach NVARCHAR(20),
	@TenSach NVARCHAR(30),
	@NgayMuonSach SMALLDATETIME,
	@NgayHenTra SMALLDATETIME

AS
BEGIN
	UPDATE MUONSACH SET MaKhachHang = @MaKhachHang, TenKhachHang= @TenKhachHang, 
	MaSach =@MaSach,TenSach=@TenSach ,NgayMuonSach = @NgayMuonSach, NgayHenTra = @NgayHenTra
	WHERE MaMuonSach = @MaMuonSach
END
GO
--1.5. Xoa
---Xóa thông tin mượn sách tu bang MUONSACH
CREATE PROC SP_XOA_MUONSACH
	@MaMuonSach NVARCHAR(10)
AS
BEGIN
	DELETE MUONSACH WHERE MaMuonSach = @MaMuonSach
END
GO
--2. Bảng SACHTHUVIEN
--2.1 Load
---Load thông tin sách bang SACHTHUVIEN
CREATE PROC SP_LOAD_SACHTV
AS
BEGIN
	SELECT * FROM SACHTHUVIEN
END
GO
--2.2 Load
---Load du lieu mã sách thu vien tu bang SACHTHUVIEN vào bang MUONSACH
CREATE PROC SP_LOAD_MASACHTV
AS
BEGIN
	SELECT MaSach FROM SACHTHUVIEN
END
GO

--2.3 Thêm
---Thêm sach vao bang SACHTHUVIEN
CREATE PROC SP_THEM_SACHTV
	@MaSach NVARCHAR(20),
	@TenSach NVARCHAR (30),
	@TacGia  NVARCHAR (30),
	@AnhSach NVARCHAR(200) ,
    @LoaiSach NVARCHAR (30)
AS
BEGIN
	INSERT INTO SACHTHUVIEN(MaSach, TenSach, TacGia, AnhSach, LoaiSach) VALUES (@MaSach, @TenSach, @TacGia, @AnhSach,@LoaiSach)
END
GO
--2.4 Sua
---Sua thông tin sach tu bang SACHTHUVIEN
CREATE PROC SP_SUA_SACHTV
	@MaSach NVARCHAR(20),
	@TenSach NVARCHAR (30),
	@TacGia  NVARCHAR (30),
	@AnhSach NVARCHAR(200) ,
    @LoaiSach NVARCHAR (30)

AS
BEGIN
	UPDATE SACHTHUVIEN SET TenSach = @TenSach, TacGia = @TacGia, AnhSach= @AnhSach, LoaiSach = @LoaiSach
	WHERE MaSach = @MaSach
END
GO
--2.5 Xoa
--- Xóa sach tu bang SACHTHUVIEN
CREATE PROC SP_XOA_SACHTV
	@MaSach NVARCHAR(20)
AS
BEGIN
	DELETE SACHTHUVIEN WHERE MaSach = @MaSach
END
GO
--3. Bảng TACGIA
--3.1 Load
---Load du lieu tu bang TACGIA
CREATE PROC SP_LOAD_TACGIA
AS
BEGIN
	SELECT * FROM TACGIA
END
GO
--3.2 Thêm
---Thêm thông tin tác giả vào bang TACGIA
CREATE PROC SP_THEM_TACGIA
	
	@MaTacGia NVARCHAR (20),
	@TenTacGia NVARCHAR (30),
	@DiaChiTG NVARCHAR (30)
AS
BEGIN
	INSERT INTO TACGIA(MaTacGia, TenTacGia, DiaChiTG)
	VALUES (@MaTacGia, @TenTacGia, @DiaChiTG)
END
GO
--3.3 Sua
---Sửa thông tin tác giả tu bang TACGIA
CREATE PROC SP_SUA_TACGIA
	@MaTacGia NVARCHAR (20),
	@TenTacGia NVARCHAR (30),
	@DiaChiTG NVARCHAR (30)
AS
BEGIN
	UPDATE TACGIA SET TenTacGia = @TenTacGia, DiaChiTG = @DiaChiTG
	WHERE MaTacGia = @MaTacGia
END
GO
--3.4 Xóa 
---Xóa tác giả tu bang TACGIA
CREATE PROC SP_DELETE_TACGIA
	@MaTacGia NVARCHAR (20)
AS
BEGIN
	DELETE TACGIA WHERE MaTacGia = @MaTacGia
END
GO
--4. Bảng KHACHHANG
--4.1 Load
---Load du lieu tu bang KHACHHANG
CREATE PROC SP_LOAD_KHACHHANG
AS
BEGIN
	SELECT * FROM KHACHHANG
END
GO
--4.2 Them
---Thêm khach hang vao bang KHACHHANG
CREATE PROC SP_THEM_KHACHHANG
	@MaKhachHang NVARCHAR(10),
	@TenKhachHang NVARCHAR(30),
	@SoDienThoaiKH NVARCHAR(30),
	@DiaChiKH NVARCHAR(30),
	@NgayDK SMALLDATETIME,
	@NgayHetHan SMALLDATETIME
AS
BEGIN
	INSERT INTO KHACHHANG(MaKhachHang, TenKhachHang, SoDienThoaiKH, DiaChiKH, NgayDK, NgayHetHan)
    VALUES (@MaKhachHang, @TenKhachHang, @SoDienThoaiKH, @DiaChiKH, @NgayDK, @NgayHetHan)
END
GO
--4.3 Sua
---Sửa thông tin khach hang  tu bang KHACHHANG
CREATE PROC SP_SUA_KHACHHANG
	@MaKhachHang NVARCHAR(10),
	@TenKhachHang NVARCHAR(30),
	@SoDienThoaiKH NVARCHAR(30),
	@DiaChiKH NVARCHAR(30),
	@NgayDK SMALLDATETIME,
	@NgayHetHan SMALLDATETIME

AS
BEGIN
	UPDATE KHACHHANG SET  TenKhachHang = @TenKhachHang, SoDienThoaiKH= @SoDienThoaiKH, DiaChiKH= @DiaChiKH,NgayDK = @NgayDK, NgayHetHan = @NgayHetHan
	WHERE MaKhachHang = @MaKhachHang
END
GO
--4.4. Xoa khach hang  tu bang KHACHHANG
CREATE PROC SP_XOA_KHACHHANG
	@MaKhachHang NVARCHAR(10)
AS
BEGIN
	DELETE KHACHHANG WHERE MaKhachHang = @MaKhachHang
END
GO
--4.5 Tìm kiếm
---Tìm thông tin khach hang  tu bang KHACHHANG

CREATE PROCEDURE SP_TIMKIEM_KHACH_HANG
@MaKhachHang NVARCHAR(10)
AS
BEGIN
SELECT * FROM KHACHHANG 
WHERE MaKhachHang like '%' + @MaKhachHang + '%'  
END
GO
--5. Bảng NHANVIEN
--5.1 Load
---Load du lieu tu bang NHANVIEN
CREATE PROC SP_LOAD_NHANVIEN
AS
BEGIN
	SELECT * FROM NHANVIEN
END
GO
--5.2 Thêm
---Thêm nhân viên vào bang NHANVIEN
CREATE PROC SP_THEM_NHANVIEN
	
	@MaNhanVien NVARCHAR(20),
	@TenNhanVien NVARCHAR(30),
	@ChucVu NVARCHAR(20),
	@SoDienThoai NVARCHAR(20),
	@DiaChi NVARCHAR(50)
AS
BEGIN
	INSERT INTO NHANVIEN(MaNhanVien, TenNhanVien, ChucVu, SoDienThoai, DiaChi)
	VALUES (@MaNhanVien, @TenNhanVien, @ChucVu, @SoDienThoai, @DiaChi) 
END
GO
--4.3 Sua
---Sửa thông tin nhân viên từ bang NHANVIEN
CREATE PROC SP_SUA_NHANVIEN
	@MaNhanVien NVARCHAR(20),
	@TenNhanVien NVARCHAR(30),
	@ChucVu NVARCHAR(20),
	@SoDienThoai NVARCHAR(20),
	@DiaChi NVARCHAR(50)
AS
BEGIN
	UPDATE NHANVIEN SET TenNhanVien = @TenNhanVien, ChucVu = @ChucVu, SoDienThoai =@SoDienThoai, DiaChi = @DiaChi
	WHERE MaNhanVien = @MaNhanVien
END
GO
--4.4. Xóa
---Xóa nhân viên tu bang NHANVIEN
CREATE PROC SP_DELETE_NHANVIEN 
	@MaNhanVien NVARCHAR(20)
AS
BEGIN
	DELETE NHANVIEN WHERE MaNhanVien = @MaNhanVien
END
GO
--5.Bảng LOAISACH
--5.1 Load
---Load du lieu tu bang LOAISACH
CREATE PROC SP_LOAD_LOAISACH
AS
BEGIN
	SELECT * FROM LOAISACH
END
GO
--5.2 Thêm
---Thêm thông tin loại sách vào bang LOAISACH
CREATE PROC SP_THEM_LOAISACH
		
	@MaLoaiSach NVARCHAR (20),
	@TenLoaiSach NVARCHAR (50)
AS
BEGIN
	INSERT INTO LOAISACH(MaLoaiSach, TenLoaiSach)
	VALUES (@MaLoaiSach, @TenLoaiSach)
END
GO
--5.3 Sua
---Sửa thông tin loại sách tu bang LOAISACH
CREATE PROC SP_SUA_LOAISACH
	@MaLoaiSach NVARCHAR (20),
	@TenLoaiSach NVARCHAR (50)
AS
BEGIN
	UPDATE LOAISACH SET TenLoaiSach = @TenLoaiSach
	WHERE MaLoaiSach = @MaLoaiSach
END
GO
--5.4 Xóa
---Xóa thông tin loại sách tu bang LOAISACH
CREATE PROC SP_DELETE_LOAISACH
	@MaLoaiSach NVARCHAR (20)
AS
BEGIN
	DELETE LOAISACH WHERE MaLoaiSach = @MaLoaiSach
END
GO
--6. Bảng DangKy
--6.1 Them
---Thêm thông tin tài khoản đăng ký vao bang DangKy
CREATE PROC SP_THEM_DANGKY
	@TenTaiKhoan NVARCHAR (20),
	@MatKhau NVARCHAR(20),
	@NhapLaiMatKhau NVARCHAR(20)
AS
BEGIN
	INSERT INTO DangKy(TenTaiKhoan, MatKhau, NhapLaiMatKhau) VALUES (@TenTaiKhoan, @MatKhau, @NhapLaiMatKhau)
END
GO
--7. Bảng TRASACH
--7.1 Load
---Load du lieu tu bang TRASACH
CREATE PROC SP_LOAD_TRASACH
AS
BEGIN
	SELECT * FROM TRASACH
END
GO

--7.2 Them
---Thêm thông tin trả sách vao bang TRASACH
CREATE PROC SP_THEM_TRASACH
	@MaTraSach NVARCHAR(10),
	@MaMuonSach NVARCHAR(10),
	@TenKhachHang NVARCHAR(30),
	@TenSach NVARCHAR(30),
	@NgayHenTra SMALLDATETIME,
	@NgayTra SMALLDATETIME,
	@PhiPhat MONEY
AS
BEGIN
	INSERT INTO TRASACH(MaTraSach,MaMuonSach,TenKhachHang,TenSach,NgayHenTra,NgayTra,PhiPhat)
    VALUES (@MaTraSach,@MaMuonSach,@TenKhachHang,@TenSach,@NgayHenTra,@NgayTra,@PhiPhat)
END
GO
--7.3 Sua
---Sửa thông tin trả sách tu bang TRASACH
CREATE PROC SP_SUA_TRASACH
	@MaTraSach NVARCHAR(10),
	@MaMuonSach NVARCHAR(10),
	@TenKhachHang NVARCHAR(30),
	@TenSach NVARCHAR(30),
	@NgayHenTra SMALLDATETIME,
	@NgayTra SMALLDATETIME,
	@PhiPhat MONEY

AS
BEGIN
	UPDATE TRASACH SET  MaMuonSach = @MaMuonSach, TenKhachHang= @TenKhachHang, TenSach= @TenSach,NgayHenTra = @NgayHenTra, NgayTra = @NgayTra, PhiPhat = @PhiPhat
	WHERE MaTraSach = @MaTraSach
END
GO
--7.4 Xoa
---Xóa thông tin trả sách tu bang TRASACH
CREATE PROC SP_XOA_TRASACH
	@MaTraSach NVARCHAR(10)
AS
BEGIN
	DELETE TRASACH  WHERE MaTraSach = @MaTraSach
END
GO



