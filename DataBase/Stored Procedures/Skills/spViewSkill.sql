USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[SelectEmployee]    Script Date: 26-09-2017 15:02:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


Create Procedure [dbo].[spViewSkill]
@SkillId int,
@SkillName varchar(50) output,
@SkillDescription varchar(100)  output,
@CategoryId int  output,
@CreatedBy int  output,
@CreatedDate datetime  output,
@LastModifiedBy int  output,
@LastModifiedDate datetime  output

As
BEGIN
	
	SELECT @SkillName = SkillName, 
	@SkillDescription= SkillDescription,
	@CategoryId = CategoryId,
	@CreatedBy= CreatedBy,
	@CreatedDate= CreatedDate,
	@LastModifiedBy= LastModifiedBy,
	@LastModifiedDate= LastModifiedBy

	 from Skill where SkillId=@SkillId
END


GO

