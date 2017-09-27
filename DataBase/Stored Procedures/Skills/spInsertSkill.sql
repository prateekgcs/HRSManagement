USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[InsertEmployee]    Script Date: 26-09-2017 15:02:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


Create Procedure [dbo].[spCreateSkill]
@SkillId int,
@SkillName varchar(50),
@SkillDescription varchar(100),
@CategoryId int,
@CreatedBy int,
@CreatedDate datetime,
@LastModifiedBy int,
@LastModifiedDate datetime

As
BEGIN
	
	Insert into Skill values(@SkillName, @SkillDescription,@CategoryId,@CreatedBy,@CreatedDate ,@LastModifiedBy ,@LastModifiedDate  )
	 
END


GO

