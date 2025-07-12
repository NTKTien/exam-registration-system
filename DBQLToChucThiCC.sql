USE MASTER;

--DROP DATABASE QLToChucThiCC;

---- Tạo database
--CREATE DATABASE QLToChucThiCC;

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
CREATE TABLE ThiSinh (
	MaDS CHAR(5),
	MaTS CHAR(5),
	HoTen NVARCHAR(100),
	GioiTinh NVARCHAR(3) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
	Ngaysinh DATE,
	SoDienThoai CHAR(10),
	CCCD CHAR(12),
	Email NVARCHAR(100),
	TGDuThiMongMuon TEXT,
	PRIMARY KEY (MaDS, MaTS)
);

-- Tạo bảng Danh Sách phòng thi
CREATE TABLE PhongThi(
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
	FOREIGN KEY (PhongThi) REFERENCES PhongThi(MaPT) 
	
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
    TrangThai NVARCHAR(20) CHECK (TrangThai IN (N'Chưa thanh toán', N'Đã hủy', N'Đã thanh toán', N'Đã xuất PDT')),
	MaDS CHAR(5),
	MaLT CHAR(5),
	TenDonVi NVARCHAR(100) DEFAULT NULL,
	FOREIGN KEY(MaLT) REFERENCES LichDGNL(MaLT),
	LoaiPDK NVARCHAR(4) CHECK (LoaiPDK IN (N'KHĐV', N'KHTD')),
	LoaiCC NVARCHAR(20) CHECK (LoaiCC IN (N'Tin học', N'Ngoại ngữ'))
);

-- Tạo bảng Thông tin người đăng ký
CREATE TABLE TTNguoiDangKy (
	MaNDK CHAR(5) PRIMARY KEY,
	CCCD CHAR(12),
	HoTen NVARCHAR(100),
	GioiTinh NVARCHAR(3) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
	Ngaysinh DATE,
	SoDienThoai CHAR(10),
	Email VARCHAR(100),
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
	MaTS CHAR(5),
	FOREIGN KEY (MaPDK) REFERENCES PhieuDangKy(MaPDK)
);

-- Tạo bảng Phiếu gia hạn
CREATE TABLE PhieuGiaHan (
	MaPGH CHAR(5) PRIMARY KEY,
	ThoiGian DATETIME,
	DiaDiem NVARCHAR(100),
	SBD CHAR(5),
	PhiGiaHan DECIMAL(10,0),
	TrangThai NVARCHAR(20) CHECK (TrangThai IN (N'Thành công', N'Đang đợi')), 
	MaPDK CHAR(5),
	LoaiGH NVARCHAR(20) CHECK (LoaiGH IN (N'Đặc biệt',N'Không đặc biệt'))
	FOREIGN KEY (MaPDK) REFERENCES PhieuDangKy(MaPDK)
);

-- Tạo bảng Hoá đơn thanh toán
CREATE TABLE HoaDonThanhToan (
	MaHD CHAR(5) PRIMARY KEY,
	TongTien DECIMAL(10,0),
	TroGia DECIMAL(10,0),
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
	DoiTuong VARCHAR(20) CHECK (DoiTuong IN ('DK', 'TT', 'GH', 'DB', 'HT')),
	NoiDung NVARCHAR(MAX),
	GiaTri DECIMAL(10,2)
)

-- INSERT DATA
-- Dữ liệu cho bảng NhanVien
INSERT INTO NhanVien VALUES
('NV001', N'Nguyễn Văn A', N'123 Lê Lợi, Q1', '0901234567', '1985-01-10', 'nva@example.com', 'TN'),
('NV002', N'Trần Thị B', N'234 Nguyễn Trãi, Q5', '0912233445', '1990-02-22', 'ttb@example.com', 'KT'),
('NV003', N'Phạm Văn C', N'12 Điện Biên, Q3', '0987654321', '1987-03-15', 'pvc@example.com', 'NL'),
('NV004', N'Lê Thị D', N'45 Nguyễn Du, Q1', '0923456789', '1992-04-05', 'ltd@example.com', 'TN'),
('NV005', N'Hà Văn E', N'67 Hai Bà Trưng, Q3', '0909876543', '1988-05-20', 'hve@example.com', 'KT'),
('NV006', N'Hoàng Thị F', N'89 Phạm Hồng Thái, Q1', '0918765432', '1991-06-12', 'htf@example.com', 'NL'),
('NV007', N'Ngô Đình G', N'101 Nguyễn Huệ, Q1', '0931234567', '1986-07-30', 'ndg@example.com', 'TN'),
('NV008', N'Bùi Văn H', N'202 Lý Tự Trọng, Q1', '0941237890', '1993-08-25', 'bvh@example.com', 'KT'),
('NV009', N'Tạ Thị I', N'303 Trần Hưng Đạo, Q5', '0950987654', '1994-09-13', 'tti@example.com', 'NL'),
('NV010', N'Vũ Văn K', N'404 Võ Thị Sáu, Q3', '0961236547', '1989-10-10', 'vvk@example.com', 'TN');

-- Dữ liệu cho bảng PhongThi
INSERT INTO PhongThi VALUES
('PT01', 1, 1),
('PT02', 1, 2),
('PT03', 2, 1),
('PT04', 2, 2),
('PT05', 3, 1),
('PT06', 3, 2),
('PT07', 4, 1),
('PT08', 4, 2),
('PT09', 5, 1),
('PT10', 5, 2);

-- Dữ liệu cho bảng LichDGNL
INSERT INTO LichDGNL VALUES
('LT001', '2025-08-01 08:00:00', '1', 'PT01', N'Tin học', 30, 25),
('LT002', '2025-08-01 14:00:00', '2', 'PT02', N'Ngoại ngữ', 30, 28),
('LT003', '2025-08-02 08:00:00', '1', 'PT03', N'Tin học', 25, 20),
('LT004', '2025-08-02 14:00:00', '2', 'PT04', N'Ngoại ngữ', 25, 22),
('LT005', '2025-08-03 08:00:00', '3', 'PT05', N'Tin học', 20, 15),
('LT006', '2025-08-03 14:00:00', '4', 'PT06', N'Ngoại ngữ', 20, 18),
('LT007', '2025-08-04 08:00:00', '1', 'PT07', N'Tin học', 30, 30),
('LT008', '2025-08-04 14:00:00', '2', 'PT08', N'Ngoại ngữ', 30, 27),
('LT009', '2025-08-05 08:00:00', '3', 'PT09', N'Tin học', 20, 18),
('LT010', '2025-08-05 14:00:00', '4', 'PT10', N'Ngoại ngữ', 20, 20);

-- Dữ liệu cho bảng ThiSinh
INSERT INTO ThiSinh VALUES
('DS001', 'TS001', N'Lê Minh Tuấn', N'Nam', '2003-01-01', '0911000001', '052204011036', 'tuanlm@gmail.com', N'Sáng 1/8/2025'),
('DS001', 'TS002', N'Nguyễn Thị Hồng', N'Nữ', '2002-03-21', '0911000002', '054704011036', 'hongnt@gmail.com', N'Sáng 1/8/2025'),
('DS002', 'TS003', N'Phạm Văn Hùng', N'Nam', '2001-12-03', '0911000003', '099904011036', 'hungpv@gmail.com', N'Chiều 1/8/2025'),
('DS002', 'TS004', N'Vũ Thị Mai', N'Nữ', '2000-08-15', '0911000004', '011204011098', 'maivt@gmail.com', N'Chiều 1/8/2025'),
('DS003', 'TS005', N'Ngô Minh Khoa', N'Nam', '2004-06-19', '0911000005', '052204022077', 'khoanm@gmail.com', N'Sáng 2/8/2025'),
('DS003', 'TS006', N'Trần Đức Lộc', N'Nam', '2003-11-11', '0911000006','052554099036',  'loctd@gmail.com', N'Sáng 2/8/2025'),
('DS004', 'TS007', N'Hoàng Thị Lan', N'Nữ', '2002-05-22', '0911000007', '052874011013', 'lanht@gmail.com', N'Chiều 2/8/2025'),
('DS004', 'TS008', N'Phan Thị Hoa', N'Nữ', '2001-07-07', '0911000008', '052204011039', 'hoapt@gmail.com', N'Chiều 2/8/2025'),
('DS005', 'TS009', N'Lý Văn Hưng', N'Nam', '2000-09-09', '0911000009', '052204011040', 'hunglv@gmail.com', N'Sáng 3/8/2025'),
('DS005', 'TS010', N'Đỗ Thị Nga', N'Nữ', '2003-10-10', '0911000010', '052204088836', 'ngocdt@gmail.com', N'Sáng 3/8/2025'),
('DS006', 'TS011', N'Đoàn Vỹ', N'Nam', '2003-10-10', '0911000010', '052204088836', 'ngocdt@gmail.com', N'Sáng 3/8/2025'),
('DS007', 'TS012', N'Đỗ Ngọc Giang', N'Nữ', '2003-10-10', '0911000010', '052204088836', 'ngocdt@gmail.com', N'Sáng 3/8/2025'),
('DS008', 'TS013', N'Nguyễn Hoàng', N'Nam', '2003-10-10', '0911000010', '052204088836', 'ngocdt@gmail.com', N'Sáng 3/8/2025');

-- Dữ liệu cho bảng LichThi_NhanVien
INSERT INTO LichThi_NhanVien VALUES
('LT001', 'NV001'),
('LT001', 'NV002'),
('LT002', 'NV003'),
('LT002', 'NV004'),
('LT003', 'NV005'),
('LT004', 'NV006'),
('LT005', 'NV007'),
('LT006', 'NV008'),
('LT007', 'NV009'),
('LT008', 'NV010');

-- Dữ liệu cho bảng PhieuDangKy
INSERT INTO PhieuDangKy VALUES
('PDK01', '2025-07-10 09:00:00', N'Đã thanh toán', 'DS001', 'LT001', N'Trường THPT A', N'KHĐV', N'Tin học'),
('PDK02', '2025-07-10 10:00:00', N'Đã thanh toán', 'DS002', 'LT002', N'Trường THPT B', N'KHĐV', N'Ngoại ngữ'),
('PDK03', '2025-07-10 11:00:00', N'Chưa thanh toán', 'DS003', 'LT003', N'Trường THPT C', N'KHĐV', N'Tin học'),
('PDK04', '2025-07-10 12:00:00', N'Đã xuất PDT', 'DS004', 'LT004', N'Trường THPT D', N'KHĐV', N'Ngoại ngữ'),
('PDK05', '2025-07-10 15:00:00', N'Chưa thanh toán', 'DS005', 'LT005', N'Trường THPT E', N'KHĐV', N'Tin học'),
('PDK06', '2025-07-10 12:15:00', N'Đã thanh toán', 'DS006', 'LT004', N'Trường THPT D', N'KHTD', N'Ngoại ngữ'),
('PDK07', '2025-07-10 15:00:00', N'Chưa thanh toán', 'DS007', 'LT005', N'Trường THPT E', N'KHTD', N'Tin học'),
('PDK08', '2025-07-10 15:30:00', N'Đã thanh toán', 'DS008', 'LT005', N'Trường THPT E', N'KHTD', N'Tin học');

-- Dữ liệu cho bảng TTNguoiDangKy
INSERT INTO TTNguoiDangKy VALUES
('NDK01', '012345678901', N'Lê Minh Tuấn', N'Nam', '2003-01-01', '0911000001', 'tuanlm@gmail.com', N'123 Đinh Tiên Hoàng', 'PDK01'),
('NDK02', '012345678902', N'Nguyễn Thị Hồng', N'Nữ', '2002-03-21', '0911000002', 'hongnt@gmail.com', N'234 Bạch Đằng', 'PDK02'),
('NDK03', '012345678903', N'Phạm Văn Hùng', N'Nam', '2001-12-03', '0911000003', 'hungpv@gmail.com', N'345 Nguyễn Trãi', 'PDK03'),
('NDK04', '012345678904', N'Vũ Thị Mai', N'Nữ', '2000-08-15', '0911000004', 'maivt@gmail.com', N'456 Lê Lợi', 'PDK04'),
('NDK05', '012345678905', N'Ngô Minh Khoa', N'Nam', '2004-06-19', '0911000005', 'khoanm@gmail.com', N'567 Lê Lai', 'PDK05'),
('NDK06', '012345678906', N'Trần Đức Lộc', N'Nam', '2003-11-11', '0911000006', 'loctd@gmail.com', N'678 Phan Đình Phùng', 'PDK06'),
('NDK07', '012345678907', N'Hoàng Thị Lan', N'Nữ', '2002-05-22', '0911000007', 'lanht@gmail.com', N'789 Võ Văn Tần', 'PDK07'),
('NDK08', '012345678908', N'Phan Thị Hoa', N'Nữ', '2001-07-07', '0911000008', 'hoapt@gmail.com', N'890 Cách Mạng Tháng 8', 'PDK08');

---- Chèn dữ liệu mới, đồng bộ với LichDGNL và PhongThi
--INSERT INTO PhieuDuThi (MaPDT, ThoiGian, DiaDiem, SBD, MaPDK)
--SELECT 
--    pdt.MaPDT,
--    l.NgayThi AS ThoiGian,
--    CONCAT(N'Phòng ', l.PhongThi, N', Tòa ', pt.Toa) AS DiaDiem,
--    pdt.SBD,
--    pdt.MaPDK
--FROM 
--    (VALUES 
--        ('PDT01', 'SBD01', 'PDK01'),
--        ('PDT02', 'SBD02', 'PDK02'),
--        ('PDT03', 'SBD03', 'PDK03'),
--        ('PDT04', 'SBD04', 'PDK04'),
--        ('PDT05', 'SBD05', 'PDK05'),
--        ('PDT06', 'SBD06', 'PDK06'),
--        ('PDT07', 'SBD07', 'PDK07'),
--        ('PDT08', 'SBD08', 'PDK08'),
--        ('PDT09', 'SBD09', 'PDK09'),
--        ('PDT10', 'SBD10', 'PDK10')
--    ) AS pdt(MaPDT, SBD, MaPDK)
--    JOIN PhieuDangKy pdk ON pdt.MaPDK = pdk.MaPDK
--    JOIN LichDGNL l ON pdk.MaLT = l.MaLT
--    JOIN PhongThi pt ON l.PhongThi = pt.MaPT;

INSERT INTO PhieuDuThi VALUES
('PDT01', '2025-08-01 08:00:00', N'Phòng 101, Toà A', 'SBD01', 'PDK04','TS007'),
('PDT02', '2025-08-01 08:00:00', N'Phòng 101, Toà A', 'SBD02', 'PDK04','TS008');

-- Chèn dữ liệu mới, đồng bộ với LichDGNL và PhongThi
INSERT INTO PhieuGiaHan (MaPGH, ThoiGian, DiaDiem, SBD, PhiGiaHan, TrangThai, MaPDK, LoaiGH)
SELECT 
    pgh.MaPGH,
    l.NgayThi AS ThoiGian,
    CONCAT(N'Phòng ', l.PhongThi, N', Tòa ', pt.Toa) AS DiaDiem,
    pgh.SBD,
    pgh.PhiGiaHan,
    pgh.TrangThai,
    pgh.MaPDK,
    pgh.LoaiGH
FROM 
    (VALUES 
        ('PGH01', 'SBD01', 500000, N'Thành công', 'PDK01', N'Đặc biệt'),
        ('PGH02', 'SBD02', 400000, N'Đang đợi', 'PDK02', N'Không đặc biệt'),
        ('PGH03', 'SBD03', 500000, N'Thành công', 'PDK03', N'Đặc biệt'),
        ('PGH04', 'SBD04', 400000, N'Đang đợi', 'PDK04', N'Không đặc biệt'),
        ('PGH05', 'SBD05', 500000, N'Thành công', 'PDK05', N'Đặc biệt'),
        ('PGH06', 'SBD06', 400000, N'Đang đợi', 'PDK06', N'Không đặc biệt'),
        ('PGH07', 'SBD07', 500000, N'Thành công', 'PDK07', N'Đặc biệt'),
        ('PGH08', 'SBD08', 400000, N'Đang đợi', 'PDK08', N'Không đặc biệt'),
        ('PGH09', 'SBD09', 500000, N'Thành công', 'PDK09', N'Đặc biệt'),
        ('PGH10', 'SBD10', 400000, N'Đang đợi', 'PDK10', N'Không đặc biệt')
    ) AS pgh(MaPGH, SBD, PhiGiaHan, TrangThai, MaPDK, LoaiGH)
    JOIN PhieuDangKy pdk ON pgh.MaPDK = pdk.MaPDK
    JOIN LichDGNL l ON pdk.MaLT = l.MaLT
    JOIN PhongThi pt ON l.PhongThi = pt.MaPT;

-- Dữ liệu cho bảng HoaDonThanhToan
INSERT INTO HoaDonThanhToan VALUES
('HD001', 1000000, 200000, 800000, 'PDK01', 'NV001'),
('HD002', 1000000, 0, 1000000, 'PDK02', 'NV002'),
('HD003', 1000000, 100000, 900000, 'PDK03', 'NV003'),
('HD004', 950000, 0, 950000, 'PDK04', 'NV004'),
('HD005', 900000, 0, 900000, 'PDK05', 'NV005'),
('HD006', 950000, 50000, 900000, 'PDK06', 'NV006'),
('HD007', 1100000, 100000, 1000000, 'PDK07', 'NV007'),
('HD008', 1200000, 0, 1200000, 'PDK08', 'NV008');

-- Dữ liệu cho bảng BangTinh
INSERT INTO BangTinh VALUES
('BT001', N'Đạt', '2025-08-10 10:00:00', '2025-08-15 15:00:00', N'Đã giao', 'PDT01', 'NV001'),
('BT002', N'Không đạt', '2025-08-10 10:20:00', '2025-08-15 15:20:00', N'Chưa giao', 'PDT02', 'NV002');

-- Insert into QuyDinh (10 rows)
INSERT INTO QuyDinh (MaQD, DoiTuong, NoiDung, GiaTri) VALUES
('QD001', 'TT', N'Số lượng thí sinh tối thiểu để trợ giá cho đơn vị là 20', 20),
('QD002', 'TT', N'Đơn vị có số lượng thí sinh vượt ngưỡng tối thiểu được trợ giá 10%', 0.1),
('QD003', 'TT', N'Thời gian đến hạn thanh toán là 3 ngày kể từ ngày đăng ký. Sau thời gian trên, các phiếu đăng ký chưa được thanh toán sẽ bị hủy.', 3),
('QD004', 'TT', N'Lệ phí thi Ngoại ngữ của khách hàng tự do: 1.800.000', 1800000),
('QD005', 'TT', N'Lệ phí thi Tin học của khách hàng tự do: 1.500.000', 1500000),
('QD006', 'TT', N'Trung tâm không trợ giá lệ phí thi cho khách hàng tự do.', 0),
('QD007', 'DK', N'Trung tâm hỗ trợ đăng ký cho hai loại khách hàng gồm khách hàng tự do và khách hàng đơn vị.', 2),
('QD008', 'GH', N'Mỗi khách hàng được gia hạn tối đa 2 lần trên một phiếu dự thi.', 2),
('QD009', 'DB', N'Khách hàng có lý do đặc biệt như bệnh tật, tai nạn, tang sự sẽ được hỗ trợ gia hạn miễn phí.', 0),
('QD010', 'HT', N'Trung tâm không hoàn phí sau khi khách hàng đã hoàn tất thanh toán và nhận phiếu dự thi.', 0);




---------------------------------------------------------------------------------------------------------------------------------------------------------------------
