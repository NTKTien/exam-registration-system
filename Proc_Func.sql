USE QLToChucThiCC;
GO

-- Lấy toàn bộ danh sách phiếu đăng ký 
CREATE OR ALTER PROCEDURE P_GetAllReg
AS
BEGIN
    SELECT 
        P.MaPDK,
        P.NgayLap,
        P.LoaiCC,
        L.NgayThi,
        D.HoTen,
        P.LoaiPDK,
        P.TrangThai
    FROM PhieuDangKy P
    JOIN DSThiSinh D ON P.MaDS = D.MaDS
    JOIN LichDGNL L ON P.MaLT = L.MaLT
END;
GO

--Lấy thông tin phiếu đăng kí theo mã phiếu 
CREATE OR ALTER PROCEDURE sp_GetRegistrationById
    @RegistrationId CHAR(5)
AS
BEGIN
    SELECT 
        P.MaPDK,
        P.NgayLap,
        ld.NgayThi,
        P.LoaiCC,
        P.TrangThai,
        ld.CaThi
    FROM PhieuDangKy P
    JOIN LichDGNL ld ON P.MaLT = ld.MaLT
    WHERE P.MaPDK = @RegistrationId
END;
GO


--Lấy thông tin khách hàng theo mã KH
CREATE OR ALTER PROCEDURE sp_GetFreeCustomerInforByRegId
    @RegistrationId CHAR(5)
AS
BEGIN
    SELECT 
        ndk.HoTen,
        ndk.GioiTinh,
        ndk.NgaySinh,
        ndk.CCCD,
        ndk.SoDienThoai,
        ndk.Email,
        ndk.DiaChi
    FROM TTNguoiDangKy ndk
    WHERE ndk.MaPDK = @RegistrationId
END;
GO

--Lấy tất cả các lịch thi có còn trống (SLTSHienTai < SLTSToiDa)
CREATE OR ALTER PROCEDURE sp_GetAllExamSchedule
 @LoaiDGNL NVARCHAR(20)
AS
BEGIN
    SELECT 
        MaLT, 
        NgayThi, 
        CaThi, 
		PhongThi,
        LoaiDGNL, 
        SLTSToiDa, 
        SLTSHienTai
    FROM LichDGNL
	WHERE SLTSHienTai < SLTSToiDa AND LoaiDGNL = @LoaiDGNL
END;
GO

-- Thêm khách hàng
CREATE OR ALTER PROCEDURE sp_InsertCustomer
    @HoTen NVARCHAR(100),
    @GioiTinh NVARCHAR(10),
    @NgaySinh DATE,
    @CCCD CHAR(12),
    @SoDienThoai VARCHAR(15),
    @Email VARCHAR(50),
    @DiaChi NVARCHAR(200),
    @MaPDK CHAR(5)
AS
BEGIN
    -- Tạo mã NDK tiếp theo: lấy số lớn nhất rồi +1
    DECLARE @NewMaNDK CHAR(5)
    DECLARE @MaxMaNDK INT

    SELECT @MaxMaNDK = MAX(CAST(SUBSTRING(MaNDK, 4, LEN(MaNDK) - 3) AS INT))
    FROM TTNguoiDangKy

    IF @MaxMaNDK IS NULL
        SET @MaxMaNDK = 0

    SET @NewMaNDK = 'NDK' + RIGHT('00' + CAST(@MaxMaNDK + 1 AS VARCHAR), 2)

    -- Thêm khách hàng
    INSERT INTO TTNguoiDangKy(MaNDK, HoTen, GioiTinh, NgaySinh, CCCD, SoDienThoai, Email, DiaChi, MaPDK)
    VALUES (@NewMaNDK, @HoTen, @GioiTinh, @NgaySinh, @CCCD, @SoDienThoai, @Email, @DiaChi, @MaPDK)
END;
GO

-- Thêm phiếu đăng ký
CREATE OR ALTER PROCEDURE sp_InsertFreeReg
    @MaPDK CHAR(5),
    @NgayDangKy DATE,
    @LoaiDGNL NVARCHAR(50),
    @MaLichThi CHAR(5),
	@LoaiPDK NVARCHAR(4)
AS
BEGIN
    INSERT INTO PhieuDangKy(MaPDK, NgayLap, TrangThai, LoaiCC, LoaiPDK, MaLT)
    VALUES (@MaPDK, @NgayDangKy, N'Chưa thanh toán', @LoaiDGNL, @LoaiPDK, @MaLichThi)
END;
GO

--Lấy mã phiếu đăng ký tiếp theo để hiển thị 
CREATE OR ALTER PROCEDURE sp_GetNextMaPhieuDK
AS
BEGIN
    DECLARE @NextNumber INT;

    -- Lấy phần số lớn nhất trong MaPDK (ví dụ: PDK01 → 1)
    SELECT @NextNumber = MAX(CAST(SUBSTRING(MaPDK, 4, LEN(MaPDK) - 3) AS INT))
    FROM PhieuDangKy;

    -- Nếu chưa có phiếu nào thì bắt đầu từ 1
    SET @NextNumber = ISNULL(@NextNumber, 0) + 1;

    -- Trả kết quả dạng: PDK01, PDK02,...
    SELECT 'PDK' + RIGHT('00' + CAST(@NextNumber AS VARCHAR(3)), 2) AS NextMaPDK;
END;
GO



-- PROCEDURE USE-CASE PHÁT HÀNH PHIẾU DỰ THI
	-- Xem tất cả phiếu đăng ký
CREATE  OR ALTER PROCEDURE XemTatCaPhieuDangKy 
AS
BEGIN
	SELECT pdk.MaPDK, dsts.HoTen, dsts.Email, pdk.LoaiPDK, ldgnl.NgayThi, ldgnl.PhongThi, pdk.TrangThai, pdk.TrangThai
	FROM PhieuDangKy pdk JOIN DSThiSinh dsts ON pdk.MaDS = dsts.MaDS
	JOIN LichDGNL ldgnl ON pdk.MaLT = ldgnl.MaLT
END;

-- Lọc phiếu đăng ký
GO
CREATE OR ALTER PROCEDURE LocPhieuDangKy
	@MaPDK CHAR(5) = NULL,
	@LoaiKyThi NVARCHAR(20) = NULL,
	@TrangThai NVARCHAR(20) = NULL
AS
BEGIN
	SELECT 
		pdk.MaPDK, 
		dsts.HoTen, 
		dsts.Email, 
		pdk.LoaiPDK, 
		ldgnl.NgayThi, 
		ldgnl.PhongThi, 
		pdk.TrangThai, 
		pdk.TrangThai
	FROM 
		PhieuDangKy pdk 
		JOIN DSThiSinh dsts ON pdk.MaDS = dsts.MaDS
		JOIN LichDGNL ldgnl ON pdk.MaLT = ldgnl.MaLT
	WHERE 
		(@MaPDK IS NULL OR pdk.MaPDK = @MaPDK)
		AND (@LoaiKyThi IS NULL OR ldgnl.LoaiDGNL = @LoaiKyThi)
		AND (@TrangThai IS NULL OR pdk.TrangThai = @TrangThai)
END;
GO

-- Xem Chi tiết Phiếu Đăng ký
CREATE OR ALTER PROCEDURE XemPhieuDangKy
	@MaPDK CHAR(5)
AS
BEGIN
	SELECT 
		ldgnl.Ngaythi,
		CONCAT(N'Tòa ', pt.Toa, N', Tầng ', pt.Tang, N', Phòng ', ldgnl.PhongThi) AS DiaDiem,
		ldgnl.Loaidgnl,
		CASE 
			WHEN pdk.TenDonVi IS NULL THEN dsts.HoTen
			ELSE pdk.TenDonVi
		END AS TenHienThi
	FROM 
		PhieuDangKy pdk
		JOIN DSThiSinh dsts ON dsts.MaDS = pdk.MaDS
		JOIN LichDGNL ldgnl ON pdk.MaLT = ldgnl.MaLT
		JOIN DSPhongThi pt ON pt.MaPT = ldgnl.PhongThi 
     
	WHERE 
		pdk.MaPDK = @MaPDK
END;
GO

-- Xem Phiếu dự thi
CREATE OR ALTER PROCEDURE XemPhieuDuThi
	@MaPDK CHAR(5)
AS
BEGIN
	SELECT 
		pdt.MaPDT, 
		pdt.ThoiGian, 
		CONCAT(N'Tòa ', pt.Toa, N', Tầng ', pt.Tang, N', Phòng ', ldgnl.PhongThi) AS DiaDiem,
		pdt.SBD, 
		ldgnl.Loaidgnl, 
		CASE 
			WHEN pdk.TenDonVi IS NULL THEN dsts.HoTen
			ELSE pdk.TenDonVi
		END AS TenHienThi
	FROM 
		PhieuDuThi pdt
		JOIN PhieuDangKy pdk ON pdt.MaPDK = pdk.MaPDK
		JOIN DSThiSinh dsts ON pdk.MaDS = dsts.MaDS
		JOIN LichDGNL ldgnl ON ldgnl.MaLT = pdk.MaLT
		JOIN DSPhongThi pt ON pt.MaPT = ldgnl.PhongThi
	WHERE 
		pdk.MaPDK = @MaPDK
END;
GO
-- Xuất Phiếu dự thi
CREATE OR ALTER PROCEDURE XuatPhieuDuThi
	@MaPDK CHAR(5)
AS
BEGIN

	DECLARE @MaPDT CHAR(5);
	DECLARE @SBD CHAR(5);
	DECLARE @NewID INT;

	-- Tạo MaPDT tự động (PDT01, PDT02, ...)
	SELECT @NewID = ISNULL(MAX(CAST(SUBSTRING(MaPDT, 4, 2) AS INT)), 0) + 1
	FROM PhieuDuThi;
	SET @MaPDT = 'PDT' + RIGHT('0' + CAST(@NewID AS VARCHAR(2)), 2);

	-- Tạo SBD tự động (SBD01, SBD02, ...)
	SELECT @NewID = ISNULL(MAX(CAST(SUBSTRING(SBD, 4, 2) AS INT)), 0) + 1
	FROM PhieuDuThi;
	SET @SBD = 'SBD' + RIGHT('0' + CAST(@NewID AS VARCHAR(2)), 2);

	-- Thêm hàng vào PhieuDuThi
	INSERT INTO PhieuDuThi (MaPDT, ThoiGian, DiaDiem, SBD, MaPDK)
	SELECT 
		@MaPDT,
		ldgnl.NgayThi,
		ldgnl.PhongThi,
		@SBD,
		pdk.MaPDK
	FROM 
		PhieuDangKy pdk
		JOIN LichDGNL ldgnl ON pdk.MaLT = ldgnl.MaLT
		JOIN DSPhongThi pt ON ldgnl.PhongThi = pt.MaPT
	WHERE 
		pdk.MaPDK = @MaPDK;

	-- Cập nhật TrangThaiXuatPDT trong PhieuDangKy (nếu có)
	UPDATE PhieuDangKy
	SET TrangThai = N'Đã xuất PDT'
	WHERE MaPDK = @MaPDK;
END;
GO

-- Lấy danh sách phiếu đăng ký theo điều kiện
CREATE PROCEDURE sp_TraCuuPDK
    @MaPDK CHAR(5) = NULL,
    @NgayLapFrom DATETIME = NULL,
    @NgayLapTo DATETIME = NULL,
    @TrangThai NVARCHAR(20) = NULL,
    @MaDS CHAR(5) = NULL,
    @MaLT CHAR(5) = NULL,
    @TenDonVi NVARCHAR(100) = NULL,
    @LoaiPDK NVARCHAR(4) = NULL,
    @LoaiCC NVARCHAR(20) = NULL
AS
BEGIN
    SELECT *
    FROM PhieuDangKy
    WHERE (@MaPDK IS NULL OR MaPDK = @MaPDK)
      AND (@NgayLapFrom IS NULL OR NgayLap >= @NgayLapFrom)
      AND (@NgayLapTo IS NULL OR NgayLap <= @NgayLapTo)
      AND (@TrangThai IS NULL OR TrangThai = @TrangThai)
      AND (@MaDS IS NULL OR MaDS = @MaDS)
      AND (@MaLT IS NULL OR MaLT = @MaLT)
      AND (@TenDonVi IS NULL OR TenDonVi LIKE '%' + @TenDonVi + '%')
      AND (@LoaiPDK IS NULL OR LoaiPDK = @LoaiPDK)
      AND (@LoaiCC IS NULL OR LoaiCC = @LoaiCC)
END;
GO

-- Lấy danh sách người đăng ký theo điều kiện
CREATE PROCEDURE sp_TraCuuTTNguoiDangKy
    @MaNDK CHAR(5) = NULL,
    @CCCD CHAR(12) = NULL,
    @HoTen NVARCHAR(100) = NULL,
    @GioiTinh NVARCHAR(3) = NULL,
    @NgaySinhFrom DATE = NULL,
    @NgaySinhTo DATE = NULL,
    @SoDienThoai CHAR(10) = NULL,
    @Email VARCHAR(100) = NULL,
    @DiaChi NVARCHAR(100) = NULL,
    @MaPDK CHAR(5) = NULL
AS
BEGIN
    SELECT *
    FROM TTNguoiDangKy
    WHERE (@MaNDK IS NULL OR MaNDK = @MaNDK)
      AND (@CCCD IS NULL OR CCCD = @CCCD)
      AND (@HoTen IS NULL OR HoTen LIKE N'%' + @HoTen + N'%')
      AND (@GioiTinh IS NULL OR GioiTinh = @GioiTinh)
      AND (@NgaySinhFrom IS NULL OR NgaySinh >= @NgaySinhFrom)
      AND (@NgaySinhTo IS NULL OR NgaySinh <= @NgaySinhTo)
      AND (@SoDienThoai IS NULL OR SoDienThoai = @SoDienThoai)
      AND (@Email IS NULL OR Email LIKE '%' + @Email + '%')
      AND (@DiaChi IS NULL OR DiaChi LIKE N'%' + @DiaChi + N'%')
      AND (@MaPDK IS NULL OR MaPDK = @MaPDK)
END;
GO

-- Tra cứu hóa đơn thanh toán
CREATE PROCEDURE sp_TraCuuHoaDon
    @MaHD CHAR(5) = NULL,
    @TongTienFrom DECIMAL(10,0) = NULL,
    @TongTienTo DECIMAL(10,0) = NULL,
    @TroGiaFrom DECIMAL(10,0) = NULL,
    @TroGiaTo DECIMAL(10,0) = NULL,
    @ThanhTienFrom DECIMAL(10,0) = NULL,
    @ThanhTienTo DECIMAL(10,0) = NULL,
    @MaPDK CHAR(5) = NULL,
    @MaNV CHAR(5) = NULL
AS
BEGIN
    SELECT *
    FROM HoaDonThanhToan
    WHERE (@MaHD IS NULL OR MaHD = @MaHD)
      AND (@TongTienFrom IS NULL OR TongTien >= @TongTienFrom)
      AND (@TongTienTo IS NULL OR TongTien <= @TongTienTo)
      AND (@TroGiaFrom IS NULL OR TroGia >= @TroGiaFrom)
      AND (@TroGiaTo IS NULL OR TroGia <= @TroGiaTo)
      AND (@ThanhTienFrom IS NULL OR ThanhTien >= @ThanhTienFrom)
      AND (@ThanhTienTo IS NULL OR ThanhTien <= @ThanhTienTo)
      AND (@MaPDK IS NULL OR MaPDK = @MaPDK)
      AND (@MaNV IS NULL OR MaNV = @MaNV)
END;
GO

-- Cập nhật hóa đơn
CREATE PROCEDURE sp_CapNhatHoaDon
    @MaHD CHAR(5),
    @TongTien DECIMAL(10,0) = NULL,
    @TroGia DECIMAL(10,0) = NULL,
    @ThanhTien DECIMAL(10,0) = NULL,
    @MaPDK CHAR(5) = NULL,
    @MaNV CHAR(5) = NULL
AS
BEGIN
    UPDATE HoaDonThanhToan
    SET TongTien   = ISNULL(@TongTien, TongTien),
        TroGia     = ISNULL(@TroGia, TroGia),
        ThanhTien  = ISNULL(@ThanhTien, ThanhTien),
        MaPDK      = ISNULL(@MaPDK, MaPDK),
        MaNV       = ISNULL(@MaNV, MaNV)
    WHERE MaHD = @MaHD
END;
GO

-- Cập nhật phiếu đăng ký
CREATE PROCEDURE sp_CapNhatPDK
    @MaPDK CHAR(5),
    @NgayLap DATETIME = NULL,
    @TrangThai NVARCHAR(20) = NULL,
    @MaDS CHAR(5) = NULL,
    @MaLT CHAR(5) = NULL,
    @TenDonVi NVARCHAR(100) = NULL,
    @LoaiPDK NVARCHAR(4) = NULL,
    @LoaiCC NVARCHAR(20) = NULL
AS
BEGIN
    UPDATE PhieuDangKy
    SET NgayLap   = ISNULL(@NgayLap, NgayLap),
        TrangThai = ISNULL(@TrangThai, TrangThai),
        MaDS      = ISNULL(@MaDS, MaDS),
        MaLT      = ISNULL(@MaLT, MaLT),
        TenDonVi  = ISNULL(@TenDonVi, TenDonVi),
        LoaiPDK   = ISNULL(@LoaiPDK, LoaiPDK),
        LoaiCC    = ISNULL(@LoaiCC, LoaiCC)
    WHERE MaPDK = @MaPDK
END;
GO




























-- Tra cứu phòng thi
CREATE PROCEDURE sp_TraCuuDSPhongThi
    @MaPT CHAR(4) = NULL,
    @Tang INT = NULL,
    @Toa INT = NULL
AS
BEGIN
    SELECT *
    FROM DSPhongThi
    WHERE (@MaPT IS NULL OR MaPT = @MaPT)
      AND (@Tang IS NULL OR Tang = @Tang)
      AND (@Toa IS NULL OR Toa = @Toa)
END;
GO

-- Tra cứu lịch 
CREATE PROCEDURE sp_TraCuuLichDGNL
    @MaLT CHAR(5) = NULL,
    @NgayThiFrom DATETIME = NULL,
    @NgayThiTo DATETIME = NULL,
    @CaThi CHAR(1) = NULL,
    @PhongThi CHAR(4) = NULL,
    @LoaiDGNL NVARCHAR(20) = NULL
AS
BEGIN
    SELECT *
    FROM LichDGNL
    WHERE (@MaLT IS NULL OR MaLT = @MaLT)
      AND (@NgayThiFrom IS NULL OR NgayThi >= @NgayThiFrom)
      AND (@NgayThiTo IS NULL OR NgayThi <= @NgayThiTo)
      AND (@CaThi IS NULL OR CaThi = @CaThi)
      AND (@PhongThi IS NULL OR PhongThi = @PhongThi)
      AND (@LoaiDGNL IS NULL OR LoaiDGNL = @LoaiDGNL)
END;
GO

-- Tra cứu nhân viên gác thi
CREATE PROCEDURE sp_TraCuuLichThiNhanVien
    @MaLT CHAR(5) = NULL,
    @MaNV CHAR(5) = NULL
AS
BEGIN
    SELECT *
    FROM LichThi_NhanVien
    WHERE (@MaLT IS NULL OR MaLT = @MaLT)
      AND (@MaNV IS NULL OR MaNV = @MaNV)
END;
GO

-- Tra cứu phiếu dự thi
CREATE PROCEDURE sp_TraCuuPhieuDuThi
    @MaPDT CHAR(5) = NULL,
    @ThoiGianFrom DATETIME = NULL,
    @ThoiGianTo DATETIME = NULL,
    @DiaDiem NVARCHAR(100) = NULL,
    @SBD CHAR(5) = NULL,
    @MaPDK CHAR(5) = NULL
AS
BEGIN
    SELECT *
    FROM PhieuDuThi
    WHERE (@MaPDT IS NULL OR MaPDT = @MaPDT)
      AND (@ThoiGianFrom IS NULL OR ThoiGian >= @ThoiGianFrom)
      AND (@ThoiGianTo IS NULL OR ThoiGian <= @ThoiGianTo)
      AND (@DiaDiem IS NULL OR DiaDiem LIKE N'%' + @DiaDiem + N'%')
      AND (@SBD IS NULL OR SBD = @SBD)
      AND (@MaPDK IS NULL OR MaPDK = @MaPDK)
END;
GO

-- Tra cứu phiếu gia hạn
CREATE PROCEDURE sp_TraCuuPhieuGiaHan
    @MaPGH CHAR(5) = NULL,
    @ThoiGianFrom DATETIME = NULL,
    @ThoiGianTo DATETIME = NULL,
    @DiaDiem NVARCHAR(100) = NULL,
    @SBD CHAR(5) = NULL,
    @PhiGiaHanFrom DECIMAL(10,0) = NULL,
    @PhiGiaHanTo DECIMAL(10,0) = NULL,
    @TrangThai NVARCHAR(20) = NULL,
    @MaPDK CHAR(5) = NULL,
    @LoaiGH NVARCHAR(20) = NULL
AS
BEGIN
    SELECT *
    FROM PhieuGiaHan
    WHERE (@MaPGH IS NULL OR MaPGH = @MaPGH)
      AND (@ThoiGianFrom IS NULL OR ThoiGian >= @ThoiGianFrom)
      AND (@ThoiGianTo IS NULL OR ThoiGian <= @ThoiGianTo)
      AND (@DiaDiem IS NULL OR DiaDiem LIKE N'%' + @DiaDiem + N'%')
      AND (@SBD IS NULL OR SBD = @SBD)
      AND (@PhiGiaHanFrom IS NULL OR PhiGiaHan >= @PhiGiaHanFrom)
      AND (@PhiGiaHanTo IS NULL OR PhiGiaHan <= @PhiGiaHanTo)
      AND (@TrangThai IS NULL OR TrangThai = @TrangThai)
      AND (@MaPDK IS NULL OR MaPDK = @MaPDK)
      AND (@LoaiGH IS NULL OR LoaiGH = @LoaiGH)
END;
GO

-- Tra cứu bảng tính
CREATE PROCEDURE sp_TraCuuBangTinh
    @MaBT CHAR(5) = NULL,
    @KetQua NVARCHAR(100) = NULL,
    @ThoiGianNhanCCFrom DATETIME = NULL,
    @ThoiGianNhanCCTo DATETIME = NULL,
    @ThoiGianGiaoCCFrom DATETIME = NULL,
    @ThoiGianGiaoCCTo DATETIME = NULL,
    @TrangThai NVARCHAR(20) = NULL,
    @MaPDT CHAR(5) = NULL,
    @NVGiaoCC CHAR(5) = NULL
AS
BEGIN
    SELECT *
    FROM BangTinh
    WHERE (@MaBT IS NULL OR MaBT = @MaBT)
      AND (@KetQua IS NULL OR KetQua LIKE N'%' + @KetQua + N'%')
      AND (@ThoiGianNhanCCFrom IS NULL OR ThoiGianNhanCC >= @ThoiGianNhanCCFrom)
      AND (@ThoiGianNhanCCTo IS NULL OR ThoiGianNhanCC <= @ThoiGianNhanCCTo)
      AND (@ThoiGianGiaoCCFrom IS NULL OR ThoiGianGiaoCC >= @ThoiGianGiaoCCFrom)
      AND (@ThoiGianGiaoCCTo IS NULL OR ThoiGianGiaoCC <= @ThoiGianGiaoCCTo)
      AND (@TrangThai IS NULL OR TrangThai = @TrangThai)
      AND (@MaPDT IS NULL OR MaPDT = @MaPDT)
      AND (@NVGiaoCC IS NULL OR NVGiaoCC = @NVGiaoCC)
END;
GO

-- Tra cứu quy định
CREATE PROCEDURE sp_TraCuuQuyDinh
    @MaQD CHAR(5) = NULL,
    @DoiTuong VARCHAR(20) = NULL,
    @NoiDung NVARCHAR(MAX) = NULL,
    @GiaTriFrom DECIMAL(10,2) = NULL,
    @GiaTriTo DECIMAL(10,2) = NULL
AS
BEGIN
    SELECT *
    FROM QuyDinh
    WHERE (@MaQD IS NULL OR MaQD = @MaQD)
      AND (@DoiTuong IS NULL OR DoiTuong = @DoiTuong)
      AND (@NoiDung IS NULL OR NoiDung LIKE N'%' + @NoiDung + N'%')
      AND (@GiaTriFrom IS NULL OR GiaTri >= @GiaTriFrom)
      AND (@GiaTriTo IS NULL OR GiaTri <= @GiaTriTo)
END;
GO

-- Tra cứu nhân viên
CREATE PROCEDURE sp_TraCuuNhanVien
    @MaNV CHAR(5) = NULL,
    @HoTen NVARCHAR(100) = NULL,
    @DiaChi NVARCHAR(100) = NULL,
    @SoDienThoai CHAR(10) = NULL,
    @NgaySinhFrom DATE = NULL,
    @NgaySinhTo DATE = NULL,
    @Email NVARCHAR(100) = NULL,
    @LoaiNV CHAR(2) = NULL
AS
BEGIN
    SELECT *
    FROM NhanVien
    WHERE (@MaNV IS NULL OR MaNV = @MaNV)
      AND (@HoTen IS NULL OR HoTen LIKE N'%' + @HoTen + N'%')
      AND (@DiaChi IS NULL OR DiaChi LIKE N'%' + @DiaChi + N'%')
      AND (@SoDienThoai IS NULL OR SoDienThoai = @SoDienThoai)
      AND (@NgaySinhFrom IS NULL OR NgaySinh >= @NgaySinhFrom)
      AND (@NgaySinhTo IS NULL OR NgaySinh <= @NgaySinhTo)
      AND (@Email IS NULL OR Email LIKE N'%' + @Email + '%')
      AND (@LoaiNV IS NULL OR LoaiNV = @LoaiNV)
END;
GO

-- Tra cứu thí sinh
CREATE PROCEDURE sp_TraCuuDSThiSinh
    @MaDS CHAR(5) = NULL,
    @MaTS CHAR(5) = NULL,
    @HoTen NVARCHAR(100) = NULL,
    @GioiTinh NVARCHAR(3) = NULL,
    @NgaySinhFrom DATE = NULL,
    @NgaySinhTo DATE = NULL,
    @SoDienThoai CHAR(10) = NULL,
    @Email NVARCHAR(100) = NULL,
    @TGDuThiMongMuon TEXT = NULL
AS
BEGIN
    SELECT *
    FROM DSThiSinh
    WHERE (@MaDS IS NULL OR MaDS = @MaDS)
      AND (@MaTS IS NULL OR MaTS = @MaTS)
      AND (@HoTen IS NULL OR HoTen LIKE N'%' + @HoTen + N'%')
      AND (@GioiTinh IS NULL OR GioiTinh = @GioiTinh)
      AND (@NgaySinhFrom IS NULL OR NgaySinh >= @NgaySinhFrom)
      AND (@NgaySinhTo IS NULL OR NgaySinh <= @NgaySinhTo)
      AND (@SoDienThoai IS NULL OR SoDienThoai = @SoDienThoai)
      AND (@Email IS NULL OR Email LIKE N'%' + @Email + '%')
      AND (@TGDuThiMongMuon IS NULL OR TGDuThiMongMuon LIKE N'%' + @TGDuThiMongMuon + N'%')
END;
GO

