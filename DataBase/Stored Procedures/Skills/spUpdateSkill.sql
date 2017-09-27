USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[SelectEmployee]    Script Date: 26-09-2017 15:02:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


Create Procedure [dbo].[spUpdateSkill]
@SkillId int,
@SkillName varchar(50) ,
@SkillDescription varchar(100) ,
<<<<<<< HEAD
@CategoryId int, 
=======
@CategoryId int,  
>>>>>>> fb645cd4a99983cf4d272eba2e6e286853e83d6b
@CreatedBy int,
@CreatedDate datetime ,
@LastModifiedBy int ,
@LastModifiedDate datetime  

As
BEGIN

UPDATE Skill 
set SkillName= @SkillName,
SkillDescription= @SkillDescription,
CategoryId= @CategoryId,
CreatedBy= @CreatedBy,
CreatedDate = @CreatedDate,
LastModifiedBy= @LastModifiedBy,
LastModifiedDate= @LastModifiedDate
where 
SkillId = @SkillId

END
GO
