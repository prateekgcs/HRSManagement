USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[InsertEmployee]    Script Date: 26-09-2017 15:02:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


Create Procedure [dbo].[spGetStatusList]
@StatusId int,
@StatusDescription varchar(25)
AS
BEGIN

select 
@StatusId= StatusId,
@StatusDescription= StatusDescription

from CivilStatus 
END
GO
