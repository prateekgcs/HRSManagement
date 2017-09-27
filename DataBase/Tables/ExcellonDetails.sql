USE [HRSManagement]
GO

/****** Object:  Table [dbo].[ExcellonDetails]    Script Date: 26-09-2017 04:21:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ExcellonDetails](
	[EmployeeId] [int] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[EnterpriseId] [varchar](50) NOT NULL,
	[Level] [int] NOT NULL,
	[DateHired] [datetime] NOT NULL,
	[WorkGroup] [varchar](50) NULL,
	[Speciality] [int] NULL,
	[ServiceLine] [varchar](50) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[LastModifiedBy] [int] NOT NULL,
	[LastModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_ExcellonDetails] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_ExcellonDetails] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_ExcellonDetails_1] UNIQUE NONCLUSTERED 
(
	[EnterpriseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ExcellonDetails]  WITH CHECK ADD  CONSTRAINT [FK_ExcellonDetails_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([EmployeeId])
GO

ALTER TABLE [dbo].[ExcellonDetails] CHECK CONSTRAINT [FK_ExcellonDetails_Employee]
GO

ALTER TABLE [dbo].[ExcellonDetails]  WITH CHECK ADD  CONSTRAINT [FK_ExcellonDetails_Level] FOREIGN KEY([Level])
REFERENCES [dbo].[Level] ([LevelId])
GO

ALTER TABLE [dbo].[ExcellonDetails] CHECK CONSTRAINT [FK_ExcellonDetails_Level]
GO

ALTER TABLE [dbo].[ExcellonDetails]  WITH CHECK ADD  CONSTRAINT [FK_ExcellonDetails_Speciality] FOREIGN KEY([Speciality])
REFERENCES [dbo].[Speciality] ([SpecialityId])
GO

ALTER TABLE [dbo].[ExcellonDetails] CHECK CONSTRAINT [FK_ExcellonDetails_Speciality]
GO

ALTER TABLE [dbo].[ExcellonDetails]  WITH CHECK ADD  CONSTRAINT [FK_ExcellonDetails_User] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([UserId])
GO

ALTER TABLE [dbo].[ExcellonDetails] CHECK CONSTRAINT [FK_ExcellonDetails_User]
GO

ALTER TABLE [dbo].[ExcellonDetails]  WITH CHECK ADD  CONSTRAINT [FK_ExcellonDetails_User1] FOREIGN KEY([LastModifiedBy])
REFERENCES [dbo].[User] ([UserId])
GO

ALTER TABLE [dbo].[ExcellonDetails] CHECK CONSTRAINT [FK_ExcellonDetails_User1]
GO

