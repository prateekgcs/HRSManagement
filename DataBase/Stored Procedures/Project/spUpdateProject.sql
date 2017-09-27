USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[spUpdateProject]    Script Date: 26-09-2017 08:15:30 PM ******/
--DROP PROCEDURE [dbo].[spUpdateProject]
--GO

/****** Object:  StoredProcedure [dbo].[spUpdateProject]    Script Date: 26-09-2017 08:15:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



Create Procedure [dbo].[spUpdateProject]
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
update Project
set 
ProjName= @ProjName,
[Description]= @Description,
Client= @Client,
 StartDate= @StartDate,
 EndDate= @EndDate,
 CreatedBy= @CreatedBy,
 CreatedDate= @CreatedDate,
 LastModifiedBy=@LastModifiedBy,
 LastModifiedDate= @LastModifiedDate

 where 
 ProjId= @ProjId


 END

GO

