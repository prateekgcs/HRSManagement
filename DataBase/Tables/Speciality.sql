USE [HRSManagement]
GO

/****** Object:  Table [dbo].[Speciality]    Script Date: 26-09-2017 04:22:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Speciality](
	[SpecialityId] [int] IDENTITY(1,1) NOT NULL,
	[SpecialityName] [varchar](35) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[LastModifiedBy] [int] NULL,
	[LastModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Speciality] PRIMARY KEY CLUSTERED 
(
	[SpecialityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Speciality] UNIQUE NONCLUSTERED 
(
	[SpecialityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Speciality]  WITH CHECK ADD  CONSTRAINT [FK_Speciality_User] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([UserId])
GO

ALTER TABLE [dbo].[Speciality] CHECK CONSTRAINT [FK_Speciality_User]
GO

ALTER TABLE [dbo].[Speciality]  WITH CHECK ADD  CONSTRAINT [FK_Speciality_User1] FOREIGN KEY([LastModifiedBy])
REFERENCES [dbo].[User] ([UserId])
GO

ALTER TABLE [dbo].[Speciality] CHECK CONSTRAINT [FK_Speciality_User1]
GO

