USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[spCreateProject]    Script Date: 26-09-2017 08:13:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



Create Procedure [dbo].[spCreateProject]
@ProjId int,
@ProjName varchar(50),
@Description varchar(100),
@Client varchar(50),
@StartDate datetime,
@EndDate datetime,
@CreatedBy int,
@CreatedDate datetime,
@LastModifiedBy int,
@LastModifiedDate datetime


AS
BEGIN
insert into Project values(@ProjName, @Description, @Client, @StartDate, @EndDate, @CreatedBy, @CreatedDate, @LastModifiedBy, @LastModifiedDate)

END

GO

