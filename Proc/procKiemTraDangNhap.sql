USE [QuanLyThuVien]
GO

/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_KiemTraDangNhap]    Script Date: 6/15/2020 5:35:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE  PROC [dbo].[PSP_NhanVien_KiemTraDangNhap]
@TenDangNhap VARCHAR(30),
@MatKhau VARCHAR(30)
AS	
IF EXISTS (SELECT 1 FROM dbo.NhanVien WHERE [TenDangNhap]=@TenDangNhap AND @MatKhau=MatKhau)
BEGIN
    SELECT 1 AS code,HoTenNV,MaTaiKhoan FROM dbo.NhanVien WHERE TenDangNhap=@TenDangNhap AND @MatKhau=MatKhau
END
ELSE
BEGIN
    SELECT 0 AS code,'' AS TenNhanVien,0 AS MaTaiKhoan
END
GO


