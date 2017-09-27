USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[spUpdateSkillCategory]    Script Date: 26-09-2017 08:15:50 PM ******/
--DROP PROCEDURE [dbo].[spUpdateSkillCategory]
--GO

/****** Object:  StoredProcedure [dbo].[spUpdateSkillCategory]    Script Date: 26-09-2017 08:15:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



Create Procedure [dbo].[spUpdateSkillCategory]
@CategoryId int,
@CategoryName varchar(50),
@CategoryDescription varchar(100),
@CreatedBy int,
@CreatedDate datetime,
@LastModifiedBy int,
@LastModifiedDate datetime

As
BEGIN

update Category set
CategoryName= @CategoryName,
CategoryDescription= @CategoryDescription,
CreatedBy= @CreatedBy,
CreatedDate= @CreatedDate,
LastModifiedBy= @LastModifiedBy,
LastModifiedDate = @LastModifiedDate

where CategoryId = @CategoryId

END

GO

