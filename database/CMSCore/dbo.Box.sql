CREATE TABLE [dbo].[Box] (
    [boxId]    INT           IDENTITY (1, 1) NOT NULL,
    [presetId] INT           NULL,
    [GUID]     VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([boxId] ASC)
);

