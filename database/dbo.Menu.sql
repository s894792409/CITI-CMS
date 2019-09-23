CREATE TABLE [dbo].[Menu] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [AddedOn] DATETIME       DEFAULT (getdate()) NOT NULL,
    [Item]    VARCHAR (1000) NOT NULL,
    [Name]    VARCHAR (25)   NOT NULL,
    [Status]  BIT            NOT NULL,
    CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED ([Id] ASC)
);

