USE [HRSManagement]
GO

/****** Object:  Table [dbo].[Project]    Script Date: 26-09-2017 04:21:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Project](
	[ProjId] [int] IDENTITY(1,1) NOT NULL,
	[ProjName] [varchar](50) NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[Client] [varchar](50) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[LastModifiedBy] [int] NULL,
	[LastModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[ProjId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Project] UNIQUE NONCLUSTERED 
(
	[ProjName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_User] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([UserId])
GO

ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_User]
GO

ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_User1] FOREIGN KEY([LastModifiedBy])
REFERENCES [dbo].[User] ([UserId])
GO

ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_User1]
GO

