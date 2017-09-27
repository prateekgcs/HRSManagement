USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[InsertEmployee]    Script Date: 26-09-2017 15:02:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


Create Procedure [dbo].[spGetCategoryList]
@SkillId int output,
@SkillName varchar(50) output

As 
BEGIN
select @SkillId= SkillId,
@SkillName= SkillName


From Skill
END
GO
