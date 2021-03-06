USE [NHUNG_THOM]
GO
ALTER TABLE [dbo].[DIEM] DROP CONSTRAINT [CK__DIEM__LAN__3B75D760]
GO
ALTER TABLE [dbo].[DIEM] DROP CONSTRAINT [CK__DIEM__DIEM__3C69FB99]
GO
ALTER TABLE [dbo].[SINHVIEN] DROP CONSTRAINT [FK_SINHVIEN_LOP]
GO
ALTER TABLE [dbo].[MONHOC_LOP] DROP CONSTRAINT [FK_MONHOC_LOP_MONHOC]
GO
ALTER TABLE [dbo].[MONHOC_LOP] DROP CONSTRAINT [FK_MONHOC_LOP_LOP]
GO
ALTER TABLE [dbo].[GIANGVIEN_LOP] DROP CONSTRAINT [FK_GIANGVIEN_LOP_LOP]
GO
ALTER TABLE [dbo].[GIANGVIEN_LOP] DROP CONSTRAINT [FK_GIANGVIEN_LOP_GIANGVIEN]
GO
ALTER TABLE [dbo].[DIEM] DROP CONSTRAINT [FK_DIEM_SINHVIEN]
GO
ALTER TABLE [dbo].[DIEM] DROP CONSTRAINT [FK_DIEM_MONHOC]
GO
ALTER TABLE [dbo].[SINHVIEN] DROP CONSTRAINT [DF_SINHVIEN_NGHIHOC]
GO
ALTER TABLE [dbo].[SINHVIEN] DROP CONSTRAINT [DF_SINHVIEN_PHAI]
GO
ALTER TABLE [dbo].[DIEM] DROP CONSTRAINT [DF_DIEM_DIEM]
GO
ALTER TABLE [dbo].[DIEM] DROP CONSTRAINT [DF_DIEM_HOCKY]
GO
/****** Object:  Index [IX_MONHOC]    Script Date: 20/06/2016 8:25:54 AM ******/
ALTER TABLE [dbo].[MONHOC] DROP CONSTRAINT [IX_MONHOC]
GO
/****** Object:  Index [IX_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
ALTER TABLE [dbo].[LOP] DROP CONSTRAINT [IX_LOP]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP TABLE [dbo].[SINHVIEN]
GO
/****** Object:  Table [dbo].[MONHOC_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP TABLE [dbo].[MONHOC_LOP]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP TABLE [dbo].[MONHOC]
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP TABLE [dbo].[LOP]
GO
/****** Object:  Table [dbo].[GIANGVIEN_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP TABLE [dbo].[GIANGVIEN_LOP]
GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP TABLE [dbo].[GIANGVIEN]
GO
/****** Object:  Table [dbo].[DIEM]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP TABLE [dbo].[DIEM]
GO
/****** Object:  StoredProcedure [dbo].[XOA_SINHVIEN]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[XOA_SINHVIEN]
GO
/****** Object:  StoredProcedure [dbo].[XOA_MONHOC]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[XOA_MONHOC]
GO
/****** Object:  StoredProcedure [dbo].[XOA_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[XOA_LOP]
GO
/****** Object:  StoredProcedure [dbo].[TIM_THEO_MA_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[TIM_THEO_MA_LOP]
GO
/****** Object:  StoredProcedure [dbo].[SUA_THONGTIN_SINHVIEN]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[SUA_THONGTIN_SINHVIEN]
GO
/****** Object:  StoredProcedure [dbo].[SUA_THONGTIN_MONHOC]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[SUA_THONGTIN_MONHOC]
GO
/****** Object:  StoredProcedure [dbo].[SUA_THONGTIN_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[SUA_THONGTIN_LOP]
GO
/****** Object:  StoredProcedure [dbo].[SUA_DIEM]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[SUA_DIEM]
GO
/****** Object:  StoredProcedure [dbo].[NHAPSINHVIEN]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[NHAPSINHVIEN]
GO
/****** Object:  StoredProcedure [dbo].[NHAPMONHOC]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[NHAPMONHOC]
GO
/****** Object:  StoredProcedure [dbo].[NHAPLOP]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[NHAPLOP]
GO
/****** Object:  StoredProcedure [dbo].[NHAPDIEM]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[NHAPDIEM]
GO
/****** Object:  StoredProcedure [dbo].[LayDiemTheoLop]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[LayDiemTheoLop]
GO
/****** Object:  StoredProcedure [dbo].[LAY_THONG_TIN_SV]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[LAY_THONG_TIN_SV]
GO
/****** Object:  StoredProcedure [dbo].[LAY_DS_SV_THEO_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[LAY_DS_SV_THEO_LOP]
GO
/****** Object:  StoredProcedure [dbo].[LAY_DS_MONHOC_THUOC_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[LAY_DS_MONHOC_THUOC_LOP]
GO
/****** Object:  StoredProcedure [dbo].[LAY_DS_MONHOC_KHONG_THUOC_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[LAY_DS_MONHOC_KHONG_THUOC_LOP]
GO
/****** Object:  StoredProcedure [dbo].[LAY_DS_MONHOC]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[LAY_DS_MONHOC]
GO
/****** Object:  StoredProcedure [dbo].[LAY_DS_DIEM_THILAN1_CHUADAT]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[LAY_DS_DIEM_THILAN1_CHUADAT]
GO
/****** Object:  StoredProcedure [dbo].[LAY_DS_DIEM_THILAN1]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[LAY_DS_DIEM_THILAN1]
GO
/****** Object:  StoredProcedure [dbo].[KIEMTRAMONHOC]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[KIEMTRAMONHOC]
GO
/****** Object:  StoredProcedure [dbo].[GetAllClass]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[GetAllClass]
GO
/****** Object:  StoredProcedure [dbo].[CHON_MONHOC_CHO_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[CHON_MONHOC_CHO_LOP]
GO
/****** Object:  StoredProcedure [dbo].[BACKUP_DATABSE]    Script Date: 20/06/2016 8:25:54 AM ******/
DROP PROCEDURE [dbo].[BACKUP_DATABSE]
GO
/****** Object:  StoredProcedure [dbo].[BACKUP_DATABSE]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BACKUP_DATABSE]
(
	@fileDate varchar(max)
)
as
begin
	DECLARE @name VARCHAR(max) -- database name  
	DECLARE @path VARCHAR(max) -- path for backup files  
	DECLARE @fileName VARCHAR(max) -- filename for backup  
	

	SET @path = 'D:\NHUNG_THOM\database\';

	

	SET @name = 'NHUNG_THOM';

	SET @fileName = @path + @name + '_' + @fileDate + '.BAK'  
	
	BACKUP DATABASE @name TO DISK = @fileName  
end
GO
/****** Object:  StoredProcedure [dbo].[CHON_MONHOC_CHO_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CHON_MONHOC_CHO_LOP]
(
	@MALOP nchar(8),
	@MAMH nchar(5)
)
as
begin
	INSERT INTO MONHOC_LOP(MAMH, MALOP) VALUES (@MAMH, @MALOP);
	return(0);
end


GO
/****** Object:  StoredProcedure [dbo].[GetAllClass]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[GetAllClass]

as
begin
	select ROW_NUMBER() OVER(ORDER BY MALOP) as STT, LOP.MALOP, LOP.TENLOP from dbo.LOP ORDER BY LOP.MALOP;
	RETURN(0);
end


GO
/****** Object:  StoredProcedure [dbo].[KIEMTRAMONHOC]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[KIEMTRAMONHOC]
(
	@MAMH nchar(5)	
)
as
begin
	select MAMH from MONHOC where MONHOC.MAMH = MAMH;
end


GO
/****** Object:  StoredProcedure [dbo].[LAY_DS_DIEM_THILAN1]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LAY_DS_DIEM_THILAN1]
(
	@MALOP nchar(8),
	@MAMH nchar(5),
	@HOCKY int
)
as
begin
	select ROW_NUMBER() OVER(ORDER BY A.MASV) as STT, A.MASV ,A.HO, A.TEN, B.DIEM
	from SINHVIEN as A left join 
	(
		select DIEM.MASV, DIEM.DIEM
		from DIEM
		where (DIEM.HOCKY = @HOCKY and DIEM.LAN = 1 and DIEM.MAMH = @MAMH)
	) as B on A.MASV = B.MASV
	where A.MALOP = @MALOP

	return (0);
end



GO
/****** Object:  StoredProcedure [dbo].[LAY_DS_DIEM_THILAN1_CHUADAT]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LAY_DS_DIEM_THILAN1_CHUADAT]
(
	@MALOP nchar(8),
	@MAMH nchar(5), 
	@HOCKY int
)
as
begin
	DECLARE @checkLan1 int;
	SET @checkLan1 = (select count(DIEM.MASV) from DIEM inner join SINHVIEN on DIEM.MASV = SINHVIEN.MASV
						where (DIEM.HOCKY = @HOCKY) and (DIEM.MAMH = @MAMH) and (SINHVIEN.MALOP = @MALOP)
					 );
	if (@checkLan1 = 0 )
	begin
		RAISERROR('CHƯA NHẬP ĐIỂM LẦN 1',16,0);
		return (3);
	end

	select ROW_NUMBER() OVER(ORDER BY SINHVIEN.MASV) as STT, SINHVIEN.MASV, SINHVIEN.HO, SINHVIEN.TEN, tempDIEM.DIEM 
		from SINHVIEN, MONHOC, 
			(SELECT DIEM.MASV, DIEM.DIEM, DIEM.MAMH
				from DIEM
				Where ((DIEM.LAN = 1) and (DIEM.DIEM < 5))
			) as tempDIEM
		where (
			(tempDIEM.MAMH = @MAMH) and (SINHVIEN.MASV = tempDIEM.MASV) and (SINHVIEN.MALOP = @MALOP)
		)
		group by SINHVIEN.MASV, SINHVIEN.HO, SINHVIEN.TEN, tempDIEM.DIEM;
	return (0);
end



GO
/****** Object:  StoredProcedure [dbo].[LAY_DS_MONHOC]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LAY_DS_MONHOC]
as
begin
	select ROW_NUMBER() OVER(ORDER BY MONHOC.MAMH) as STT, MONHOC.MAMH, MONHOC.TENMH from dbo.MONHOC ORDER BY MONHOC.MAMH;
	RETURN(0);
end


GO
/****** Object:  StoredProcedure [dbo].[LAY_DS_MONHOC_KHONG_THUOC_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LAY_DS_MONHOC_KHONG_THUOC_LOP]
(
	@MALOP nchar(8)
)
as
begin
	SELECT ROW_NUMBER() OVER(ORDER BY MONHOC.MAMH) as STT, MONHOC.MAMH, MONHOC.TENMH
	from MONHOC 
	where MAMH NOT IN 
	(
		SELECT MAMH FROM MONHOC_LOP WHERE MONHOC_LOP.MALOP = @MALOP
	)
end

GO
/****** Object:  StoredProcedure [dbo].[LAY_DS_MONHOC_THUOC_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LAY_DS_MONHOC_THUOC_LOP]
(
	@MALOP nchar(8)
)
as
begin
	SELECT ROW_NUMBER() OVER(ORDER BY MONHOC.MAMH) as STT, MONHOC.MAMH, MONHOC.TENMH
	from MONHOC, MONHOC_LOP
	where ((MONHOC_LOP.MALOP = @MALOP) and (MONHOC.MAMH = MONHOC_LOP.MAMH))
end

GO
/****** Object:  StoredProcedure [dbo].[LAY_DS_SV_THEO_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LAY_DS_SV_THEO_LOP]
(
	@MALOP nchar(8)
)
as
begin
	DECLARE @check int
	SET @check = (select COUNT(LOP.MALOP) from LOP Where LOP.MALOP = @MALOP);
	
	if (@check = 0)
	begin
		RAISERROR('LỚP KHÔNG TỒN TẠI', 16,0);
		return (3);
	end
	SET @check = (select COUNT(SINHVIEN.MASV) from SINHVIEN where SINHVIEN.MALOP = @MALOP);
	if (@check = 0)
	begin
		RAISERROR('LOP CHƯA CÓ SINH VIÊN', 16,0);
		return (3);
	end

	select MASV, HO, TEN, PHAI, DIACHI, NGAYSINH, NOISINH, GHICHU, NGHIHOC from SINHVIEN where SINHVIEN.MALOP = @MALOP;
end


GO
/****** Object:  StoredProcedure [dbo].[LAY_THONG_TIN_SV]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LAY_THONG_TIN_SV]
(
	@MASV nchar(8)
)
as
begin
	select * from SINHVIEN where SINHVIEN.MASV = @MASV ORDER BY SINHVIEN.MASV
end


GO
/****** Object:  StoredProcedure [dbo].[LayDiemTheoLop]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayDiemTheoLop]
(
	@MaLop nchar(8)
)
as
begin
	select SINHVIEN.HO, SINHVIEN.TEN, MONHOC.TENMH, DIEM.LAN, DIEM.DIEM 
		from dbo.LOP, dbo.DIEM, dbo.SINHVIEN, dbo.MONHOC 
		where ((dbo.DIEM.MASV = dbo.SINHVIEN.MASV) and (dbo.SINHVIEN.MALOP = dbo.LOP.MALOP) and (dbo.LOP.MALOP = @MaLop) 
			and (dbo.DIEM.MAMH = dbo.MONHOC.MAMH)) 
end


GO
/****** Object:  StoredProcedure [dbo].[NHAPDIEM]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NHAPDIEM]
(
	@MASV nchar(8),	
	@MAMH nchar(5),
	@LAN smallint,
	@DIEM float,
	@HOCKY int
)
as
begin
	if (@LAN != 1 and @LAN != 2)
	begin
		RAISERROR('Invalid parameter: @LAN is only two value 1 or 2', 16,0);
		return -1
	end
	if (@DIEM <0 and @DIEM >10)
	begin
		RAISERROR('Invalid parameter: @DIEM is on the scale of 0 to 10', 16,0);
		return -1
	end	
	
	DECLARE @checkMH int ;
	SET @checkMH = (select COUNT(MONHOC.MAMH) from MONHOC where MONHOC.MAMH = @MAMH);
	if (@checkMH = 0)
	begin
		RAISERROR('MON HOC NOT EXITS', 16,0);
		return -1
	end
	
	DECLARE @checkSV int ;
	SET @checkSV = (select COUNT(SINHVIEN.MASV) from SINHVIEN where SINHVIEN.MASV = @MASV);
	if (@checkSV = 0)
	begin
		RAISERROR('SINH VIEN NOT EXITS', 16,0);
		return -1
	end
	
	INSERT into DIEM(MASV,MAMH, LAN, DIEM, HOCKY) VALUES(@MASV, @MAMH, @LAN, @DIEM, @HOCKY);
	return 0
end


GO
/****** Object:  StoredProcedure [dbo].[NHAPLOP]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NHAPLOP]
(
	@MALOP nchar(8),
	@TENLOP nvarchar(40)
)
as
begin
	if ((@MALOP IS NULL) OR (@MALOP = ' '))
	begin
		RAISERROR('Invalid parameter: MA LOP is not null', 16,0);
		return(3)	
	end
	if (@TENLOP IS NULL OR @TENLOP = ' ')
	begin
		RAISERROR('Invalid parameter: TEN LOP is not null', 16,0);
		return(3)	
	end

	DECLARE @check int;
	SET @check = (select COUNT(MALOP) from LOP where LOP.MALOP = @MALOP);

	if (@check > 0)
	begin
		RAISERROR('LOP is exited', 16,0);
		return(3)	
	end	

	SET @check = (select COUNT(TENLOP) from LOP where LOP.TENLOP = @TENLOP);

	if (@check > 0)
	begin
		RAISERROR('LOP NAME is exited', 16,0);
		return(3)	
	end	

	insert into LOP(MALOP,TENLOP) values(@MALOP, @TENLOP);
	return(0);
end


GO
/****** Object:  StoredProcedure [dbo].[NHAPMONHOC]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NHAPMONHOC]
(	
	@MAMH nchar(5),
	@TENMH nvarchar(40)
)
as
begin
	if ((@MAMH IS NULL) OR (@MAMH = ' '))
	begin
		RAISERROR('Invalid parameter: MA MON HOC is not null', 16,0);
		return(3)	
	end
	
	if (@TENMH IS NULL OR @TENMH = ' ')
	begin
		RAISERROR('Invalid parameter: TEN MON HOC is not null', 16,0);
		return(3)	
	end

	DECLARE @check int;
	SET @check = (select COUNT(MAMH) from MONHOC where MONHOC.MAMH = @MAMH);

	if (@check > 0)
	begin
		RAISERROR('MON HOC is exited', 16,0);
		return(3)	
	end	

	SET @check = (select COUNT(TENMH) from MONHOC where MONHOC.TENMH = @TENMH);

	if (@check > 0)
	begin
		RAISERROR('Name of MONHOC is exited', 16,0);
		return(3)	
	end	

	insert into MONHOC(MAMH, TENMH) values(@MAMH, @TENMH);
	return(0);
end


GO
/****** Object:  StoredProcedure [dbo].[NHAPSINHVIEN]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NHAPSINHVIEN]
(		
	@HO nvarchar(40),
	@TEN nvarchar(10),
	@MALOP nchar(8),
	@PHAI bit,
	@NGAYSINH datetime,
	@NOISINH nvarchar(40),
	@DIACHI nvarchar(80),
	@GHICHU ntext
)
as
begin
	insert into SINHVIEN(HO, TEN, MALOP, PHAI, NGAYSINH, NOISINH, DIACHI, GHICHU)
	values (@HO, @TEN, @MALOP, @PHAI, @NGAYSINH, @NOISINH, @DIACHI, @GHICHU)
end


GO
/****** Object:  StoredProcedure [dbo].[SUA_DIEM]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SUA_DIEM]
(
	@MASV nchar(8),
	@MAMH nchar(5),
	@LAN smallint,
	@HOCKY int,
	@DIEM float
)
as
begin
	UPDATE DIEM 
	SET
		DIEM.DIEM = @DIEM
	WHERE (DIEM.MASV = @MASV) and (DIEM. MAMH = @MAMH) and (DIEM.LAN = @LAN) and (DIEM.HOCKY = @HOCKY)
	return (0);
end

GO
/****** Object:  StoredProcedure [dbo].[SUA_THONGTIN_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SUA_THONGTIN_LOP]
(
	@MALOP_OLD nchar(8),
	@MALOP_NEW nchar(8),
	@TENLOP nvarchar(40)
)
as
begin
	if ((@MALOP_NEW IS NULL) OR (@MALOP_NEW = ' '))
	begin
		RAISERROR('Invalid parameter: MA LOP is not null', 16,0);
		return(3)	
	end
	if (@TENLOP IS NULL OR @TENLOP = ' ')
	begin
		RAISERROR('Invalid parameter: TEN LOP is not null', 16,0);
		return(3)	
	end
	UPDATE LOP
	SET
		MALOP = @MALOP_NEW,
		TENLOP = @TENLOP
	WHERE LOP.MALOP = @MALOP_OLD
	return(0)

end


GO
/****** Object:  StoredProcedure [dbo].[SUA_THONGTIN_MONHOC]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SUA_THONGTIN_MONHOC]
(
	@MAMH_OLD nchar(5),
	@MAMH_NEW nchar(5),
	@TENMH nvarchar(40)
)
as
begin
	if ((@MAMH_NEW IS NULL) OR (@MAMH_NEW = ' '))
	begin
		RAISERROR('Invalid parameter: MA MON HOC is not null', 16,0);
		return(3)	
	end
	if (@TENMH IS NULL OR @TENMH = ' ')
	begin
		RAISERROR('Invalid parameter: TEN MON HOC is not null', 16,0);
		return(3)	
	end
	UPDATE MONHOC
	SET
		MAMH = @MAMH_NEW,
		TENMH = @TENMH
	WHERE MONHOC.MAMH = @MAMH_OLD
	return(0)
end


GO
/****** Object:  StoredProcedure [dbo].[SUA_THONGTIN_SINHVIEN]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SUA_THONGTIN_SINHVIEN]
(
	@MASV nchar(8),
	@HO nvarchar(40),
	@TEN nvarchar(10),	
	@PHAI bit,
	@NGAYSINH datetime,
	@NOISINH nvarchar(40),
	@DIACHI nvarchar(80),
	@GHICHU ntext,
	@NGHIHOC bit
)
as
begin
	UPDATE SINHVIEN
	SET
		HO = @HO, 
		TEN = @TEN,
		PHAI = @PHAI,
		NGAYSINH = @NGAYSINH, 
		NOISINH = @NOISINH,
		DIACHI =  @GHICHU,
		GHICHU = @GHICHU,
		NGHIHOC = @NGHIHOC
	WHERE
		MASV = @MASV
end
GO
/****** Object:  StoredProcedure [dbo].[TIM_THEO_MA_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TIM_THEO_MA_LOP]
(
	@MALOP nchar(8)
)
as
begin
	select * from LOP where LOP.MALOP = @MALOP;
end


GO
/****** Object:  StoredProcedure [dbo].[XOA_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[XOA_LOP]
(
	@MALOP nchar(8)
)
as
begin
	DECLARE @checkSV int;
	SET @checkSV = (select count(SINHVIEN.MASV) from SINHVIEN Where SINHVIEN.MALOP = @MALOP);
	if (@checkSV = 0)
	begin
		delete from LOP where LOP.MALOP = @MALOP;
		return;
	end
	else 
	begin
		UPDATE SINHVIEN 
		SET 
			MALOP = NULL
		WHERE SINHVIEN.MALOP = @MALOP;
		delete from LOP where LOP.MALOP = @MALOP;
		return;
	end
end


GO
/****** Object:  StoredProcedure [dbo].[XOA_MONHOC]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XOA_MONHOC]
(
	@MAMH nchar(5)
)
as
begin
	DELETE FROM DIEM WHERE DIEM.MAMH = @MAMH;
	DELETE FROM MONHOC WHERE MONHOC.MAMH = @MAMH;
	return (0);
end


GO
/****** Object:  StoredProcedure [dbo].[XOA_SINHVIEN]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XOA_SINHVIEN]
(
	@MASV nchar(8)
)
as
begin
	DECLARE @checkSV int ;
	SET @checkSV = (select count(MASV) from SINHVIEN where MASV = @MASV);

	if (@checkSV = 0)
	begin
		RAISERROR('SINH VIÊN KHÔNG TỒN TẠI TRONG LỚP NÀY',16,0);
		return(3);
	end

	DELETE FROM DIEM where DIEM.MASV = @MASV;
	DELETE from SINHVIEN where MASV = @MASV;
	return(0);
end
GO
/****** Object:  Table [dbo].[DIEM]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEM](
	[MASV] [bigint] NOT NULL,
	[MAMH] [nchar](5) NOT NULL,
	[LAN] [smallint] NOT NULL,
	[HOCKY] [int] NOT NULL,
	[DIEM] [float] NOT NULL,
 CONSTRAINT [PK_DIEM] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[MAMH] ASC,
	[LAN] ASC,
	[HOCKY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGVIEN](
	[MAGV] [nchar](8) NOT NULL,
	[HO] [nvarchar](40) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[PHAI] [bit] NOT NULL,
	[NGAYSINH] [datetime] NOT NULL,
	[NOISINH] [nvarchar](40) NOT NULL,
	[DIACHI] [nvarchar](80) NOT NULL,
 CONSTRAINT [PK_GIANGVIEN] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIANGVIEN_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGVIEN_LOP](
	[MAGV] [nchar](8) NOT NULL,
	[MALOP] [nchar](8) NOT NULL,
 CONSTRAINT [PK_GIANGVIEN_LOP] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC,
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [nchar](8) NOT NULL,
	[TENLOP] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [nchar](5) NOT NULL,
	[TENMH] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MONHOC_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC_LOP](
	[MAMH] [nchar](5) NOT NULL,
	[MALOP] [nchar](8) NOT NULL,
 CONSTRAINT [PK_MONHOC_LOP] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC,
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 20/06/2016 8:25:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [bigint] IDENTITY(10000000,1) NOT NULL,
	[HO] [nvarchar](40) NOT NULL,
	[TEN] [nvarchar](40) NOT NULL,
	[MALOP] [nchar](8) NULL,
	[PHAI] [bit] NOT NULL,
	[NGAYSINH] [datetime] NOT NULL,
	[NOISINH] [nvarchar](40) NOT NULL,
	[DIACHI] [nvarchar](80) NOT NULL,
	[GHICHU] [ntext] NULL,
	[NGHIHOC] [bit] NOT NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [HOCKY], [DIEM]) VALUES (10000000, N'CTDL ', 1, 1, 4)
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [HOCKY], [DIEM]) VALUES (10000000, N'CTDL ', 2, 1, 8)
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [HOCKY], [DIEM]) VALUES (10000001, N'CTDL ', 1, 1, 10)
INSERT [dbo].[LOP] ([MALOP], [TENLOP]) VALUES (N'ATTT    ', N'AN TOÀN THÔNG TIN')
INSERT [dbo].[LOP] ([MALOP], [TENLOP]) VALUES (N'CN01    ', N'CÔNG NGHỆ THÔNG TIN 1')
INSERT [dbo].[LOP] ([MALOP], [TENLOP]) VALUES (N'CN02    ', N'CÔNG NGHỆ THÔNG TIN 2')
INSERT [dbo].[LOP] ([MALOP], [TENLOP]) VALUES (N'CN03    ', N'CÔNG NGHỆ THÔNG TIN 3')
INSERT [dbo].[LOP] ([MALOP], [TENLOP]) VALUES (N'DT01    ', N'ĐIỆN TỬ 01')
INSERT [dbo].[LOP] ([MALOP], [TENLOP]) VALUES (N'DT02    ', N'ĐIỆN TỬ 02')
INSERT [dbo].[LOP] ([MALOP], [TENLOP]) VALUES (N'HTTT    ', N'HE THONG THONG TIN')
INSERT [dbo].[LOP] ([MALOP], [TENLOP]) VALUES (N'KTDN    ', N'KINH TẾ ĐỐI NGOẠI')
INSERT [dbo].[LOP] ([MALOP], [TENLOP]) VALUES (N'QTKD    ', N'QUẢN TRỊ KINH DOANH')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH]) VALUES (N'CTDL ', N'CÁU TRÚC DỮ LIỆU')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH]) VALUES (N'LTW  ', N'LẬP TRÌNH WEB')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH]) VALUES (N'QLDA ', N'QUAN LY DU AN')
INSERT [dbo].[MONHOC_LOP] ([MAMH], [MALOP]) VALUES (N'CTDL ', N'ATTT    ')
INSERT [dbo].[MONHOC_LOP] ([MAMH], [MALOP]) VALUES (N'CTDL ', N'CN01    ')
INSERT [dbo].[MONHOC_LOP] ([MAMH], [MALOP]) VALUES (N'CTDL ', N'CN02    ')
INSERT [dbo].[MONHOC_LOP] ([MAMH], [MALOP]) VALUES (N'CTDL ', N'DT01    ')
INSERT [dbo].[MONHOC_LOP] ([MAMH], [MALOP]) VALUES (N'LTW  ', N'ATTT    ')
INSERT [dbo].[MONHOC_LOP] ([MAMH], [MALOP]) VALUES (N'LTW  ', N'CN01    ')
INSERT [dbo].[MONHOC_LOP] ([MAMH], [MALOP]) VALUES (N'LTW  ', N'CN02    ')
SET IDENTITY_INSERT [dbo].[SINHVIEN] ON 

INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC]) VALUES (10000000, N'PHAN TRẦN', N'HỒNG PHÚC', N'CN01    ', 1, CAST(0x0000871A00000000 AS DateTime), N'QUẬN 1', N'BÌNH THẠNH', N'Đẹp trai, nhiều gái theo', 0)
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC]) VALUES (10000001, N'TRẦN NGỌC', N'HẠNH', N'CN01    ', 1, CAST(0x00007D4800000000 AS DateTime), N'QUẬN 1', N'GÒ VẤP', NULL, 0)
SET IDENTITY_INSERT [dbo].[SINHVIEN] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_LOP]    Script Date: 20/06/2016 8:25:54 AM ******/
ALTER TABLE [dbo].[LOP] ADD  CONSTRAINT [IX_LOP] UNIQUE NONCLUSTERED 
(
	[TENLOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_MONHOC]    Script Date: 20/06/2016 8:25:54 AM ******/
ALTER TABLE [dbo].[MONHOC] ADD  CONSTRAINT [IX_MONHOC] UNIQUE NONCLUSTERED 
(
	[TENMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DIEM] ADD  CONSTRAINT [DF_DIEM_HOCKY]  DEFAULT ((1)) FOR [HOCKY]
GO
ALTER TABLE [dbo].[DIEM] ADD  CONSTRAINT [DF_DIEM_DIEM]  DEFAULT ((0.0)) FOR [DIEM]
GO
ALTER TABLE [dbo].[SINHVIEN] ADD  CONSTRAINT [DF_SINHVIEN_PHAI]  DEFAULT ((1)) FOR [PHAI]
GO
ALTER TABLE [dbo].[SINHVIEN] ADD  CONSTRAINT [DF_SINHVIEN_NGHIHOC]  DEFAULT ((0)) FOR [NGHIHOC]
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [FK_DIEM_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_MONHOC]
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [FK_DIEM_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_SINHVIEN]
GO
ALTER TABLE [dbo].[GIANGVIEN_LOP]  WITH CHECK ADD  CONSTRAINT [FK_GIANGVIEN_LOP_GIANGVIEN] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIANGVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[GIANGVIEN_LOP] CHECK CONSTRAINT [FK_GIANGVIEN_LOP_GIANGVIEN]
GO
ALTER TABLE [dbo].[GIANGVIEN_LOP]  WITH CHECK ADD  CONSTRAINT [FK_GIANGVIEN_LOP_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[GIANGVIEN_LOP] CHECK CONSTRAINT [FK_GIANGVIEN_LOP_LOP]
GO
ALTER TABLE [dbo].[MONHOC_LOP]  WITH CHECK ADD  CONSTRAINT [FK_MONHOC_LOP_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[MONHOC_LOP] CHECK CONSTRAINT [FK_MONHOC_LOP_LOP]
GO
ALTER TABLE [dbo].[MONHOC_LOP]  WITH CHECK ADD  CONSTRAINT [FK_MONHOC_LOP_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
GO
ALTER TABLE [dbo].[MONHOC_LOP] CHECK CONSTRAINT [FK_MONHOC_LOP_MONHOC]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [CK__DIEM__DIEM__3C69FB99] CHECK  (([DIEM]>=(0) AND [DIEM]<=(10) OR [DIEM]=(-1)))
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [CK__DIEM__DIEM__3C69FB99]
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [CK__DIEM__LAN__3B75D760] CHECK  (([LAN]=(1) OR [LAN]=(2)))
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [CK__DIEM__LAN__3B75D760]
GO
