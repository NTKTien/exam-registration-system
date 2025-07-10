USE QLToChucThiCC;

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
        P.TrangThaiThanhToan
    FROM PhieuDangKy P
    JOIN DSThiSinh D ON P.MaDS = D.MaDS
    JOIN LichDGNL L ON P.MaLT = L.MaLT
END

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
        P.TrangThaiThanhToan,
        ld.CaThi
    FROM PhieuDangKy P
    JOIN LichDGNL ld ON P.MaLT = ld.MaLT
    WHERE P.MaPDK = @RegistrationId
END


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
END

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
END

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
END

-- Thêm phiếu đăng ký
CREATE OR ALTER PROCEDURE sp_InsertFreeReg
    @MaPDK CHAR(5),
    @NgayDangKy DATE,
    @LoaiDGNL NVARCHAR(50),
    @MaLichThi CHAR(5),
	@LoaiPDK NVARCHAR(4)
AS
BEGIN
    INSERT INTO PhieuDangKy(MaPDK, NgayLap, TrangThaiThanhToan, LoaiCC, LoaiPDK, MaLT)
    VALUES (@MaPDK, @NgayDangKy, N'Chưa thanh toán', @LoaiDGNL, @LoaiPDK, @MaLichThi)
END

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
END



-- PROCEDURE USE-CASE PHÁT HÀNH PHIẾU DỰ THI
	-- Xem tất cả phiếu đăng ký
	GO
	CREATE  OR ALTER PROCEDURE XemTatCaPhieuDangKy 
	AS
	BEGIN
		SELECT pdk.MaPDK, dsts.HoTen, dsts.Email, pdk.LoaiPDK, ldgnl.NgayThi, ldgnl.PhongThi, pdk.TrangThaiThanhToan, pdk.TrangThai
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
			pdk.TrangThaiThanhToan, 
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


	-- Xem Chi tiết Phiếu Đăng ký
	GO
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

	-- Xem Phiếu dự thi
	GO
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

	-- Xuất Phiếu dự thi
	GO
	GO
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