USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[spGetLevelList]    Script Date: 26-09-2017 15:03:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


Create Procedure [dbo].[spGetLevelList]
@LevelId Int output,
@LevelDescription Varchar(35) output

As
BEGIN
	

	SELECT @LevelId=LevelId, @LevelDescription = LevelDescription from Level
END


GO

