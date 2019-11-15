CREATE TABLE [dbo].[Card] (
    [cardId]      INT            IDENTITY (1, 1) NOT NULL,
    [title]       NVARCHAR (MAX) NULL,
    [color]       NVARCHAR (50)  NULL,
    [value]       NVARCHAR (MAX) NULL,
    [icon]        VARCHAR (MAX)  NULL,
    [boxId]       INT            NULL,
    [dateCreated] DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([cardId] ASC)
);

