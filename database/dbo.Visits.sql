USE [CMSCore]
GO

/****** Object:  Table [dbo].[Visits]    Script Date: 2019/11/4 15:51:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Visits](
	[VisitId] [int] IDENTITY(1,1) NOT NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Name] [varchar](max) NULL,
	[Pax] [int] NULL,
	[SIC] [varchar](max) NULL,
	[Host] [varchar](max) NULL,
	[ForeignVisit] [bit] NULL,
	[dateCreated] [datetime] NULL,
	[No] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[VisitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

