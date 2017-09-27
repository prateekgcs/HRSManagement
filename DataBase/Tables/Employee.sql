USE [HRSManagement]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 26-09-2017 04:21:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[MiddleName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[Age] [int] NULL,
	[Gender] [varchar](1) NOT NULL,
	[CivilStatus] [int] NOT NULL,
	[Religion] [varchar](20) NULL,
	[Citizenship] [varchar](50) NOT NULL,
	[MobileNo] [varchar](50) NULL,
	[HomePhoneNo] [varchar](50) NULL,
	[Street1] [varchar](100) NOT NULL,
	[Street2] [varchar](100) NULL,
	[City] [varchar](100) NOT NULL,
	[State] [varchar](100) NOT NULL,
	[ZipCode] [varchar](20) NULL,
	[Country] [varchar](100) NOT NULL,
	[ProjectProfile] [varchar](100) NULL,
	[SkillProfile] [varchar](100) NULL,
	[EducBackGround] [varchar](500) NOT NULL,
	[Recognitions] [varchar](500) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[LastModifiedBy] [int] NULL,
	[LastModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_CivilStatus] FOREIGN KEY([CivilStatus])
REFERENCES [dbo].[CivilStatus] ([StatusId])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_CivilStatus]
GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_User] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([UserId])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_User]
GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_User1] FOREIGN KEY([LastModifiedBy])
REFERENCES [dbo].[User] ([UserId])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_User1]
GO

