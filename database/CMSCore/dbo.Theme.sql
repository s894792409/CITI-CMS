CREATE TABLE [dbo].[Theme] (
    [themeId]         INT          IDENTITY (1, 1) NOT NULL,
    [backgroundColor] VARCHAR (7)  NULL,
    [fontStyle]       VARCHAR (50) NULL,
    [dateCreated]     DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([themeId] ASC)
);

