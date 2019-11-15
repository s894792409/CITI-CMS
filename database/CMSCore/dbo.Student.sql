USE [CMSCore]
GO

/****** Object:  Table [dbo].[Student]    Script Date: 2019/11/4 15:51:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student](
	[studentAdmin] [varchar](7) NOT NULL,
	[studentName] [varchar](max) NULL,
	[projectId] [int] NULL,
	[dateCreated] [datetime] NULL,
	[Photo] [varbinary](max) NULL,
	[PhotoType] [varchar](50) NULL,
	[studentBirthday] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[studentAdmin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

