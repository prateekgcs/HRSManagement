USE [HRSManagement]
GO

/****** Object:  Table [dbo].[Level]    Script Date: 26-09-2017 04:21:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Level](
	[LevelId] [int] NOT NULL,
	[LevelDescription] [varchar](35) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[LastModifiedBy] [int] NULL,
	[LastModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Level] PRIMARY KEY CLUSTERED 
(
	[LevelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Level] UNIQUE NONCLUSTERED 
(
	[LevelDescription] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Level]  WITH CHECK ADD  CONSTRAINT [FK_Level_User] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([UserId])
GO

ALTER TABLE [dbo].[Level] CHECK CONSTRAINT [FK_Level_User]
GO

ALTER TABLE [dbo].[Level]  WITH CHECK ADD  CONSTRAINT [FK_Level_User1] FOREIGN KEY([LastModifiedBy])
REFERENCES [dbo].[User] ([UserId])
GO

ALTER TABLE [dbo].[Level] CHECK CONSTRAINT [FK_Level_User1]
GO

