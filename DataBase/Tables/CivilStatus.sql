USE [HRSManagement]
GO

/****** Object:  Table [dbo].[CivilStatus]    Script Date: 26-09-2017 04:20:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CivilStatus](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusDescription] [varchar](25) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[LastModifiedBy] [int] NULL,
	[LastModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_CivilStatus] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_CivilStatus] UNIQUE NONCLUSTERED 
(
	[StatusDescription] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[CivilStatus]  WITH CHECK ADD  CONSTRAINT [FK_CivilStatus_CivilStatus] FOREIGN KEY([StatusId])
REFERENCES [dbo].[CivilStatus] ([StatusId])
GO

ALTER TABLE [dbo].[CivilStatus] CHECK CONSTRAINT [FK_CivilStatus_CivilStatus]
GO

