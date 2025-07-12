USE QLToChucThiCC;
GO

--------------------------------PROC CHO LẬP PHIẾU ĐĂNG KÝ TỰ DO------------------------------
-- Lấy toàn bộ danh sách phiếu đăng ký 
CREATE OR ALTER PROCEDURE P_GetAllReg
AS
BEGIN
    SELECT 
        P.MaPDK,
        CONVERT(varchar, P.NgayLap, 103) + ' ' + CONVERT(varchar, P.NgayLap, 108) AS NgayLap,
        P.LoaiCC,
        CONVERT(varchar, L.NgayThi, 103) AS NgayThi,
        T.HoTen,
        P.LoaiPDK,
        P.TrangThai
    FROM PhieuDangKy P
    JOIN TTNguoiDangKy T ON P.MaPDK = T.MaPDK
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
        CONVERT(varchar, P.NgayLap, 103) + ' ' + CONVERT(varchar, P.NgayLap, 108) AS NgayLap,
        CONVERT(varchar, ld.NgayThi, 103) + ' ' + CONVERT(varchar, ld.NgayThi, 108) AS NgayThi,
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
        CONVERT(varchar, ndk.Ngaysinh, 103) AS NgaySinh,
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
    @LoaiDGNL NVARCHAR(20) = NULL
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
    WHERE SLTSHienTai < SLTSToiDa
      AND (@LoaiDGNL IS NULL OR LoaiDGNL = @LoaiDGNL)
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

--Thêm một thí sinh
CREATE OR ALTER PROCEDURE sp_InsertCandidate
    @HoTen NVARCHAR(100),
    @GioiTinh NVARCHAR(3),
    @Ngaysinh DATE,
    @SoDienThoai CHAR(10),
    @CCCD CHAR(12),
    @Email NVARCHAR(100),
    @OutMaDS CHAR(5) OUTPUT                
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NewMaDS CHAR(5), @NewMaTS CHAR(5);

    -- Sinh MaDS mới
    SELECT @NewMaDS = 
        'DS' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaDS, 3, 3) AS INT)), 0) + 1 AS VARCHAR), 3)
    FROM ThiSinh;

    -- Sinh MaTS mới
    SELECT @NewMaTS = 
        'TS' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaTS, 3, 3) AS INT)), 0) + 1 AS VARCHAR), 3)
    FROM ThiSinh;

    -- Thêm bản ghi mới
    INSERT INTO ThiSinh (
        MaDS, MaTS, HoTen, GioiTinh, Ngaysinh, SoDienThoai, CCCD, Email
    )
    VALUES (
        @NewMaDS, @NewMaTS, @HoTen, @GioiTinh, @Ngaysinh, @SoDienThoai, @CCCD, @Email
    );

    -- Gán mã DS ra tham số output
    SET @OutMaDS = @NewMaDS;
END;
GO

--Lấy thông tin thí sinh theo mã phiếu đăng kí 
CREATE OR ALTER PROCEDURE sp_GetCandidateByMaPDK
    @MaPDK CHAR(5)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        TS.HoTen,
        TS.GioiTinh,
		CONVERT(varchar, TS.Ngaysinh, 103) AS NgaySinh,
        TS.SoDienThoai,
        TS.CCCD,
        TS.Email
    FROM PhieuDangKy PDK
    JOIN ThiSinh TS ON PDK.MaDS = TS.MaDS
    WHERE PDK.MaPDK = @MaPDK;
END;
GO

-- Thêm phiếu đăng ký và cập nhật SLTSHienTai của lịch thi
CREATE OR ALTER PROCEDURE sp_InsertFreeReg
    @MaPDK CHAR(5),
	@MaDS CHAR(5),
    @NgayDangKy DATETIME,
    @LoaiDGNL NVARCHAR(50),
    @MaLichThi CHAR(5),
    @LoaiPDK NVARCHAR(4)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Thêm phiếu đăng ký
        INSERT INTO PhieuDangKy(MaPDK, MaDS, NgayLap, TrangThai, LoaiCC, LoaiPDK, MaLT)
        VALUES (@MaPDK, @MaDS, @NgayDangKy, N'Chưa thanh toán', @LoaiDGNL, @LoaiPDK, @MaLichThi);

        -- Cập nhật số lượng thí sinh hiện tại trong LichDGNL
        UPDATE LichDGNL
        SET SLTSHienTai = SLTSHienTai + 1
        WHERE MaLT = @MaLichThi;

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        -- Gợi ý: Thêm xử lý lỗi tại đây nếu cần (ví dụ: RAISERROR)
        THROW;
    END CATCH
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

--Thêm một hóa đơn 
CREATE OR ALTER PROCEDURE sp_InsertInvoice
    @MaPDK CHAR(5),
    @MaNV CHAR(5)
AS
BEGIN
    DECLARE @NewMaHD CHAR(5);
    DECLARE @MaxMaHD INT;

    -- Sinh mã HD mới dạng HD01, HD02,...
    SELECT @MaxMaHD = MAX(CAST(SUBSTRING(MaHD, 3, LEN(MaHD) - 2) AS INT))
    FROM HoaDonThanhToan;

    IF @MaxMaHD IS NULL
        SET @MaxMaHD = 0;

    SET @NewMaHD = 'HD' + RIGHT('00' + CAST(@MaxMaHD + 1 AS VARCHAR), 2);

    -- Thêm hóa đơn với 3 cột tiền là NULL
    INSERT INTO HoaDonThanhToan (MaHD, TongTien, TroGia, ThanhTien, MaPDK, MaNV)
    VALUES (@NewMaHD, NULL, NULL, NULL, @MaPDK, @MaNV);
END;
GO

----------------------------------------- PROC THANH TOÁN TỰ DO-------------------------------------
-- Lấy danh sách phiếu đăng ký theo điều kiện
CREATE PROCEDURE sp_SearchRegistration
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
CREATE PROCEDURE sp_SearchRegistor
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
CREATE PROCEDURE sp_SearchInvoice
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
CREATE PROCEDURE sp_UpdateInvoice
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
CREATE PROCEDURE sp_UpdateRegistration
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

-- Tra cứu quy định
CREATE PROCEDURE sp_SearchRegulation
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
----------------------------------------- PROC ĐĂNG NHẬP -------------------------------------
-- Tra cứu nhân viên
CREATE PROCEDURE sp_SearchEmp
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

----------------------------------------- PROC PHÁT HÀNH PHIẾU DỰ THI-------------------------------------
	-- Xem tất cả phiếu đăng ký
CREATE  OR ALTER PROCEDURE XemTatCaPhieuDangKy 
AS
BEGIN
	SELECT pdk.MaPDK, dsts.MaTS, dsts.Email, pdk.LoaiPDK, ldgnl.NgayThi, ldgnl.PhongThi, pdk.TrangThai,
	CASE 
			WHEN pdk.TenDonVi IS NULL THEN dsts.HoTen
			ELSE pdk.TenDonVi
		END AS TenHienThi
	FROM PhieuDangKy pdk JOIN ThiSinh dsts ON pdk.MaDS = dsts.MaDS
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
		dsts.Email, 
		dsts.MaTS,
		pdk.LoaiPDK, 
		ldgnl.NgayThi, 
		ldgnl.PhongThi, 
		pdk.TrangThai,
		CASE 
			WHEN pdk.TenDonVi IS NULL THEN dsts.HoTen
			ELSE pdk.TenDonVi
		END AS TenHienThi
	FROM 
		PhieuDangKy pdk 
		JOIN ThiSinh dsts ON pdk.MaDS = dsts.MaDS
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
		JOIN ThiSinh dsts ON dsts.MaDS = pdk.MaDS
		JOIN LichDGNL ldgnl ON pdk.MaLT = ldgnl.MaLT
		JOIN PhongThi pt ON pt.MaPT = ldgnl.PhongThi 
     
	WHERE 
		pdk.MaPDK = @MaPDK
END;
GO

-- Xem Phiếu dự thi
CREATE OR ALTER PROCEDURE XemPhieuDuThi
	@MaPDK CHAR(5),
	@MaTS CHAR(5)
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
		JOIN LichDGNL ldgnl ON ldgnl.MaLT = pdk.MaLT
		JOIN PhongThi pt ON pt.MaPT = ldgnl.PhongThi
		Join ThiSinh dsts ON dsts.MaDS = pdk.MaDS AND dsts.MaTS= pdt.MaTS
	WHERE 
		pdk.MaPDK = @MaPDK and pdt.MaTS = @MaTS
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
	DECLARE @MaDS CHAR(5);
    
	SELECT @MaDS = MaDS FROM PhieuDangKy WHERE MaPDK = @MaPDK;
    -- Tạo phiếu dự thi cho từng thí sinh trong danh sách
    DECLARE ts_cursor CURSOR FOR
    SELECT MaTS 
    FROM ThiSinh 
    WHERE MaDS =@MaDS;

    DECLARE @MaTS CHAR(5);
    
    OPEN ts_cursor;
    FETCH NEXT FROM ts_cursor INTO @MaTS;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Tạo MaPDT tự động
        SELECT @NewID = ISNULL(MAX(CAST(SUBSTRING(MaPDT, 4, 2) AS INT)), 0) + 1
        FROM PhieuDuThi;
        SET @MaPDT = 'PDT' + RIGHT('0' + CAST(@NewID AS VARCHAR(2)), 2);

        -- Tạo SBD tự động (đảm bảo mỗi MaTS có SBD khác nhau)
        SELECT @NewID = ISNULL(MAX(CAST(SUBSTRING(SBD, 4, 2) AS INT)), 0) + 1
        FROM PhieuDuThi;
        SET @SBD = 'SBD' + RIGHT('0' + CAST(@NewID AS VARCHAR(2)), 2);

        -- Thêm hàng vào PhieuDuThi
        INSERT INTO PhieuDuThi (MaPDT, ThoiGian, DiaDiem, SBD, MaPDK, MaTS)
        SELECT 
            @MaPDT,
            ldgnl.NgayThi,
            ldgnl.PhongThi,
            @SBD,
            pdk.MaPDK, 
			@MaTS
        FROM 
            PhieuDangKy pdk
            JOIN LichDGNL ldgnl ON pdk.MaLT = ldgnl.MaLT
            JOIN PhongThi pt ON ldgnl.PhongThi = pt.MaPT
        WHERE 
            pdk.MaPDK = @MaPDK;

        FETCH NEXT FROM ts_cursor INTO @MaTS;
    END;

    CLOSE ts_cursor;
    DEALLOCATE ts_cursor;

    -- Cập nhật TrangThai trong PhieuDangKy
    UPDATE PhieuDangKy
    SET TrangThai = N'Đã xuất PDT'
    WHERE MaPDK = @MaPDK;
END;
GO
---------------------------------------- PROC GIA HẠN ---------------------------------------------------------
-- Xoá nếu đã tồn tại
DROP PROCEDURE IF EXISTS sp_GetPendingExtends;
GO
-- Tạo procedure lay danh sach phieu gia han co trang thai "dang doi"
CREATE PROCEDURE sp_GetPendingExtends
AS
BEGIN
    SELECT 
        MaPGH,
        ThoiGian,
        DiaDiem,
        SBD,
        PhiGiaHan,
        MaPDK,
        LoaiGH
    FROM 
        PhieuGiaHan
    WHERE 
        TrangThai = N'Đang đợi';
END;
GO
-- lay chi tiet phieu gia han
DROP PROCEDURE IF EXISTS sp_GetExtensionDetails;
GO
CREATE PROCEDURE sp_GetExtensionDetails
    @MaPGH CHAR(5)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        PDT.MaPDT AS MaPhieuDuThi,
        PGH.LoaiGH,
        PGH.ThoiGian
    FROM PhieuGiaHan PGH
    INNER JOIN PhieuDangKy PDK ON PGH.MaPDK = PDK.MaPDK
    INNER JOIN PhieuDuThi PDT ON PDK.MaPDK = PDT.MaPDK
    WHERE PGH.MaPGH = @MaPGH;
END;
GO
-- cap nhat phieu gia han
DROP PROCEDURE IF EXISTS sp_SaveExtension;
GO
 create PROCEDURE sp_SaveExtension
    @MaPGH CHAR(5),
    @PhiGiaHan DECIMAL(10,0)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem MaPGH đã tồn tại chưa
    IF EXISTS (SELECT 1 FROM PhieuGiaHan WHERE MaPGH = @MaPGH)
    BEGIN
        -- Cập nhật thông tin nếu MaPGH đã tồn tại
        UPDATE PhieuGiaHan
        SET 
            PhiGiaHan = @PhiGiaHan,
            TrangThai = N'Thành công'
        WHERE MaPGH = @MaPGH;
    END
    ELSE
    BEGIN
        -- Báo lỗi nếu MaPGH không tồn tại
        RAISERROR ('Mã phiếu gia hạn không tồn tại.', 16, 1);
        RETURN;
    END
END;
GO
