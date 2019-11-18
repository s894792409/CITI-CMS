USE [CMSCore]
GO

/****** Object:  Table [dbo].[Card]    Script Date: 2019/11/18 12:29:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Card](
	[cardId] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](max) NULL,
	[color] [nvarchar](50) NULL,
	[value] [nvarchar](max) NULL,
	[icon] [varchar](max) NULL,
	[boxId] [int] NULL,
	[dateCreated] [datetime] NULL,
	[cardType] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

