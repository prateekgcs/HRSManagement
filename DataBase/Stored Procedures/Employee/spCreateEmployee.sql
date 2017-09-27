USE [HRSManagement]
GO

/****** Object:  StoredProcedure [dbo].[spCreateEmployee]    Script Date: 26-09-2017 08:12:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE Procedure [dbo].[spCreateEmployee]
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
@EduBackGround Varchar(500),
@Recognitions Varchar(500),
@CreatedBy Int,
@CreatedDate DateTime,
@LastModifiedBy Int,
@LastModifiedDate Datetime

As
BEGIN
	
	Insert into Employee values( 
@FirstName,
@MiddleName,
@LastName,
@BirthDate,
@Age,
@Gender,
@CivilStatus,
@Religion,
@Citizenship,
@MobileNo,
@HomePhoneNo ,
@Street1 ,
@Street2 ,
@City,
@State ,
@ZipCode,
@Country ,
@ProjectProfile ,
@SkillProfile ,
@EduBackGround ,
@Recognitions,
@CreatedBy,
@CreatedDate ,
@LastModifiedBy,
@LastModifiedDate 
)
	 
END



GO

