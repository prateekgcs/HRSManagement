USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[spViewSkillCategory]    Script Date: 26-09-2017 08:16:45 PM ******/
--DROP PROCEDURE [dbo].[spViewSkillCategory]
--GO

/****** Object:  StoredProcedure [dbo].[spViewSkillCategory]    Script Date: 26-09-2017 08:16:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



Create Procedure [dbo].[spViewSkillCategory]
@CategoryId int,
@CategoryName varchar(50),
@CategoryDescription varchar(100),
@CreatedBy int,
@CreatedDate datetime,
@LastModifiedBy int,
@LastModifiedDate datetime

As
BEGIN

select  
CategoryName= @CategoryName,
CategoryDescription= @CategoryDescription,
CreatedBy= @CreatedBy,
CreatedDate= @CreatedDate,
LastModifiedBy= @LastModifiedBy,
LastModifiedDate = @LastModifiedDate

from Category

where CategoryId = @CategoryId

END

GO

