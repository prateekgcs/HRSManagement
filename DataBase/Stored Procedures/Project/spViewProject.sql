USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[spViewProject]    Script Date: 26-09-2017 08:16:29 PM ******/
--DROP PROCEDURE [dbo].[spViewProject]
--GO

/****** Object:  StoredProcedure [dbo].[spViewProject]    Script Date: 26-09-2017 08:16:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



Create Procedure [dbo].[spViewProject]
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
select
ProjName= @ProjName,
[Description]= @Description,
Client= @Client,
 StartDate= @StartDate,
 EndDate= @EndDate,
 CreatedBy= @CreatedBy,
 CreatedDate= @CreatedDate,
 LastModifiedBy=@LastModifiedBy,
 LastModifiedDate= @LastModifiedDate
 from Project
 where 
 ProjId= @ProjId


 END

GO

