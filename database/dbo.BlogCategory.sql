CREATE TABLE [dbo].[BlogCategory] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [AddedOn]         DATETIME      DEFAULT (getdate()) NOT NULL,
    [Description]     VARCHAR (MAX) NOT NULL,
    [MetaDescription] VARCHAR (250) NULL,
    [MetaKeyword]     VARCHAR (250) NULL,
    [MetaTitle]       VARCHAR (250) NULL,
    [Name]            VARCHAR (100) NOT NULL,
    [ParentId]        INT           NULL,
    [Status]          BIT           NOT NULL,
    [Url]             VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_BlogCategory] PRIMARY KEY CLUSTERED ([Id] ASC)
);

