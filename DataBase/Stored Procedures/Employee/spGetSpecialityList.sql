USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[spGetSpecialityList]    Script Date: 26-09-2017 15:03:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


Create Procedure [dbo].[spGetSpecialityList]
@SpecialityId Int output,
@SpecialityName Varchar(35) output

As
BEGIN
	

	SELECT @SpecialityId=SpecialityId, @SpecialityName = SpecialityName from Speciality
END


GO

