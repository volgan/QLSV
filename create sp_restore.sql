USE [master]
GO

/****** Object:  StoredProcedure [dbo].[RESTORE_DATABSE]    Script Date: 24/06/2016 10:33:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[RESTORE_DATABSE]
(
	@path varchar(max)
)
as
begin
	DECLARE @name VARCHAR(max) -- database name  	
	SET @name = 'NHUNG_THOM';		

	RESTORE DATABASE @name FROM DISK = @path
end
GO


