CREATE TABLE [dbo].[Images] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Name]        VARCHAR (MAX)    NOT NULL,
    [Data]        VARBINARY (MAX)  NOT NULL,
    [Length]      INT              NOT NULL,
    [Width]       INT              NOT NULL,
    [Height]      INT              NOT NULL,
    [ContentType] VARCHAR (50)     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

