USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[spViewEmployee]    Script Date: 26-09-2017 08:16:12 PM ******/
--DROP PROCEDURE [dbo].[spViewEmployee]
--GO

/****** Object:  StoredProcedure [dbo].[spViewEmployee]    Script Date: 26-09-2017 08:16:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



Create Procedure [dbo].[spViewEmployee]
@EmployeeId int,
@FirstName varchar(50) output,
@MiddleName varchar(50) output,
@LastName varchar(50) output,
@BirthDate Datetime output,
@Age Int output,
@Gender Varchar(1) output,
@CivilStatus Int output,
@Religion Varchar(20) output,
@Citizenship Varchar(15) output,
@MobileNo Varchar(15) output,
@HomePhoneNo Varchar(15) output,
@Street1 Varchar(100) output,
@Street2 Varchar(100) output,
@City Varchar(100) output,
@State Varchar(100) output,
@ZipCode Varchar(20) output,
@Country Varchar(100) output,
@ProjectProfile Varchar(100) output,
@SkillProfile Varchar(100) output,
@EducBackGround Varchar(500) output,
@Recognitions Varchar(500) output,
@CreatedBy Int,
@CreatedDate DateTime,
@LastModifiedBy Int,
@LastModifiedDate Datetime

As
BEGIN
	
	SELECT 
@FirstName=FirstName,
@MiddleName=MiddleName,
@LastName=LastName,
@BirthDate=BirthDate,
@Age=Age,
@Gender=Gender,
@CivilStatus=CivilStatus,
@Religion=Religion,
@Citizenship=Citizenship,
@MobileNo=MobileNo,
@HomePhoneNo=HomePhoneNo,
@Street1=Street1,
@Street2=Street2 ,
@City=City,
@State=[State],
@ZipCode=ZipCode,
@Country=Country ,
@ProjectProfile=ProjectProfile ,
@SkillProfile=SkillProfile ,
@EducBackGround=EducBackGround ,
@Recognitions=Recognitions,
@CreatedBy=CreatedBy,
@CreatedDate=CreatedDate ,
@LastModifiedBy=LastModifiedBy,
@LastModifiedDate=LastModifiedDate

	 from Employee where EmployeeId=@EmployeeId
END



GO

