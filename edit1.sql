-- sua phieu gia han -> them LoaiGH, va insert tuong ung
USE MASTER;

DROP DATABASE QLToChucThiCC;

-- Tạo database
CREATE DATABASE QLToChucThiCC;
go
-- Sử dụng database
USE QLToChucThiCC;

-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    MaNV CHAR(5) PRIMARY KEY,
    HoTen NVARCHAR(100),
    DiaChi NVARCHAR(100),
    SoDienThoai CHAR(10),
    NgaySinh DATE,
	Email NVARCHAR(100),
	LoaiNV CHAR(2) CHECK (LoaiNV IN ('TN', 'KT','NL'))
);

-- Tạo bảng Danh Sách thí sinh
CREATE TABLE DSThiSinh (
	MaDS CHAR(5),
	MaTS CHAR(5),
	HoTen NVARCHAR(100),
	GioiTinh NVARCHAR(3) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
	Ngaysinh DATE,
	SoDienThoai CHAR(10),
	Email NVARCHAR(100),
	TGDuThiMongMuon TEXT,
	PRIMARY KEY (MaDS, MaTS),
	CONSTRAINT UQ_MaDS UNIQUE (MaDS)
);

-- Tạo bảng Danh Sách phòng thi
CREATE TABLE DSPhongThi(
	MaPT CHAR(4) PRIMARY KEY,
	Tang INT,
	Toa INT
);

-- Tạo bảng Lịch ĐGNL
CREATE TABLE LichDGNL(
	MaLT CHAR(5) PRIMARY KEY,
	NgayThi DATETIME,
	CaThi CHAR(1) CHECK (CaThi IN ('1','2','3','4')),
	PhongThi CHAR(4),
	LoaiDGNL NVARCHAR(20) CHECK (LoaiDGNL IN (N'Tin học', N'Ngoại ngữ')),
	SLTSToiDa INT CHECK (SLTSToiDa >=0),
	SLTSHienTai INT 
	CHECK ( SLTSHienTai >=0 ),
	CHECK (SLTSHienTai <= SLTSToiDa ),
	FOREIGN KEY (PhongThi) REFERENCES DSPhongThi(MaPT) 
	
);

-- Tạo bảng Lịch thi_Nhân viên
CREATE TABLE LichThi_NhanVien(
	MaLT CHAR(5),
	MaNV CHAR(5),
	PRIMARY KEY (MALT,MaNV),
	FOREIGN KEY (MaLT) REFERENCES LichDGNL(MaLT), 
	FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) 
);

-- Tạo bảng Phiếu đăng ký
CREATE TABLE PhieuDangKy (
    MaPDK CHAR(5) PRIMARY KEY,
    NgayLap DATETIME,
    TrangThaiThanhToan NVARCHAR(20) CHECK (TrangThaiThanhToan IN (N'Đã thanh toán', N'Chưa thanh toán')),
	MaDS CHAR(5),
	FOREIGN KEY(MaDS) REFERENCES DSThiSinh(MaDS),
	MaLT CHAR(5),
	TenDonVi NVARCHAR(100) DEFAULT NULL,  -- UPDATE 7/7
	FOREIGN KEY(MaLT) REFERENCES LichDGNL(MaLT),
	LoaiPDK NVARCHAR(4) CHECK (LoaiPDK IN (N'KHĐV', N'KHTD'))  --UPDATE 7/7
);

-- Tạo bảng Thông tin người đăng ký
CREATE TABLE TTNguoiDangKy (
	MaNDK CHAR(5) PRIMARY KEY,
	CCCD CHAR(12),		--UPDATE 7/7
	HoTen NVARCHAR(100),
	GioiTinh NVARCHAR(3) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
	Ngaysinh DATE,
	SoDienThoai CHAR(10),
	DiaChi NVARCHAR(100),
	MaPDK CHAR(5),
	FOREIGN KEY(MaPDK) REFERENCES PhieuDangKy(MaPDK)
);

-- Tạo bảng Phiếu dự thi
CREATE TABLE PhieuDuThi (
    MaPDT CHAR(5) PRIMARY KEY,
    ThoiGian DATETIME,
	DiaDiem NVARCHAR(100),
	SBD CHAR(5),
	MaPDK CHAR(5),
	FOREIGN KEY (MaPDK) REFERENCES PhieuDangKy(MaPDK)
);

-- Tạo bảng Phiếu gia hạn
CREATE TABLE PhieuGiaHan (
	MaPGH CHAR(5) PRIMARY KEY,
	ThoiGian DATETIME,
	DiaDiem NVARCHAR(100),
	SBD CHAR(5),
	PhiGiaHan DECIMAL(10,0),
	TrangThai NVARCHAR(20) CHECK (TrangThai IN (N'Thành công', N'Thất bại', N'Đang đợi')),
	MaPDK CHAR(5),
	LoaiGH NVARCHAR(20) CHECK (LoaiGH IN (N'Đặc biệt',N'Không đặc biệt' ))
	FOREIGN KEY (MaPDK) REFERENCES PhieuDangKy(MaPDK)
);

-- Tạo bảng Hoá đơn thanh toán
CREATE TABLE HoaDonThanhToan (
	MaHD CHAR(5) PRIMARY KEY,
	TongTien DECIMAL(10,0),
	TroGia DECIMAL(10,0),
	GiamGia DECIMAL(10,0),
	ThanhTien DECIMAL(10,0),
	MaPDK CHAR(5),
	MaNV CHAR(5),
	FOREIGN KEY (MaPDK) REFERENCES PhieuDangKy(MaPDK),
	FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

-- Tạo bảng Bảng tính
CREATE TABLE BangTinh (
    MaBT CHAR(5) PRIMARY KEY,
    KetQua NVARCHAR(100),
    ThoiGianNhanCC DATETIME,
	ThoiGianGiaoCC DATETIME,
	TrangThai NVARCHAR(20) CHECK (TrangThai IN (N'Đã giao', N'Chưa giao', N'Quá hạn')),
	MaPDT CHAR(5),
	NVGiaoCC CHAR(5),
	FOREIGN KEY (MaPDT) REFERENCES PhieuDuThi(MaPDT),
	FOREIGN KEY (NVGiaoCC) REFERENCES NhanVien(MaNV)
);

-- Tạo bảng Quy định
CREATE TABLE QuyDinh (
	MaQD CHAR(5),
	DoiTuong VARCHAR(20) CHECK (DoiTuong IN ('LichDGNL', 'HoaDonThanhToan', 'PhieuGiaHan')),
	NoiDung TEXT,
	GiaTri INT
)

-- INSERT DATA

-- Insert into NhanVien 
INSERT INTO NhanVien (MaNV, HoTen, DiaChi, SoDienThoai, NgaySinh, Email, LoaiNV) VALUES
('NV001', N'Nguyễn Văn An', N'123 Đường Láng, Hà Nội', '0987654321', '1990-05-20', 'an.nv@gmail.com', 'TN'),
('NV002', N'Trần Thị Bình', N'45 Nguyễn Huệ, TP.HCM', '0912345678', '1985-11-15', 'binh.tt@gmail.com', 'KT'),
('NV003', N'Lê Minh Châu', N'78 Trần Phú, Đà Nẵng', '0934567890', '1992-03-10', 'chau.lm@gmail.com', 'NL'),
('NV004', N'Phạm Văn Đức', N'12 Lê Lợi, Huế', '0901234567', '1988-07-25', 'duc.pv@gmail.com', 'TN'),
('NV005', N'Hoàng Thị Mai', N'56 Phạm Văn Đồng, Hà Nội', '0978765432', '1995-09-30', 'mai.ht@gmail.com', 'KT'),
('NV006', N'Vũ Văn Hùng', N'89 Hai Bà Trưng, Hà Nội', '0945678901', '1990-12-12', 'hung.vv@gmail.com', 'NL'),
('NV007', N'Đỗ Thị Lan', N'34 Nguyễn Trãi, TP.HCM', '0923456789', '1987-04-18', 'lan.dt@gmail.com', 'TN'),
('NV008', N'Bùi Minh Tuấn', N'67 Lê Đại Hành, Đà Nẵng', '0967890123', '1993-06-22', 'tuan.bm@gmail.com', 'KT'),
('NV009', N'Ngô Thị Ngọc', N'23 Trần Hưng Đạo, Hà Nội', '0956789012', '1991-08-15', 'ngoc.nt@gmail.com', 'NL'),
('NV010', N'Lý Văn Khánh', N'45 Hùng Vương, Huế', '0931234567', '1989-10-10', 'khanh.lv@gmail.com', 'TN');

-- Insert into DSThiSinh 
INSERT INTO DSThiSinh (MaDS, MaTS, HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, TGDuThiMongMuon) VALUES
('DS001', 'TS001', N'Nguyễn Thị Hoa', N'Nữ', '2000-02-15', '0981234567', 'hoa.nt@gmail.com', 'Sáng'),
('DS002', 'TS002', N'Trần Văn Hùng', N'Nam', '1999-06-20', '0918765432', 'hung.tv@gmail.com', 'Chiều'),
('DS003', 'TS003', N'Lê Thị Lan', N'Nữ', '2001-08-10', '0935678901', 'lan.lt@gmail.com', 'Sáng'),
('DS004', 'TS004', N'Phạm Minh Tuấn', N'Nam', '2000-12-05', '0902345678', 'tuan.pm@gmail.com', 'Tối'),
('DS005', 'TS005', N'Vũ Thị Ngọc', N'Nữ', '1998-04-22', '0976543210', 'ngoc.vt@gmail.com', 'Sáng'),
('DS006', 'TS006', N'Đỗ Văn Khánh', N'Nam', '1999-09-18', '0941234567', 'khanh.dv@gmail.com', 'Chiều'),
('DS007', N'TS007', N'Bùi Thị Mai', N'Nữ', '2000-03-25', '0967891234', 'mai.bt@gmail.com', 'Sáng'),
('DS008', 'TS008', N'Ngô Văn Long', N'Nam', '1999-07-30', '0952345678', 'long.nv@gmail.com', 'Tối'),
('DS009', 'TS009', N'Lý Thị Hương', N'Nữ', '2001-01-12', '0923456781', 'huong.lt@gmail.com', 'Chiều'),
('DS010', 'TS010', N'Hồ Minh Đức', N'Nam', '1998-11-05', '0915678902', 'duc.hm@gmail.com', 'Sáng');

-- Insert into DSPhongThi 
INSERT INTO DSPhongThi (MaPT, Tang, Toa) VALUES
('PT01', 1, 1),
('PT02', 2, 1),
('PT03', 3, 1),
('PT04', 1, 2),
('PT05', 2, 2),
('PT06', 3, 2),
('PT07', 1, 3),
('PT08', 2, 3),
('PT09', 3, 3),
('PT10', 1, 4);

-- Insert into LichDGNL 
INSERT INTO LichDGNL (MaLT, NgayThi, CaThi, PhongThi, LoaiDGNL, SLTSToiDa, SLTSHienTai) VALUES
('LT001', '2025-07-10 08:00:00', '1', 'PT01', N'Tin học', 30, 25),
('LT002', '2025-07-10 13:00:00', '2', 'PT02', N'Ngoại ngữ', 25, 20),
('LT003', '2025-07-11 08:00:00', '1', 'PT03', N'Tin học', 40, 35),
('LT004', '2025-07-11 13:00:00', '2', 'PT04', N'Ngoại ngữ', 30, 28),
('LT005', '2025-07-12 15:00:00', '3', 'PT05', N'Tin học', 20, 15),
('LT006', '2025-07-12 18:00:00', '4', 'PT06', N'Ngoại ngữ', 25, 22),
('LT007', '2025-07-13 08:00:00', '1', 'PT07', N'Tin học', 35, 30),
('LT008', '2025-07-13 13:00:00', '2', 'PT08', N'Ngoại ngữ', 30, 25),
('LT009', '2025-07-14 15:00:00', '3', 'PT09', N'Tin học', 25, 20),
('LT010', '2025-07-14 18:00:00', '4', 'PT10', N'Ngoại ngữ', 20, 18);

-- Insert into LichThi_NhanVien 
INSERT INTO LichThi_NhanVien (MaLT, MaNV) VALUES
('LT001', 'NV001'),
('LT002', 'NV002'),
('LT003', 'NV003'),
('LT004', 'NV004'),
('LT005', 'NV005'),
('LT006', 'NV006'),
('LT007', 'NV007'),
('LT008', 'NV008'),
('LT009', 'NV009'),
('LT010', 'NV010');

-- Insert into PhieuDangKy 
INSERT INTO PhieuDangKy (MaPDK, NgayLap, TrangThaiThanhToan, MaDS, MaLT, TenDonVi, LoaiPDK) VALUES
('PDK01', '2025-07-01 10:00:00', N'Đã thanh toán', 'DS001', 'LT001', N'Công ty ABC', N'KHĐV'),
('PDK02', '2025-07-02 14:00:00', N'Chưa thanh toán', 'DS002', 'LT002', NULL, N'KHTD'),
('PDK03', '2025-07-03 09:00:00', N'Đã thanh toán', 'DS003', 'LT003', N'Công ty XYZ', N'KHĐV'),
('PDK04', '2025-07-04 11:00:00', N'Chưa thanh toán', 'DS004', 'LT004', NULL, N'KHTD'),
('PDK05', '2025-07-05 15:00:00', N'Đã thanh toán', 'DS005', 'LT005', N'Công ty DEF', N'KHĐV'),
('PDK06', '2025-07-06 16:00:00', N'Chưa thanh toán', 'DS006', 'LT006', NULL, N'KHTD'),
('PDK07', '2025-07-07 10:00:00', N'Đã thanh toán', 'DS007', 'LT007', N'Công ty GHI', N'KHĐV'),
('PDK08', '2025-07-08 12:00:00', N'Chưa thanh toán', 'DS008', 'LT008', NULL, N'KHTD'),
('PDK09', '2025-07-09 14:00:00', N'Đã thanh toán', 'DS009', 'LT009', N'Công ty JKL', N'KHĐV'),
('PDK10', '2025-07-10 16:00:00', N'Chưa thanh toán', 'DS010', 'LT010', NULL, N'KHTD');

-- Insert into TTNguoiDangKy
INSERT INTO TTNguoiDangKy (MaNDK, CCCD, HoTen, GioiTinh, NgaySinh, SoDienThoai, DiaChi, MaPDK) VALUES
('NDK01', '123456789012', N'Nguyễn Thị Hoa', N'Nữ', '2000-02-15', '0981234567', N'123 Đường Láng, Hà Nội', 'PDK01'),
('NDK02', '234567890123', N'Trần Văn Hùng', N'Nam', '1999-06-20', '0918765432', N'45 Nguyễn Huệ, TP.HCM', 'PDK02'),
('NDK03', '345678901234', N'Lê Thị Lan', N'Nữ', '2001-08-10', '0935678901', N'78 Trần Phú, Đà Nẵng', 'PDK03'),
('NDK04', '456789012345', N'Phạm Minh Tuấn', N'Nam', '2000-12-05', '0902345678', N'12 Lê Lợi, Huế', 'PDK04'),
('NDK05', '567890123456', N'Vũ Thị Ngọc', N'Nữ', '1998-04-22', '0976543210', N'56 Phạm Văn Đồng, Hà Nội', 'PDK05'),
('NDK06', '678901234567', N'Đỗ Văn Khánh', N'Nam', '1999-09-18', '0941234567', N'89 Hai Bà Trưng, Hà Nội', 'PDK06'),
('NDK07', '789012345678', N'Bùi Thị Mai', N'Nữ', '2000-03-25', '0967891234', N'34 Nguyễn Trãi, TP.HCM', 'PDK07'),
('NDK08', '890123456789', N'Ngô Văn Long', N'Nam', '1999-07-30', '0952345678', N'67 Lê Đại Hành, Đà Nẵng', 'PDK08'),
('NDK09', '901234567890', N'Lý Thị Hương', N'Nữ', '2001-01-12', '0923456781', N'23 Trần Hưng Đạo, Hà Nội', 'PDK09'),
('NDK10', '012345678901', N'Hồ Minh Đức', N'Nam', '1998-11-05', '0915678902', N'45 Hùng Vương, Huế', 'PDK10');

-- Insert into PhieuDuThi 
INSERT INTO PhieuDuThi (MaPDT, ThoiGian, DiaDiem, SBD, MaPDK) VALUES
('PDT01', '2025-07-10 08:00:00', N'Tòa 1, Tầng 1, Hà Nội', 'SBD01', 'PDK01'),
('PDT02', '2025-07-10 13:00:00', N'Tòa 1, Tầng 2, Hà Nội', 'SBD02', 'PDK02'),
('PDT03', '2025-07-11 08:00:00', N'Tòa 2, Tầng 3, Hà Nội', 'SBD03', 'PDK03'),
('PDT04', '2025-07-11 13:00:00', N'Tòa 2, Tầng 1, Hà Nội', 'SBD04', 'PDK04'),
('PDT05', '2025-07-12 15:00:00', N'Tòa 3, Tầng 2, Hà Nội', 'SBD05', 'PDK05'),
('PDT06', '2025-07-12 18:00:00', N'Tòa 2, Tầng 3, Hà Nội', 'SBD06', 'PDK06'),
('PDT07', '2025-07-13 08:00:00', N'Tòa 3, Tầng 1, Hà Nội', 'SBD07', 'PDK07'),
('PDT08', '2025-07-13 13:00:00', N'Tòa 4, Tầng 2, Hà Nội', 'SBD08', 'PDK08'),
('PDT09', '2025-07-14 15:00:00', N'Tòa 3, Tầng 3, Hà Nội', 'SBD09', 'PDK09'),
('PDT10', '2025-07-14 18:00:00', N'Tòa 4, Tầng 1, Hà Nội', 'SBD10', 'PDK10');

-- Insert into PhieuGiaHan
INSERT INTO PhieuGiaHan (MaPGH, ThoiGian, DiaDiem, SBD, PhiGiaHan, TrangThai, MaPDK, LoaiGH) VALUES
('PGH01', '2025-07-07 09:00:00', N'Hà Nội', 'SBD01', 500000, N'Thành công', 'PDK01', N'Không đặc biệt'),
('PGH02', '2025-07-07 10:00:00', N'Hà Nội', 'SBD02', 500000, N'Đang đợi', 'PDK02', N'Đặc biệt'),
('PGH03', '2025-07-07 11:00:00', N'Hà Nội', 'SBD03', 500000, N'Thành công', 'PDK03', N'Không đặc biệt'),
('PGH04', '2025-07-07 12:00:00', N'Hà Nội', 'SBD04', 500000, N'Thất bại', 'PDK04', N'Không đặc biệt'),
('PGH05', '2025-07-07 13:00:00', N'Hà Nội', 'SBD05', 500000, N'Đang đợi', 'PDK05', N'Đặc biệt'),
('PGH06', '2025-07-07 14:00:00', N'Hà Nội', 'SBD06', 500000, N'Thành công', 'PDK06', N'Không đặc biệt'),
('PGH07', '2025-07-07 15:00:00', N'Hà Nội', 'SBD07', 500000, N'Đang đợi', 'PDK07', N'Không đặc biệt'),
('PGH08', '2025-07-07 16:00:00', N'Hà Nội', 'SBD08', 500000, N'Thất bại', 'PDK08', N'Đặc biệt'),
('PGH09', '2025-07-07 17:00:00', N'Hà Nội', 'SBD09', 500000, N'Thành công', 'PDK09', N'Không đặc biệt'),
('PGH10', '2025-07-07 18:00:00', N'Hà Nội', 'SBD10', 500000, N'Đang đợi', 'PDK10', N'Không đặc biệt');


-- Insert into HoaDonThanhToan
INSERT INTO HoaDonThanhToan (MaHD, TongTien, TroGia, GiamGia, ThanhTien, MaPDK, MaNV) VALUES
('HD001', 1000000, 0, 100000, 900000, 'PDK01', 'NV001'),
('HD002', 1200000, 0, 0, 1200000, 'PDK02', 'NV002'),
('HD003', 1500000, 0, 200000, 1300000, 'PDK03', 'NV003'),
('HD004', 1000000, 0, 0, 1000000, 'PDK04', 'NV004'),
('HD005', 1100000, 0, 100000, 1000000, 'PDK05', 'NV005'),
('HD006', 1300000, 0, 150000, 1150000, 'PDK06', 'NV006'),
('HD007', 1400000, 0, 200000, 1200000, 'PDK07', 'NV007'),
('HD008', 1000000, 0, 0, 1000000, 'PDK08', 'NV008'),
('HD009', 1200000, 0, 100000, 1100000, 'PDK09', 'NV009'),
('HD010', 1500000, 0, 0, 1500000, 'PDK10', 'NV010');

-- Insert into BangTinh 
INSERT INTO BangTinh (MaBT, KetQua, ThoiGianNhanCC, ThoiGianGiaoCC, TrangThai, MaPDT, NVGiaoCC) VALUES
('BT001', N'Đạt', '2025-07-15 09:00:00', '2025-07-16 09:00:00', N'Đã giao', 'PDT01', 'NV001'),
('BT002', N'Không đạt', '2025-07-15 10:00:00', '2025-07-16 10:00:00', N'Đã giao', 'PDT02', 'NV002'),
('BT003', N'Đạt', '2025-07-15 11:00:00', NULL, N'Chưa giao', 'PDT03', 'NV003'),
('BT004', N'Đạt', '2025-07-15 12:00:00', '2025-07-17 12:00:00', N'Đã giao', 'PDT04', 'NV004'),
('BT005', N'Không đạt', '2025-07-15 13:00:00', NULL, N'Quá hạn', 'PDT05', 'NV005'),
('BT006', N'Đạt', '2025-07-15 14:00:00', '2025-07-17 14:00:00', N'Đã giao', 'PDT06', 'NV006'),
('BT007', N'Không đạt', '2025-07-15 15:00:00', NULL, N'Chưa giao', 'PDT07', 'NV007'),
('BT008', N'Đạt', '2025-07-15 16:00:00', '2025-07-17 16:00:00', N'Đã giao', 'PDT08', 'NV008'),
('BT009', N'Không đạt', '2025-07-15 17:00:00', NULL, N'Quá hạn', 'PDT09', 'NV009'),
('BT010', N'Đạt', '2025-07-15 18:00:00', '2025-07-17 18:00:00', N'Đã giao', 'PDT10', 'NV010');

---- Insert into QuyDinh (10 rows)
--INSERT INTO QuyDinh (MaQD, DoiTuong, NoiDung, GiaTri) VALUES
--('QD001', 'LichDGNL', N'Số lượng thí sinh tối đa mỗi ca', 50),
--('QD002', 'HoaDonThanhToan', N'Giảm giá cho thí sinh đăng ký sớm', 100000),
--('QD003', 'PhieuGiaHan', N'Phí gia hạn chứng chỉ', 500000),
--('QD004', 'LichDGNL', N'Số ca thi tối đa mỗi ngày', 4),
--('QD005', 'HoaDonThanhToan', N'Tổng tiền tối đa mỗi phiếu', 2000000),
--('QD006', 'PhieuGiaHan', N'Thời hạn gia hạn tối đa (ngày)', 30),
--('QD007', 'LichDGNL', N'Thời gian bắt đầu ca 1', 8),
--('QD008', 'HoaDonThanhToan', N'Phí dịch vụ bổ sung', 50000),
--('QD009', 'LichDGNL', N'Số lượng phòng thi tối đa', 20),
--('QD010', 'PhieuGiaHan', N'Số lần gia hạn tối đa', 2);