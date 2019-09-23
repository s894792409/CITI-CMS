CREATE TABLE [dbo].[Blog] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [AddedOn]         DATETIME      DEFAULT (getdate()) NOT NULL,
    [CategoryId]      INT           NOT NULL,
    [Description]     VARCHAR (MAX) NOT NULL,
    [MetaDescription] VARCHAR (250) NULL,
    [MetaKeyword]     VARCHAR (250) NULL,
    [MetaTitle]       VARCHAR (250) NULL,
    [Name]            VARCHAR (100) NOT NULL,
    [PrimaryImageId]  INT           NULL,
    [Status]          BIT           NOT NULL,
    [Url]             VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Blog] PRIMARY KEY CLUSTERED ([Id] ASC)
);

