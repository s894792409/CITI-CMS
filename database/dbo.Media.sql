CREATE TABLE [dbo].[Media] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [AddedOn]     DATETIME      DEFAULT (getdate()) NOT NULL,
    [Alt]         VARCHAR (100) NULL,
    [Description] VARCHAR (100) NULL,
    [Name]        VARCHAR (100) NOT NULL,
    [ParentId]    INT           NULL,
    [Title]       VARCHAR (100) NULL,
    [Url]         VARCHAR (250) NOT NULL,
    CONSTRAINT [PK_Media] PRIMARY KEY CLUSTERED ([Id] ASC)
);

