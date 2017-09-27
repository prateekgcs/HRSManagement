USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[spUpdateEmployee]    Script Date: 26-09-2017 08:15:12 PM ******/
--DROP PROCEDURE [dbo].[spUpdateEmployee]
--GO

/****** Object:  StoredProcedure [dbo].[spUpdateEmployee]    Script Date: 26-09-2017 08:15:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE Procedure [dbo].[spUpdateEmployee]

@EmployeeId int,
@FirstName varchar(50),
@MiddleName varchar(50),
@LastName varchar(50),
@BirthDate Datetime,
@Age Int,
@Gender Varchar(1),
@CivilStatus Int,
@Religion Varchar(20),
@Citizenship Varchar(15),
@MobileNo Varchar(15),
@HomePhoneNo Varchar(15),
@Street1 Varchar(100),
@Street2 Varchar(100),
@City Varchar(100),
@State Varchar(100),
@ZipCode Varchar(20),
@Country Varchar(100),
@ProjectProfile Varchar(100),
@SkillProfile Varchar(100),
@EducBackGround Varchar(500),
@Recognitions Varchar(500),
@CreatedBy Int,
@CreatedDate DateTime,
@LastModifiedBy Int,
@LastModifiedDate Datetime


As
BEGIN
	
	Update Employee set FirstName=@FirstName,
MiddleName=@MiddleName,
LastName=@LastName,
BirthDate=@BirthDate,
Age=@Age,
Gender=@Gender,
CivilStatus=@CivilStatus,
Religion=@Religion,
Citizenship=@Citizenship,
MobileNo=@MobileNo,
HomePhoneNo=@HomePhoneNo,
Street1=@Street1,
Street2=@Street2 ,
City=@City,
[State]=@State,
ZipCode=@ZipCode,
Country=@Country ,
ProjectProfile=@ProjectProfile ,
SkillProfile=@SkillProfile ,
EducBackGround=@EducBackGround ,
Recognitions=@Recognitions,
CreatedBy=@CreatedBy,
CreatedDate=@CreatedDate ,
LastModifiedBy=@LastModifiedBy,
LastModifiedDate=@LastModifiedDate

 where EmployeeId=@EmployeeId
	 
END



GO

